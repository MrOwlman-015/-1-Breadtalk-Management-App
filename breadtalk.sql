 use master
if exists (select * from sysdatabases where name = 'QLBreadtalk')
	drop database QLBreadtalk
create database QLBreadtalk
go
use QLBreadtalk
go



create table NhanVien (
	maNV varchar(20),
	hotenNV nvarchar(50) not null,
	sdt varchar(10) not null unique,
	soCaLam int,
	constraint pk_maNV primary key(maNV)
)


create table Tai_khoan
(
	username varchar(20) not null,
	pass varchar(30),
	Loai int --1: Quan ly; 2: Nhan vien; 3: Khach hang
)



create table KhachHang (
	maKH varchar(20),
	tenKH nvarchar(50) not null,
	username varchar(20) not null,
	pass varchar(20) not null,
	sdt varchar(10) not null unique,
	constraint pk_maKH primary key (maKH),
)





create table KhuyenMai (
	maKhuyenMai int identity(1,1),
	tenKM nvarchar(20) not null,
	ngayBatDau date default getDate(),
	ngayKetThuc date not null,
	constraint pk_maKM primary key(maKhuyenMai),
)











create table KhoBanh
(
	maBanh int identity(1,1) not null,
	tenBanh nvarchar(25),
	soLuongTon int not null,
	soLuongXuat int not null,
	soLuongVao int not null,
	soBanhHong int default 0,
	constraint pk_maKB primary key(maBanh)
	
)
create table Banh (
	maBanh int,
	tenBanh nvarchar(25) not null,
	soLuong int not null,
	donGia int not null,
	constraint pk_maBanh primary key(maBanh),
	constraint fk_maBanh_kho  foreign key(maBanh) references KhoBanh(maBanh)
)

create table Hoadon
(
	maHoadon int identity (1,1),
	maKH varchar(20) not null,
	maNV varchar(20) not null,
	maKhuyenMai int not null,
	ngayLap date default getdate(),
	tongTien int not null,
	constraint pk_maHD primary key(maHoadon),
	constraint fk_maKH foreign key(maKH) references Khachhang(maKH),
	constraint fk_maNV foreign key(maNV) references NhanVien(maNV),
	constraint fk_maKM foreign key(maKhuyenMai) references KhuyenMai(maKhuyenMai),
)

create table chiTiet_Hoadon
(
	maHoadon int,
	maBanh int,
	soLuong int,
	donGia int
	primary key(maHoadon, maBanh),
	constraint fk_maHoadon foreign key(maHoadon) references Hoadon(maHoadon),
	constraint fk_maBanh foreign key (maBanh) references Banh(maBanh),
)


----TRIGGERs ----
go
CREATE TRIGGER trg_DeleteNhanVien
ON NhanVien
AFTER DELETE
AS
BEGIN
	DELETE FROM Tai_khoan
	WHERE username = (SELECT maNV FROM deleted)
END

go
go
CREATE TRIGGER trg_DeleteKhachHang
ON KhachHang
AFTER DELETE
AS
BEGIN
	DELETE FROM Tai_khoan
	WHERE username = (SELECT username FROM deleted)
END

go
CREATE TRIGGER tr_UpdateKhachHang
ON KhachHang
AFTER UPDATE
AS
BEGIN
  UPDATE Tai_khoan
  SET pass = i.pass
  FROM Tai_khoan t
  INNER JOIN inserted i ON t.username = i.username
  WHERE t.Loai = 3; -- Update only Khach hang accounts
END;
go



go 
CREATE TRIGGER trg_InsertTaiKhoanForNewEmployee
ON NhanVien
AFTER INSERT
AS
BEGIN
    INSERT INTO Tai_Khoan (username, pass, loai)
    SELECT inserted.maNV, inserted.sdt, 2
    FROM inserted
    LEFT JOIN Tai_Khoan ON inserted.maNV = Tai_Khoan.username
    WHERE Tai_Khoan.username IS NULL;
END;
go


go 
CREATE TRIGGER trg_InsertTaiKhoanForNewGuest
ON KhachHang
AFTER INSERT
AS
BEGIN
    INSERT INTO Tai_Khoan (username, pass, loai)
    SELECT inserted.username, inserted.pass, 3
    FROM inserted
    LEFT JOIN Tai_Khoan ON inserted.username = Tai_Khoan.username
    WHERE Tai_Khoan.username IS NULL;
END;
go


--Auto ma nhan vien
go
create function dbo.auto_mNV()
returns varchar(5)
as
begin
	declare @ID varchar(5)
	if (select count(maNV) from NhanVien) = 0
		set @ID = '000'
	else
		select @ID = max(right(maNV, 3)) from NhanVien
		select @ID = case
			when @ID >= 0 and @ID < 9 then 'NV00' + convert(char, convert(int, @ID) + 1)
			when @ID >= 9 and @ID < 99 then 'NV0' + convert(char, convert(int, @ID) + 1)
			when @ID >= 99 then 'HV' + convert(char, convert(int, @ID) + 1)
		END
	return @ID
END
go



-- Auto ma KH
go
create function dbo.auto_mKH()
returns varchar(5)
as
begin
	declare @ID varchar(5)
	if (select count(maKH) from KhachHang) = 0
		set @ID = '000'
	else
		select @ID = max(right(maKH, 3)) from KhachHang
		select @ID = case
			when @ID >= 0 and @ID < 9 then 'KH00' + convert(char, convert(int, @ID) + 1)
			when @ID >= 9 and @ID < 99 then 'KH0' + convert(char, convert(int, @ID) + 1)
			when @ID >= 99 then 'HV' + convert(char, convert(int, @ID) + 1)
		END
	return @ID
END
go



-- CRUD for NhanVien table
CREATE PROCEDURE dbo.NhanVien_CRUD
    @StatementType VARCHAR(10),
    @maNV VARCHAR(20) = NULL,
    @hotenNV NVARCHAR(50) = NULL,
    @sdt VARCHAR(10) = NULL,
    @soCaLam INT = NULL
	AS
	BEGIN
		SET NOCOUNT ON;
		IF (@StatementType = 'SELECT')
		BEGIN
			SELECT *
			FROM dbo.NhanVien
			WHERE maNV = @maNV

		END
		ELSE IF (@StatementType = 'INSERT')
		BEGIN
			INSERT INTO dbo.NhanVien (maNV, hotenNV, sdt, soCaLam)
			VALUES (dbo.auto_mNV(), @hotenNV, @sdt, @soCaLam)
		END
		ELSE IF (@StatementType = 'UPDATE')
		BEGIN
			UPDATE dbo.NhanVien
			SET hotenNV = @hotenNV,
				sdt = @sdt,
				soCaLam = @soCaLam
			WHERE maNV = @maNV
		END
		ELSE IF (@StatementType = 'DELETE')
		BEGIN
			DELETE FROM dbo.NhanVien
			WHERE maNV = @maNV
		END
	END

go
CREATE PROCEDURE dbo.Khachhang_CRUD
	@StatementType VARCHAR(10), 
	@maKH VARCHAR(20) = NULL,
	@tenKH NVARCHAR(50) = NULL,
	@username VARCHAR(20) = NULL,
	@pass VARCHAR(20) = NULL,
	@sdt VARCHAR(10) = NULL
	AS
	BEGIN
		SET NOCOUNT ON;
		IF (@StatementType = 'SELECT')
			BEGIN
			SELECT *
			FROM dbo.Khachhang
			WHERE (maKH = @maKH)
		END
		ELSE IF (@StatementType = 'INSERT')
		BEGIN
			INSERT INTO dbo.Khachhang (maKH, tenKH, username, pass, sdt)
			VALUES (dbo.auto_mKH(), @tenKH, @username, @pass, @sdt)
		END
		ELSE IF (@StatementType = 'UPDATE')
		BEGIN
			UPDATE dbo.Khachhang
			SET tenKH = @tenKH,
				username = @username,
				pass = @pass,
				sdt = @sdt
			WHERE maKH = @maKH
		END
		ELSE IF (@StatementType = 'DELETE')
		BEGIN
			DELETE FROM dbo.Khachhang
			WHERE maKH = @maKH
		END
	END

go
CREATE PROCEDURE dbo.Banh_CRUD
    @StatementType VARCHAR(10),
    @maBanh INT = NULL,
    @tenBanh NVARCHAR(25) = NULL,
    @soLuong INT = NULL,
    @donGia INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF (@StatementType = 'SELECT')
    BEGIN
        SELECT *
        FROM dbo.Banh
        WHERE maBanh = @maBanh
    END
    ELSE IF (@StatementType = 'INSERT')
    BEGIN
        INSERT INTO dbo.Banh (maBanh, tenBanh, soLuong, donGia)
        VALUES (@maBanh, @tenBanh, @soLuong, @donGia)
    END
    ELSE IF (@StatementType = 'UPDATE')
    BEGIN
        UPDATE dbo.Banh
        SET tenBanh = @tenBanh,
            soLuong = @soLuong,
            donGia = @donGia
        WHERE maBanh = @maBanh
    END
    ELSE IF (@StatementType = 'DELETE')
    BEGIN
        DELETE FROM dbo.Banh
        WHERE maBanh = @maBanh
    END
END



go
CREATE PROCEDURE dbo.KhuyenMai_CRUD
    @StatementType VARCHAR(10),
    @maKM INT = NULL,
    @tenKM NVARCHAR(20) = NULL,
    @ngayBatDau DATE = NULL,
    @ngayKetThuc DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF (@StatementType = 'SELECT')
    BEGIN
        SELECT *
        FROM dbo.KhuyenMai
        WHERE maKhuyenMai = @maKM
    END
    ELSE IF (@StatementType = 'INSERT')
    BEGIN
        INSERT INTO dbo.KhuyenMai (tenKM, ngayBatDau, ngayKetThuc)
        VALUES (@tenKM, @ngayBatDau, @ngayKetThuc)
    END
    ELSE IF (@StatementType = 'UPDATE')
    BEGIN
        UPDATE dbo.KhuyenMai
        SET tenKM = @tenKM,
            ngayBatDau = @ngayBatDau,
            ngayKetThuc = @ngayKetThuc
        WHERE maKhuyenMai = @maKM
    END
    ELSE IF (@StatementType = 'DELETE')
    BEGIN
        DELETE FROM dbo.KhuyenMai
        WHERE maKhuyenMai = @maKM
    END
END

go



go
CREATE PROCEDURE dbo.Hoadon_CRUD
    @StatementType VARCHAR(10),
    @maHD INT = NULL,
    @maKH VARCHAR(20) = NULL,
    @maNV VARCHAR(20) = NULL,
	@maKhuyenMai INT = NULL,
    @ngayLap DATE = NULL,
    @tongTien INT = NULL
	AS
	BEGIN
		SET NOCOUNT ON;
		IF (@StatementType = 'SELECT')
		BEGIN
			SELECT *
			FROM dbo.Hoadon
			WHERE maHoadon = @maHD
		END
		ELSE IF (@StatementType = 'INSERT')
		BEGIN
			INSERT INTO dbo.Hoadon (maKH, maNV, ngayLap, maKhuyenMai, tongTien)
			VALUES (@maKH, @maNV, COALESCE(@ngayLap, GETDATE()), @maKhuyenMai, @tongTien)
		END
		ELSE IF (@StatementType = 'UPDATE')
		BEGIN
			UPDATE dbo.Hoadon
			SET maKH = @maKH,
				maNV = @maNV,
				maKhuyenMai = @maKhuyenMai,
				ngayLap = COALESCE(@ngayLap, ngayLap),
				tongTien = @tongTien
			WHERE maHoadon = @maHD
		END
		ELSE IF (@StatementType = 'DELETE')
		BEGIN
			DELETE FROM dbo.Hoadon
			WHERE maHoadon = @maHD
		END
	END


go
CREATE PROCEDURE dbo.chiTiet_Hoadon_CRUD
    @StatementType VARCHAR(10),
    @maHD INT = NULL,
    @maBanh INT = NULL,
    @soLuong INT = NULL,
    @donGia INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF (@StatementType = 'SELECT')
    BEGIN
        SELECT *
        FROM dbo.chiTiet_Hoadon
        WHERE maHoadon = @maHD AND maBanh = @maBanh
    END
    ELSE IF (@StatementType = 'INSERT')
    BEGIN
        INSERT INTO dbo.chiTiet_Hoadon (maHoadon, maBanh, soLuong, donGia)
        VALUES (@maHD, @maBanh, @soLuong, @donGia)
    END
    ELSE IF (@StatementType = 'UPDATE')
    BEGIN
        UPDATE dbo.chiTiet_Hoadon
        SET soLuong = @soLuong,
            donGia = @donGia
        WHERE maHoadon = @maHD AND maBanh = @maBanh
    END
    ELSE IF (@StatementType = 'DELETE')
    BEGIN
        DELETE FROM dbo.chiTiet_Hoadon
        WHERE maHoadon = @maHD AND maBanh = @maBanh
    END
END


go
CREATE PROCEDURE dbo.KhoBanh_CRUD
    @StatementType VARCHAR(10),
    @maBanh INT = NULL,
    @tenBanh NVARCHAR(25) = NULL,
    @soLuongTon INT = NULL,
    @soLuongXuat INT = NULL,
    @soLuongVao INT = NULL,
    @soBanhHong INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF (@StatementType = 'SELECT')
    BEGIN
        SELECT *
        FROM dbo.KhoBanh
        WHERE maBanh = @maBanh
    END
    ELSE IF (@StatementType = 'INSERT')
    BEGIN
        INSERT INTO dbo.KhoBanh (tenBanh, soLuongTon, soLuongXuat, soLuongVao, soBanhHong)
        VALUES (@tenBanh, @soLuongTon, @soLuongXuat, @soLuongVao, COALESCE(@soBanhHong, 0))
    END
    ELSE IF (@StatementType = 'UPDATE')
    BEGIN
        UPDATE dbo.KhoBanh
        SET tenBanh = @tenBanh,
            soLuongTon = @soLuongTon,
            soLuongXuat = @soLuongXuat,
            soLuongVao = @soLuongVao,
            soBanhHong = COALESCE(@soBanhHong, 0)
        WHERE maBanh = @maBanh
    END
    ELSE IF (@StatementType = 'DELETE')
    BEGIN
        DELETE FROM dbo.KhoBanh
        WHERE maBanh = @maBanh
    END
END
--EXEC dbo.NhanVien_CRUD 'INSERT', NULL, 'Phu', '1234', 0
insert into Tai_khoan values
('admin1', 'admin1', 1),
('admin2', 'admin2', 1),
('admin3', 'admin3', 1)


insert into KhoBanh values 
(N'Bông lan', 50, 15, 68, 3),
(N'Bông lan trứng muối', 50, 15, 68, 3),
(N'Bánh mì', 50, 15, 68, 3),
(N'Bánh sừng bò', 50, 15, 68, 3),
(N'Chocolate Donut', 80, 15, 97, 2),
(N'Saugase Boat', 50, 15, 68, 3),
(N'Blue Berry Custard', 50, 15, 68, 3),
(N'Double Cheese', 60, 15, 76, 1),
(N'Cocoa Teddy', 50, 15, 68, 3),
(N'Get Cheesy', 20, 15, 38, 3),
(N'Fire Floss', 50, 15, 68, 3),
(N'Floss', 30, 15, 48, 3),
(N'Bánh mì truyền thống', 100, 15, 118, 3),
(N'Japan Light Cheese', 10, 15, 28, 3),
(N'SR Choccolate Slided', 50, 15, 68, 3)
