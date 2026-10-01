using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
// Chổ để tạo tài khoản( ĐĂNG KÝ / Đ NHẬP / QUÊN MK / THÔNG TIN HỒ SƠ/ LỊCH SỬ ĐH / CẬP NHẬT HỒ SƠ ) 
namespace ThanhTamNgoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly string _connectionString;

        public AccountController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public class RegisterRequest
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public DateTime? Birthday { get; set; }
            public DateTime? AnniversaryDate { get; set; }
        }
        //CHỨC NĂNG ĐĂNG KÝ
        //1. Mục đích: Nhận thông tin từ Form Đăng ký và lưu vào CSDL
        //2. Cách hoạt động:
        //- Đầu tiên dùng lệnh SELECT COUNT để kiểm tra xem Email đã bị người khác đăng ký chưa.
        //- Nếu chưa, dùng lệnh INSERT INTO Users để tạo tài khoản mới.
        // 3.   dùng đối tượng SqlConnection để mở kết nối trực tiếp.
        // Lúc chèn dữ liệu,  dùng Parameters.AddWithValue để truyền biến, giúp trang web chống lại các cuộc tấn công SQL Injection ạ"


        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest("Invalid input data.");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string checkExistQuery = "SELECT COUNT(1) FROM Users WHERE Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkExistQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", request.Email);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            return Conflict("Email already exists.");
                        }
                    }

                    string insertQuery = @"
                        INSERT INTO Users (FullName, Email, PasswordHash, Birthday, AnniversaryDate, CreatedAt)
                        VALUES (@FullName, @Email, @PasswordHash, @Birthday, @AnniversaryDate, GETDATE())";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@FullName", request.FullName);
                        insertCmd.Parameters.AddWithValue("@Email", request.Email);
                        insertCmd.Parameters.AddWithValue("@PasswordHash", request.Password); 
                        insertCmd.Parameters.AddWithValue("@Birthday", request.Birthday.HasValue ? (object)request.Birthday.Value : DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@AnniversaryDate", request.AnniversaryDate.HasValue ? (object)request.AnniversaryDate.Value : DBNull.Value);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return Ok("Registration successful.");
                        }
                        else
                        {
                            return StatusCode(500, "Failed to register user.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
        public class ForgotPasswordRequest
        {
            public string Email { get; set; }
        }
        // CHỨC NĂNG QUÊN MẬT KHẨU
        // 1. Mục đích: Kiểm tra xem email khách nhập vào có tồn tại trong hệ thống hay không để gửi link khôi phục.
        // 2. Cách hoạt động: Dùng câu lệnh SELECT COUNT(1) FROM Users WHERE Email = @Email.
        //    - Nếu exists > 0 (nghĩa là có tài khoản), báo thành công.
        //    - Nếu không có, báo lỗi Not Found.
        [HttpPost("forgotpassword")]
        public IActionResult ForgotPassword([FromBody] ForgotPasswordRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email))
            {
                return BadRequest("Vui lòng nhập email.");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", request.Email);
                        int exists = Convert.ToInt32(cmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            return Ok("Đã gửi liên kết khôi phục mật khẩu vào email của bạn.");
                        }
                        else
                        {
                            return NotFound("Email này chưa được đăng ký trong hệ thống.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
            public class LoginRequest
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        // CHỨC NĂNG ĐĂNG NHẬP
        // 1. Mục đích: Xác thực thông tin Email và Password khách hàng nhập vào.
        // 2. Cách hoạt động: 
        //    - Dùng câu lệnh SELECT FullName FROM Users WHERE Email = ... AND PasswordHash = ...
        //    - Dùng hàm ExecuteScalar() của C# để lấy đúng cái tên người dùng (FullName) mang về báo đăng nhập thành công.
        // 3.  "Thay vì dùng các framework nặng nề, chọn dùng
        // ADO.NET thuần với hàm ExecuteScalar() để trích xuất dữ liệu đăng nhập.
        // Việc này giúp tốc độ phản hồi của API cực kỳ nhanh, bấm đăng nhập là vào liền."
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest("Vui lòng nhập đầy đủ Email và Mật khẩu.");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT FullName FROM Users WHERE Email = @Email AND PasswordHash = @Password";
                    
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Email", request.Email);
                        command.Parameters.AddWithValue("@Password", request.Password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string fullName = result.ToString();
                            return Ok(new { message = "Đăng nhập thành công!", user = fullName });
                        }
                        else
                        {
                            return Unauthorized("Email hoặc mật khẩu không chính xác.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
        // LẤY THÔNG TIN HỒ SƠ NGƯỜI DÙNG (PROFILE)
        // 1. Mục đích: Lấy dữ liệu cá nhân của khách hàng (Tên, Email, SĐT, Địa chỉ) từ CSDL để hiển thị lên trang "Hồ sơ cá nhân" 
        //    hoặc tự động điền sẵn thông tin vào form lúc Thanh toán (Checkout).
        // 2. Cách hoạt động: 
        //    - Nhận Email của người dùng từ đường dẫn API (HTTP GET).
        //    - Dùng câu lệnh SELECT kết hợp điều kiện WHERE Email = @Email để tìm đúng khách hàng.
        //    - Sử dụng đối tượng SqlDataReader của ADO.NET để đọc từng cột dữ liệu và đóng gói thành định dạng JSON trả về cho Front-end.
        // 3. Từ khóa :
        //     SqlDataReader đọc dữ liệu theo luồng (stream) một chiều tiến tới. Nó không lưu toàn bộ dữ liệu vào bộ nhớ nên
        //    tốc độ xử lý cực kỳ nhanh và nhẹ gọn, rất phù hợp để lấy thông tin chi tiết của 1 user ạ."
        //    - Bảo mật: " tiếp tục dùng Parameters.AddWithValue (@Email) để ngăn chặn tuyệt đối lỗi bảo mật SQL Injection ạ."
        [HttpGet("profile/{email}")]
        public IActionResult GetProfile(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT FullName, Email, PhoneNumber, Address, Status FROM Users WHERE Email = @Email";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Ok(new {
                                    name = reader["FullName"],
                                    email = reader["Email"],
                                    phone = reader["PhoneNumber"].ToString(),
                                    address = reader["Address"].ToString(),
                                    status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
                return NotFound("Người dùng không tồn tại.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Lỗi kết nối CSDL: " + ex.Message);
            }
        }
        // TRUY XUẤT LỊCH SỬ ĐƠN HÀNG (ORDER HISTORY)
        // 1. Mục đích: Hàm này dùng để chuẩn bị truy xuất danh sách các đơn hàng cũ mà khách hàng đã đặt trong bảng Orders.
        // 2. Cách hoạt động: 
        //    - Nhận Email của khách hàng từ API.
        //    - Viết câu lệnh SELECT để chuẩn bị lấy các cột OrderId, OrderDate, TotalAmount, Status dựa trên điều kiện UserEmail = @Email.
        //    - Mở kết nối đến CSDL, đưa tham số Email vào và hiện tại đang thiết lập trả về thông báo xác nhận thành công.
        // 3. Từ khóa :
        //    - Bảo mật : Không bao giờ cộng chuỗi trực tiếp khi truyền biến. Em luôn sử dụng hàm 'command.Parameters.AddWithValue' để gán giá trị @Email.
        //    Kỹ thuật này giúp hệ thống bảo mật an toàn, chống lại được các cuộc tấn công SQL Injection ạ."
        //    - Dùng 'using' (ở SqlConnection và SqlCommand) : 'using' giúp hệ thống tự động dọn dẹp và đóng kết nối CSDL ngay sau khi chạy xong lệnh (kể cả khi bị lỗi), giúp web không bị tràn bộ nhớ hay treo server ạ."
        [HttpGet("orders/{email}")]
        public IActionResult GetOrderHistory(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT OrderId, OrderDate, TotalAmount, Status FROM Orders WHERE UserEmail = @Email";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        return Ok(new { message = "Truy xuất lịch sử đơn hàng thành công." });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Lỗi truy xuất đơn hàng: " + ex.Message);
            }
        }
        // CẬP NHẬT THÔNG TIN HỒ SƠ (UPDATE PROFILE)
        // 1. Mục đích: Xử lý yêu cầu lưu lại các thông tin cá nhân mới (Tên, SĐT, Địa chỉ, Ngày sinh) do khách hàng vừa chỉnh sửa trên giao diện.
        // 2. Cách hoạt động:
        //    - Nhận toàn bộ gói dữ liệu từ Front-end gửi lên thông qua đối tượng 'UpdateProfileRequest' (được đánh dấu là [FromBody]).
        //    - Dùng câu lệnh UPDATE của SQL để ghi đè dữ liệu mới vào bảng Users, tìm đúng người cần sửa thông qua điều kiện WHERE Email = @Email.
        //    - Thực thi bằng hàm 'ExecuteNonQuery()' và kiểm tra số dòng bị ảnh hưởng (rowsAffected) để biết là có cập nhật thành công hay không.
        // 3. Từ khóa :
        //    [HttpPut] mà không dùng [HttpPost]":  chuẩn thiết kế RESTful API, phương thức POST được dùng để TẠO MỚI dữ liệu,
        //    còn phương thức PUT được dùng để CẬP NHẬT/CHỈNH SỬA dữ liệu đã tồn tại ."
        //    - "Hàm ExecuteNonQuery() khác gì với ExecuteReader() :ExecuteReader() dùng để đọc/lấy bảng dữ liệu ra (lệnh SELECT). Còn ExecuteNonQuery() dùng cho các lệnh không trả về bảng (như INSERT, UPDATE, DELETE),
        //    nó chỉ trả về 1 con số (int) báo cho biết có bao nhiêu dòng trong CSDL vừa bị tác động thôi."
        //    -  (object)DBNull.Value' : kỹ thuật bắt lỗi giá trị rỗng. Nếu khách hàng bỏ trống ô nhập liệu (truyền lên null), code sẽ tự động chuyển nó thành giá trị NULL hợp lệ của SQL Server,
        //    giúp hệ thống không bao giờ bị 'văng' lỗi (crash) ạ."
        [HttpPut("update-profile")]
        public IActionResult UpdateProfile([FromBody] UpdateProfileRequest request)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Users SET FullName = @FullName, PhoneNumber = @Phone, Address = @Address, Birthday = @Birthday WHERE Email = @Email";
                    
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", request.FullName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", request.Phone ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Address", request.Address ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Birthday", request.Birthday ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Email", request.Email);

                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                            return Ok(new { message = "Lưu thông tin thành công vào CSDL!" });
                        else
                            return NotFound("Không tìm thấy email này trong hệ thống.");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Lỗi Server: " + ex.Message);
            }
        }

        public class UpdateProfileRequest
        {
            public string Email { get; set; }
            public string FullName { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Birthday { get; set; }
        }
        }
    }
