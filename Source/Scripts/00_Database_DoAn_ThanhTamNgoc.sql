-- ĐỒ ÁN: HỆ THỐNG QUẢN LÝ VÀ PHÂN PHỐI TRANG SỨC THANH TÂM NGỌC
-- NGƯỜI THỰC HIỆN: HUỲNH BÍCH TRÂN

-- 1. TẠO CƠ SỞ DỮ LIỆU
CREATE DATABASE ThanhTamNgocDb;
GO

USE ThanhTamNgocDb;
GO

-- 2. TẠO BẢNG TÀI KHOẢN (KHÁCH HÀNG & ADMIN)
CREATE TABLE Users (
    Email VARCHAR(100) PRIMARY KEY,
    Password VARCHAR(255) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Phone VARCHAR(15),
    Address NVARCHAR(255),
    Role VARCHAR(20) DEFAULT 'Customer' -- 'Admin' hoặc 'Customer'
);
GO

-- 3. TẠO BẢNG DANH MỤC TRANG SỨC
CREATE TABLE Categories (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);
GO

-- 4. TẠO BẢNG SẢN PHẨM (NGỌC BỘI, NHẪN, VÒNG TAY...)
CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(200) NOT NULL,
    CategoryId INT,
    Price DECIMAL(18,2) NOT NULL,
    Description NVARCHAR(MAX),
    ImageUrl VARCHAR(500),
    StockQuantity INT DEFAULT 10,
    GemType NVARCHAR(100) DEFAULT N'Ngọc Thiên Nhiên',
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);
GO

-- 5. TẠO BẢNG HÓA ĐƠN (ĐƠN HÀNG)
CREATE TABLE Orders (
    OrderId INT IDENTITY(1,1) PRIMARY KEY,
    UserEmail VARCHAR(100) NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    ShippingAddress NVARCHAR(255) NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    OrderStatus NVARCHAR(50) DEFAULT N'Đang chờ xử lý',
    FOREIGN KEY (UserEmail) REFERENCES Users(Email)
);
GO

-- 6. TẠO BẢNG CHI TIẾT ĐƠN HÀNG
CREATE TABLE OrderDetails (
    OrderDetailId INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT NOT NULL,
    ProductName NVARCHAR(200) NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId) ON DELETE CASCADE
);
GO

--THÊM DỮ LIỆU MẪU 

-- Tạo tài khoản Admin và Khách mẫu
INSERT INTO Users (Email, Password, FullName, Phone, Role) VALUES 
('admin', '123456', N'Quản Trị Viên', '0999999999', 'Admin'),
('huynhbichtran01234@gmail.com', '123456', N'Huỳnh Bích Trân', '0787994363', 'Customer');

-- Tạo danh mục
INSERT INTO Categories (CategoryName) VALUES 
(N'Nhẫn'), (N'Vòng tay'), (N'Mặt dây chuyền'), (N'Ngọc bội');

-- Tạo vài sản phẩm mẫu tượng trưng
INSERT INTO Products (ProductName, CategoryId, Price, StockQuantity, GemType, ImageUrl) VALUES
(N'Nhẫn Phỉ Thúy mẫu 01', 1, 5100000, 10, N'Phỉ Thúy', '25-nhan.jpg'),
(N'Nhẫn Phỉ Thúy mẫu 03', 1, 5300000, 8, N'Phỉ Thúy', '08-nhan.jpg'),
(N'Vòng tay Bạch Ngọc', 2, 4200000, 15, N'Bạch Ngọc', '13-vong.jpg'),
(N'Ngọc Bội Bình An', 4, 3500000, 5, N'Ngọc Bích', 'ngocboi-01.jpg');

-- Tạo 1 đơn hàng mẫu đã hoàn tất
INSERT INTO Orders (UserEmail, ShippingAddress, TotalAmount, OrderStatus) VALUES
('huynhbichtran01234@gmail.com', N'Huỳnh Bích Trân - 0787994363 - TPHCM', 5300000, N'Thành công');

INSERT INTO OrderDetails (OrderId, ProductName, Quantity, UnitPrice) VALUES
(1, N'Nhẫn Phỉ Thúy mẫu 03', 1, 5300000);
GO

--  danh mục
SELECT * FROM Categories;

--  sản phẩm
SELECT * FROM Products;

--  người dùng
SELECT * FROM Users;