<!-- LOGO VÀ TIÊU ĐỀ -->
<p align="center">
  <img src="https://github.com/Lequangtien165/BombMasterFinal/raw/main/sourceanh/icon.png?raw=true" alt="BombMaster Logo" width="200">
</p>

<h1 align="center">💣 BombMaster</h1>
<p align="center">
  <strong>Tựa game bắn súng đối kháng trực tuyến vui nhộn dành cho nhiều người chơi</strong><br>
  Đồ án môn <strong>Lập trình mạng căn bản</strong> - Nhóm 10 🎮
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-98%25-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms">
  <img src="https://img.shields.io/badge/Firebase-FFCA28?style=for-the-badge&logo=firebase&logoColor=black" alt="Firebase">
  <img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" alt="License">
</p>

<p align="center">
  <a href="#-tính-năng">Tính năng</a> •
  <a href="#-công-nghệ-sử-dụng">Công nghệ</a> •
  <a href="#-cài-đặt-và-chạy-dự-án">Cài đặt</a> •
  <a href="#-cách-chơi">Cách chơi</a> •
  <a href="#-thành-viên-nhóm">Thành viên</a>
</p>

---

## 📌 Giới thiệu

**BombMaster** là một trò chơi bắn súng đối kháng trực tuyến được xây dựng bằng ngôn ngữ C# trên nền tảng Windows Forms. Người chơi sẽ điều khiển một chiếc xe tăng, di chuyển trên bản đồ và sử dụng đạn để tiêu diệt đối thủ. Trò chơi hỗ trợ mạng lưới cho phép nhiều người chơi tham gia cùng lúc, tạo nên những trận đấu gay cấn và vui nhộn.

Đây là sản phẩm của nhóm 10 trong khuôn khổ đồ án môn **Lập trình mạng căn bản**.

---

## ✨ Tính năng

| 🎮 Tính năng | 📝 Mô tả |
|:---|:---|
| **Chế độ Multiplayer** | Hỗ trợ nhiều người chơi cùng lúc qua kết nối mạng. |
| **Phòng chờ (Lobby)** | Người chơi có thể tạo phòng hoặc tham gia phòng có sẵn, chat với nhau trước trận đấu. |
| **Điều khiển xe tăng** | Điều khiển xe tăng di chuyển, bắn đạn và né tránh đối thủ. |
| **Hệ thống tài khoản** | Đăng ký, đăng nhập và lưu thông tin người dùng qua **Firebase**. |
| **Giao diện thân thiện** | Đồ họa 2D đơn giản nhưng bắt mắt, dễ làm quen. |
| **Kết nối ổn định** | Sử dụng socket để đảm bảo đồng bộ trạng thái giữa các client. |

---

## 🛠 Công nghệ sử dụng

- **Ngôn ngữ lập trình:** C# (.NET 8.0 / .NET Framework 4.8) 🟣
- **Giao diện người dùng:** Windows Forms 🖥️
- **Cơ sở dữ liệu:** Firebase Firestore (lưu thông tin tài khoản) 🔥
- **Truyền thông mạng:** Socket (TCP/IP) 🌐
- **Môi trường phát triển:** Visual Studio 2022

---

## 📦 Cài đặt và chạy dự án

### Yêu cầu hệ thống
- **Hệ điều hành:** Windows 10/11
- **Phần mềm:** [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download) hoặc .NET Framework 4.8, [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (có thể dùng bản Community miễn phí)

### Hướng dẫn chạy

1. **Clone repository**
   ```bash
   git clone https://github.com/Lequangtien165/BombMasterFinal.git
   cd BombMasterFinal
