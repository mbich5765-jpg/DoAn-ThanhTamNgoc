using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
// thanh toan ( Thanh toán  / xem lịch sử mua hàng ) 
namespace ThanhTamNgoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly string _connectionString;

        public OrdersController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        // THANH TOÁN ĐƠN HÀNG (CHECKOUT)
        // 1. Mục đích:
        //    - Lưu thông tin tổng quan của hóa đơn (Orders) và chi tiết các sản phẩm khách đã mua (OrderDetails) vào CSDL.
        // 2. Kỹ thuật SQL và ADO.NET áp dụng:
        //    - Lệnh 'OUTPUT INSERTED.OrderId': Sử dụng để trả về ngay lập tức khóa chính (ID) của hóa đơn vừa được tạo trong bảng cha (Orders).
        //    - Xử lý quan hệ Cha-Con: Lấy OrderId vừa tạo gán vào trường khóa ngoại (OrderId) của các bản ghi chi tiết đơn hàng (bảng OrderDetails) thông qua vòng lặp, đảm bảo tính toàn vẹn tham chiếu (Referential Integrity).
        // 3. Kỹ thuật thanh toán (Mock Payment & QR Code):
        //    - Mã QR động: Tích hợp API VietQR tại Front-end để sinh mã QR thanh toán dựa trên Tổng tiền và Số tài khoản đích.
        //    - Giả lập thanh toán (Mock): Cấu trúc API được thiết kế để lưu trạng thái 'Thành công' sau khi người dùng xác nhận. Kiến trúc phần mềm đã được thiết lập sẵn sàng
        //    để tích hợp Webhook/IPN của các cổng thanh toán thực tế (như VNPay, MoMo) trong tương lai.

        [HttpPost("checkout")]
        public IActionResult Checkout([FromBody] CheckoutRequest request)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string orderQuery = @"
                        INSERT INTO Orders (UserEmail, ShippingAddress, TotalAmount, OrderStatus)
                        OUTPUT INSERTED.OrderId
                        VALUES (@Email, @Address, @TotalAmount, N'Thành công')";

                    int orderId = 0;
                    using (SqlCommand cmd = new SqlCommand(orderQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", request.Email);
                        cmd.Parameters.AddWithValue("@Address", request.Address);
                        cmd.Parameters.AddWithValue("@TotalAmount", request.TotalAmount);
                        orderId = (int)cmd.ExecuteScalar();
                    }

                    foreach (var item in request.Items)
                    {
                        string detailQuery = @"
                            INSERT INTO OrderDetails (OrderId, ProductName, Quantity, UnitPrice)
                            VALUES (@OrderId, @ProductName, @Quantity, @UnitPrice)";

                        using (SqlCommand detailCmd = new SqlCommand(detailQuery, conn))
                        {
                            detailCmd.Parameters.AddWithValue("@OrderId", orderId);
                            detailCmd.Parameters.AddWithValue("@ProductName", item.Name);
                            detailCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            detailCmd.Parameters.AddWithValue("@UnitPrice", item.Price);
                            detailCmd.ExecuteNonQuery();
                        }
                    }
                }
                return Ok(new { message = "Thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi hệ thống: " + ex.Message });
            }
        }
        //  XEM LỊCH SỬ MUA HÀNG
        // 1. Mục đích: 
        //    - Truy xuất danh sách các đơn hàng đã đặt của một khách hàng cụ thể dựa trên Email.
        // 2. Kỹ thuật SQL áp dụng (Tối ưu hóa dữ liệu trả về):
        //    - Lọc và Sắp xếp: Dùng mệnh đề WHERE để lọc theo UserEmail và ORDER BY DESC để hiển thị hóa đơn mới nhất lên đầu.
        //    - Hàm STRING_AGG kết hợp Subquery: Xử lý nối chuỗi toàn bộ tên sản phẩm và số lượng của một đơn hàng thành một dòng văn bản duy nhất ngay tại tầng CSDL.
        //    - Lý do áp dụng: Giảm tải khối lượng dữ liệu truyền qua mạng và loại bỏ việc phải dùng vòng lặp C# để gom nhóm, giúp tăng tốc độ phản hồi (Response Time) của API.


        [HttpGet("history/{email}")]
        public IActionResult GetOrderHistory(string email)
        {
            try
            {
                var orders = new List<object>();
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT o.OrderId, o.OrderDate, o.TotalAmount, o.OrderStatus,
                               (SELECT STRING_AGG(ProductName + ' (x' + CAST(Quantity AS VARCHAR(10)) + ')', ', ') 
                                FROM OrderDetails od WHERE od.OrderId = o.OrderId) AS Products
                        FROM Orders o
                        WHERE o.UserEmail = @Email
                        ORDER BY o.OrderDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orders.Add(new
                                {
                                    OrderId = reader["OrderId"].ToString(),
                                    OrderDate = Convert.ToDateTime(reader["OrderDate"]).ToString("dd/MM/yyyy HH:mm"),
                                    Products = reader["Products"].ToString(),
                                    TotalAmount = reader["TotalAmount"],
                                    Status = reader["OrderStatus"].ToString()
                                });
                            }
                        }
                    }
                }
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi hệ thống: " + ex.Message });
            }
        }
    }

    public class CheckoutRequest
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public List<CartItemDto> Items { get; set; }
    }

    public class CartItemDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}