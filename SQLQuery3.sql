

TAIKHOAN(MATK, TENDANGNHAP, MATKHAU)
NHANVIEN(MANV, TENNV, NAMSINH, DIACHI, SDT, MATK)
KHOA(MAKHOA, TENKHOA, CHUYENMON, SLBACSI)
BACSI(MABS, TENBS, NAMSINH, DIACHI, SDT, HOCHAM, MAKHOA)   
BENHNHAN(MABN, TENBN, NAMSINH, GIOITINH, SDT, EMAIL, DIACHI)
PHIEUDATLICH(MAPHIEUDL, NGAYLAPPHIEU, MANV, MABN)
CTPHIEUDATLICH(MAPHIEUDL, MABS , DAKHAMTAI, LYDO, TINHTRANG)

CREATE DATABASE QL_DAT_LICH_KHAM_BENH
GO

USE QL_DAT_LICH_KHAM_BENH
GO

CREATE TABLE TAIKHOAN(
    MATK NCHAR(20) PRIMARY KEY,
	TENDANGNHAP NCHAR(100),
	MATKHAU NCHAR(100),
)

insert into TAIKHOAN values('TK001','HUNG','meomeo')
insert into TAIKHOAN values('TK002','THUY','meomeo')
insert into TAIKHOAN values('TK003','THINH','meomeo')
insert into TAIKHOAN values('TK004','HIEU','meomeo')

CREATE TABLE NHANVIEN(
    MANV NCHAR(20) PRIMARY KEY ,
    TENNV NVARCHAR(200),
    NAMSINH INT,
    DIACHI NVARCHAR(200),
    SDT CHAR(20),
    MATK NCHAR(20) UNIQUE FOREIGN KEY REFERENCES TAIKHOAN,
)
insert into NHANVIEN values('NV01',N'Nguyễn Duy Hùng',2002,N'48 Đường 30, P.Linh Đông, TP Thủ Đức',0854345453,'TK001')
insert into NHANVIEN values('NV02',N'Nguyễ Trọng Thuỷ',2002,N'172 Đường 18, Phường 7, Q.Gò Vấp, TP HCM',0982745678,'TK002')
insert into NHANVIEN values('NV03',N'Nguyễn Quốc Thịnh',2002,N'29 Đường 32, P.Linh Xuân, TP Thủ Đức',0857345234,'TK003')
insert into NHANVIEN values('NV04',N'Trần Phúc Hiếu',2002,N'29 Đường 32, P.Linh Xuân, TP Thủ Đức',085734234,'TK004') 

CREATE TABLE KHOA(
    MAKHOA NCHAR(20) PRIMARY KEY ,
    TENKHOA NVARCHAR(200),
    CHUYENMON NVARCHAR(200),
    SLBACSI INT,
)
insert into KHOA values('KHNHI',N'Khoa nhi',N'Khám và điều trị bệnh nhi',3)
insert into KHOA values('KHNGOAI',N'Khoa ngoại',N'Khám và điều trị chấn thương chỉnh hình',3)
insert into KHOA values('KHNOI',N'Khoa nội',N'Khám và điều trị nội thần kinh, nội hô hấp, nội tim mạch, nội tiêu hóa - gan mật , cơ xương khớp',2)

CREATE TABLE BACSI(
    MABS NCHAR(20) PRIMARY KEY ,
    TENBS NVARCHAR(200),
    NAMSINH INT,
    DIACHI NVARCHAR(200),
    SDT CHAR(20),
    HOCHAM NVARCHAR(200),
    MAKHOA NCHAR(20)FOREIGN KEY REFERENCES KHOA,
)
insert into BACSI values('BS01',N'Trần Minh Nhật',1980,N'38/55 Đường số 1, P.Trường Thọ, TP Thủ Đức',0989999888,N'Bác sĩ chuyên khoa I','KHNHI')
insert into BACSI values('BS02',N'Nguyễn Minh Dũng',1972,N'32 Đường số 2, P.Hiệp Bình Chánh, TP Thủ Đức',0858456743,N'Bác sĩ chuyên khoa II','KHNHI')
insert into BACSI values('BS03',N'Phạm Gia Nguyên',1982,N'38/55 Đường số 1, P.Trường Thọ, TP Thủ Đức',0945634546,N'Bác sĩ chuyên khoa I','KHNHI')
insert into BACSI values('BS04',N'Nguyễn Văn An',1970,N'23 Đường 18, P.Linh Đông, TP Thủ Đức',0982768574,N'Bác sĩ chuyên khoa II','KHNGOAI')
insert into BACSI values('BS05',N'Lê Văn Thắng',1990,N'70 Đường số 7, P.Linh Xuân, TP Thủ Đức',0858463746,N'Bác sĩ Thực Tập','KHNGOAI')
insert into BACSI values('BS06',N'Lê Văn Hoàng',1980,N'38/55 Đường số 1, P.Trường Thọ, TP Thủ Đức',0989999888,N'Bác sĩ chuyên khoa I','KHNGOAI')
insert into BACSI values('BS07',N'Trương Công Quốc Nhật',1987,N'32 Đường số 2, P.Hiệp Bình Chánh, TP Thủ Đức',0989999888,N'Bác sĩ chuyên khoa I','KHNOI')
insert into BACSI values('BS08',N'Lê Việt Đức',1979,N'135 Nguyễn Xí, Phường 25, Q.Bình Thạnh, TP HCM',0989999888,N'Bác sĩ chuyên khoa II','KHNOI')

CREATE TABLE BENHNHAN(
    MABN INT IDENTITY(0001,1) PRIMARY KEY ,
    TENBN NVARCHAR(200) NOT NULL,
    NAMSINH INT ,
    GIOITINH BIT,
    EMAIL NVARCHAR(200) NOT NULL,
    SDT CHAR(20) NOT NULL,
    DIACHI NVARCHAR(200),
)


CREATE TABLE PHIEUDATLICH(
    MAPHIEUDL INT IDENTITY(0001,1) PRIMARY KEY ,
    NGAYLAPPHIEU DATETIME,
    MANV NCHAR(20) FOREIGN KEY REFERENCES NHANVIEN,
    MABN INT FOREIGN KEY REFERENCES BENHNHAN,
)

CREATE TABLE CTPHIEUDATLICH(
    MAPHIEUDL INT FOREIGN KEY REFERENCES PHIEUDATLICH,
    MABS NCHAR(20) FOREIGN KEY REFERENCES BACSI,
    DAKHAMTAI NVARCHAR(100),
    LYDO NVARCHAR(200),
    TINHTRANG BIT, 
	CONSTRAINT PK_CTPHIEUDATLICH PRIMARY KEY(MAPHIEUDL, MABS)

)

