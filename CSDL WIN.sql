create database QuanLyQuanCafe
go

use QuanLyQuanCafe
go

create table TABLESS(
	ID int identity primary key,
	Ten nvarchar(50) Not NULL,
	TrangThai int Not NULL---1:Hoạt động 0:Trống 
)
go

create table ACCOUNTS(
	TenDangNhap nvarchar(50) primary key,
	TenHienThi nvarchar(50) Not NULL,
	MatKhau nvarchar(100) Not NULL,
	GioiTinh nvarchar(4) NOT NULL,
	DiaChi nvarchar(100) Not NULL,
	SDT nvarchar(12) Not NULL,
	Loai int Not NULL -- 1:Admin  0:Nhan Vien
)
go

create table TYPEFOOD(
	ID int identity primary key,
	TenHienThi nvarchar(50) Not NULL
)
go

create table FOOD(
	ID int identity primary key,
	TenHienThi nvarchar(50) Not NULL,
	Loai int NOT NULL,
	Gia float Not NULL default 0
	foreign key (Loai) references dbo.TYPEFOOD(ID)
)
go

create table HOADON(
	ID_HD int identity primary key,
	Checkin date not null default getdate(),
	Chechout date,
	IDBan int not null,
	TongTien float not null

	foreign key (IDBan) references dbo.TABLESS(ID)
)
go

create table CHITIETHOADON(
	ID int identity primary key,
	IDHoaDon int not null,
	IDThucAn int not null,
	SoLuong int not null default 0,
	GiaBan float not null
	foreign key (IDHoaDon) references dbo.HOADON(ID_HD),
	foreign key (IDThucAn) references dbo.FOOD(ID)
)
go
/*Thêm dữ liệu vào database */
/*thêm bảng tài khoản */
INSERT INTO ACCOUNTS (TenDangNhap,TenHienThi,MatKhau,GioiTinh,DiaChi,SDT,Loai)
VALUES ('0306191300@caothang.edu.vn',N'Nguyễn Hoài Chương','NHC300',N'Nam',N'46 Phạm thị Ngư - Phan thiết',N'0947166376',0),
		('0306191338@caothang.edu.vn',N'Huỳnh Tấn Nghĩa','HTN338',N'Nam',N'Quận 6 TPHCM ',N'094',1),
		('0306191298@caothang.edu.vn',N'Ngô Quang Bảo','NQB298',N'Nam',N'Quận 8',N'6376',0)
/* Thêm bảng TYPE FOOD */
INSERT INTO TYPEFOOD (TenHienThi)
VALUES (N'Thức uống'),
		(N'Thức ăn nhẹ')
/* Thêm bảng FOOD */
INSERT INTO FOOD (TenHienThi,Loai,Gia)
VALUES (N'Cafe đen',1,15000),
		(N'Bánh Gato',2,30000),
		(N'Cafe sữa',1,15000),
		(N'Cafe chồn',1,50000),
		(N'Bánh Gấu Matcha',2,25000),
		(N'Bánh chà bông',2,15000),
		(N'Capuchino',1,30000),
		(N'Nước tắc xí muội',1,15000),
		(N'Cafe Culi',1,40000),
		(N'Bánh cá nướng',2,20000),
		(N'Cafe Moka',1,45000),
		(N'Nước Cam ép',1,20000),
		(N'Nước Ngọt',1,15000)

/* Thêm bảng TABLED */
INSERT INTO TABLESS (Ten,TrangThai)
VALUES (N'BÀN 1',0),
		(N'BÀN 2',0),
		(N'BÀN 3',0),
		(N'BÀN 4',0),
		(N'BÀN 5',0),
		(N'BÀN 6',0),
		(N'BÀN 7',0),
		(N'BÀN 8',0),
		(N'BÀN 9',0),
		(N'BÀN 10',0)
