KIỂM THỬ PHẦN MỀM – NUnit, Selenium WebDriver, API Postman

📖 Giới thiệu
Đây là đồ án môn - Kiểm Thử Phần Mềm gồm 3 phần:
1. Unit Test – NUnit: Kiểm thử chức năng chuyển đổi số nguyên dương cơ số 10 sang cơ số bất kỳ (2 ≤ k ≤ 16).
2. Selenium WebDriver: Kiểm thử các chức năng trên website Pinterest (Login, Share Pin, Create Pin).
3. API Testing – Postmam: Tạo API với JSON Server và viết test case kiểm thử API bằng Postman.

🧩 1. Unit Test – NUnit
🔹 Chức năng
- Ngôn ngữ: C#
- IDE: Visual Studio 2022
- Chức năng chính: Chuyển đổi số nguyên dương n từ cơ số 10 sang hệ cơ số k (2 ≤ k ≤ 16).
🔹 Thiết kế kiểm thử
- Kỹ thuật: Bảng quyết định + Phân tích giá trị biên.
- Dữ liệu kiểm thử: CSV & Excel.

🧩 2. Selenium WebDriver – Pinterest
🔹 Chức năng kiểm thử
- Login: Kiểm tra đăng nhập thành công / thất bại với các tổ hợp dữ liệu khác nhau.
- Share Pin: Chia sẻ pin cho người nhận hợp lệ và không hợp lệ.
- Create Pin: Đăng tải ảnh (.jpg < 20MB) và video (.mp4 < 200MB) ( quá kích thước được đăng tải nên đã xoá ), kiểm tra giới hạn kích thước. 
🔹 Công cụ & Thư viện
- Ngôn ngữ: C#
- Selenium.WebDriver
- Selenium.WebDriver.ChromeDriver

🧩 3. API Testing – Postman & JSON Server
🔹 Thực hiện
- Tạo REST API giả lập bằng JSON Server.
- Kiểm thử các API với Postman.
- Viết test script để tự động kiểm tra kết quả trả về.
- Sử dụng Tests tab với pm.test() để kiểm tra:
  + Status code.
  + Nội dung trả về.
  + Độ dài danh sách.
  + Tính đúng đắn của dữ liệu sau khi POST/PUT/DELETE.


