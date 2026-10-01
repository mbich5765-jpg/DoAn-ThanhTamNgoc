CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(200) NOT NULL,
    CategoryId INT, 
    Price DECIMAL(18, 2) NOT NULL,
    Description NVARCHAR(MAX),
    ImageUrl VARCHAR(500),
    StockQuantity INT DEFAULT 0,
    GemType NVARCHAR(100), 
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);-- Cập nhật mô tả "Quốc dân" cho TOÀN BỘ sản phẩm trong cửa hàng
UPDATE Products
SET Description = N'Tuyệt tác trang sức ngọc thiên nhiên cao cấp, được chế tác thủ công vô cùng tinh xảo. Chất ngọc nguyên bản lên nước trong veo, bề mặt được đánh bóng mượt mà, rờn tay mướt mịn. Không chỉ là điểm nhấn hoàn hảo tôn vinh khí chất sang trọng và thanh lịch, mỗi tác phẩm còn là vật phẩm phong thủy mang ý nghĩa cát tường, giúp thu hút vượng khí, tài lộc và mang lại bình an trọn đời cho chủ nhân.'
GO