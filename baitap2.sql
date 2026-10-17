CREATE DATABASE QuanLyNguoiDung;
GO

USE QuanLyNguoiDung;
GO

CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,               
    TenDangNhap NVARCHAR(20) NOT NULL UNIQUE,           
    SoDienThoai VARCHAR(10) NOT NULL,                   
    Email NVARCHAR(100) NULL,                           
    MatKhauBam NVARCHAR(64) NOT NULL,                   
    Salt NVARCHAR(32) NOT NULL,                         
    NgayTao DATETIME2 NOT NULL DEFAULT SYSDATETIME(),   
    LanDangNhapCuoi DATETIME2 NULL                      
);
GO

INSERT INTO Users (TenDangNhap, SoDienThoai, Email, MatKhauBam, Salt)
VALUES (N'nguyenhaha', '0901234567', N'123@gmail.com', N'samplehashvalue123456', N'samplesalt123');

SELECT * FROM Users;
GO