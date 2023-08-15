INSERT INTO ThanhPho (ThanhPho, TenThanhPho)
VALUES (1, N'Ha Noi'),
       (2, N'Ho Chi Minh'),
       (3, N'Đa Nang'),
       (4, N'Hai Phong');
	
	   INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia)
VALUES (1, 'San pham 1', 10000),
       (2, 'San pham 2', 20000),
       (3, 'San pham 3', 30000),
       (4, 'San pham 4', 40000);
	   INSERT INTO NhanVien (MaNV, Ho, Ten)
VALUES (1, 'Nguyem', 'Van A'),
       (2, 'Tran', 'Thi B'),
       (3, 'Le', 'Van C'),
       (4, 'Pham', 'Thi D');
	   INSERT INTO KhachHang (MaKH, TenCty, DiaChi, ThanhPho, DienThoai)
VALUES (1, 'Công ty TNHH ABC', '123 Đuong XYZ', 1, '0123456789'),
       (2, 'Công ty TNHH DEF', '456 Đuong UVW', 2, '0987654321'),
       (3, 'Công ty TNHH GHI', '789 Đuong RST', 3, '0123456789'),
       (4, 'Công ty TNHH JKL', '321 Đuong OPQ', 4, '0987654321');
		  INSERT INTO HoaDon (MaHD, MaKH, MaNV)
VALUES (1, 1, 1),
       (2, 2, 2),
       (3, 3, 3),
       (4, 4, 4);
	   INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong)
VALUES (1, 1, 10),
       (1, 2, 20),
       (2, 3, 30),
       (2, 4, 40),
       (3, 1, 50)
	   	     select * from NhanVien
			 SELECT MaSanPham,TenSanPham,DONGIA FROM SANPHAM
			 SELECT MAHD,MAKH,MANV FROM HOADON
			 SELECT * FROM CHITIETHOADON