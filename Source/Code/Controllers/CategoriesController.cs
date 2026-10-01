using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThanhTamNgoc.Api.Data;
using ThanhTamNgoc.Api.Models;
// dDanh muc spham hiên ra menu ( THEM MOI DANH MUC_ADMIN/ DS TOÀN MỤC )


// QUẢN LÝ DANH MỤC SẢN PHẨM (CATEGORIES)
// 1. Mục đích chung:
//    - Cung cấp API quản lý các loại trang sức (danh mục) để hiển thị lên menu điều hướng trên giao diện khách hàng và bộ lọc sản phẩm.
// 2. Kỹ thuật lập trình áp dụng (Entity Framework Core):
//    - ORM (Object-Relational Mapping): Thao tác với CSDL thông qua các đối tượng C# (AppDbContext) thay vì sử dụng câu lệnh truy vấn SQL thô.
//    - Dependency Injection (DI): Tiêm (inject) AppDbContext vào Controller thông qua constructor để quản lý vòng đời của kết nối CSDL một cách tự động.
//    - Bất đồng bộ (Async/Await & Task): Tránh tình trạng thắt cổ chai (bottleneck) tại server. Luồng (thread) xử lý sẽ được giải phóng trong thời gian
//    chờ CSDL phản hồi, giúp tăng khả năng chịu tải đồng thời của hệ thống.
namespace ThanhTamNgoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        //LẤY DANH SÁCH TOÀN BỘ DANH MỤC
        // - Hoạt động: Sử dụng phương thức mở rộng 'ToListAsync()' của Entity Framework để
        // truy xuất toàn bộ các bản ghi từ bảng Categories trong CSDL và trả về dưới dạng danh sách.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
        // THÊM MỚI DANH MỤC SẢN PHẨM(DÀNH CHO ADMIN)
        // - Hoạt động: 
        //   + Tiếp nhận đối tượng Category được map tự động từ HTTP Request Body.
        //   + 'Add()': Đưa đối tượng vào bộ theo dõi (Change Tracker) của Entity Framework với trạng thái Added.
        //   + 'SaveChangesAsync()': Kích hoạt EF Core tự động sinh ra câu lệnh INSERT tương ứng và thực thi xuống CSDL vật lý.
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }
    }
}