# NT106.R14-BaiTap2.2 - Quản lý người dùng

Bài tập 2.2 nhóm 10 lớp NT106.R14: ứng dụng Windows Forms quản lý người dùng với chức năng đăng ký, đăng nhập, lưu trữ trên SQL Server.

## Chức năng

- **Đăng ký**: kiểm tra dữ liệu trước khi gửi cơ sở dữ liệu, chống trùng tên đăng nhập, băm mật khẩu trước khi lưu.
- **Đăng nhập**: xác thực bằng cách so sánh chuỗi băm, sai tên hoặc sai mật khẩu dùng chung một thông báo.
- **Trang chính**: hiển thị thông tin người dùng lấy từ cơ sở dữ liệu, đăng xuất quay lại form đăng nhập.

## Cài đặt và chạy

1. Chạy `baitap2.sql` trong SQL Server Management Studio để tạo cơ sở dữ liệu `QuanLyNguoiDung` và bảng `Users`.
2. Nếu tên instance SQL Server khác, sửa `ChuoiKetNoi` trong `XuLyNguoiDung.cs`.
3. Mở `CRUD-APP.slnx` bằng Visual Studio hoặc chạy `dotnet run`.

## Cấu trúc mã nguồn

| Tệp | Vai trò |
| --- | --- |
| `DangNhap.cs` | Form đăng nhập |
| `DangKy.cs` | Form đăng ký |
| `FormChinh.cs` | Form trang chính |
| `KiemTraNhapLieu.cs` | Hàm thuần kiểm tra dữ liệu nhập |
| `XuLyNguoiDung.cs` | Lớp truy cập cơ sở dữ liệu, mọi câu lệnh SQL dùng tham số |
| `MatKhau.cs` | Băm và kiểm tra mật khẩu |
| `NguoiDung.cs` | Bản ghi thông tin người dùng |

## Bảo mật

- Mật khẩu băm bằng PBKDF2-HMAC-SHA256, 600.000 vòng lặp, salt riêng cho từng tài khoản (khuyến nghị OWASP).
- Bảng `Users` có ràng buộc `UNIQUE` trên `TenDangNhap`, kết hợp kiểm tra trùng ở phía chương trình.
- Mọi ngoại lệ đều được chuyển thành thông báo tiếng Việt, không lộ chi tiết kỹ thuật cho người dùng.
