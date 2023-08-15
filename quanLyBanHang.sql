Create Database QuanLyBanHang
use QuanLyBanHang
CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY,
    TenSanPham VARCHAR(255),
    DonGia FLOAT,
    Hinh VARBINARY(MAX)
);
CREATE TABLE ChiTietHoaDon (
    MaHD INT,
    MaSP INT,
    SoLuong INT,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSanPham)
);
CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY,
    MaKH INT,
    MaNV INT,
    NgayLapHD DATE,
    NgayNhanHang DATE
);
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    Ho VARCHAR(255),
    Ten VARCHAR(255),
    Nu BIT,
    NgayNV DATE,
    DiaChi VARCHAR(255),
    DienThoai VARCHAR(20),
    Hinh VARBINARY(MAX)
);
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
    TenCty VARCHAR(255),
    DiaChi VARCHAR(255),
    ThanhPho VARCHAR(255),
    DienThoai VARCHAR(20)
);
CREATE TABLE ThanhPho (
    ThanhPho VARCHAR(255) PRIMARY KEY,
    TenThanhPho VARCHAR(255)
);



ALTER TABLE HoaDon
ADD FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);
ALTER TABLE HoaDon
ADD FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH);

ALTER TABLE KhachHang
ADD FOREIGN KEY (ThanhPho) REFERENCES ThanhPho(ThanhPho);