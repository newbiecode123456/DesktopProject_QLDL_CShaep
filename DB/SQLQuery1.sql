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
	PRIMARY KEY (MaPhim, MaRap, NgayChieu)
	foreign key (MaPhim) references Phim(MaPhim),
	foreign key (MaRap) references Rap(MaRap)
)
--alter table LichChieu alter column ChuoiMaSuat varchar(100)
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

create proc USP_GetPhimbyMaPhim 
@MaPhim varchar(10)
as begin
	select * from Phim where MaPhim=@MaPhim
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

create proc USP_GetAllTheLoaiPhuoffPhim 
@MaPhim varchar(10)
as begin 
	select * from TheLoai as TL,PhimTheLoaiPhu as PTLP
	where TL.MaTheLoai = PTLP.MaTheLoai and MaPhim = 'P0001'@MaPhim
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

create proc USP_GetAllRapofCumRap 
@MaCum varchar(5)
as begin
	select * from Rap where MaCum= @MaCum
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

-- USP of PhimTheLoaiPhuDAO
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

alter proc USP_CheckorUncheckPhimTheLoaiPhu 
@MaPhim varchar(10), @MaTheLoai varchar(5)
as begin
	declare @kt int = 0
	select @kt = count(*) from PhimTheLoaiPhu where MaPhim=@MaPhim and MaTheLoai=@MaTheLoai
	if(@kt>0)
	begin
		delete PhimTheLoaiPhu where MaPhim=@MaPhim and MaTheLoai=@MaTheLoai
	end
	else
	begin
		insert PhimTheLoaiPhu(MaPhim,MaTheLoai) values(@MaPhim,@MaTheLoai)
	end
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

create proc USP_DeleteKeHoachofPhim 
@MaPhim varchar(10)
as begin
	delete KeHoach
	where MaPhim=@MaPhim
end
go


-- USP of LichChieuDAO
create proc USP_GetAllLichChieu
as begin
	select * from LichChieu
end
go

create proc USP_InsertLichChieu 
@MaPhim varchar(10), @MaRap varchar(5), @NgayChieu DateTime, @ChuoiMaSuat varchar(100)
as begin
	insert LichChieu(MaPhim,MaRap,NgayChieu,ChuoiMaSuat)
	values(@MaPhim,@MaRap,@NgayChieu,@ChuoiMaSuat)
end
go

create proc USP_UpdateLichChieu 
@MaPhim varchar(10), @MaRap varchar(5), @NgayChieu DateTime, @ChuoiMaSuat varchar(100)
as begin
	update LichChieu
	set ChuoiMaSuat =@ChuoiMaSuat
	where MaPhim = @MaPhim and MaRap=@MaRap and NgayChieu=@NgayChieu
end 
go

create proc USP_DeleteLichChieu 
@MaPhim varchar(10), @MaRap varchar(5), @NgayChieu DateTime
as begin
	delete LichChieu
	where MaPhim = @MaPhim and MaRap=@MaRap and NgayChieu=@NgayChieu
end
go

create proc USP_CheckExistLichChieu 
@MaRap varchar(5), @NgayChieu DateTime
as begin
	select count(*) from LichChieu where MaRap=@MaRap and NgayChieu=@NgayChieu
end
go

create proc USP_CheckIfExistLichChieu
@MaRap varchar(5), @NgayChieu DateTime, @ChuoiMaSuat varchar(3)
as begin
	select count(*) from LichChieu where MaRap=@MaRap and NgayChieu=@NgayChieu and ChuoiMaSuat like '%'+@ChuoiMaSuat+'%'
end
go

create proc USP_DeleteLichChieuofPhim 
@MaPhim varchar(10)
as begin
	delete LichChieu
	where MaPhim =@MaPhim
end
go

create proc USP_DeleteLichChieuofRap 
@MaRap varchar(5)
as begin
	delete LichChieu
	where MaRap=@MaRap
end
go
-- USP of SuatChieuDAO
create proc USP_GetAllSuatChieu
as begin
	select * from SuatChieu
end
go

alter proc USP_InsertSuatChieu 
@MaSuat varchar(5),@GioBatDau int , @PhutBatDau int
as begin
	declare @kt int
	select @kt = count(*) from SuatChieu where GioBatDau=@GioBatDau or GioBatDau=@GioBatDau+1
	if(@kt > 0)
	begin 
		update SuatChieu
		set GioBatDau=@GioBatDau,PhutBatDau=@PhutBatDau
		where MaSuat = @MaSuat
	end
	else
	begin
		insert SuatChieu(MaSuat,GioBatDau,PhutBatDau)
		values(@MaSuat,@GioBatDau,@PhutBatDau)
	end
end
go

create proc USP_UpdateSuatChieu 
@MaSuat varchar(3), @GioBatDau int , @PhutBatDau int
as begin
	update SuatChieu
	set GioBatDau=@GioBatDau,PhutBatDau=@PhutBatDau
	where MaSuat=@MaSuat
end
go

create proc USP_DeleteSuatChieu 
@MaSuat varchar(3)
as begin
	delete SuatChieu
	where MaSuat=@MaSuat
end
go

-- USP of TongThoiLuongofMaCum
create proc USP_GetAllTongThoiLongofCum
as begin
	select KH.MaCum,sum(P.ThoiLuong) as "TongThoiLuong"
	from Phim as P,KeHoach as KH
	where P.MaPhim = KH.MaPhim
	group by KH.MaCum
end
go

create proc USP_GetTongThoiLongbyMaCum 
@MaCum varchar(5)
as begin
select KH.MaCum,sum(P.ThoiLuong) as "TongThoiLuong"
from Phim as P,KeHoach as KH
where P.MaPhim = KH.MaPhim and KH.MaCum = @MaCum --'CR001'
group by KH.MaCum
end 
go

-- USP of TongThoiLuongofMaRap
-- Cần lấy ra Rạp X nào đó vào 1 ngày cụ thể có thời lượng chiếu là bao nhiêu
-- để so sánh với tổng thời gian chiếu trong ngày


create proc intGetTongThoiLuongbyMaRap 
@MaRap varchar(5), @NgayChieu DateTime
as begin
	select LC.MaRap,sum(P.ThoiLuong) as "TongThoiLuong"
	from Phim as P,LichChieu as LC
	where P.MaPhim = LC.MaPhim and LC.NgayChieu=@NgayChieu and LC.MaRap=@MaRap
	group by LC.MaRap
end
go


select * from Phim
select * from LichChieu



-- USP of CumRapRapDAO
select R.MaCum,CR.TenCum,CR.DiaChi,R.MaRap,R.TongGhe
from CumRap as CR,Rap as R 
where CR.MaCum=R.MaCum and CR.MaCum='CR001'

select CR.MaCum,CR.TenCum,sum(TongGhe) as 'TongSoGhe'
from CumRap as CR,Rap as R 
where CR.MaCum=R.MaCum
group by CR.MaCum,CR.TenCum


-- USP of ThoiLuongPhim vs CumRap
select * 
from Phim as P,CumRap as CR,KeHoach as KH
where P.MaPhim = KH.MaPhim and CR.MaCum=KH.MaCum

select * 
from Phim as P,CumRap as CR,KeHoach as KH
where P.MaPhim = KH.MaPhim and CR.MaCum=KH.MaCum and KH.MaCum = 'CR001'



-- trigger of SuatChieu
delete trigger UTG_ChuoiMaSuat
on SuatChieu
instead of insert
as 
declare @MaSuat varchar(3),@GioBatDau int,@PhutBatDau int
select @MaSuat=@MaSuat,@GioBatDau=GioBatDau,@PhutBatDau=PhutBatDau
from inserted
insert into SuatChieu values(@MaSuat,@GioBatDau,@PhutBatDau)
go

INSERT INTO SuatChieu(GioBatDau,PhutBatDau) VALUES (4,20)
select * from SuatChieu


