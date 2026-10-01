using Microsoft.EntityFrameworkCore.Migrations;
// Người dùng (Users), Danh mục (Categories) và Sản phẩm (Products).
#nullable disable
// MIGRATION: KHỞI TẠO CƠ SỞ DỮ LIỆU BAN ĐẦU (INITIAL CREATE) < để ENtity frame work tự động xây dựng CSDL dựa trên các Class C# => gọi là Code-First Approach.
// - Kỹ thuật áp dụng: Entity Framework Core Migrations (Code-First Approach).
// - Mục đích: Tự động biên dịch các class C# (Models) thành mã DDL để tạo bảng,
// định nghĩa kiểu dữ liệu và thiết lập các ràng buộc (Khóa chính, Khóa ngoại) trong SQL Server mà không cần viết script SQL thủ công.
namespace ThanhTamNgoc.Api.Migrations
{
    /// <inheritdoc />
    // PHƯƠNG THỨC UP(): THỰC THI MIGRATION
    // - Kích hoạt khi chạy lệnh 'Update-Database'.
    // - Nhiệm vụ: Khởi tạo các bảng (Categories, Users, Products), cấp phát tự động Khóa chính (Identity) và thiết lập Khóa ngoại
    // (ForeignKey) từ bảng Products sang Categories với cơ chế Xóa tầng (Cascade Delete).
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CertificateUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        // PHƯƠNG THỨC DOWN(): HOÀN TÁC (ROLLBACK) MIGRATION
        // - Kích hoạt khi muốn gỡ bỏ Migration này để quay về phiên bản trước đó.
        // - Nhiệm vụ: Xóa các bảng (DropTable) theo thứ tự ngược lại với lúc tạo để đảm bảo không bị lỗi xung đột ràng buộc khóa ngoại (Foreign Key Constraint).
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
