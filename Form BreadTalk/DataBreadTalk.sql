--use master
create database QLBreadtalk
go
use QLBreadtalk
go


--create table KhuyenMai (
--	maKhuyenMai varchar(10),
--	tenKM nvarchar(20) not null,
--	ngayBatDau date default getDate(),
--	ngayKetThuc date not null,
--	constraint pk_maKM primary key(maKhuyenMai),
--)


--create table LoaiNV (
--	maLNV varchar(5) primary key,
--	tenLNV nvarchar(15) not null,
--)

--create table NhanVien (
--	maNV int identity (1,1),
--	hotenNV nvarchar(50) not null,
--	loaiNV varchar(5) not null,
--	phanquyen varchar(20) not null,
--	taikhoan varchar(20) not null unique,
--	matkhau varchar(50) not null,
--	SDT varchar(10) not null,
--	constraint pk_maNV primary key(maNV),
--	constraint fk_maLNV foreign key(loaiNV) references LoaiNV(maLNV),
--)

--create table KhachHang (
--	maKH int identity (1,1),
--	tenKH nvarchar(50) not null,
--	soLanMua int default 1,
--	constraint pk_maKH primary key (maKH),
--)

--create table LoaiBanh (
--	maLoaiBanh int identity (1,1) primary key,
--	tenLoaiBanh nvarchar(20) not null,

--)

--create table Banh (
--	maBanh int identity (1,1),
--	tenBanh nvarchar(25) not null,
--	soLuong int not null,
--	donGia int not null,
--	maLoaiBanh int,
--	maKhuyenMai varchar(10),
--	soBanhHong int default 0,
--	constraint pk_maBanh primary key(maBanh),
--	constraint fk_maLoaiBanh foreign key (maLoaiBanh) references LoaiBanh(maLoaiBanh),
--	constraint fk_KhuyenMai foreign key (maKhuyenMai) references KhuyenMai(maKhuyenMai),
--)

--create table NguyenLieu (
--	maNL int identity (1,1),
--	tenNL nvarchar(15) not null,
--	soLuong int not null,
--	donviTinh varchar(10) not null,
--	constraint pk_maNL primary key (maNL),
--)

--create table CongThuc_Banh (
--	maBanh int,
--	maNL int,
--	khoiLuong int not null,
--	donviTinh varchar(10) not null,
--	primary key(maBanh,maNL),
--	constraint fk_maBanh_NL foreign key(maBanh) references Banh(maBanh),
--	constraint fk_maNL foreign key (maNL) references NguyenLieu(maNL),
--)

--create table Hoadon
--(
--	maHoadon int identity (1,1),
--	maKH int not null,
--	maNV int not null,
--	ngayLap date default getdate(),
--	tongTien int,
--	constraint pk_maHD primary key(maHoadon),
--	constraint fk_maKH foreign key(maKH) references Khachhang(maKH),
--	constraint fk_maNV foreign key(maNV) references NhanVien(maNV),
--)

--create table chiTiet_Hoadon
--(
--	maHoadon int,
--	maBanh int,
--	soLuong int,
--	donGia int,
--	primary key(maHoadon, maBanh),
--	constraint fk_maHoadon foreign key(maHoadon) references Hoadon(maHoadon),
--	constraint fk_maBanh foreign key (maBanh) references Banh(maBanh),
--)

--create table KhoBanh
--(
--	maKhoBanh int identity (1,1),
--	maBanh int not null, 
--	soLuongTon int not null,
--	soLuongXuat int not null,
--	soLuongVao int not null,
--	constraint pk_maKB primary key(maKhoBanh),
--	constraint fk_maBanh_kho  foreign key(maBanh) references Banh(maBanh)
--)
