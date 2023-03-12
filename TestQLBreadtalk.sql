use master
create database TestQLBreadtalk
go
use TestQLBreadtalk
go

create table NhanVien (
	hotenNV nvarchar(50) not null,
	taikhoan varchar(20) not null unique,
	matkhau varchar(50) not null,
	SDT varchar(10) not null,
	constraint pk_SDT primary key(SDT)
)
