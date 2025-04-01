# Hệ Thống Quản Lý Khách Hàng Ngân Hàng SacomBank

## Giới Thiệu
Dự án này là hệ thống quản lý thông tin khách hàng dành cho ngân hàng SacomBank, được phát triển theo mô hình MVC và sử dụng SQL Server làm hệ quản trị cơ sở dữ liệu. Hệ thống hỗ trợ các chức năng chính như quản lý khách hàng, tài khoản, giao dịch, dịch vụ ngân hàng, và hệ thống thông báo.

## Công Nghệ Sử Dụng
- **Ngôn ngữ lập trình**: C# (WinForms)
- **Cơ sở dữ liệu**: SQL Server
- **Mô hình kiến trúc**: MVC
- **Thư viện hỗ trợ**: Entity Framework, ADO.NET

## Cài Đặt
### Yêu Cầu Hệ Thống
- **Hệ điều hành**: Windows 10/11
- **Phần mềm cần thiết**:
  - .NET 8 SDK
  - SQL Server
  - SQL Server Management Studio (SSMS)
  - Visual Studio 2022 trở lên

### Hướng Dẫn Cài Đặt
1. **Clone dự án**
   ```sh
   git clone https://github.com/your-repo-url.git
   cd project-folder
   ```
2. **Cấu hình CSDL**
   - Khởi động SQL Server và tạo database theo file `database.sql` trong thư mục `Database`.
   - Kiểm tra chuỗi kết nối trong file `appsettings.json` (nếu dùng .NET 8, thay vì `app.config`).

3. **Chạy ứng dụng**
   - Mở dự án bằng Visual Studio
   - Build & Run

## Cấu Trúc Dự Án
```
📁 QuanLyThongTinKhachHangSacomBank
│── 📁 Controllers    # Chứa các controller xử lý logic
│── 📁 Models         # Chứa các model (DTO, Entity)
│── 📁 Views          # Chứa giao diện WinForms
│── 📁 Database       # Chứa script SQL tạo database
│── 📁 Utils          # Các hàm tiện ích
│── appsettings.json  # Cấu hình chuỗi kết nối DB
│── Program.cs        # Điểm bắt đầu của ứng dụng
```

## Chức Năng Chính
- **Quản lý khách hàng**: Thêm, sửa, xóa khách hàng, quản lý thông tin cá nhân.
- **Quản lý tài khoản**: Tạo tài khoản, khóa/mở tài khoản, kiểm tra số dư.
- **Giao dịch**: Chuyển tiền, nạp tiền, rút tiền, kiểm tra lịch sử giao dịch.
- **Quản lý dịch vụ**: Tiết kiệm, vay vốn, thanh toán khoản vay.
- **Hệ thống thông báo**: Nhận thông báo giao dịch, thông báo hệ thống.

## Thành Viên Dự Án
- **Project Manager**: [Tên]
- **Business Analyst**: [Tên]
- **Developer**: [Tên]
- **UI/UX Designer**: [Tên]

## Liên Hệ
Nếu có bất kỳ vấn đề gì, vui lòng liên hệ qua email: [your-email@example.com]
