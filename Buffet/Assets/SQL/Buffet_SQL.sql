CREATE DATABASE CuaHangBuffet;
GO

USE CuaHangBuffet;
GO

CREATE TABLE QUANTRIVIEN(
    MaQuanTriVien INT PRIMARY KEY NOT NULL IDENTITY,
	TenTruyCapQTV VARCHAR(10) NOT NULL,
	MatKhau VARCHAR(50) NOT NULL
);
GO

CREATE TABLE NHANVIEN (
    MaNhanVien INT PRIMARY KEY NOT NULL IDENTITY,
    HoTenNhanVien NVARCHAR(255) NOT NULL,
	NgaySinh DATE NOT NULL,
	SoCCCDNhanVien INT NOT NULL UNIQUE,
	DienThoai CHAR(10) NOT NULL UNIQUE,
);
GO


CREATE TABLE PHANQUYEN(
	MaPhanQuyen INT PRIMARY KEY NOT NULL IDENTITY,
	VaiTroPhanQuyen NVARCHAR(255) NOT NULL,
);
GO

CREATE TABLE  TAIKHOAN(
	MaTaiKhoan INT PRIMARY KEY NOT NULL IDENTITY,
	TenTruyCap VARCHAR(10) NOT NULL,
	MatKhau  VARCHAR(50) NOT NULL,
	VaiTro NVARCHAR(50) NOT NULL,
	MaPhanQuyen INT NOT NULL,
	MaNhanVien INT,
	FOREIGN KEY(MaNhanVien) REFERENCES dbo.NHANVIEN(MaNhanVien),
	FOREIGN KEY(MaPhanQuyen) REFERENCES dbo.PHANQUYEN(MaPhanQuyen)
);
GO

CREATE TABLE KHO (
	MaKho INT PRIMARY KEY NOT NULL IDENTITY,
	TenKho NVARCHAR(255) NOT NULL
);
GO

CREATE TABLE LOAISANPHAMKHO(
	MaLoaiSanPhamKho INT PRIMARY KEY NOT NULL IDENTITY,
	TenLoaiSanPhamKho NVARCHAR(255) NOT NULL,
);
GO

CREATE TABLE SANPHAMKHO (
    MaSanPhamKho INT PRIMARY KEY NOT NULL IDENTITY,
	TenSanPhamKho NVARCHAR(255) NOT NULL,
	Kho NVARCHAR(255) NOT NULL,
	LoaiSanPhamKho NVARCHAR(255) NOT NULL,
	DonViTinh NVARCHAR(255) NOT NULL,
	SoLuong INT NOT NULL,
	NguoiNhapKho NVARCHAR(255),
	NguoiCapNhat NVARCHAR(255),
	TinhTrangSpKho BIT DEFAULT 1,
	MaKho INT,
	MaLoaiSanPhamKho INT,
	MaQuanTriVien INT,
	MaNhanVien INT,
	FOREIGN KEY(MaLoaiSanPhamKho) REFERENCES dbo.LOAISANPHAMKHO(MaLoaiSanPhamKho),
	FOREIGN KEY(MaKho) REFERENCES dbo.KHO(MaKho),
	FOREIGN KEY(MaQuanTriVien) REFERENCES dbo.QUANTRIVIEN(MaQuanTriVien),
	FOREIGN KEY(MaNhanVien) REFERENCES dbo.NHANVIEN(MaNhanVien),
);
GO

CREATE TABLE DANHMUCMONAN(
	MaDanhMucMonAn INT PRIMARY KEY NOT NULL IDENTITY,
	TenDanhMucMonAn NVARCHAR(255) NOT NULL,
);
GO

CREATE TABLE MONAN (
    MaMonAn INT PRIMARY KEY NOT NULL IDENTITY,
	TenMonAn NVARCHAR(255) NOT NULL,
	SoLuongMonAn INT NOT NULL,
	TinhTrangMonAn BIT DEFAULT 1,
	MaDanhMucMonAn INT,
	FOREIGN KEY(MaDanhMucMonAn) REFERENCES dbo.DANHMUCMONAN(MaDanhMucMonAn)
);
GO

CREATE TABLE BANAN (
    MaBanAn INT PRIMARY KEY NOT NULL IDENTITY,
	TenBanAn NVARCHAR(255) NOT NULL,
	SucChua INT NOT NULL,
	TinhTrangBanAn BIT DEFAULT 0,
);
GO
CREATE TABLE DANHMUCDOUONG(
	MaDanhMucDoUong INT PRIMARY KEY NOT NULL IDENTITY,
	TenDanhMucDoUong NVARCHAR(255) NOT NULL,
);
GO
CREATE TABLE DOUONG (
    MaDoUong INT PRIMARY KEY NOT NULL IDENTITY,
	TenDoUong NVARCHAR(255) NOT NULL,
	GiaDoUong MONEY NOT NULL,
	SoLuongDoUong INT NOT NULL,
	TinhTrangDoUong BIT DEFAULT 1,
	MaDanhMucDoUong INT,
	FOREIGN KEY(MaDanhMucDoUong) REFERENCES dbo.DANHMUCDOUONG(MaDanhMucDoUong)
);
GO

CREATE TABLE HOADON (
    MaHoaDon INT PRIMARY KEY NOT NULL IDENTITY,
	TenKhachHang NVARCHAR(255) NOT NULL,
	SoLuongKhach INT NOT NULL,
	BanKhachHang NVARCHAR(255) NOT NULL,
	ThoiGianKhachVao DATETIME,
	GiaSetBuffet MONEY DEFAULT 0,
	TongPhiDoUong MONEY	DEFAULT 0,
	TongTien MONEY DEFAULT 0,
	Thue INT DEFAULT 0, --Thuế giá theo %
	GiamGia	INT DEFAULT 0, --Giảm giá theo %
	TienThanhToan MONEY DEFAULT 0,
	SoTienNhan MONEY DEFAULT 0,
	SoTienTraKhach MONEY DEFAULT 0,
	ThoiGianHoaDon DATETIME,
	TinhTrangHoaDon BIT DEFAULT 0,
	MaBanAn INT,

	MaNhanVien INT,
	FOREIGN KEY(MaBanAn) REFERENCES dbo.BANAN(MaBanAn),
	
	FOREIGN KEY(MaNhanVien) REFERENCES dbo.NHANVIEN(MaNhanVien),
	
	
);
GO

CREATE TABLE CHITIETHOADON(
	MaChiTietHoaDon INT PRIMARY KEY NOT NULL IDENTITY,
	SoLuongLay INT DEFAULT 0,
	ThanhTien MONEY DEFAULT 0,

	MaDoUong INT,
	MaHoaDon INT,
	FOREIGN KEY(MaDoUong) REFERENCES dbo.DOUONG(MaDoUong),
	FOREIGN KEY(MaHoaDon) REFERENCES dbo.HOADON(MaHoaDon)
	
)

GO

CREATE TABLE DOANHTHU (
    MaDoanhThu INT PRIMARY KEY NOT NULL IDENTITY,
	TenDoanhThu NVARCHAR(255) NOT NULL,
	NgayDoanhThu DATETIME NOT NULL,
	NhanVienDoanhThu NVARCHAR(255) NOT NULL,
	TongDoanhThu MONEY NOT NULL,
	MaHoaDon INT,
	MaNhanVien INT,
	FOREIGN KEY(MaHoaDon) REFERENCES dbo.HOADON(MaHoaDon),
	FOREIGN KEY(MaNhanVien) REFERENCES dbo.NHANVIEN(MaNhanVien),
);
GO


-- Thêm dữ liệu QUẢN TRỊ VIÊN 
INSERT INTO QUANTRIVIEN(
	TenTruyCapQTV,
	MatKhau
)VALUES(
	'admin',
	'admin'
);


-- Thêm dữ liệu PHÂN QUYỀN
INSERT INTO PHANQUYEN(
	VaiTroPhanQuyen
)VALUES(
	N'Lễ tân'
);
INSERT INTO PHANQUYEN(
	VaiTroPhanQuyen
)VALUES(
	N'Nhân viên phục vụ'
);
INSERT INTO PHANQUYEN(
	VaiTroPhanQuyen
)VALUES(
	N'Đầu bếp'
);
-- Thêm dữ liệu NHÂN VIÊN 
INSERT INTO NHANVIEN(
	HoTenNhanVien,
	NgaySinh,
	SoCCCDNhanVien,
	DienThoai
)VALUES(
	N'Nguyễn Văn A',
	'2022-01-11',
	1921223333,
	'0923456822'
);
INSERT INTO NHANVIEN(
	HoTenNhanVien,
	NgaySinh,
	SoCCCDNhanVien,
	DienThoai
)VALUES(
	N'Nguyễn Văn B',
	'2022-01-11',
	1921223337,
	'0923456827'
);

INSERT INTO NHANVIEN(
	HoTenNhanVien,
	NgaySinh,
	SoCCCDNhanVien,
	DienThoai
)VALUES(
	N'Nguyễn Văn C',
	'2022-01-11',
	1921223332,
	'0923456821'
);

-- Thêm dữ liệu BÀN ĂN 
INSERT INTO BANAN(
	TenBanAn,
	SucChua
)VALUES(
	N'Bàn 1',
	5
);

INSERT INTO BANAN(
	TenBanAn,
	SucChua
)VALUES(
	N'Bàn 2',
	5
);

INSERT INTO BANAN(
	TenBanAn,
	SucChua
)VALUES(
	N'Bàn 3',
	5
);

INSERT INTO BANAN(
	TenBanAn,
	SucChua
)VALUES(
	N'Bàn 4',
	5
);

INSERT INTO BANAN(
	TenBanAn,
	SucChua
)VALUES(
	N'Bàn 5',
	5
);
INSERT INTO BANAN(
	TenBanAn,
	SucChua
)VALUES(
	N'Bàn 6',
	6
);

INSERT INTO BANAN(
	TenBanAn,
	SucChua,
	TinhTrangBanAn
)VALUES(
	N'Bàn 7',
	7,
	0
);
-- Thêm dữ liệu DANH MỤC MÓN ĂN 
INSERT INTO DANHMUCMONAN(
	TenDanhMucMonAn
)
VALUES(
	N'Điểm tâm'
);

INSERT INTO DANHMUCMONAN(
	TenDanhMucMonAn
)
VALUES(
	N'Món chính'
);

INSERT INTO DANHMUCMONAN(
	TenDanhMucMonAn
)
VALUES(
	N'Tráng miệng'
);
--Thêm món ăn
INSERT INTO MONAN(
	TenMonAn,
	SoLuongMonAn,
	MaDanhMucMonAn
)
VALUES(
	N'Cai blah',
	40,
	2
);

INSERT INTO MONAN(
	TenMonAn,
	SoLuongMonAn,
	MaDanhMucMonAn
)
VALUES(
	N'Ga Quay',
	40,
	2
)

INSERT INTO MONAN(
	TenMonAn,
	SoLuongMonAn,
	MaDanhMucMonAn
)
VALUES(
	N'Vit Quay',
	40,
	2
)

INSERT INTO MONAN(
	TenMonAn,
	SoLuongMonAn,
	MaDanhMucMonAn
)
VALUES(
	N'Dua Hau',
	40,
	3
)

INSERT INTO MONAN(
	TenMonAn,
	SoLuongMonAn,
	MaDanhMucMonAn
)
VALUES(
	N'Thanh Long',
	40,
	3
)

INSERT INTO MONAN(
	TenMonAn,
	SoLuongMonAn,
	MaDanhMucMonAn
)
VALUES(
	N'Cam',
	40,
	3
)
-- Thêm dữ liệu DANH MỤC ĐỒ UỐNG
INSERT INTO DANHMUCDOUONG(
	TenDanhMucDoUong
)
VALUES(
	N'NƯỚC NGỌT'
);

INSERT INTO DANHMUCDOUONG(
	TenDanhMucDoUong
)
VALUES(
	N'BIA'
);

INSERT INTO DANHMUCDOUONG(
	TenDanhMucDoUong
)
VALUES(
	N'RƯỢU'
);

--
INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Nước cam',
	10000,
	500,
	1
);

INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Nước chanh leo',
	10000,
	500,
	1
);
INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Nước Bí đao',
	10000,
	500,
	1
);
INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Nước nuti táo',
	10000,
	500,
	1
);
INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Nước nuti xoài',
	10000,
	500,
	1
);
INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Nước dâu',
	10000,
	500,
	1
);
INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Nước điện giải',
	10000,
	500,
	1
);

INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Bia 333',
	10000,
	500,
	1
);

INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Bia HaNoi',
	10000,
	500,
	1
);

INSERT INTO DOUONG(
	TenDoUong,
	GiaDoUong,
	SoLuongDoUong,
	MaDanhMucDoUong
)
VALUES(
	'Bia SaiGon',
	10000,
	500,
	1
);


-- Thêm dữ liệu KHO
INSERT INTO KHO(
	TenKho
)
VALUES(
	N'Kho Số 1'
);

-- Thêm dữ liệu LOAISANPHAMKHO
INSERT INTO LOAISANPHAMKHO(
	TenLoaiSanPhamKho
)
VALUES(
	N'Nguyên liệu'
);

INSERT INTO LOAISANPHAMKHO(
	TenLoaiSanPhamKho
)
VALUES(
	N'Vật tư'
);

