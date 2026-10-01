using Microsoft.EntityFrameworkCore.Migrations;
// GIỎ HÀNG 
#nullable disable
// KHỞI TẠO HỆ THỐNG GIỎ HÀNG (ADD CART SYSTEM)
// - Mục đích: Bổ sung thêm các bảng lưu trữ tính năng Giỏ hàng vào CSDL hiện tại thông qua luồng Code-First.
// - Kỹ thuật áp dụng: Thiết lập quan hệ thực thể (Entity Relationships) chuẩn mực giữa Giỏ hàng, Người dùng và Sản phẩm.
namespace ThanhTamNgoc.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddCartSystem : Migration
    {
        /// <inheritdoc />
        // PHƯƠNG THỨC UP(): THỰC THI MIGRATION TẠO BẢNG GIỎ HÀNG
        // - Nhiệm vụ 1: Tạo bảng 'Carts' (Giỏ hàng của khách) và gắn khóa ngoại (UserId) liên kết sang bảng Users.
        // - Nhiệm vụ 2: Tạo bảng 'CartItems' (Chi tiết giỏ hàng). Bảng này đóng vai trò trung gian, chứa khóa ngoại trỏ về bảng Carts (CartId) và bảng Products (ProductId).
        // - Kỹ thuật Toàn vẹn dữ liệu (Cascade Delete): Áp dụng 'ReferentialAction.Cascade'. Nghĩa là nếu xóa một User, toàn bộ Carts và CartItems của người đó sẽ bị hệ thống tự động dọn sạch, giúp CSDL không bị tồn đọng dữ liệu rác (Orphan Data).
        // - Kỹ thuật Tối ưu hiệu năng (Indexing): Lệnh CreateIndex tự động đánh chỉ mục lên các cột khóa ngoại.
        // Việc này giúp thao tác JOIN bảng để đếm số lượng sản phẩm trong giỏ hàng diễn ra với tốc độ cực nhanh (O(log n)).
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");
        }

        /// <inheritdoc />
        // PHƯƠNG THỨC DOWN(): HOÀN TÁC (ROLLBACK)
        // - Nhiệm vụ: Gỡ bỏ hệ thống giỏ hàng. Tuân thủ nguyên tắc xóa bảng con (CartItems) trước,
        // rồi mới xóa bảng cha (Carts) để tránh vi phạm lỗi ràng buộc khóa ngoại (FK Constraint Violation).
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
