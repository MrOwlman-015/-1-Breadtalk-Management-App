use master
if exists (select * from sysdatabases where name = 'QLBreadtalk')
	drop database QLBreadtalk
create database QLBreadtalk
go
use QLBreadtalk
go

create table NhanVien (
	maNV int identity (1,1),
	username varchar(20) not null,
	pass varchar(20) not null,
	hotenNV nvarchar(50),
	sdt varchar(10) not null unique,
	soCaLam int,
	loaiNhanVien int, --1: admin, 2: nhân viên
	constraint pk_maNV primary key(maNV)
)


create table KhachHang (
	maKH int identity (1,1),
	username varchar(20) not null,
	pass varchar(20) not null,
	tenKH nvarchar(50) not null,
	sdt varchar(10) not null unique,
	constraint pk_maKH primary key (maKH),
)


create table Banh (
	maBanh int identity (1,1),
	tenBanh nvarchar(25) not null,
	soLuong int not null,
	donGia int not null,
	maKhuyenMai varchar(10),
	constraint pk_maBanh primary key(maBanh),
)


create table KhuyenMai (
	maKhuyenMai varchar(10),
	tenKM nvarchar(20) not null,
	ngayBatDau date default getDate(),
	ngayKetThuc date not null,
	constraint pk_maKM primary key(maKhuyenMai),
	mabanh int,
	foreign key(mabanh) references Banh(maBanh)
)





create table NguyenLieu (
	maNL int identity (1,1),
	tenNL nvarchar(15) not null,
	soLuong int not null,
	donGia int not null,
	donviTinh varchar(10) not null,
	constraint pk_maNL primary key (maNL),
)

create table CongThuc_Banh (
	maBanh int,
	maNL int,
	khoiLuong int not null,
	donviTinh varchar(10) not null,
	primary key(maBanh,maNL),
	constraint fk_maBanh_NL foreign key(maBanh) references Banh(maBanh),
	constraint fk_maNL foreign key (maNL) references NguyenLieu(maNL),
)

create table Hoadon
(
	maHoadon int identity (1,1),
	maKH int not null,
	maNV int not null,
	ngayLap date default getdate(),
	tongTien int,
	constraint pk_maHD primary key(maHoadon),
	constraint fk_maKH foreign key(maKH) references Khachhang(maKH),
	constraint fk_maNV foreign key(maNV) references NhanVien(maNV),
)

create table chiTiet_Hoadon
(
	maHoadon int,
	maBanh int,
	soLuong int,
	donGia int,
	primary key(maHoadon, maBanh),
	constraint fk_maHoadon foreign key(maHoadon) references Hoadon(maHoadon),
	constraint fk_maBanh foreign key (maBanh) references Banh(maBanh),
)

create table KhoBanh
(
	maBanh int identity(1,1) not null,
	tenBanh nvarchar(25),
	soLuongTon int not null,
	soLuongXuat int not null,
	soLuongVao int not null,
	soBanhHong int default 0,
	constraint pk_maKB primary key(maBanh),
	constraint fk_maBanh_kho  foreign key(maBanh) references Banh(maBanh)
)

