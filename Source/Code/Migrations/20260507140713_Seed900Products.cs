using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThanhTamNgoc.Api.Migrations
{
    /// <inheritdoc />
    public partial class Seed900Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Ngọc Phỉ Thúy cao cấp", "Phỉ Thúy" },
                    { 2, "Đá Emerald thiên nhiên", "Ngọc Lục Bảo" },
                    { 3, "Hồng ngọc huyết bồ câu", "Ruby" },
                    { 4, "Sapphire xanh thẳm", "Lam Ngọc" },
                    { 5, "Ngọc Băng Chủng trong suốt", "Băng Chủng" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CertificateUrl", "Color", "Description", "GemType", "ImageUrl", "IsFeatured", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 1.", "Phỉ Thúy", "default.jpg", true, "Nhẫn Phỉ Thúy mẫu 01", 5100000m, 10 },
                    { 2, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 2.", "Phỉ Thúy", "default.jpg", true, "Nhẫn Phỉ Thúy mẫu 02", 5200000m, 10 },
                    { 3, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 3.", "Phỉ Thúy", "default.jpg", true, "Nhẫn Phỉ Thúy mẫu 03", 5300000m, 10 },
                    { 4, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 4.", "Phỉ Thúy", "default.jpg", true, "Nhẫn Phỉ Thúy mẫu 04", 5400000m, 10 },
                    { 5, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 5.", "Phỉ Thúy", "default.jpg", true, "Nhẫn Phỉ Thúy mẫu 05", 5500000m, 10 },
                    { 6, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 6.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 06", 5600000m, 10 },
                    { 7, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 7.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 07", 5700000m, 10 },
                    { 8, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 8.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 08", 5800000m, 10 },
                    { 9, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 9.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 09", 5900000m, 10 },
                    { 10, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 10.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 10", 6000000m, 10 },
                    { 11, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 11.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 11", 6100000m, 10 },
                    { 12, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 12.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 12", 6200000m, 10 },
                    { 13, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 13.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 13", 6300000m, 10 },
                    { 14, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 14.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 14", 6400000m, 10 },
                    { 15, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 15.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 15", 6500000m, 10 },
                    { 16, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 16.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 16", 6600000m, 10 },
                    { 17, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 17.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 17", 6700000m, 10 },
                    { 18, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 18.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 18", 6800000m, 10 },
                    { 19, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 19.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 19", 6900000m, 10 },
                    { 20, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 20.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 20", 7000000m, 10 },
                    { 21, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 21.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 21", 7100000m, 10 },
                    { 22, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 22.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 22", 7200000m, 10 },
                    { 23, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 23.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 23", 7300000m, 10 },
                    { 24, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 24.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 24", 7400000m, 10 },
                    { 25, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 25.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 25", 7500000m, 10 },
                    { 26, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 26.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 26", 7600000m, 10 },
                    { 27, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 27.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 27", 7700000m, 10 },
                    { 28, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 28.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 28", 7800000m, 10 },
                    { 29, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 29.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 29", 7900000m, 10 },
                    { 30, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Phỉ Thúy tinh xảo, mẫu số 30.", "Phỉ Thúy", "default.jpg", false, "Nhẫn Phỉ Thúy mẫu 30", 8000000m, 10 },
                    { 31, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 1.", "Phỉ Thúy", "default.jpg", true, "Mặt dây chuyền Phỉ Thúy mẫu 01", 5100000m, 10 },
                    { 32, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 2.", "Phỉ Thúy", "default.jpg", true, "Mặt dây chuyền Phỉ Thúy mẫu 02", 5200000m, 10 },
                    { 33, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 3.", "Phỉ Thúy", "default.jpg", true, "Mặt dây chuyền Phỉ Thúy mẫu 03", 5300000m, 10 },
                    { 34, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 4.", "Phỉ Thúy", "default.jpg", true, "Mặt dây chuyền Phỉ Thúy mẫu 04", 5400000m, 10 },
                    { 35, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 5.", "Phỉ Thúy", "default.jpg", true, "Mặt dây chuyền Phỉ Thúy mẫu 05", 5500000m, 10 },
                    { 36, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 6.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 06", 5600000m, 10 },
                    { 37, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 7.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 07", 5700000m, 10 },
                    { 38, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 8.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 08", 5800000m, 10 },
                    { 39, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 9.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 09", 5900000m, 10 },
                    { 40, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 10.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 10", 6000000m, 10 },
                    { 41, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 11.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 11", 6100000m, 10 },
                    { 42, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 12.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 12", 6200000m, 10 },
                    { 43, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 13.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 13", 6300000m, 10 },
                    { 44, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 14.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 14", 6400000m, 10 },
                    { 45, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 15.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 15", 6500000m, 10 },
                    { 46, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 16.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 16", 6600000m, 10 },
                    { 47, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 17.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 17", 6700000m, 10 },
                    { 48, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 18.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 18", 6800000m, 10 },
                    { 49, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 19.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 19", 6900000m, 10 },
                    { 50, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 20.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 20", 7000000m, 10 },
                    { 51, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 21.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 21", 7100000m, 10 },
                    { 52, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 22.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 22", 7200000m, 10 },
                    { 53, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 23.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 23", 7300000m, 10 },
                    { 54, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 24.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 24", 7400000m, 10 },
                    { 55, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 25.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 25", 7500000m, 10 },
                    { 56, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 26.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 26", 7600000m, 10 },
                    { 57, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 27.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 27", 7700000m, 10 },
                    { 58, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 28.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 28", 7800000m, 10 },
                    { 59, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 29.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 29", 7900000m, 10 },
                    { 60, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Phỉ Thúy tinh xảo, mẫu số 30.", "Phỉ Thúy", "default.jpg", false, "Mặt dây chuyền Phỉ Thúy mẫu 30", 8000000m, 10 },
                    { 61, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 1.", "Phỉ Thúy", "default.jpg", true, "Chuỗi Phỉ Thúy mẫu 01", 5100000m, 10 },
                    { 62, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 2.", "Phỉ Thúy", "default.jpg", true, "Chuỗi Phỉ Thúy mẫu 02", 5200000m, 10 },
                    { 63, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 3.", "Phỉ Thúy", "default.jpg", true, "Chuỗi Phỉ Thúy mẫu 03", 5300000m, 10 },
                    { 64, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 4.", "Phỉ Thúy", "default.jpg", true, "Chuỗi Phỉ Thúy mẫu 04", 5400000m, 10 },
                    { 65, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 5.", "Phỉ Thúy", "default.jpg", true, "Chuỗi Phỉ Thúy mẫu 05", 5500000m, 10 },
                    { 66, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 6.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 06", 5600000m, 10 },
                    { 67, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 7.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 07", 5700000m, 10 },
                    { 68, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 8.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 08", 5800000m, 10 },
                    { 69, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 9.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 09", 5900000m, 10 },
                    { 70, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 10.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 10", 6000000m, 10 },
                    { 71, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 11.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 11", 6100000m, 10 },
                    { 72, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 12.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 12", 6200000m, 10 },
                    { 73, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 13.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 13", 6300000m, 10 },
                    { 74, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 14.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 14", 6400000m, 10 },
                    { 75, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 15.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 15", 6500000m, 10 },
                    { 76, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 16.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 16", 6600000m, 10 },
                    { 77, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 17.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 17", 6700000m, 10 },
                    { 78, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 18.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 18", 6800000m, 10 },
                    { 79, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 19.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 19", 6900000m, 10 },
                    { 80, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 20.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 20", 7000000m, 10 },
                    { 81, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 21.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 21", 7100000m, 10 },
                    { 82, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 22.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 22", 7200000m, 10 },
                    { 83, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 23.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 23", 7300000m, 10 },
                    { 84, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 24.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 24", 7400000m, 10 },
                    { 85, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 25.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 25", 7500000m, 10 },
                    { 86, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 26.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 26", 7600000m, 10 },
                    { 87, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 27.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 27", 7700000m, 10 },
                    { 88, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 28.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 28", 7800000m, 10 },
                    { 89, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 29.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 29", 7900000m, 10 },
                    { 90, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Phỉ Thúy tinh xảo, mẫu số 30.", "Phỉ Thúy", "default.jpg", false, "Chuỗi Phỉ Thúy mẫu 30", 8000000m, 10 },
                    { 91, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 1.", "Phỉ Thúy", "default.jpg", true, "Bông tai Phỉ Thúy mẫu 01", 5100000m, 10 },
                    { 92, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 2.", "Phỉ Thúy", "default.jpg", true, "Bông tai Phỉ Thúy mẫu 02", 5200000m, 10 },
                    { 93, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 3.", "Phỉ Thúy", "default.jpg", true, "Bông tai Phỉ Thúy mẫu 03", 5300000m, 10 },
                    { 94, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 4.", "Phỉ Thúy", "default.jpg", true, "Bông tai Phỉ Thúy mẫu 04", 5400000m, 10 },
                    { 95, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 5.", "Phỉ Thúy", "default.jpg", true, "Bông tai Phỉ Thúy mẫu 05", 5500000m, 10 },
                    { 96, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 6.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 06", 5600000m, 10 },
                    { 97, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 7.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 07", 5700000m, 10 },
                    { 98, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 8.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 08", 5800000m, 10 },
                    { 99, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 9.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 09", 5900000m, 10 },
                    { 100, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 10.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 10", 6000000m, 10 },
                    { 101, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 11.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 11", 6100000m, 10 },
                    { 102, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 12.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 12", 6200000m, 10 },
                    { 103, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 13.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 13", 6300000m, 10 },
                    { 104, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 14.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 14", 6400000m, 10 },
                    { 105, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 15.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 15", 6500000m, 10 },
                    { 106, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 16.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 16", 6600000m, 10 },
                    { 107, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 17.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 17", 6700000m, 10 },
                    { 108, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 18.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 18", 6800000m, 10 },
                    { 109, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 19.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 19", 6900000m, 10 },
                    { 110, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 20.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 20", 7000000m, 10 },
                    { 111, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 21.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 21", 7100000m, 10 },
                    { 112, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 22.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 22", 7200000m, 10 },
                    { 113, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 23.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 23", 7300000m, 10 },
                    { 114, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 24.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 24", 7400000m, 10 },
                    { 115, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 25.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 25", 7500000m, 10 },
                    { 116, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 26.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 26", 7600000m, 10 },
                    { 117, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 27.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 27", 7700000m, 10 },
                    { 118, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 28.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 28", 7800000m, 10 },
                    { 119, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 29.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 29", 7900000m, 10 },
                    { 120, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Phỉ Thúy tinh xảo, mẫu số 30.", "Phỉ Thúy", "default.jpg", false, "Bông tai Phỉ Thúy mẫu 30", 8000000m, 10 },
                    { 121, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 1.", "Phỉ Thúy", "default.jpg", true, "Vòng tay Phỉ Thúy mẫu 01", 5100000m, 10 },
                    { 122, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 2.", "Phỉ Thúy", "default.jpg", true, "Vòng tay Phỉ Thúy mẫu 02", 5200000m, 10 },
                    { 123, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 3.", "Phỉ Thúy", "default.jpg", true, "Vòng tay Phỉ Thúy mẫu 03", 5300000m, 10 },
                    { 124, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 4.", "Phỉ Thúy", "default.jpg", true, "Vòng tay Phỉ Thúy mẫu 04", 5400000m, 10 },
                    { 125, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 5.", "Phỉ Thúy", "default.jpg", true, "Vòng tay Phỉ Thúy mẫu 05", 5500000m, 10 },
                    { 126, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 6.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 06", 5600000m, 10 },
                    { 127, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 7.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 07", 5700000m, 10 },
                    { 128, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 8.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 08", 5800000m, 10 },
                    { 129, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 9.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 09", 5900000m, 10 },
                    { 130, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 10.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 10", 6000000m, 10 },
                    { 131, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 11.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 11", 6100000m, 10 },
                    { 132, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 12.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 12", 6200000m, 10 },
                    { 133, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 13.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 13", 6300000m, 10 },
                    { 134, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 14.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 14", 6400000m, 10 },
                    { 135, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 15.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 15", 6500000m, 10 },
                    { 136, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 16.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 16", 6600000m, 10 },
                    { 137, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 17.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 17", 6700000m, 10 },
                    { 138, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 18.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 18", 6800000m, 10 },
                    { 139, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 19.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 19", 6900000m, 10 },
                    { 140, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 20.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 20", 7000000m, 10 },
                    { 141, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 21.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 21", 7100000m, 10 },
                    { 142, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 22.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 22", 7200000m, 10 },
                    { 143, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 23.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 23", 7300000m, 10 },
                    { 144, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 24.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 24", 7400000m, 10 },
                    { 145, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 25.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 25", 7500000m, 10 },
                    { 146, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 26.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 26", 7600000m, 10 },
                    { 147, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 27.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 27", 7700000m, 10 },
                    { 148, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 28.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 28", 7800000m, 10 },
                    { 149, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 29.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 29", 7900000m, 10 },
                    { 150, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Phỉ Thúy tinh xảo, mẫu số 30.", "Phỉ Thúy", "default.jpg", false, "Vòng tay Phỉ Thúy mẫu 30", 8000000m, 10 },
                    { 151, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 1.", "Phỉ Thúy", "default.jpg", true, "Ngọc bội Phỉ Thúy mẫu 01", 5100000m, 10 },
                    { 152, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 2.", "Phỉ Thúy", "default.jpg", true, "Ngọc bội Phỉ Thúy mẫu 02", 5200000m, 10 },
                    { 153, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 3.", "Phỉ Thúy", "default.jpg", true, "Ngọc bội Phỉ Thúy mẫu 03", 5300000m, 10 },
                    { 154, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 4.", "Phỉ Thúy", "default.jpg", true, "Ngọc bội Phỉ Thúy mẫu 04", 5400000m, 10 },
                    { 155, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 5.", "Phỉ Thúy", "default.jpg", true, "Ngọc bội Phỉ Thúy mẫu 05", 5500000m, 10 },
                    { 156, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 6.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 06", 5600000m, 10 },
                    { 157, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 7.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 07", 5700000m, 10 },
                    { 158, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 8.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 08", 5800000m, 10 },
                    { 159, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 9.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 09", 5900000m, 10 },
                    { 160, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 10.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 10", 6000000m, 10 },
                    { 161, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 11.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 11", 6100000m, 10 },
                    { 162, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 12.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 12", 6200000m, 10 },
                    { 163, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 13.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 13", 6300000m, 10 },
                    { 164, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 14.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 14", 6400000m, 10 },
                    { 165, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 15.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 15", 6500000m, 10 },
                    { 166, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 16.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 16", 6600000m, 10 },
                    { 167, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 17.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 17", 6700000m, 10 },
                    { 168, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 18.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 18", 6800000m, 10 },
                    { 169, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 19.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 19", 6900000m, 10 },
                    { 170, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 20.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 20", 7000000m, 10 },
                    { 171, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 21.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 21", 7100000m, 10 },
                    { 172, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 22.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 22", 7200000m, 10 },
                    { 173, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 23.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 23", 7300000m, 10 },
                    { 174, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 24.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 24", 7400000m, 10 },
                    { 175, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 25.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 25", 7500000m, 10 },
                    { 176, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 26.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 26", 7600000m, 10 },
                    { 177, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 27.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 27", 7700000m, 10 },
                    { 178, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 28.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 28", 7800000m, 10 },
                    { 179, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 29.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 29", 7900000m, 10 },
                    { 180, 1, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Phỉ Thúy tinh xảo, mẫu số 30.", "Phỉ Thúy", "default.jpg", false, "Ngọc bội Phỉ Thúy mẫu 30", 8000000m, 10 },
                    { 181, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 1.", "Ngọc Lục Bảo", "default.jpg", true, "Nhẫn Ngọc Lục Bảo mẫu 01", 5100000m, 10 },
                    { 182, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 2.", "Ngọc Lục Bảo", "default.jpg", true, "Nhẫn Ngọc Lục Bảo mẫu 02", 5200000m, 10 },
                    { 183, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 3.", "Ngọc Lục Bảo", "default.jpg", true, "Nhẫn Ngọc Lục Bảo mẫu 03", 5300000m, 10 },
                    { 184, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 4.", "Ngọc Lục Bảo", "default.jpg", true, "Nhẫn Ngọc Lục Bảo mẫu 04", 5400000m, 10 },
                    { 185, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 5.", "Ngọc Lục Bảo", "default.jpg", true, "Nhẫn Ngọc Lục Bảo mẫu 05", 5500000m, 10 },
                    { 186, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 6.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 06", 5600000m, 10 },
                    { 187, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 7.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 07", 5700000m, 10 },
                    { 188, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 8.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 08", 5800000m, 10 },
                    { 189, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 9.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 09", 5900000m, 10 },
                    { 190, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 10.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 10", 6000000m, 10 },
                    { 191, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 11.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 11", 6100000m, 10 },
                    { 192, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 12.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 12", 6200000m, 10 },
                    { 193, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 13.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 13", 6300000m, 10 },
                    { 194, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 14.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 14", 6400000m, 10 },
                    { 195, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 15.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 15", 6500000m, 10 },
                    { 196, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 16.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 16", 6600000m, 10 },
                    { 197, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 17.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 17", 6700000m, 10 },
                    { 198, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 18.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 18", 6800000m, 10 },
                    { 199, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 19.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 19", 6900000m, 10 },
                    { 200, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 20.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 20", 7000000m, 10 },
                    { 201, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 21.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 21", 7100000m, 10 },
                    { 202, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 22.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 22", 7200000m, 10 },
                    { 203, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 23.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 23", 7300000m, 10 },
                    { 204, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 24.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 24", 7400000m, 10 },
                    { 205, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 25.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 25", 7500000m, 10 },
                    { 206, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 26.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 26", 7600000m, 10 },
                    { 207, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 27.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 27", 7700000m, 10 },
                    { 208, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 28.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 28", 7800000m, 10 },
                    { 209, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 29.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 29", 7900000m, 10 },
                    { 210, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 30.", "Ngọc Lục Bảo", "default.jpg", false, "Nhẫn Ngọc Lục Bảo mẫu 30", 8000000m, 10 },
                    { 211, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 1.", "Ngọc Lục Bảo", "default.jpg", true, "Mặt dây chuyền Ngọc Lục Bảo mẫu 01", 5100000m, 10 },
                    { 212, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 2.", "Ngọc Lục Bảo", "default.jpg", true, "Mặt dây chuyền Ngọc Lục Bảo mẫu 02", 5200000m, 10 },
                    { 213, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 3.", "Ngọc Lục Bảo", "default.jpg", true, "Mặt dây chuyền Ngọc Lục Bảo mẫu 03", 5300000m, 10 },
                    { 214, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 4.", "Ngọc Lục Bảo", "default.jpg", true, "Mặt dây chuyền Ngọc Lục Bảo mẫu 04", 5400000m, 10 },
                    { 215, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 5.", "Ngọc Lục Bảo", "default.jpg", true, "Mặt dây chuyền Ngọc Lục Bảo mẫu 05", 5500000m, 10 },
                    { 216, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 6.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 06", 5600000m, 10 },
                    { 217, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 7.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 07", 5700000m, 10 },
                    { 218, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 8.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 08", 5800000m, 10 },
                    { 219, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 9.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 09", 5900000m, 10 },
                    { 220, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 10.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 10", 6000000m, 10 },
                    { 221, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 11.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 11", 6100000m, 10 },
                    { 222, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 12.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 12", 6200000m, 10 },
                    { 223, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 13.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 13", 6300000m, 10 },
                    { 224, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 14.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 14", 6400000m, 10 },
                    { 225, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 15.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 15", 6500000m, 10 },
                    { 226, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 16.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 16", 6600000m, 10 },
                    { 227, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 17.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 17", 6700000m, 10 },
                    { 228, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 18.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 18", 6800000m, 10 },
                    { 229, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 19.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 19", 6900000m, 10 },
                    { 230, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 20.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 20", 7000000m, 10 },
                    { 231, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 21.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 21", 7100000m, 10 },
                    { 232, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 22.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 22", 7200000m, 10 },
                    { 233, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 23.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 23", 7300000m, 10 },
                    { 234, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 24.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 24", 7400000m, 10 },
                    { 235, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 25.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 25", 7500000m, 10 },
                    { 236, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 26.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 26", 7600000m, 10 },
                    { 237, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 27.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 27", 7700000m, 10 },
                    { 238, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 28.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 28", 7800000m, 10 },
                    { 239, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 29.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 29", 7900000m, 10 },
                    { 240, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 30.", "Ngọc Lục Bảo", "default.jpg", false, "Mặt dây chuyền Ngọc Lục Bảo mẫu 30", 8000000m, 10 },
                    { 241, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 1.", "Ngọc Lục Bảo", "default.jpg", true, "Chuỗi Ngọc Lục Bảo mẫu 01", 5100000m, 10 },
                    { 242, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 2.", "Ngọc Lục Bảo", "default.jpg", true, "Chuỗi Ngọc Lục Bảo mẫu 02", 5200000m, 10 },
                    { 243, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 3.", "Ngọc Lục Bảo", "default.jpg", true, "Chuỗi Ngọc Lục Bảo mẫu 03", 5300000m, 10 },
                    { 244, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 4.", "Ngọc Lục Bảo", "default.jpg", true, "Chuỗi Ngọc Lục Bảo mẫu 04", 5400000m, 10 },
                    { 245, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 5.", "Ngọc Lục Bảo", "default.jpg", true, "Chuỗi Ngọc Lục Bảo mẫu 05", 5500000m, 10 },
                    { 246, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 6.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 06", 5600000m, 10 },
                    { 247, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 7.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 07", 5700000m, 10 },
                    { 248, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 8.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 08", 5800000m, 10 },
                    { 249, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 9.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 09", 5900000m, 10 },
                    { 250, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 10.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 10", 6000000m, 10 },
                    { 251, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 11.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 11", 6100000m, 10 },
                    { 252, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 12.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 12", 6200000m, 10 },
                    { 253, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 13.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 13", 6300000m, 10 },
                    { 254, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 14.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 14", 6400000m, 10 },
                    { 255, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 15.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 15", 6500000m, 10 },
                    { 256, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 16.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 16", 6600000m, 10 },
                    { 257, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 17.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 17", 6700000m, 10 },
                    { 258, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 18.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 18", 6800000m, 10 },
                    { 259, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 19.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 19", 6900000m, 10 },
                    { 260, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 20.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 20", 7000000m, 10 },
                    { 261, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 21.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 21", 7100000m, 10 },
                    { 262, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 22.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 22", 7200000m, 10 },
                    { 263, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 23.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 23", 7300000m, 10 },
                    { 264, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 24.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 24", 7400000m, 10 },
                    { 265, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 25.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 25", 7500000m, 10 },
                    { 266, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 26.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 26", 7600000m, 10 },
                    { 267, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 27.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 27", 7700000m, 10 },
                    { 268, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 28.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 28", 7800000m, 10 },
                    { 269, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 29.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 29", 7900000m, 10 },
                    { 270, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 30.", "Ngọc Lục Bảo", "default.jpg", false, "Chuỗi Ngọc Lục Bảo mẫu 30", 8000000m, 10 },
                    { 271, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 1.", "Ngọc Lục Bảo", "default.jpg", true, "Bông tai Ngọc Lục Bảo mẫu 01", 5100000m, 10 },
                    { 272, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 2.", "Ngọc Lục Bảo", "default.jpg", true, "Bông tai Ngọc Lục Bảo mẫu 02", 5200000m, 10 },
                    { 273, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 3.", "Ngọc Lục Bảo", "default.jpg", true, "Bông tai Ngọc Lục Bảo mẫu 03", 5300000m, 10 },
                    { 274, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 4.", "Ngọc Lục Bảo", "default.jpg", true, "Bông tai Ngọc Lục Bảo mẫu 04", 5400000m, 10 },
                    { 275, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 5.", "Ngọc Lục Bảo", "default.jpg", true, "Bông tai Ngọc Lục Bảo mẫu 05", 5500000m, 10 },
                    { 276, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 6.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 06", 5600000m, 10 },
                    { 277, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 7.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 07", 5700000m, 10 },
                    { 278, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 8.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 08", 5800000m, 10 },
                    { 279, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 9.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 09", 5900000m, 10 },
                    { 280, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 10.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 10", 6000000m, 10 },
                    { 281, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 11.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 11", 6100000m, 10 },
                    { 282, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 12.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 12", 6200000m, 10 },
                    { 283, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 13.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 13", 6300000m, 10 },
                    { 284, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 14.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 14", 6400000m, 10 },
                    { 285, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 15.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 15", 6500000m, 10 },
                    { 286, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 16.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 16", 6600000m, 10 },
                    { 287, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 17.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 17", 6700000m, 10 },
                    { 288, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 18.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 18", 6800000m, 10 },
                    { 289, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 19.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 19", 6900000m, 10 },
                    { 290, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 20.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 20", 7000000m, 10 },
                    { 291, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 21.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 21", 7100000m, 10 },
                    { 292, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 22.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 22", 7200000m, 10 },
                    { 293, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 23.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 23", 7300000m, 10 },
                    { 294, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 24.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 24", 7400000m, 10 },
                    { 295, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 25.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 25", 7500000m, 10 },
                    { 296, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 26.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 26", 7600000m, 10 },
                    { 297, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 27.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 27", 7700000m, 10 },
                    { 298, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 28.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 28", 7800000m, 10 },
                    { 299, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 29.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 29", 7900000m, 10 },
                    { 300, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 30.", "Ngọc Lục Bảo", "default.jpg", false, "Bông tai Ngọc Lục Bảo mẫu 30", 8000000m, 10 },
                    { 301, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 1.", "Ngọc Lục Bảo", "default.jpg", true, "Vòng tay Ngọc Lục Bảo mẫu 01", 5100000m, 10 },
                    { 302, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 2.", "Ngọc Lục Bảo", "default.jpg", true, "Vòng tay Ngọc Lục Bảo mẫu 02", 5200000m, 10 },
                    { 303, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 3.", "Ngọc Lục Bảo", "default.jpg", true, "Vòng tay Ngọc Lục Bảo mẫu 03", 5300000m, 10 },
                    { 304, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 4.", "Ngọc Lục Bảo", "default.jpg", true, "Vòng tay Ngọc Lục Bảo mẫu 04", 5400000m, 10 },
                    { 305, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 5.", "Ngọc Lục Bảo", "default.jpg", true, "Vòng tay Ngọc Lục Bảo mẫu 05", 5500000m, 10 },
                    { 306, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 6.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 06", 5600000m, 10 },
                    { 307, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 7.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 07", 5700000m, 10 },
                    { 308, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 8.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 08", 5800000m, 10 },
                    { 309, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 9.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 09", 5900000m, 10 },
                    { 310, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 10.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 10", 6000000m, 10 },
                    { 311, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 11.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 11", 6100000m, 10 },
                    { 312, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 12.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 12", 6200000m, 10 },
                    { 313, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 13.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 13", 6300000m, 10 },
                    { 314, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 14.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 14", 6400000m, 10 },
                    { 315, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 15.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 15", 6500000m, 10 },
                    { 316, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 16.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 16", 6600000m, 10 },
                    { 317, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 17.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 17", 6700000m, 10 },
                    { 318, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 18.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 18", 6800000m, 10 },
                    { 319, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 19.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 19", 6900000m, 10 },
                    { 320, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 20.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 20", 7000000m, 10 },
                    { 321, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 21.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 21", 7100000m, 10 },
                    { 322, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 22.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 22", 7200000m, 10 },
                    { 323, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 23.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 23", 7300000m, 10 },
                    { 324, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 24.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 24", 7400000m, 10 },
                    { 325, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 25.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 25", 7500000m, 10 },
                    { 326, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 26.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 26", 7600000m, 10 },
                    { 327, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 27.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 27", 7700000m, 10 },
                    { 328, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 28.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 28", 7800000m, 10 },
                    { 329, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 29.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 29", 7900000m, 10 },
                    { 330, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 30.", "Ngọc Lục Bảo", "default.jpg", false, "Vòng tay Ngọc Lục Bảo mẫu 30", 8000000m, 10 },
                    { 331, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 1.", "Ngọc Lục Bảo", "default.jpg", true, "Ngọc bội Ngọc Lục Bảo mẫu 01", 5100000m, 10 },
                    { 332, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 2.", "Ngọc Lục Bảo", "default.jpg", true, "Ngọc bội Ngọc Lục Bảo mẫu 02", 5200000m, 10 },
                    { 333, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 3.", "Ngọc Lục Bảo", "default.jpg", true, "Ngọc bội Ngọc Lục Bảo mẫu 03", 5300000m, 10 },
                    { 334, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 4.", "Ngọc Lục Bảo", "default.jpg", true, "Ngọc bội Ngọc Lục Bảo mẫu 04", 5400000m, 10 },
                    { 335, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 5.", "Ngọc Lục Bảo", "default.jpg", true, "Ngọc bội Ngọc Lục Bảo mẫu 05", 5500000m, 10 },
                    { 336, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 6.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 06", 5600000m, 10 },
                    { 337, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 7.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 07", 5700000m, 10 },
                    { 338, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 8.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 08", 5800000m, 10 },
                    { 339, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 9.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 09", 5900000m, 10 },
                    { 340, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 10.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 10", 6000000m, 10 },
                    { 341, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 11.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 11", 6100000m, 10 },
                    { 342, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 12.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 12", 6200000m, 10 },
                    { 343, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 13.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 13", 6300000m, 10 },
                    { 344, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 14.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 14", 6400000m, 10 },
                    { 345, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 15.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 15", 6500000m, 10 },
                    { 346, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 16.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 16", 6600000m, 10 },
                    { 347, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 17.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 17", 6700000m, 10 },
                    { 348, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 18.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 18", 6800000m, 10 },
                    { 349, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 19.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 19", 6900000m, 10 },
                    { 350, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 20.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 20", 7000000m, 10 },
                    { 351, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 21.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 21", 7100000m, 10 },
                    { 352, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 22.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 22", 7200000m, 10 },
                    { 353, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 23.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 23", 7300000m, 10 },
                    { 354, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 24.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 24", 7400000m, 10 },
                    { 355, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 25.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 25", 7500000m, 10 },
                    { 356, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 26.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 26", 7600000m, 10 },
                    { 357, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 27.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 27", 7700000m, 10 },
                    { 358, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 28.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 28", 7800000m, 10 },
                    { 359, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 29.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 29", 7900000m, 10 },
                    { 360, 2, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ngọc Lục Bảo tinh xảo, mẫu số 30.", "Ngọc Lục Bảo", "default.jpg", false, "Ngọc bội Ngọc Lục Bảo mẫu 30", 8000000m, 10 },
                    { 361, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 1.", "Ruby", "default.jpg", true, "Nhẫn Ruby mẫu 01", 5100000m, 10 },
                    { 362, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 2.", "Ruby", "default.jpg", true, "Nhẫn Ruby mẫu 02", 5200000m, 10 },
                    { 363, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 3.", "Ruby", "default.jpg", true, "Nhẫn Ruby mẫu 03", 5300000m, 10 },
                    { 364, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 4.", "Ruby", "default.jpg", true, "Nhẫn Ruby mẫu 04", 5400000m, 10 },
                    { 365, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 5.", "Ruby", "default.jpg", true, "Nhẫn Ruby mẫu 05", 5500000m, 10 },
                    { 366, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 6.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 06", 5600000m, 10 },
                    { 367, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 7.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 07", 5700000m, 10 },
                    { 368, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 8.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 08", 5800000m, 10 },
                    { 369, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 9.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 09", 5900000m, 10 },
                    { 370, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 10.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 10", 6000000m, 10 },
                    { 371, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 11.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 11", 6100000m, 10 },
                    { 372, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 12.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 12", 6200000m, 10 },
                    { 373, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 13.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 13", 6300000m, 10 },
                    { 374, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 14.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 14", 6400000m, 10 },
                    { 375, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 15.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 15", 6500000m, 10 },
                    { 376, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 16.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 16", 6600000m, 10 },
                    { 377, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 17.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 17", 6700000m, 10 },
                    { 378, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 18.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 18", 6800000m, 10 },
                    { 379, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 19.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 19", 6900000m, 10 },
                    { 380, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 20.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 20", 7000000m, 10 },
                    { 381, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 21.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 21", 7100000m, 10 },
                    { 382, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 22.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 22", 7200000m, 10 },
                    { 383, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 23.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 23", 7300000m, 10 },
                    { 384, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 24.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 24", 7400000m, 10 },
                    { 385, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 25.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 25", 7500000m, 10 },
                    { 386, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 26.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 26", 7600000m, 10 },
                    { 387, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 27.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 27", 7700000m, 10 },
                    { 388, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 28.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 28", 7800000m, 10 },
                    { 389, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 29.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 29", 7900000m, 10 },
                    { 390, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Ruby tinh xảo, mẫu số 30.", "Ruby", "default.jpg", false, "Nhẫn Ruby mẫu 30", 8000000m, 10 },
                    { 391, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 1.", "Ruby", "default.jpg", true, "Mặt dây chuyền Ruby mẫu 01", 5100000m, 10 },
                    { 392, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 2.", "Ruby", "default.jpg", true, "Mặt dây chuyền Ruby mẫu 02", 5200000m, 10 },
                    { 393, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 3.", "Ruby", "default.jpg", true, "Mặt dây chuyền Ruby mẫu 03", 5300000m, 10 },
                    { 394, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 4.", "Ruby", "default.jpg", true, "Mặt dây chuyền Ruby mẫu 04", 5400000m, 10 },
                    { 395, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 5.", "Ruby", "default.jpg", true, "Mặt dây chuyền Ruby mẫu 05", 5500000m, 10 },
                    { 396, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 6.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 06", 5600000m, 10 },
                    { 397, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 7.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 07", 5700000m, 10 },
                    { 398, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 8.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 08", 5800000m, 10 },
                    { 399, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 9.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 09", 5900000m, 10 },
                    { 400, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 10.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 10", 6000000m, 10 },
                    { 401, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 11.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 11", 6100000m, 10 },
                    { 402, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 12.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 12", 6200000m, 10 },
                    { 403, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 13.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 13", 6300000m, 10 },
                    { 404, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 14.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 14", 6400000m, 10 },
                    { 405, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 15.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 15", 6500000m, 10 },
                    { 406, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 16.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 16", 6600000m, 10 },
                    { 407, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 17.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 17", 6700000m, 10 },
                    { 408, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 18.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 18", 6800000m, 10 },
                    { 409, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 19.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 19", 6900000m, 10 },
                    { 410, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 20.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 20", 7000000m, 10 },
                    { 411, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 21.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 21", 7100000m, 10 },
                    { 412, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 22.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 22", 7200000m, 10 },
                    { 413, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 23.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 23", 7300000m, 10 },
                    { 414, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 24.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 24", 7400000m, 10 },
                    { 415, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 25.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 25", 7500000m, 10 },
                    { 416, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 26.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 26", 7600000m, 10 },
                    { 417, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 27.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 27", 7700000m, 10 },
                    { 418, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 28.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 28", 7800000m, 10 },
                    { 419, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 29.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 29", 7900000m, 10 },
                    { 420, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Ruby tinh xảo, mẫu số 30.", "Ruby", "default.jpg", false, "Mặt dây chuyền Ruby mẫu 30", 8000000m, 10 },
                    { 421, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 1.", "Ruby", "default.jpg", true, "Chuỗi Ruby mẫu 01", 5100000m, 10 },
                    { 422, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 2.", "Ruby", "default.jpg", true, "Chuỗi Ruby mẫu 02", 5200000m, 10 },
                    { 423, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 3.", "Ruby", "default.jpg", true, "Chuỗi Ruby mẫu 03", 5300000m, 10 },
                    { 424, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 4.", "Ruby", "default.jpg", true, "Chuỗi Ruby mẫu 04", 5400000m, 10 },
                    { 425, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 5.", "Ruby", "default.jpg", true, "Chuỗi Ruby mẫu 05", 5500000m, 10 },
                    { 426, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 6.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 06", 5600000m, 10 },
                    { 427, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 7.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 07", 5700000m, 10 },
                    { 428, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 8.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 08", 5800000m, 10 },
                    { 429, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 9.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 09", 5900000m, 10 },
                    { 430, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 10.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 10", 6000000m, 10 },
                    { 431, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 11.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 11", 6100000m, 10 },
                    { 432, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 12.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 12", 6200000m, 10 },
                    { 433, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 13.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 13", 6300000m, 10 },
                    { 434, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 14.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 14", 6400000m, 10 },
                    { 435, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 15.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 15", 6500000m, 10 },
                    { 436, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 16.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 16", 6600000m, 10 },
                    { 437, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 17.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 17", 6700000m, 10 },
                    { 438, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 18.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 18", 6800000m, 10 },
                    { 439, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 19.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 19", 6900000m, 10 },
                    { 440, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 20.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 20", 7000000m, 10 },
                    { 441, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 21.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 21", 7100000m, 10 },
                    { 442, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 22.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 22", 7200000m, 10 },
                    { 443, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 23.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 23", 7300000m, 10 },
                    { 444, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 24.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 24", 7400000m, 10 },
                    { 445, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 25.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 25", 7500000m, 10 },
                    { 446, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 26.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 26", 7600000m, 10 },
                    { 447, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 27.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 27", 7700000m, 10 },
                    { 448, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 28.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 28", 7800000m, 10 },
                    { 449, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 29.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 29", 7900000m, 10 },
                    { 450, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Ruby tinh xảo, mẫu số 30.", "Ruby", "default.jpg", false, "Chuỗi Ruby mẫu 30", 8000000m, 10 },
                    { 451, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 1.", "Ruby", "default.jpg", true, "Bông tai Ruby mẫu 01", 5100000m, 10 },
                    { 452, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 2.", "Ruby", "default.jpg", true, "Bông tai Ruby mẫu 02", 5200000m, 10 },
                    { 453, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 3.", "Ruby", "default.jpg", true, "Bông tai Ruby mẫu 03", 5300000m, 10 },
                    { 454, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 4.", "Ruby", "default.jpg", true, "Bông tai Ruby mẫu 04", 5400000m, 10 },
                    { 455, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 5.", "Ruby", "default.jpg", true, "Bông tai Ruby mẫu 05", 5500000m, 10 },
                    { 456, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 6.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 06", 5600000m, 10 },
                    { 457, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 7.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 07", 5700000m, 10 },
                    { 458, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 8.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 08", 5800000m, 10 },
                    { 459, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 9.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 09", 5900000m, 10 },
                    { 460, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 10.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 10", 6000000m, 10 },
                    { 461, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 11.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 11", 6100000m, 10 },
                    { 462, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 12.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 12", 6200000m, 10 },
                    { 463, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 13.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 13", 6300000m, 10 },
                    { 464, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 14.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 14", 6400000m, 10 },
                    { 465, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 15.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 15", 6500000m, 10 },
                    { 466, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 16.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 16", 6600000m, 10 },
                    { 467, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 17.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 17", 6700000m, 10 },
                    { 468, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 18.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 18", 6800000m, 10 },
                    { 469, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 19.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 19", 6900000m, 10 },
                    { 470, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 20.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 20", 7000000m, 10 },
                    { 471, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 21.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 21", 7100000m, 10 },
                    { 472, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 22.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 22", 7200000m, 10 },
                    { 473, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 23.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 23", 7300000m, 10 },
                    { 474, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 24.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 24", 7400000m, 10 },
                    { 475, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 25.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 25", 7500000m, 10 },
                    { 476, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 26.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 26", 7600000m, 10 },
                    { 477, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 27.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 27", 7700000m, 10 },
                    { 478, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 28.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 28", 7800000m, 10 },
                    { 479, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 29.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 29", 7900000m, 10 },
                    { 480, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Ruby tinh xảo, mẫu số 30.", "Ruby", "default.jpg", false, "Bông tai Ruby mẫu 30", 8000000m, 10 },
                    { 481, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 1.", "Ruby", "default.jpg", true, "Vòng tay Ruby mẫu 01", 5100000m, 10 },
                    { 482, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 2.", "Ruby", "default.jpg", true, "Vòng tay Ruby mẫu 02", 5200000m, 10 },
                    { 483, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 3.", "Ruby", "default.jpg", true, "Vòng tay Ruby mẫu 03", 5300000m, 10 },
                    { 484, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 4.", "Ruby", "default.jpg", true, "Vòng tay Ruby mẫu 04", 5400000m, 10 },
                    { 485, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 5.", "Ruby", "default.jpg", true, "Vòng tay Ruby mẫu 05", 5500000m, 10 },
                    { 486, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 6.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 06", 5600000m, 10 },
                    { 487, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 7.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 07", 5700000m, 10 },
                    { 488, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 8.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 08", 5800000m, 10 },
                    { 489, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 9.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 09", 5900000m, 10 },
                    { 490, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 10.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 10", 6000000m, 10 },
                    { 491, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 11.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 11", 6100000m, 10 },
                    { 492, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 12.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 12", 6200000m, 10 },
                    { 493, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 13.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 13", 6300000m, 10 },
                    { 494, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 14.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 14", 6400000m, 10 },
                    { 495, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 15.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 15", 6500000m, 10 },
                    { 496, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 16.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 16", 6600000m, 10 },
                    { 497, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 17.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 17", 6700000m, 10 },
                    { 498, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 18.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 18", 6800000m, 10 },
                    { 499, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 19.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 19", 6900000m, 10 },
                    { 500, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 20.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 20", 7000000m, 10 },
                    { 501, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 21.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 21", 7100000m, 10 },
                    { 502, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 22.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 22", 7200000m, 10 },
                    { 503, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 23.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 23", 7300000m, 10 },
                    { 504, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 24.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 24", 7400000m, 10 },
                    { 505, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 25.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 25", 7500000m, 10 },
                    { 506, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 26.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 26", 7600000m, 10 },
                    { 507, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 27.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 27", 7700000m, 10 },
                    { 508, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 28.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 28", 7800000m, 10 },
                    { 509, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 29.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 29", 7900000m, 10 },
                    { 510, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Ruby tinh xảo, mẫu số 30.", "Ruby", "default.jpg", false, "Vòng tay Ruby mẫu 30", 8000000m, 10 },
                    { 511, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 1.", "Ruby", "default.jpg", true, "Ngọc bội Ruby mẫu 01", 5100000m, 10 },
                    { 512, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 2.", "Ruby", "default.jpg", true, "Ngọc bội Ruby mẫu 02", 5200000m, 10 },
                    { 513, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 3.", "Ruby", "default.jpg", true, "Ngọc bội Ruby mẫu 03", 5300000m, 10 },
                    { 514, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 4.", "Ruby", "default.jpg", true, "Ngọc bội Ruby mẫu 04", 5400000m, 10 },
                    { 515, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 5.", "Ruby", "default.jpg", true, "Ngọc bội Ruby mẫu 05", 5500000m, 10 },
                    { 516, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 6.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 06", 5600000m, 10 },
                    { 517, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 7.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 07", 5700000m, 10 },
                    { 518, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 8.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 08", 5800000m, 10 },
                    { 519, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 9.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 09", 5900000m, 10 },
                    { 520, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 10.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 10", 6000000m, 10 },
                    { 521, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 11.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 11", 6100000m, 10 },
                    { 522, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 12.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 12", 6200000m, 10 },
                    { 523, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 13.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 13", 6300000m, 10 },
                    { 524, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 14.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 14", 6400000m, 10 },
                    { 525, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 15.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 15", 6500000m, 10 },
                    { 526, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 16.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 16", 6600000m, 10 },
                    { 527, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 17.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 17", 6700000m, 10 },
                    { 528, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 18.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 18", 6800000m, 10 },
                    { 529, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 19.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 19", 6900000m, 10 },
                    { 530, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 20.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 20", 7000000m, 10 },
                    { 531, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 21.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 21", 7100000m, 10 },
                    { 532, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 22.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 22", 7200000m, 10 },
                    { 533, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 23.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 23", 7300000m, 10 },
                    { 534, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 24.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 24", 7400000m, 10 },
                    { 535, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 25.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 25", 7500000m, 10 },
                    { 536, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 26.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 26", 7600000m, 10 },
                    { 537, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 27.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 27", 7700000m, 10 },
                    { 538, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 28.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 28", 7800000m, 10 },
                    { 539, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 29.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 29", 7900000m, 10 },
                    { 540, 3, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Ruby tinh xảo, mẫu số 30.", "Ruby", "default.jpg", false, "Ngọc bội Ruby mẫu 30", 8000000m, 10 },
                    { 541, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 1.", "Lam Ngọc", "default.jpg", true, "Nhẫn Lam Ngọc mẫu 01", 5100000m, 10 },
                    { 542, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 2.", "Lam Ngọc", "default.jpg", true, "Nhẫn Lam Ngọc mẫu 02", 5200000m, 10 },
                    { 543, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 3.", "Lam Ngọc", "default.jpg", true, "Nhẫn Lam Ngọc mẫu 03", 5300000m, 10 },
                    { 544, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 4.", "Lam Ngọc", "default.jpg", true, "Nhẫn Lam Ngọc mẫu 04", 5400000m, 10 },
                    { 545, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 5.", "Lam Ngọc", "default.jpg", true, "Nhẫn Lam Ngọc mẫu 05", 5500000m, 10 },
                    { 546, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 6.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 06", 5600000m, 10 },
                    { 547, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 7.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 07", 5700000m, 10 },
                    { 548, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 8.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 08", 5800000m, 10 },
                    { 549, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 9.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 09", 5900000m, 10 },
                    { 550, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 10.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 10", 6000000m, 10 },
                    { 551, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 11.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 11", 6100000m, 10 },
                    { 552, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 12.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 12", 6200000m, 10 },
                    { 553, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 13.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 13", 6300000m, 10 },
                    { 554, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 14.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 14", 6400000m, 10 },
                    { 555, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 15.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 15", 6500000m, 10 },
                    { 556, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 16.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 16", 6600000m, 10 },
                    { 557, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 17.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 17", 6700000m, 10 },
                    { 558, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 18.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 18", 6800000m, 10 },
                    { 559, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 19.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 19", 6900000m, 10 },
                    { 560, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 20.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 20", 7000000m, 10 },
                    { 561, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 21.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 21", 7100000m, 10 },
                    { 562, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 22.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 22", 7200000m, 10 },
                    { 563, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 23.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 23", 7300000m, 10 },
                    { 564, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 24.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 24", 7400000m, 10 },
                    { 565, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 25.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 25", 7500000m, 10 },
                    { 566, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 26.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 26", 7600000m, 10 },
                    { 567, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 27.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 27", 7700000m, 10 },
                    { 568, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 28.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 28", 7800000m, 10 },
                    { 569, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 29.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 29", 7900000m, 10 },
                    { 570, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Lam Ngọc tinh xảo, mẫu số 30.", "Lam Ngọc", "default.jpg", false, "Nhẫn Lam Ngọc mẫu 30", 8000000m, 10 },
                    { 571, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 1.", "Lam Ngọc", "default.jpg", true, "Mặt dây chuyền Lam Ngọc mẫu 01", 5100000m, 10 },
                    { 572, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 2.", "Lam Ngọc", "default.jpg", true, "Mặt dây chuyền Lam Ngọc mẫu 02", 5200000m, 10 },
                    { 573, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 3.", "Lam Ngọc", "default.jpg", true, "Mặt dây chuyền Lam Ngọc mẫu 03", 5300000m, 10 },
                    { 574, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 4.", "Lam Ngọc", "default.jpg", true, "Mặt dây chuyền Lam Ngọc mẫu 04", 5400000m, 10 },
                    { 575, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 5.", "Lam Ngọc", "default.jpg", true, "Mặt dây chuyền Lam Ngọc mẫu 05", 5500000m, 10 },
                    { 576, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 6.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 06", 5600000m, 10 },
                    { 577, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 7.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 07", 5700000m, 10 },
                    { 578, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 8.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 08", 5800000m, 10 },
                    { 579, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 9.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 09", 5900000m, 10 },
                    { 580, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 10.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 10", 6000000m, 10 },
                    { 581, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 11.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 11", 6100000m, 10 },
                    { 582, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 12.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 12", 6200000m, 10 },
                    { 583, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 13.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 13", 6300000m, 10 },
                    { 584, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 14.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 14", 6400000m, 10 },
                    { 585, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 15.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 15", 6500000m, 10 },
                    { 586, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 16.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 16", 6600000m, 10 },
                    { 587, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 17.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 17", 6700000m, 10 },
                    { 588, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 18.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 18", 6800000m, 10 },
                    { 589, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 19.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 19", 6900000m, 10 },
                    { 590, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 20.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 20", 7000000m, 10 },
                    { 591, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 21.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 21", 7100000m, 10 },
                    { 592, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 22.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 22", 7200000m, 10 },
                    { 593, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 23.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 23", 7300000m, 10 },
                    { 594, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 24.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 24", 7400000m, 10 },
                    { 595, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 25.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 25", 7500000m, 10 },
                    { 596, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 26.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 26", 7600000m, 10 },
                    { 597, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 27.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 27", 7700000m, 10 },
                    { 598, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 28.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 28", 7800000m, 10 },
                    { 599, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 29.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 29", 7900000m, 10 },
                    { 600, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Lam Ngọc tinh xảo, mẫu số 30.", "Lam Ngọc", "default.jpg", false, "Mặt dây chuyền Lam Ngọc mẫu 30", 8000000m, 10 },
                    { 601, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 1.", "Lam Ngọc", "default.jpg", true, "Chuỗi Lam Ngọc mẫu 01", 5100000m, 10 },
                    { 602, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 2.", "Lam Ngọc", "default.jpg", true, "Chuỗi Lam Ngọc mẫu 02", 5200000m, 10 },
                    { 603, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 3.", "Lam Ngọc", "default.jpg", true, "Chuỗi Lam Ngọc mẫu 03", 5300000m, 10 },
                    { 604, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 4.", "Lam Ngọc", "default.jpg", true, "Chuỗi Lam Ngọc mẫu 04", 5400000m, 10 },
                    { 605, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 5.", "Lam Ngọc", "default.jpg", true, "Chuỗi Lam Ngọc mẫu 05", 5500000m, 10 },
                    { 606, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 6.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 06", 5600000m, 10 },
                    { 607, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 7.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 07", 5700000m, 10 },
                    { 608, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 8.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 08", 5800000m, 10 },
                    { 609, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 9.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 09", 5900000m, 10 },
                    { 610, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 10.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 10", 6000000m, 10 },
                    { 611, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 11.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 11", 6100000m, 10 },
                    { 612, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 12.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 12", 6200000m, 10 },
                    { 613, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 13.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 13", 6300000m, 10 },
                    { 614, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 14.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 14", 6400000m, 10 },
                    { 615, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 15.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 15", 6500000m, 10 },
                    { 616, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 16.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 16", 6600000m, 10 },
                    { 617, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 17.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 17", 6700000m, 10 },
                    { 618, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 18.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 18", 6800000m, 10 },
                    { 619, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 19.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 19", 6900000m, 10 },
                    { 620, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 20.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 20", 7000000m, 10 },
                    { 621, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 21.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 21", 7100000m, 10 },
                    { 622, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 22.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 22", 7200000m, 10 },
                    { 623, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 23.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 23", 7300000m, 10 },
                    { 624, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 24.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 24", 7400000m, 10 },
                    { 625, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 25.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 25", 7500000m, 10 },
                    { 626, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 26.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 26", 7600000m, 10 },
                    { 627, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 27.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 27", 7700000m, 10 },
                    { 628, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 28.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 28", 7800000m, 10 },
                    { 629, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 29.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 29", 7900000m, 10 },
                    { 630, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Lam Ngọc tinh xảo, mẫu số 30.", "Lam Ngọc", "default.jpg", false, "Chuỗi Lam Ngọc mẫu 30", 8000000m, 10 },
                    { 631, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 1.", "Lam Ngọc", "default.jpg", true, "Bông tai Lam Ngọc mẫu 01", 5100000m, 10 },
                    { 632, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 2.", "Lam Ngọc", "default.jpg", true, "Bông tai Lam Ngọc mẫu 02", 5200000m, 10 },
                    { 633, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 3.", "Lam Ngọc", "default.jpg", true, "Bông tai Lam Ngọc mẫu 03", 5300000m, 10 },
                    { 634, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 4.", "Lam Ngọc", "default.jpg", true, "Bông tai Lam Ngọc mẫu 04", 5400000m, 10 },
                    { 635, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 5.", "Lam Ngọc", "default.jpg", true, "Bông tai Lam Ngọc mẫu 05", 5500000m, 10 },
                    { 636, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 6.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 06", 5600000m, 10 },
                    { 637, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 7.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 07", 5700000m, 10 },
                    { 638, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 8.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 08", 5800000m, 10 },
                    { 639, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 9.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 09", 5900000m, 10 },
                    { 640, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 10.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 10", 6000000m, 10 },
                    { 641, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 11.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 11", 6100000m, 10 },
                    { 642, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 12.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 12", 6200000m, 10 },
                    { 643, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 13.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 13", 6300000m, 10 },
                    { 644, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 14.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 14", 6400000m, 10 },
                    { 645, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 15.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 15", 6500000m, 10 },
                    { 646, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 16.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 16", 6600000m, 10 },
                    { 647, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 17.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 17", 6700000m, 10 },
                    { 648, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 18.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 18", 6800000m, 10 },
                    { 649, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 19.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 19", 6900000m, 10 },
                    { 650, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 20.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 20", 7000000m, 10 },
                    { 651, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 21.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 21", 7100000m, 10 },
                    { 652, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 22.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 22", 7200000m, 10 },
                    { 653, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 23.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 23", 7300000m, 10 },
                    { 654, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 24.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 24", 7400000m, 10 },
                    { 655, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 25.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 25", 7500000m, 10 },
                    { 656, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 26.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 26", 7600000m, 10 },
                    { 657, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 27.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 27", 7700000m, 10 },
                    { 658, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 28.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 28", 7800000m, 10 },
                    { 659, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 29.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 29", 7900000m, 10 },
                    { 660, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Lam Ngọc tinh xảo, mẫu số 30.", "Lam Ngọc", "default.jpg", false, "Bông tai Lam Ngọc mẫu 30", 8000000m, 10 },
                    { 661, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 1.", "Lam Ngọc", "default.jpg", true, "Vòng tay Lam Ngọc mẫu 01", 5100000m, 10 },
                    { 662, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 2.", "Lam Ngọc", "default.jpg", true, "Vòng tay Lam Ngọc mẫu 02", 5200000m, 10 },
                    { 663, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 3.", "Lam Ngọc", "default.jpg", true, "Vòng tay Lam Ngọc mẫu 03", 5300000m, 10 },
                    { 664, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 4.", "Lam Ngọc", "default.jpg", true, "Vòng tay Lam Ngọc mẫu 04", 5400000m, 10 },
                    { 665, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 5.", "Lam Ngọc", "default.jpg", true, "Vòng tay Lam Ngọc mẫu 05", 5500000m, 10 },
                    { 666, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 6.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 06", 5600000m, 10 },
                    { 667, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 7.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 07", 5700000m, 10 },
                    { 668, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 8.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 08", 5800000m, 10 },
                    { 669, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 9.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 09", 5900000m, 10 },
                    { 670, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 10.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 10", 6000000m, 10 },
                    { 671, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 11.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 11", 6100000m, 10 },
                    { 672, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 12.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 12", 6200000m, 10 },
                    { 673, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 13.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 13", 6300000m, 10 },
                    { 674, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 14.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 14", 6400000m, 10 },
                    { 675, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 15.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 15", 6500000m, 10 },
                    { 676, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 16.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 16", 6600000m, 10 },
                    { 677, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 17.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 17", 6700000m, 10 },
                    { 678, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 18.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 18", 6800000m, 10 },
                    { 679, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 19.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 19", 6900000m, 10 },
                    { 680, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 20.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 20", 7000000m, 10 },
                    { 681, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 21.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 21", 7100000m, 10 },
                    { 682, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 22.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 22", 7200000m, 10 },
                    { 683, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 23.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 23", 7300000m, 10 },
                    { 684, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 24.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 24", 7400000m, 10 },
                    { 685, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 25.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 25", 7500000m, 10 },
                    { 686, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 26.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 26", 7600000m, 10 },
                    { 687, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 27.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 27", 7700000m, 10 },
                    { 688, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 28.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 28", 7800000m, 10 },
                    { 689, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 29.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 29", 7900000m, 10 },
                    { 690, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Lam Ngọc tinh xảo, mẫu số 30.", "Lam Ngọc", "default.jpg", false, "Vòng tay Lam Ngọc mẫu 30", 8000000m, 10 },
                    { 691, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 1.", "Lam Ngọc", "default.jpg", true, "Ngọc bội Lam Ngọc mẫu 01", 5100000m, 10 },
                    { 692, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 2.", "Lam Ngọc", "default.jpg", true, "Ngọc bội Lam Ngọc mẫu 02", 5200000m, 10 },
                    { 693, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 3.", "Lam Ngọc", "default.jpg", true, "Ngọc bội Lam Ngọc mẫu 03", 5300000m, 10 },
                    { 694, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 4.", "Lam Ngọc", "default.jpg", true, "Ngọc bội Lam Ngọc mẫu 04", 5400000m, 10 },
                    { 695, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 5.", "Lam Ngọc", "default.jpg", true, "Ngọc bội Lam Ngọc mẫu 05", 5500000m, 10 },
                    { 696, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 6.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 06", 5600000m, 10 },
                    { 697, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 7.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 07", 5700000m, 10 },
                    { 698, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 8.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 08", 5800000m, 10 },
                    { 699, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 9.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 09", 5900000m, 10 },
                    { 700, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 10.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 10", 6000000m, 10 },
                    { 701, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 11.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 11", 6100000m, 10 },
                    { 702, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 12.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 12", 6200000m, 10 },
                    { 703, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 13.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 13", 6300000m, 10 },
                    { 704, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 14.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 14", 6400000m, 10 },
                    { 705, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 15.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 15", 6500000m, 10 },
                    { 706, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 16.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 16", 6600000m, 10 },
                    { 707, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 17.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 17", 6700000m, 10 },
                    { 708, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 18.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 18", 6800000m, 10 },
                    { 709, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 19.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 19", 6900000m, 10 },
                    { 710, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 20.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 20", 7000000m, 10 },
                    { 711, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 21.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 21", 7100000m, 10 },
                    { 712, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 22.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 22", 7200000m, 10 },
                    { 713, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 23.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 23", 7300000m, 10 },
                    { 714, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 24.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 24", 7400000m, 10 },
                    { 715, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 25.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 25", 7500000m, 10 },
                    { 716, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 26.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 26", 7600000m, 10 },
                    { 717, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 27.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 27", 7700000m, 10 },
                    { 718, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 28.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 28", 7800000m, 10 },
                    { 719, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 29.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 29", 7900000m, 10 },
                    { 720, 4, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Lam Ngọc tinh xảo, mẫu số 30.", "Lam Ngọc", "default.jpg", false, "Ngọc bội Lam Ngọc mẫu 30", 8000000m, 10 },
                    { 721, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 1.", "Băng Chủng", "default.jpg", true, "Nhẫn Băng Chủng mẫu 01", 5100000m, 10 },
                    { 722, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 2.", "Băng Chủng", "default.jpg", true, "Nhẫn Băng Chủng mẫu 02", 5200000m, 10 },
                    { 723, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 3.", "Băng Chủng", "default.jpg", true, "Nhẫn Băng Chủng mẫu 03", 5300000m, 10 },
                    { 724, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 4.", "Băng Chủng", "default.jpg", true, "Nhẫn Băng Chủng mẫu 04", 5400000m, 10 },
                    { 725, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 5.", "Băng Chủng", "default.jpg", true, "Nhẫn Băng Chủng mẫu 05", 5500000m, 10 },
                    { 726, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 6.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 06", 5600000m, 10 },
                    { 727, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 7.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 07", 5700000m, 10 },
                    { 728, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 8.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 08", 5800000m, 10 },
                    { 729, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 9.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 09", 5900000m, 10 },
                    { 730, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 10.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 10", 6000000m, 10 },
                    { 731, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 11.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 11", 6100000m, 10 },
                    { 732, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 12.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 12", 6200000m, 10 },
                    { 733, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 13.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 13", 6300000m, 10 },
                    { 734, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 14.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 14", 6400000m, 10 },
                    { 735, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 15.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 15", 6500000m, 10 },
                    { 736, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 16.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 16", 6600000m, 10 },
                    { 737, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 17.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 17", 6700000m, 10 },
                    { 738, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 18.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 18", 6800000m, 10 },
                    { 739, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 19.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 19", 6900000m, 10 },
                    { 740, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 20.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 20", 7000000m, 10 },
                    { 741, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 21.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 21", 7100000m, 10 },
                    { 742, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 22.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 22", 7200000m, 10 },
                    { 743, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 23.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 23", 7300000m, 10 },
                    { 744, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 24.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 24", 7400000m, 10 },
                    { 745, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 25.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 25", 7500000m, 10 },
                    { 746, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 26.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 26", 7600000m, 10 },
                    { 747, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 27.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 27", 7700000m, 10 },
                    { 748, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 28.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 28", 7800000m, 10 },
                    { 749, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 29.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 29", 7900000m, 10 },
                    { 750, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Nhẫn chế tác từ Băng Chủng tinh xảo, mẫu số 30.", "Băng Chủng", "default.jpg", false, "Nhẫn Băng Chủng mẫu 30", 8000000m, 10 },
                    { 751, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 1.", "Băng Chủng", "default.jpg", true, "Mặt dây chuyền Băng Chủng mẫu 01", 5100000m, 10 },
                    { 752, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 2.", "Băng Chủng", "default.jpg", true, "Mặt dây chuyền Băng Chủng mẫu 02", 5200000m, 10 },
                    { 753, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 3.", "Băng Chủng", "default.jpg", true, "Mặt dây chuyền Băng Chủng mẫu 03", 5300000m, 10 },
                    { 754, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 4.", "Băng Chủng", "default.jpg", true, "Mặt dây chuyền Băng Chủng mẫu 04", 5400000m, 10 },
                    { 755, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 5.", "Băng Chủng", "default.jpg", true, "Mặt dây chuyền Băng Chủng mẫu 05", 5500000m, 10 },
                    { 756, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 6.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 06", 5600000m, 10 },
                    { 757, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 7.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 07", 5700000m, 10 },
                    { 758, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 8.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 08", 5800000m, 10 },
                    { 759, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 9.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 09", 5900000m, 10 },
                    { 760, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 10.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 10", 6000000m, 10 },
                    { 761, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 11.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 11", 6100000m, 10 },
                    { 762, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 12.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 12", 6200000m, 10 },
                    { 763, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 13.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 13", 6300000m, 10 },
                    { 764, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 14.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 14", 6400000m, 10 },
                    { 765, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 15.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 15", 6500000m, 10 },
                    { 766, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 16.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 16", 6600000m, 10 },
                    { 767, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 17.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 17", 6700000m, 10 },
                    { 768, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 18.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 18", 6800000m, 10 },
                    { 769, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 19.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 19", 6900000m, 10 },
                    { 770, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 20.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 20", 7000000m, 10 },
                    { 771, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 21.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 21", 7100000m, 10 },
                    { 772, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 22.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 22", 7200000m, 10 },
                    { 773, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 23.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 23", 7300000m, 10 },
                    { 774, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 24.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 24", 7400000m, 10 },
                    { 775, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 25.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 25", 7500000m, 10 },
                    { 776, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 26.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 26", 7600000m, 10 },
                    { 777, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 27.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 27", 7700000m, 10 },
                    { 778, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 28.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 28", 7800000m, 10 },
                    { 779, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 29.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 29", 7900000m, 10 },
                    { 780, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Mặt dây chuyền chế tác từ Băng Chủng tinh xảo, mẫu số 30.", "Băng Chủng", "default.jpg", false, "Mặt dây chuyền Băng Chủng mẫu 30", 8000000m, 10 },
                    { 781, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 1.", "Băng Chủng", "default.jpg", true, "Chuỗi Băng Chủng mẫu 01", 5100000m, 10 },
                    { 782, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 2.", "Băng Chủng", "default.jpg", true, "Chuỗi Băng Chủng mẫu 02", 5200000m, 10 },
                    { 783, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 3.", "Băng Chủng", "default.jpg", true, "Chuỗi Băng Chủng mẫu 03", 5300000m, 10 },
                    { 784, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 4.", "Băng Chủng", "default.jpg", true, "Chuỗi Băng Chủng mẫu 04", 5400000m, 10 },
                    { 785, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 5.", "Băng Chủng", "default.jpg", true, "Chuỗi Băng Chủng mẫu 05", 5500000m, 10 },
                    { 786, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 6.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 06", 5600000m, 10 },
                    { 787, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 7.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 07", 5700000m, 10 },
                    { 788, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 8.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 08", 5800000m, 10 },
                    { 789, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 9.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 09", 5900000m, 10 },
                    { 790, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 10.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 10", 6000000m, 10 },
                    { 791, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 11.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 11", 6100000m, 10 },
                    { 792, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 12.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 12", 6200000m, 10 },
                    { 793, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 13.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 13", 6300000m, 10 },
                    { 794, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 14.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 14", 6400000m, 10 },
                    { 795, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 15.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 15", 6500000m, 10 },
                    { 796, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 16.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 16", 6600000m, 10 },
                    { 797, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 17.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 17", 6700000m, 10 },
                    { 798, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 18.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 18", 6800000m, 10 },
                    { 799, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 19.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 19", 6900000m, 10 },
                    { 800, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 20.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 20", 7000000m, 10 },
                    { 801, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 21.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 21", 7100000m, 10 },
                    { 802, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 22.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 22", 7200000m, 10 },
                    { 803, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 23.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 23", 7300000m, 10 },
                    { 804, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 24.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 24", 7400000m, 10 },
                    { 805, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 25.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 25", 7500000m, 10 },
                    { 806, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 26.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 26", 7600000m, 10 },
                    { 807, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 27.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 27", 7700000m, 10 },
                    { 808, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 28.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 28", 7800000m, 10 },
                    { 809, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 29.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 29", 7900000m, 10 },
                    { 810, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Chuỗi chế tác từ Băng Chủng tinh xảo, mẫu số 30.", "Băng Chủng", "default.jpg", false, "Chuỗi Băng Chủng mẫu 30", 8000000m, 10 },
                    { 811, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 1.", "Băng Chủng", "default.jpg", true, "Bông tai Băng Chủng mẫu 01", 5100000m, 10 },
                    { 812, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 2.", "Băng Chủng", "default.jpg", true, "Bông tai Băng Chủng mẫu 02", 5200000m, 10 },
                    { 813, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 3.", "Băng Chủng", "default.jpg", true, "Bông tai Băng Chủng mẫu 03", 5300000m, 10 },
                    { 814, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 4.", "Băng Chủng", "default.jpg", true, "Bông tai Băng Chủng mẫu 04", 5400000m, 10 },
                    { 815, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 5.", "Băng Chủng", "default.jpg", true, "Bông tai Băng Chủng mẫu 05", 5500000m, 10 },
                    { 816, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 6.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 06", 5600000m, 10 },
                    { 817, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 7.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 07", 5700000m, 10 },
                    { 818, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 8.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 08", 5800000m, 10 },
                    { 819, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 9.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 09", 5900000m, 10 },
                    { 820, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 10.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 10", 6000000m, 10 },
                    { 821, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 11.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 11", 6100000m, 10 },
                    { 822, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 12.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 12", 6200000m, 10 },
                    { 823, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 13.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 13", 6300000m, 10 },
                    { 824, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 14.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 14", 6400000m, 10 },
                    { 825, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 15.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 15", 6500000m, 10 },
                    { 826, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 16.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 16", 6600000m, 10 },
                    { 827, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 17.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 17", 6700000m, 10 },
                    { 828, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 18.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 18", 6800000m, 10 },
                    { 829, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 19.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 19", 6900000m, 10 },
                    { 830, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 20.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 20", 7000000m, 10 },
                    { 831, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 21.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 21", 7100000m, 10 },
                    { 832, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 22.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 22", 7200000m, 10 },
                    { 833, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 23.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 23", 7300000m, 10 },
                    { 834, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 24.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 24", 7400000m, 10 },
                    { 835, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 25.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 25", 7500000m, 10 },
                    { 836, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 26.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 26", 7600000m, 10 },
                    { 837, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 27.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 27", 7700000m, 10 },
                    { 838, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 28.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 28", 7800000m, 10 },
                    { 839, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 29.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 29", 7900000m, 10 },
                    { 840, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Bông tai chế tác từ Băng Chủng tinh xảo, mẫu số 30.", "Băng Chủng", "default.jpg", false, "Bông tai Băng Chủng mẫu 30", 8000000m, 10 },
                    { 841, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 1.", "Băng Chủng", "default.jpg", true, "Vòng tay Băng Chủng mẫu 01", 5100000m, 10 },
                    { 842, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 2.", "Băng Chủng", "default.jpg", true, "Vòng tay Băng Chủng mẫu 02", 5200000m, 10 },
                    { 843, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 3.", "Băng Chủng", "default.jpg", true, "Vòng tay Băng Chủng mẫu 03", 5300000m, 10 },
                    { 844, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 4.", "Băng Chủng", "default.jpg", true, "Vòng tay Băng Chủng mẫu 04", 5400000m, 10 },
                    { 845, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 5.", "Băng Chủng", "default.jpg", true, "Vòng tay Băng Chủng mẫu 05", 5500000m, 10 },
                    { 846, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 6.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 06", 5600000m, 10 },
                    { 847, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 7.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 07", 5700000m, 10 },
                    { 848, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 8.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 08", 5800000m, 10 },
                    { 849, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 9.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 09", 5900000m, 10 },
                    { 850, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 10.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 10", 6000000m, 10 },
                    { 851, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 11.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 11", 6100000m, 10 },
                    { 852, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 12.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 12", 6200000m, 10 },
                    { 853, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 13.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 13", 6300000m, 10 },
                    { 854, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 14.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 14", 6400000m, 10 },
                    { 855, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 15.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 15", 6500000m, 10 },
                    { 856, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 16.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 16", 6600000m, 10 },
                    { 857, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 17.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 17", 6700000m, 10 },
                    { 858, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 18.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 18", 6800000m, 10 },
                    { 859, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 19.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 19", 6900000m, 10 },
                    { 860, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 20.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 20", 7000000m, 10 },
                    { 861, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 21.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 21", 7100000m, 10 },
                    { 862, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 22.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 22", 7200000m, 10 },
                    { 863, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 23.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 23", 7300000m, 10 },
                    { 864, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 24.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 24", 7400000m, 10 },
                    { 865, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 25.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 25", 7500000m, 10 },
                    { 866, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 26.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 26", 7600000m, 10 },
                    { 867, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 27.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 27", 7700000m, 10 },
                    { 868, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 28.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 28", 7800000m, 10 },
                    { 869, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 29.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 29", 7900000m, 10 },
                    { 870, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Vòng tay chế tác từ Băng Chủng tinh xảo, mẫu số 30.", "Băng Chủng", "default.jpg", false, "Vòng tay Băng Chủng mẫu 30", 8000000m, 10 },
                    { 871, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 1.", "Băng Chủng", "default.jpg", true, "Ngọc bội Băng Chủng mẫu 01", 5100000m, 10 },
                    { 872, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 2.", "Băng Chủng", "default.jpg", true, "Ngọc bội Băng Chủng mẫu 02", 5200000m, 10 },
                    { 873, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 3.", "Băng Chủng", "default.jpg", true, "Ngọc bội Băng Chủng mẫu 03", 5300000m, 10 },
                    { 874, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 4.", "Băng Chủng", "default.jpg", true, "Ngọc bội Băng Chủng mẫu 04", 5400000m, 10 },
                    { 875, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 5.", "Băng Chủng", "default.jpg", true, "Ngọc bội Băng Chủng mẫu 05", 5500000m, 10 },
                    { 876, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 6.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 06", 5600000m, 10 },
                    { 877, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 7.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 07", 5700000m, 10 },
                    { 878, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 8.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 08", 5800000m, 10 },
                    { 879, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 9.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 09", 5900000m, 10 },
                    { 880, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 10.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 10", 6000000m, 10 },
                    { 881, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 11.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 11", 6100000m, 10 },
                    { 882, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 12.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 12", 6200000m, 10 },
                    { 883, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 13.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 13", 6300000m, 10 },
                    { 884, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 14.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 14", 6400000m, 10 },
                    { 885, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 15.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 15", 6500000m, 10 },
                    { 886, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 16.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 16", 6600000m, 10 },
                    { 887, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 17.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 17", 6700000m, 10 },
                    { 888, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 18.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 18", 6800000m, 10 },
                    { 889, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 19.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 19", 6900000m, 10 },
                    { 890, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 20.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 20", 7000000m, 10 },
                    { 891, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 21.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 21", 7100000m, 10 },
                    { 892, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 22.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 22", 7200000m, 10 },
                    { 893, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 23.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 23", 7300000m, 10 },
                    { 894, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 24.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 24", 7400000m, 10 },
                    { 895, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 25.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 25", 7500000m, 10 },
                    { 896, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 26.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 26", 7600000m, 10 },
                    { 897, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 27.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 27", 7700000m, 10 },
                    { 898, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 28.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 28", 7800000m, 10 },
                    { 899, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 29.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 29", 7900000m, 10 },
                    { 900, 5, "cert.jpg", "Tự nhiên", "Sản phẩm Ngọc bội chế tác từ Băng Chủng tinh xảo, mẫu số 30.", "Băng Chủng", "default.jpg", false, "Ngọc bội Băng Chủng mẫu 30", 8000000m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
