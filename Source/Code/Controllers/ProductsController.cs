using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
//Giao dieN QUẢN LÝ SẢN PHẨM (Lấy danh sách, Lọc tìm kiếm, Thêm_Admin, Sửa_Admin, Xóa_admin).
namespace ThanhTamNgoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly string _connectionString;

        public ProductsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        // LẤY DANH SÁCH VÀ LỌC SẢN PHẨM
        // 1. Mục đích: Truy xuất danh sách sản phẩm hiển thị lên trang chủ. Hỗ trợ tìm kiếm theo tên và lọc theo danh mục, khoảng giá.
        // 2. Kỹ thuật SQL áp dụng (Truy vấn động - Dynamic SQL):
        //    - Khởi tạo câu truy vấn cơ sở với điều kiện 'WHERE 1=1' (Mẹo kỹ thuật: Giúp dễ dàng nối chuỗi các điều kiện AND phía sau mà không bị lỗi cú pháp SQL).
        //    - Sử dụng các câu lệnh 'if' trong C# để nối thêm điều kiện lọc vào chuỗi SQL chỉ khi Client có truyền tham số tương ứng (HasValue hoặc NotNullOrEmpty).
        // 3. Kỹ thuật Bảo mật:
        //    - Mặc dù sử dụng kỹ thuật nối chuỗi SQL, nhưng các giá trị thực tế vẫn được truyền gián tiếp qua Parameters (AddWithValue) kết hợp toán tử '%'
        //    cho mệnh đề LIKE, đảm bảo hệ thống hoàn toàn miễn nhiễm với lỗi SQL Injection.
        [HttpGet]
        public IActionResult GetProducts([FromQuery] string search = "", [FromQuery] int? categoryId = null, [FromQuery] decimal? minPrice = null, [FromQuery] decimal? maxPrice = null)
        {
            try
            {
                List<object> products = new List<object>();

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Products WHERE 1=1";

                    if (!string.IsNullOrEmpty(search))
                    {
                        sql += " AND Name LIKE @Search";
                    }
                    if (categoryId.HasValue)
                    {
                        sql += " AND CategoryId = @CategoryId";
                    }
                    if (minPrice.HasValue)
                    {
                        sql += " AND Price >= @MinPrice";
                    }
                    if (maxPrice.HasValue)
                    {
                        sql += " AND Price <= @MaxPrice";
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (!string.IsNullOrEmpty(search))
                        {
                            command.Parameters.AddWithValue("@Search", "%" + search + "%");
                        }
                        if (categoryId.HasValue)
                        {
                            command.Parameters.AddWithValue("@CategoryId", categoryId.Value);
                        }
                        if (minPrice.HasValue)
                        {
                            command.Parameters.AddWithValue("@MinPrice", minPrice.Value);
                        }
                        if (maxPrice.HasValue)
                        {
                            command.Parameters.AddWithValue("@MaxPrice", maxPrice.Value);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new
                                {
                                    id = reader["Id"],
                                    name = reader["Name"],
                                    price = reader["Price"],
                                    imageUrl = reader["ImageUrl"] != DBNull.Value ? reader["ImageUrl"].ToString() : "",
                                    gemType = reader["GemType"] != DBNull.Value ? reader["GemType"].ToString() : "",
                                    description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : "" 
                                });
                            }
                        }
                    }
                }

                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
        //  XEM CHI TIẾT SẢN PHẨM
        // 1. Mục đích: Lấy toàn bộ thông tin chi tiết của một sản phẩm cụ thể dựa trên ID định danh để render trang chi tiết.
        // 2. Kỹ thuật SQL & ADO.NET: 
        //    - Thực thi truy vấn SELECT dựa trên điều kiện khóa chính (WHERE Id = @Id).
        //    - Sử dụng SqlDataReader để trích xuất dữ liệu và đóng gói thành định dạng JSON trả về cho Frontend.
        // 3. Kỹ thuật C# áp dụng (Xử lý an toàn dữ liệu rỗng):
        //    - Xử lý ngoại lệ dữ liệu bằng cách kết hợp kiểm tra 'DBNull.Value' và toán tử ba ngôi (Ternary operator).
        //    - Fallback cơ chế: Nếu trường Description bị bỏ trống (NULL) trong CSDL, hệ thống tự động gán chuỗi hiển thị mặc định ('Đang cập nhật mô tả...')
        //    . Kỹ thuật này bảo vệ giao diện người dùng (UI) khỏi các lỗi hiển thị chuỗi 'null' hoặc nguy cơ vỡ cấu trúc layout (Layout breaking) do thiếu hụt dữ liệu.
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Products WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var product = new
                                {
                                    id = reader["Id"],
                                    name = reader["Name"],
                                    description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : "Đang cập nhật mô tả...",
                                    price = reader["Price"],
                                    stockQuantity = reader["StockQuantity"],
                                    imageUrl = reader["ImageUrl"] != DBNull.Value ? reader["ImageUrl"].ToString() : "",
                                    gemType = reader["GemType"] != DBNull.Value ? reader["GemType"].ToString() : ""
                                };
                                return Ok(product);
                            }
                            else
                            {
                                return NotFound("Không tìm thấy sản phẩm.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Lỗi Server: " + ex.Message);
            }
        }
        //  THÊM MỚI SẢN PHẨM (DÀNH CHO ADMIN)
        // 1. Mục đích: Xử lý yêu cầu tạo mới một bản ghi sản phẩm vào cơ sở dữ liệu.
        // 2. Kỹ thuật C# áp dụng (Xử lý dữ liệu đầu vào):
        //    - Ứng dụng toán tử Null-coalescing (??) để cấp phát giá trị mặc định cho các trường dữ liệu tùy chọn.
        //    - Cơ chế: Nếu Request Body không chứa các trường như ImageUrl, GemType hoặc Description (giá trị mang NULL),
        //    mã lệnh sẽ tự động chèn các giá trị mặc định an toàn ('default.jpg', 'Ngọc tự nhiên', chuỗi rỗng) để đảm bảo tính nhất quán của bảng Products.
        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductDto req)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Products (Name, Price, StockQuantity, ImageUrl, GemType, Description) VALUES (@name, @price, @stock, @img, @gem, @desc)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", req.Name);
                        cmd.Parameters.AddWithValue("@price", req.Price);
                        cmd.Parameters.AddWithValue("@stock", req.StockQuantity);
                        cmd.Parameters.AddWithValue("@img", req.ImageUrl ?? "default.jpg");
                        cmd.Parameters.AddWithValue("@gem", req.GemType ?? "Ngọc tự nhiên");
                        cmd.Parameters.AddWithValue("@desc", req.Description ?? "");
                        cmd.ExecuteNonQuery();
                    }
                }
                return Ok(new { message = "Thêm sản phẩm thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        //  CẬP NHẬT THÔNG TIN SẢN PHẨM (DÀNH CHO ADMIN)
        // 1. Mục đích: Chỉnh sửa các tham số cơ bản của một sản phẩm (Tên, Giá, Số lượng tồn kho) thông qua định danh ID.
        // 2. Kỹ thuật thiết kế API: Tuân thủ kiến trúc RESTful bằng việc sử dụng HTTP PUT cho các thao tác tác động và thay đổi toàn vẹn một tài nguyên hiện có.
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductDto req)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Products SET Name=@name, Price=@price, StockQuantity=@stock WHERE Id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", req.Name);
                        cmd.Parameters.AddWithValue("@price", req.Price);
                        cmd.Parameters.AddWithValue("@stock", req.StockQuantity);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return Ok(new { message = "Cập nhật thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        //  XÓA SẢN PHẨM (DÀNH CHO ADMIN)
        // 1. Mục đích: Loại bỏ hoàn toàn một bản ghi sản phẩm khỏi CSDL.
        // 2. Ràng buộc toàn vẹn (Integrity Constraint): Thao tác xóa (HTTP DELETE) đòi hỏi sản phẩm này không dính dáng đến khóa ngoại
        // (Foreign Key) trong bảng OrderDetails, hoặc CSDL đã được cấu hình tính năng Xóa tầng (CASCADE DELETE) để tránh phát sinh lỗi xung đột dữ liệu.
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Products WHERE Id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return Ok(new { message = "Xóa thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }

    public class ProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string GemType { get; set; }
    }
}