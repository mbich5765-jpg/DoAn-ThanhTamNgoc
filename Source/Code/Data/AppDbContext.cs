using Microsoft.EntityFrameworkCore;
using ThanhTamNgoc.Api.Models;
// CẤU HÌNH CƠ SỞ DỮ LIỆU (DATABASE CONTEXT)
namespace ThanhTamNgoc.Api.Data
{
    
    // - Lớp AppDbContext kế thừa từ DbContext của Entity Framework Core, đóng vai trò làm cầu nối (Session) giữa code C# và SQL Server.
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        // 1. ÁNH XẠ THỰC THỂ (ENTITY MAPPING): Khai báo các class Models sẽ được ánh xạ thành các Table trong CSDL.
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        // 2. TẠO DỮ LIỆU MẪU (DATA SEEDING):
        // - Ghi đè hàm OnModelCreating để tự động chèn dữ liệu vào CSDL ngay khi chạy Migration lần đầu.
        // - Kỹ thuật áp dụng: Sử dụng vòng lặp lồng nhau (Nested Loops) để tự động sinh ra 900 bản ghi sản phẩm
        // (5 Danh mục * 6 Phân loại * 30 Mẫu) với dữ liệu giả lập (Mock data) về giá cả và mô tả.
        // - Mục đích: Cung cấp khối lượng dữ liệu đủ lớn để kiểm thử (Test) ngay lập tức các chức năng như: Lọc theo giá,
        // Tìm kiếm, và Phân trang (Pagination) trên giao diện Front-end mà không cần thao tác nhập liệu thủ công.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed Categories (Chèn 5 danh mục gốc)
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Phỉ Thúy", Description = "Ngọc Phỉ Thúy cao cấp" },
                new Category { Id = 2, Name = "Ngọc Lục Bảo", Description = "Đá Emerald thiên nhiên" },
                new Category { Id = 3, Name = "Ruby", Description = "Hồng ngọc huyết bồ câu" },
                new Category { Id = 4, Name = "Lam Ngọc", Description = "Sapphire xanh thẳm" },
                new Category { Id = 5, Name = "Băng Chủng", Description = "Ngọc Băng Chủng trong suốt" }
            };
            modelBuilder.Entity<Category>().HasData(categories);
            // Seed Products (Sinh tự động 900 sản phẩm)
            var products = new List<Product>();
            string[] items = { "Nhẫn", "Mặt dây chuyền", "Chuỗi", "Bông tai", "Vòng tay", "Ngọc bội" };
            int productId = 1;

            foreach (var cat in categories)
            {
                foreach (var item in items)
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        products.Add(new Product
                        {
                            Id = productId++,
                            Name = $"{item} {cat.Name} mẫu {i:D2}",
                            Description = $"Sản phẩm {item} chế tác từ {cat.Name} tinh xảo, mẫu số {i}.",
                            Price = 5000000 + (i * 100000),  // GIÁ TĂNG DẦN TỰ ĐỘNG 
                            StockQuantity = 10,
                            GemType = cat.Name,
                            Color = "Tự nhiên",
                            IsFeatured = i <= 5,  // 5 MẪU ĐẦU TIÊN ĐÁNH DẤU LÀ NỔI BẬT 
                            CategoryId = cat.Id,
                            ImageUrl = "default.jpg",
                            CertificateUrl = "cert.jpg"
                        });
                    }
                }
            }
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}