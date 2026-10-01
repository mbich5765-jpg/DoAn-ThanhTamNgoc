using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThanhTamNgoc.Api.Data;
using ThanhTamNgoc.Api.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
// QUẢN LÝ TÀI KHOẢN VÀ XÁC THỰC (USERS & AUTHENTICATION): ĐĂNG KÝ/ĐĂNG NHẬP / QUẢN LÝ TRẠNG TRÁI TÀI KHOẢNG
namespace ThanhTamNgoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public UsersController(AppDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        //  ĐĂNG KÝ TÀI KHOẢN (REGISTER)
        // 1. Kỹ thuật EF Core áp dụng: Sử dụng AnyAsync() để kiểm tra sự tồn tại của Username trước khi thực hiện lệnh Add().
        // 2. Lý do áp dụng: Việc kiểm tra trước giúp ngăn chặn lỗi xung đột dữ liệu (Unique Constraint Violation) ở tầng CSDL
        // và trả về thông báo lỗi thân thiện cho Client thay vì ném ra một Exception hệ thống.

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User user)
        {
            if (await _context.Users.AnyAsync(u => u.Username == user.Username))
            {
                return BadRequest("Tên đăng nhập này đã có người sử dụng rồi!");
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
        //  ĐĂNG NHẬP & CẤP PHÁT TOKEN (LOGIN & JWT)
        // 1. Xác thực (Authentication): Truy vấn CSDL bằng FirstOrDefaultAsync() để đối chiếu Username và Mật khẩu.
        // 2. Cấp phát JSON Web Token (JWT):
        //    - Kỹ thuật Claims: Nhúng các thông tin định danh (Id, Username) và phân quyền (Role) vào phần Payload của Token để Frontend và các API khác nhận diện người dùng.
        //    - Vòng đời (Expiration): Thiết lập Token có hiệu lực trong 7 ngày (DateTime.UtcNow.AddDays(7)).
        //    - Khóa ký (Signing Credentials): Mã hóa chữ ký bằng thuật toán bảo mật đối xứng HMAC-SHA256 với khóa bí mật cấu hình tại appsettings.json.
        //    Quá trình này đảm bảo tính toàn vẹn của Token, chống lại các hành vi giả mạo (Tampering) từ phía Client.

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginDto loginInfo)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == loginInfo.Username && u.PasswordHash == loginInfo.PasswordHash);

            if (user == null)
            {
                return Unauthorized("Hình như sai tài khoản hoặc mật khẩu rồi nè!");
            }

            var jwtKey = _config["Jwt:Key"] ?? "";
            var keyBytes = Encoding.UTF8.GetBytes(jwtKey);
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, user.Role ?? "Customer")
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                Issuer = _config["Jwt:Issuer"],
                Audience = _config["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new
            {
                Message = "Đăng nhập thành công!",
                Token = tokenString,
                UserInfo = user
            });
        }
        //  KHÓA/MỞ KHÓA TÀI KHOẢN (TOGGLE STATUS)
        // 1. Mục đích: Chuyển đổi qua lại trạng thái hoạt động của người dùng (từ 1 sang 0 và ngược lại).
        // 2. Kỹ thuật SQL & EF Core kết hợp:
        //    - ExecuteSqlRawAsync(): Phương thức cho phép thực thi trực tiếp câu lệnh SQL thô (Raw SQL) thông qua Entity Framework Core.
        //    - Toán tử CASE WHEN: Xử lý logic đảo trạng thái trực tiếp tại tầng CSDL.
        //    - Tham số hóa an toàn ({0}): Dữ liệu ID truyền vào được tham số hóa thành đối tượng DbParameter của ADO.NET ngầm định, ngăn chặn hoàn toàn nguy cơ SQL Injection.
        //    - Lý do áp dụng: Giúp tối ưu hóa hiệu năng. Thay vì phải SELECT thực thể lên bộ nhớ (Change Tracking) rồi mới
        //    UPDATE và SaveChanges, kỹ thuật này tác động trực tiếp và đóng kết nối ngay lập tức.

        [HttpPut("toggle-status/{id}")]
        public async Task<IActionResult> ToggleUserStatus(int id)
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync("UPDATE Users SET TrangThai = CASE WHEN TrangThai = 1 THEN 0 ELSE 1 END WHERE Id = {0}", id);
                return Ok(new { message = "Cập nhật trạng thái thành công!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi Server: " + ex.Message });
            }
        }
    }

    public class LoginDto
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}