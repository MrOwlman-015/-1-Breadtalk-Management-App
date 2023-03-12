# -1-Breadtalk-Management-App

Update file sql Breadtalk 2 bảng Nhân viên và Khách hàng:
	Gộp bảng Nhân viên và Tài khoản Nhân viên lại để dễ truy vấn bên phía đăng nhập và tránh lỗi vướng khóa ngoại sdt ở bảng tài khoản nhân viên khi insert data vào database.
	Tương tự với hai bảng Khách hàng và Tài khoản Khách hàng.
	Hoán đổi vị trí tạo bảng Bánh và Khuyến mãi, khóa ngoại ở bảng Khuyến mãi trỏ đến bảng Bánh để tránh trường hợp lỗi conflict data khi insert data vào bảng Bánh.
Update demo code với 2 form demo đăng nhập đăng ký:
	Hiện tại ở demo đã hoàn thành code việc đăng nhập đăng ký và truy xuất đến database.
	Trung đang đợi phần thiết kế chính thức ở form đăng nhập đăng ký từ Tiến để triển khai code sang.