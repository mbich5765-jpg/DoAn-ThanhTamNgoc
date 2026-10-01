using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
// quan tri ADMIN ( TỔNG QUAN / QUAN LY ĐH / TAI KHOAN / BIEU DO_TOP5 / TRẠNG THÁI ĐƠN HÀNG ) 
namespace ThanhTamNgoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly string _connectionString;

        public AdminController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        // THỐNG KÊ TỔNG QUAN (DASHBOARD)
        // 1. Mục đích: 
        //    - Truy xuất các số liệu tổng quan (Doanh thu, Tổng đơn hàng, Tổng người dùng, Tổng tồn kho) để hiển thị trên Dashboard của Admin.
        // 2. Kỹ thuật SQL áp dụng:
        //    - Sử dụng các hàm tập hợp (Aggregate Functions) như SUM(), COUNT().
        //    - Sử dụng hàm ISNULL() để xử lý ngoại lệ rỗng (tránh lỗi NullReference khi không có đơn hàng nào).
        // 3. Kỹ thuật C# áp dụng (Tối ưu hiệu năng):
        //    - Phương thức 'ExecuteScalar()': Chỉ trích xuất duy nhất một giá trị (dòng 1, cột 1) từ tập kết quả truy vấn.
        //    - Lý do áp dụng: Giảm thiểu tối đa chi phí cấp phát bộ nhớ (overhead) so với việc dùng ExecuteReader(), giúp API phản hồi các số liệu thống kê với tốc độ cao nhất.
        [HttpGet("dashboard")]
        public IActionResult GetDashboard()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    var cmdRev = new SqlCommand("SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders WHERE OrderStatus <> N'Đã hủy'", conn);
                    decimal totalRev = Convert.ToDecimal(cmdRev.ExecuteScalar());

                    var cmdOrd = new SqlCommand("SELECT COUNT(*) FROM Orders", conn);
                    int totalOrd = Convert.ToInt32(cmdOrd.ExecuteScalar());

                    var cmdUsr = new SqlCommand("SELECT COUNT(*) FROM Users", conn);
                    int totalUsr = Convert.ToInt32(cmdUsr.ExecuteScalar());

                    var cmdProd = new SqlCommand("SELECT ISNULL(SUM(StockQuantity), 0) FROM Products", conn);
                    int totalProd = Convert.ToInt32(cmdProd.ExecuteScalar());

                    return Ok(new { revenue = totalRev, orders = totalOrd, users = totalUsr, products = totalProd });
                }
            }
            catch (Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }
        // LẤY DANH SÁCH TẤT CẢ ĐƠN HÀNG (DÀNH CHO ADMIN)
        // 1. Mục đích: 
        //    - Truy xuất toàn bộ dữ liệu đơn hàng trong hệ thống để hiển thị lên bảng quản lý.
        // 2. Kỹ thuật SQL áp dụng (Tối ưu hóa truy vấn):
        //    - Subquery (Truy vấn con): Lấy trường FullName từ bảng Users dựa trên UserEmail.
        //    - Hàm STRING_AGG: Tự động gộp nhiều dòng sản phẩm thuộc cùng một đơn hàng trong bảng OrderDetails thành một chuỗi duy nhất ngay tại tầng CSDL.
        //    - Lý do áp dụng: Giảm thiểu số lượng truy vấn (N+1 query problem), tránh việc dùng C# lặp qua từng đơn hàng để nối chuỗi, giúp API trả về dữ liệu phẳng (flat data) nhanh chóng.
        // 3. Kỹ thuật C# áp dụng (Xử lý an toàn dữ liệu):
        //    - Toán tử Null-coalescing (??): 'reader["CustomerName"]?.ToString() ?? reader["UserEmail"].ToString()'
        //    - Lý do áp dụng: Bắt lỗi NullReferenceException trong trường hợp khách hàng chưa cập nhật FullName. Hệ thống sẽ tự động dự phòng lấy UserEmail để hiển thị thay thế,
        //    đảm bảo tính toàn vẹn dữ liệu khi parse sang JSON.
        [HttpGet("orders")]
        public IActionResult GetOrders()
        {
            try
            {
                var list = new List<object>();
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    var query = @"
                        SELECT o.OrderId, o.UserEmail, o.OrderDate, o.TotalAmount, o.OrderStatus,
                               (SELECT TOP 1 FullName FROM Users WHERE Email = o.UserEmail) as CustomerName,
                               (SELECT STRING_AGG(ProductName + ' (x' + CAST(Quantity AS VARCHAR) + ')', ', ') 
                                FROM OrderDetails WHERE OrderId = o.OrderId) as Products
                        FROM Orders o 
                        ORDER BY o.OrderDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                id = reader["OrderId"].ToString(),
                                customerName = reader["CustomerName"]?.ToString() ?? reader["UserEmail"].ToString(),
                                email = reader["UserEmail"].ToString(),
                                products = reader["Products"].ToString(),
                                total = reader["TotalAmount"],
                                status = reader["OrderStatus"].ToString(),
                                date = Convert.ToDateTime(reader["OrderDate"]).ToString("dd/MM/yyyy HH:mm")
                            });
                        }
                    }
                }
                return Ok(list);
            }
            catch (Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }
        // LẤY DANH SÁCH TÀI KHOẢN NGƯỜI DÙNG (DÀNH CHO ADMIN)
        // 1. Mục đích: 
        //    - Truy xuất danh sách thông tin cơ bản của tất cả người dùng trong hệ thống để phục vụ cho tính năng Quản lý tài khoản.
        // 2. Kỹ thuật SQL áp dụng:
        //    - Chỉ SELECT các trường thông tin hiển thị cần thiết (Id, FullName, Email, TrangThai), loại bỏ hoàn toàn các trường nhạy cảm (như PasswordHash) ra khỏi truy vấn để đảm bảo bảo mật dữ liệu ở tầng API.
        // 3. Kỹ thuật C# áp dụng (Kiểm tra và xử lý DBNull):
        //    - Đoạn xử lý: 'reader["TrangThai"] != DBNull.Value ? Convert.ToInt32(...) : 1'
        //    - Lý do áp dụng: Quản lý rủi ro dữ liệu rỗng từ CSDL. Đối với các tài khoản được tạo trước khi cột TrangThai được thêm vào, giá trị có thể là NULL. Cấu trúc toán tử ba ngôi (Ternary operator) kết hợp kiểm tra DBNull.Value giúp ngăn chặn lỗi InvalidCastException.
        //    - Nếu phát hiện NULL, hệ thống tự động gán giá trị fallback là 1 (Trạng thái bình thường/Hoạt động), giúp tiến trình đọc dữ liệu không bị ngắt quãng.
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            try
            {
                var list = new List<object>();
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, FullName, Email, TrangThai FROM Users", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                id = reader["Id"],
                                name = reader["FullName"].ToString(),
                                email = reader["Email"].ToString(),
                                trangThai = reader["TrangThai"] != DBNull.Value ? Convert.ToInt32(reader["TrangThai"]) : 1
                            });
                        }
                    }
                }
                return Ok(list);
            }
            catch (Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }
        //  DỮ LIỆU BIỂU ĐỒ & TOP 5 SẢN PHẨM BÁN CHẠY
        // 1. Mục đích: 
        //    - Cung cấp tập dữ liệu (Labels, Values) để Frontend vẽ biểu đồ doanh thu theo tháng và danh sách 5 sản phẩm có doanh số cao nhất.
        // 2. Kỹ thuật SQL áp dụng (Gom nhóm & Thống kê):
        //    - Gom nhóm (GROUP BY MONTH(OrderDate)): Xử lý gom nhóm các hóa đơn theo tháng và tính tổng tiền ngay tại tầng CSDL.
        //    - Phân loại (TOP 5 + ORDER BY ... DESC): Lọc và sắp xếp giảm dần để lấy chính xác 5 bản ghi có số lượng bán cao nhất.
        //    - Lý do áp dụng: Đẩy tải xử lý logic (tính toán, phân loại) xuống tầng Database (nơi được tối ưu cho việc này). Tầng API
        //    chỉ đóng vai trò trung chuyển dữ liệu đã làm sạch, giúp tiết kiệm triệt để tài nguyên CPU/RAM cho server.
        [HttpGet("chart-data")]
        public IActionResult GetChartData()
        {
            try
            {
                var chartLabels = new List<string>();
                var chartValues = new List<decimal>();
                var topProducts = new List<object>();

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    // 1. Gom dữ liệu vẽ Biểu đồ: Tổng doanh thu theo từng tháng
                    string queryChart = @"
                        SELECT 'Tháng ' + CAST(MONTH(OrderDate) AS VARCHAR) AS MonthLabel, 
                               SUM(TotalAmount) AS Revenue
                        FROM Orders 
                        WHERE OrderStatus <> N'Đã hủy'
                        GROUP BY MONTH(OrderDate)
                        ORDER BY MONTH(OrderDate)";

                    using (SqlCommand cmd = new SqlCommand(queryChart, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            chartLabels.Add(reader["MonthLabel"].ToString());
                            chartValues.Add(Convert.ToDecimal(reader["Revenue"]));
                        }
                    }

                    // 2. Gom dữ liệu Top 5 sản phẩm bán chạy nhất
                    string queryTop = @"
                        SELECT TOP 5 ProductName, SUM(Quantity) AS TotalSold
                        FROM OrderDetails od
                        JOIN Orders o ON od.OrderId = o.OrderId
                        WHERE o.OrderStatus <> N'Đã hủy'
                        GROUP BY ProductName
                        ORDER BY TotalSold DESC";

                    using (SqlCommand cmd = new SqlCommand(queryTop, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            topProducts.Add(new
                            {
                                name = reader["ProductName"].ToString(),
                                sold = Convert.ToInt32(reader["TotalSold"])
                            });
                        }
                    }
                }
                // Gói tất cả gửi lên web
                return Ok(new { labels = chartLabels, values = chartValues, top = topProducts });
            }
            catch (Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }

        // CẬP NHẬT TRẠNG THÁI ĐƠN HÀNG (DÀNH CHO ADMIN)
        // 1. Mục đích: 
        //    - Cập nhật tiến trình xử lý của một đơn hàng cụ thể (ví dụ: Đang chờ xử lý, Đã thanh toán, Đã giao hàng, Đã hủy) dựa vào mã OrderId.
        // 2. Kỹ thuật thiết kế API (RESTful Standard):
        //    - Sử dụng [HttpPut]: Tuân thủ chuẩn RESTful API cho thao tác cập nhật (Update) tài nguyên hiện có.
        //    - Tách biệt tham số định tuyến (Route parameter): ID đơn hàng được khai báo trực tiếp trên URL '{id}'
        //    để định danh chính xác đối tượng cần sửa, còn dữ liệu trạng thái mới được truyền kín bên trong phần Body ([FromBody]), giúp cấu trúc API rõ ràng và bảo mật.
        // 3. Kỹ thuật ADO.NET và Bảo mật dữ liệu:
        //    - Sử dụng Parameterized Query (Parameters.AddWithValue): Gán biến @status và @id thông qua tham số thay vì
        //    cộng chuỗi SQL, loại bỏ hoàn toàn nguy cơ tấn công SQL Injection.
        //    - Thực thi ExecuteNonQuery(): Chỉ định CSDL thực thi lệnh UPDATE mà không cần trả về tập kết quả (ResultSet) dư thừa,
        //    giúp tối ưu hóa hiệu suất và tiết kiệm bộ nhớ xử lý của server.
        [HttpPut("update-order-status/{id}")]
        public IActionResult UpdateOrderStatus(int id, [FromBody] StatusRequest req)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Orders SET OrderStatus = @status WHERE OrderId = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@status", req.Status);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return Ok(new { message = "Thành công" });
            }
            catch (Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }
    }

    public class StatusRequest
    {
        public string Status { get; set; }
    }
}