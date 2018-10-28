create database QL_TimViec
go
use QL_TimViec
go

create table account
(
	username nvarchar(100) PRIMARY KEY not null,
	password nvarchar(1000) not null,
	type int not null,
	tinhtrang int,
)
GO

create table KhachHang
(
	makh nvarchar(20) PRIMARY KEY not null,
	tenkh nvarchar(100),
	diachi nvarchar(100),
	sdt nvarchar(20),
	username nvarchar(100),
	foreign key (username) references account(username),
)
Go

create table tuyendung
(
	
	manhatd nvarchar(20) PRIMARY KEY not null,
	tennhatd nvarchar(100),
	diachi nvarchar(100),
	sdt nvarchar(20),
	username nvarchar(100),
	foreign key (username) references account(username),
)
go

create table quantri
(
	
	maqt nvarchar(20) PRIMARY KEY not null,
	tenqt nvarchar(100),
	diachi nvarchar(100),
	sdt nvarchar(20),
	username nvarchar(100),
	foreign key (username) references account(username),
)
go

create table loaicongviec
(
	maloai nvarchar(20) PRIMARY KEY not null,
	tenloai nvarchar(100),
)

create table congviec
(
	macv nvarchar(20) PRIMARY KEY not null,
	tencv nvarchar(100),
	maloai nvarchar(20),
	foreign key (maloai) references loaicongviec(maloai),
)
go

create table baidang
(
	mabd nvarchar(20) PRIMARY KEY not null,
	manhatd nvarchar(20),
	macv nvarchar(20),
	title nvarchar(100),
	image nvarchar(200),
	luong int,
	ngaydang date,
	foreign key (manhatd) references tuyendung(manhatd),
	foreign key (macv) references congviec(macv)
)
go

create table chitietbd
(
	id int identity primary key,
	mabd nvarchar(20) not null,
	title nvarchar(150),
	tencty nvarchar(100),
	yeucau nvarchar(500),
	noidung nvarchar(500),
	foreign key (mabd) references baidang(mabd),
)

create table dangky
(
	id int identity primary key,
	mabd nvarchar(20) not null,
	makh nvarchar(20),
	foreign key (mabd) references baidang(mabd),
	foreign key (makh) references khachhang(makh),
)
go



CREATE FUNCTION func_NextID (@lastID VARCHAR(6	),@prefix VARCHAR(2),@size int)
RETURNS VARCHAR(6)	
AS
BEGIN
	IF(@lastID='')
		SET @lastID = @prefix + REPLICATE(0,@size - LEN(@prefix))
	DECLARE @num_nextUserID INT, @nextUserID VARCHAR(6)
	SET @lastID= LTRIM(RTRIM(@lastID))
	SET @num_nextUserID= REPLACE(@lastID,@prefix,'')+1;
	SET @size= @size- LEN(@prefix)
	SET @nextUserID=@prefix + REPLICATE(0,@size - LEN(@prefix))
	SET @nextUserID= @prefix + RIGHT(REPLICATE(0,@size)+CONVERT(VARCHAR(MAX),@num_nextUserID),@size)
	RETURN @nextUserID
END
GO
--triger congviec
CREATE TRIGGER UTP_Nextmacv ON congviec FOR INSERT
AS
BEGIN
	DECLARE @lastID VARCHAR(6)
	SET @lastID=(SELECT TOP 1 macv FROM dbo.congviec ORDER BY macv DESC)
	UPDATE dbo.congviec SET macv= dbo.func_NextID(@lastID,'cv',6) WHERE macv=''
END
GO
--trigger quản trị
CREATE TRIGGER UTP_qtri ON quantri FOR INSERT
AS
BEGIN
	DECLARE @lastID VARCHAR(6)
	SET @lastID=(SELECT TOP 1 maqt FROM dbo.quantri ORDER BY maqt DESC)
	UPDATE dbo.quantri SET maqt= dbo.func_NextID(@lastID,'QT',6) WHERE maqt=''
END
GO
--Trigger insert Khách hàng
CREATE TRIGGER UTP_NextMaKH ON KhachHang FOR INSERT
AS
BEGIN
	DECLARE @lastID VARCHAR(6)
	SET @lastID=(SELECT TOP 1 makh FROM dbo.KhachHang ORDER BY makh DESC)
	UPDATE dbo.KhachHang SET makh= dbo.func_NextID(@lastID,'KH',6) WHERE makh=''
END
GO
--trigger nhà tuyển dụng
CREATE TRIGGER UTP_NextMaNcc ON tuyendung FOR INSERT
AS
BEGIN
	DECLARE @lastID VARCHAR(6)
	SET @lastID=(SELECT TOP 1 manhatd FROM dbo.tuyendung ORDER BY manhatd DESC)
	UPDATE dbo.tuyendung SET manhatd = dbo.func_NextID(@lastID,'ntd',6) WHERE manhatd =''
END
GO
--Trigger insert baidang
CREATE TRIGGER UTP_NextMabd ON baidang FOR INSERT
AS
BEGIN
	DECLARE @lastID VARCHAR(6)
	SET @lastID=(SELECT TOP 1 mabd FROM dbo.baidang ORDER BY mabd DESC)
	UPDATE dbo.baidang SET mabd = dbo.func_NextID(@lastID,'BD',6) WHERE mabd=''
END
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'aâdêôouà?ã?á??????????è???é????? ì?i?íò?õ?ó??????????ù?u?ú?????????ý AÂÐÊÔOUÀ?Ã?Á??????????È???É?????Ì?I?Í Ò?Õ?Ó??????????Ù?U?Ú?????????Ý' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
go
--insert baidang
create Proc USP_Insertbaidang
@manhatd varchar(10),@macv varchar(10),@tittle nvarchar(100),@image nvarchar(200)
as
begin
	insert baidang(mabd,manhatd,macv,title,image,luong,ngaydang) values ('',@manhatd,@macv,@tittle,@image,0,GETDATE())
end
go



--thêm accounts
insert into account values('tung','123',9,1)
insert into account values('sontung','123',0,0)
insert into account values('hien','123',1,1)
insert into account values('duc','123',1,1)
insert into account values('phat','123',2,1)
insert into account values('tien','123',2,0)
go
--thêm khách hàng
insert into KhachHang values ('kh01',N'tùng',N'525 lê trọng tấn','0363064268','tung')
insert into KhachHang values ('kh02',N'Hiền',N'Tân phú','0363064268','hien')
insert into KhachHang values ('kh03',N'Đức',N'Bình hưng hòa','0363064268','duc')
go
--thêm tuyển dụng
insert into tuyendung values ('td01',N'cty nam hải','140 lê trọng tấn','0328456789','phat')
insert into tuyendung values ('td02',N'Nhà tuyển dụng','525 lũy bán bích','0312345678','tien')
go
--thêm quản trị
insert into quantri values ('qt01',N'Sơn Tùng','525 lê trọng tấn','0328456789','phat')
insert into quantri values ('qt02',N'quản trị','525 lũy bán bích','0312345678','tien')
go
--thêm loại công viêc
insert into loaicongviec values ('l01','Partime')
insert into loaicongviec values ('l02','Fulltime')
go
--thêm công việc
insert into congviec values ('cv01',N'phục vụ','l01')
insert into congviec values ('cv02',N'Bán hàng','l01')
insert into congviec values ('cv03',N'phát tờ rơi','l01')
insert into congviec values ('cv04',N'lập trình viên','l02')
insert into congviec values ('cv05',N'Nhân viên văn phòng','l02')
insert into congviec values ('cv06',N'nhân viên kế toán','l02')
go
--thêm bảng tin
insert into baidang values ('bd01','td01','cv01',N'Phục vụ tiệc cưới lương cao','',240000,'2018/10/22')
insert into baidang values ('bd02','td02','cv02',N'Bán hàng theo lịch học','',3000000,'2018/10/22')
insert into baidang values ('bd03','td02','cv03',N'phát tờ rơi tại ngã tư','',100000,'2018/10/22')
insert into baidang values ('bd04','td02','cv04',N'Lâp trình win dow','',15000000,'2018/10/22')
insert into baidang values ('bd05','td02','cv05',N'Nhân viên văn phòng','',5000000,'2018/10/22')
insert into baidang values ('bd06','td01','cv06',N'Nhân viên văn phòng','',9000000,'2018/10/22')
go
--thêm chi tiết bảng tin
insert into chitietbd values ('bd01',N'Phục vụ tiệc cưới lương cao','Công ty Nam Hải','Làm việc siêng năng, nhiệt tình','Phục vụ nhà hàng tiệc cưới,quán ăn')
insert into chitietbd values ('bd02',N'bán hàng lương cao theo ca','shop hoa anh đào','Làm việc siêng năng, nhiệt tình','bán quần áo')
insert into chitietbd values ('bd03',N'phát tờ rơi lương liền','công ty địa ốc','Làm việc siêng năng, nhiệt tình','phát tờ rơi tại các ngã tư')
insert into chitietbd values ('bd04',N'lập trình phần mềm','Bosch','Làm việc siêng năng, nhiệt tình','có kỹ năng code, tư duy tốt')
insert into chitietbd values ('bd05',N'Nhân viên văn phòng','Công ty Bảo việc','Làm việc siêng năng, nhiệt tình','Soạn thảo, lên lịch làm việc, báo cáo thống kê')
insert into chitietbd values ('bd06',N'Nhân viên kinh doanh làm việc theo tháng','Công ty xây dưng thịnh phát','Làm việc siêng năng, nhiệt tình','sale online, có laptop')
go