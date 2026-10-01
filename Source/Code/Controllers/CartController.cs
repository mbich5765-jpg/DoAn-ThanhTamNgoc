using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ThanhTamNgoc.Api.Data;
using ThanhTamNgoc.Api.Models;
// giỏ hàng ( XEM GIO HANG / THEM GIO HANG )
namespace ThanhTamNgoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] 
    public class CartController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        private int GetCurrentUserId()
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(userIdString ?? "0");
        }
        // CHỨC NĂNG XEM GIỎ HÀNG
        // 1. Mục đích: Hiển thị toàn bộ các món trang sức đang nằm trong giỏ của khách hàng đang đăng nhập.
        // 2. Cách hoạt động: 
        //    - Hệ thống tự lấy ID khách hàng từ cái thẻ JWT Token (GetCurrentUserId).
        //    - Dùng Entity Framework để tìm đúng cái giỏ hàng của khách đó. Nếu khách mới toanh chưa có giỏ, tự động tạo mới 1 cái giỏ trống luôn.
        // 3. Từ khóa : ở module Giỏ hàng chuyển sang dùng ORM là Entity Framework Core. Điểm nhấn là hàm này xài kỹ thuật Eager Loading bằng từ khóa '.Include' và '.ThenInclude'.
        // Nó giúp gom dữ liệu của cả 3 bảng (Giỏ Hàng, Chi Tiết Giỏ, Sản Phẩm) lên chỉ trong 1 lần kết nối duy nhất, code cực kỳ hướng đối tượng và sạch sẽ ạ!"

        [HttpGet]
        public async Task<ActionResult<Cart>> GetMyCart()
        {
            var userId = GetCurrentUserId();

            var cart = await _context.Carts
                .Include(c => c.CartItems!)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            return Ok(cart);
        }
        // CHỨC NĂNG THÊM VÀO GIỎ HÀNG
        // 1. Mục đích: Khách bấm nút "Thêm vào giỏ" thì sẽ lưu món đó vào Database.
        // 2. Cách hoạt động: 
        //    - Quét xem giỏ hàng của khách đã có món này chưa (tìm qua existingItem).
        //    - NẾU CÓ RỒI: Lấy số lượng cũ cộng dồn thêm số lượng mới (+Quantity).
        //    - NẾU CHƯA CÓ: Tạo ra một dòng mới toanh chứa sản phẩm đó nhét vào giỏ. 
        //    - Cuối cùng gọi SaveChangesAsync() để chốt lưu xuống SQL.
        // 3. Từ khóa : này em xử lý logic gộp số lượng rất chặt chẽ ạ.
        // Trước khi thêm,  luôn check sự tồn tại của món hàng trong giỏ. Nếu khách bấm thêm 5 lần 1 món, code 
        //  chỉ cộng dồn số lượng lên 5 chứ không tạo ra 5 dòng trùng lặp nhau. Việc này giúp bảo vệ Database không bị phình to do rác dữ liệu (Data Duplication) ạ."

        [HttpPost("add")]
        public async Task<ActionResult> AddToCart([FromBody] CartItemRequest request)
        {
            var userId = GetCurrentUserId();

            var cart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserId == userId);
            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            var existingItem = cart.CartItems?.FirstOrDefault(ci => ci.ProductId == request.ProductId);
            if (existingItem != null)
            {
             
                existingItem.Quantity += request.Quantity; 
            }
            else
            {

                var newItem = new CartItem
                {
                    CartId = cart.Id,
                    ProductId = request.ProductId,
                    Quantity = request.Quantity
                };
                _context.CartItems.Add(newItem);
            }

            await _context.SaveChangesAsync();
            return Ok(new { message = "Đã bỏ ngọc quý vào giỏ thành công rực rỡ!" });
        }
    }

    public class CartItemRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}