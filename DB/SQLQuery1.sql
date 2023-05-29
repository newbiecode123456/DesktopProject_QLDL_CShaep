create database QuanLyDuLieu
go
use QuanLyDuLieu
go
-- CumRap (MaCum varchar(5), TenCum nvarchar(50), DiaChi nvarchar(100))
create table CumRap
(
	MaCum varchar(5) primary key,
	TenCum nvarchar(50) not null default N'Không tên',
	DiaChi nvarchar(100) not null default N'Không rõ địa chỉ'
)
go
--Rap (MaRap varchar(5), TongGhe int, MaCum varchar(5)) TongGhe: là tổng số chổ ngồi
create table Rap
(
	MaRap varchar(5) primary key,
	TongGhe int not null default 0,
	MaCum varchar(5) not null
	foreign key (MaCum) references CumRap(MaCum)
)
go
-- TheLoai (MaTheLoai varchar(5), TenTheLoai nvarchar(50))
create table TheLoai
(
	MaTheLoai varchar(5) primary key,
	TenTheLoai nvarchar(50) not null default N'Không tên'
)
go
-- Phim (MaPhim varchar(10), TenPhim nvarchar(50), MaTheLoaiChinh varchar(5), ThoiLuong int)
create table Phim
(
	MaPhim varchar(10) primary key,
	TenPhim nvarchar(50) not null default N'Không tên',
	MaTheLoaiChinh varchar(5) not null,
	ThoiLuong int not null default 0,
	foreign key (MaTheLoaiChinh) references TheLoai(MaTheLoai)
)
go
-- PhimTheLoaiPhu (MaPhim varchar(10), MaTheLoai varchar(5))
create table PhimTheLoaiPhu
(
	MaPhim varchar(10),
	MaTheLoai varchar(5) 
	PRIMARY KEY (MaPhim, MaTheLoai)
	foreign key (MaPhim) references Phim(MaPhim),
	foreign key (MaTheLoai) references TheLoai(MaTheLoai)
)
go
--KeHoach (MaPhim varchar(10), MaCum varchar(5), NgayKhoiChieu date, NgayKetThuc date, GhiChu nvarchar(100))
create table KeHoach
(
	MaPhim varchar(10),
	MaCum varchar(5),
	NgayKhoiChieu date not null default getdate(),
	NgayKetThuc date  not null default getdate(),
	GhiChu nvarchar(100) default N'Không có'
	PRIMARY KEY (MaPhim, MaCum, NgayKhoiChieu,NgayKetThuc)
	foreign key (MaPhim) references Phim(MaPhim),
	foreign key (MaCum) references CumRap(MaCum)
)

-- alter table KeHoach alter column GhiChu nvarchar(100) default N'Không có'
--SuatChieu (MaSuat varchar(3), GioBatDau int, PhutBatDau int)
create table SuatChieu
(
	MaSuat varchar(3) primary key,
	GioBatDau int not null default 0,
	PhutBatDau int not null default 0
)
--LichChieu (MaPhim varchar(10), MaRap varchar(5), NgayChieu date, ChuoiMaSuat nvarchar(100))
create table LichChieu
(
	MaPhim varchar(10),
	MaRap varchar(5),
	NgayChieu date,
	ChuoiMaSuat nvarchar(100)
	PRIMARY KEY (MaPhim, MaRap, NgayChieu,ChuoiMaSuat)
	foreign key (MaPhim) references Phim(MaPhim),
	foreign key (MaRap) references Rap(MaRap)
)
-- Đăng nhập
create table DangNhap
(
	DisplayName nvarchar(100) not null,
	UserName nvarchar(100) not null primary key,
	PassWord nvarchar(1000) not null,
	Type int not null default 0
)
go

-- USP of DangNhapDAO
create proc USP_Login
@userName nvarchar(100),@passWord nvarchar(100)
as begin
	select * from DangNhap
	where UserName = @userName and PassWord = @passWord
end
go

-- USP of PhimDAO
create proc USP_GetAllPhim
as begin
	select * from Phim
end
go

create proc USP_InsertPhim
@MaPhim varchar(10), @TenPhim nvarchar(50), @MaTheLoaiChinh varchar(5),@ThoiLuong int
as begin
	insert Phim(MaPhim,TenPhim,MaTheLoaiChinh,ThoiLuong)
	values(@MaPhim,@TenPhim,@MaTheLoaiChinh,@ThoiLuong)
end
go

create proc USP_DeletePhim
@MaPhim varchar(10)
as begin
	delete Phim
	where MaPhim = @MaPhim
end
go

create proc USP_DeletePhimofTheLoai
@MaTheLoai varchar(5)
as begin
	delete Phim
	where MaTheLoaiChinh = @MaTheLoai
end
go

create proc USP_UpdatePhim
@MaPhim varchar(10), @TenPhim nvarchar(50),@MaTheLoaiChinh varchar(5) , @ThoiLuong int
as begin
	update Phim
	set TenPhim = @TenPhim , MaTheLoaiChinh = @MaTheLoaiChinh , ThoiLuong = @ThoiLuong
	where MaPhim = @MaPhim
end
go
-- USP of TheLoaiDAO
create proc USP_GetAllTheLoaiofPhim
@MaPhim varchar(10)
as begin
	select * from PhimTheLoaiPhu as PTLP,TheLoai as TL
	where PTLP.MaPhim = @MaPhim and PTLP.MaTheLoai = TL.MaTheLoai
end 
go

create proc USP_GetTheLoaiChinhofPhim
@MaTheLoaiChinh varchar(5)
as begin
	select MaTheLoai,TenTheLoai from TheLoai
	where MaTheLoai = @MaTheLoaiChinh
end
go

create proc USP_GetAllTheLoai
as begin
	select * from TheLoai
end
go

create proc USP_InsertTheLoai
@MaTheLoai varchar(5), @TenTheLoai nvarchar(50)
as begin
	insert TheLoai(MaTheLoai,TenTheLoai)
	values(@MaTheLoai,@TenTheLoai)
end
go

create proc USP_DeleteTheLoai
@MaTheLoai varchar(5)
as begin
	delete TheLoai
	where MaTheLoai=@MaTheLoai
end
go

create proc USP_UpdateTheLoai
@MaTheLoai varchar(5), @TenTheLoai nvarchar(50)
as begin
	update TheLoai
	set TenTheLoai = @TenTheLoai
	where MaTheLoai = @MaTheLoai
end
go
-- USP of RapDAO
create proc USP_GetAllRap
as begin
	select * from Rap
end
go

create proc USP_InsertRap
@MaRap varchar(5) , @TongGhe int , @MaCum varchar(5)
as begin
	insert Rap(MaRap,TongGhe,MaCum)
	values(@MaRap,@TongGhe,@MaCum)
end
go

create proc USP_UpdateRap
@MaRap varchar(5) , @TongGhe int , @MaCum varchar(5)
as begin
	update Rap
	set TongGhe = @TongGhe , MaCum = @MaCum
	where MaRap = @MaRap
end
go

create proc USP_DeleteRap
@MaRap varchar(5)
as begin
	delete Rap
	where MaRap = @MaRap
end
go

create proc USP_DeleteRapofCumRap 
@MaCum varchar(5)
as begin
	delete Rap
	where MaCum=@MaCum
end 
go

-- USP of CumRapDAO
create proc USP_InsertCumRap
@MaCum varchar(5) , @TenCum nvarchar(50) , @DiaChi nvarchar(100)
as begin
	insert CumRap(MaCum,TenCum,DiaChi)
	values(@MaCum,@TenCum,@DiaChi)
end
go

create proc USP_UpdateCumRap
@MaCum varchar(5) , @TenCum nvarchar(50) , @DiaChi nvarchar(100)
as begin
	update CumRap
	set TenCum = @TenCum , DiaChi = @DiaChi
	where MaCum = @MaCum
end
go

create proc USP_GetAllCumRap
as begin
	select MaCum,TenCum,DiaChi from CumRap
end
go

create proc USP_GetCumRapofRap
@MaCum varchar(5)
as begin
	Select MaCum,TenCum,DiaChi from CumRap
	where MaCum = @MaCum
end
go

create proc USP_DeleteCumRap 
@MaCum varchar(5)
as begin
	delete CumRap
	where MaCum=@MaCum
end
go

-- USP of MaTheLoaiPhuDAO
create proc USP_DeletePhimTheLoaiPhuofPhim
@MaPhim varchar(5)
as begin
	delete PhimTheLoaiPhu
	where MaPhim = @MaPhim
end
go

create proc USP_DeletePhimTheLoaiPhuofTheLoai
@MaTheLoai varchar(5)
as begin
	delete PhimTheLoaiPhu
	where MaTheLoai = @MaTheLoai
end 
go

-- USP of KeHoachDAO
create proc USP_GetAllKeHoach
as begin
	select * from KeHoach
end
go

create proc USP_InsertKeHoach
@MaPhim varchar(10), @MaCum varchar(5), @NgayKhoiChieu DateTime, @NgayKetThuc DateTime, @GhiChu nvarchar(100)
as begin
	if(@NgayKetThuc > @NgayKhoiChieu)
	begin
		insert KeHoach(MaPhim,MaCum,NgayKhoiChieu,NgayKetThuc,GhiChu)
		values(@MaPhim,@MaCum,@NgayKhoiChieu,@NgayKetThuc,@GhiChu)
	end
end 
go

create proc USP_UpdateKeHoach
@MaPhim varchar(10), @MaCum varchar(5), @NgayKhoiChieu DateTime, @NgayKetThuc DateTime, @GhiChu nvarchar(100)
as begin
	if(@NgayKetThuc > @NgayKhoiChieu)
	begin 
		update KeHoach
		set GhiChu=@GhiChu
		where MaPhim = @MaPhim and MaCum = @MaCum and NgayKhoiChieu=@NgayKhoiChieu and NgayKetThuc=@NgayKetThuc
	end
end
go

create proc USP_DeleteKeHoach
@MaPhim varchar(10), @MaCum varchar(5), @NgayKhoiChieu DateTime, @NgayKetThuc DateTime
as begin
	delete KeHoach
	where MaPhim = @MaPhim and MaCum = @MaCum and NgayKhoiChieu=@NgayKhoiChieu and NgayKetThuc=@NgayKetThuc 
end
go

-- USP of LichChieuDAO
create proc USP_GetAllLichChieu
as begin
	select * from LichChieu
end
go

select * from Rap