-- CSDL cho ứng dụng Quản lý người dùng (BaiTap2.2)
-- Chạy script này trong SQL Server Management Studio.

IF DB_ID(N'QuanLyNguoiDung') IS NULL
    CREATE DATABASE QuanLyNguoiDung;
GO

USE QuanLyNguoiDung;
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users (
    UserId            INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap       NVARCHAR(20)  NOT NULL UNIQUE,
    SoDienThoai       VARCHAR(10)   NOT NULL,
    Email             NVARCHAR(100) NULL,
    MatKhauBam        NVARCHAR(64)  NOT NULL,
    Salt              NVARCHAR(32)  NOT NULL,
    MaOTP             VARCHAR(6)    NULL,
    ThoiGianHetHanOTP DATETIME2     NULL,
    NgayTao           DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    LanDangNhapCuoi   DATETIME2     NULL
);
GO
