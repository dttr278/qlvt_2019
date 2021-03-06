USE [QL_VATTU]
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 04/24/2017 09:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOTAIKHOAN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'QL_VATTU'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END

  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE = 'CONGTY'  OR @ROLE = 'CHINHANH' 
  BEGIN
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
      EXEC sp_addsrvrolemember @LGNAME, 'DBCREATOR'
  END
 
RETURN 0  -- THANH CONG
GO
/****** Object:  Table [dbo].[VATTU]    Script Date: 04/24/2017 09:47:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATTU](
	[MAVT] [nchar](10) NOT NULL,
	[TENVT] [nvarchar](50) NOT NULL,
	[DVT] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_VATTU] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TENVT] ON [dbo].[VATTU] 
(
	[TENVT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT]) VALUES (N'MX01      ', N'Máy giặt tự động cửa trước', N'cái')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT]) VALUES (N'MX02      ', N'Máy giặt tự động cửa trên  Inox 6,5kg', N'cái')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT]) VALUES (N'MX07      ', N'Máy lạnh Daikin 1 ngựa', N'cái')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT]) VALUES (N'TV02      ', N'TiVi 25'' 2 loa ky thuật số LG', N'cái')
/****** Object:  View [dbo].[V_CacPhanManh]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_CacPhanManh]
AS
SELECT TENCN=Pub.description , Servername=subscriber_server 
FROM dbo.sysmergepublications Pub,  
 dbo.sysmergesubscriptions Sub 
WHERE  PUB.pubid=SUB.pubid
GO
/****** Object:  Table [dbo].[CHINHANH]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHINHANH](
	[MACN] [nchar](10) NOT NULL,
	[CHINHANH] [nvarchar](100) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SoDT] [nvarchar](15) NULL,
 CONSTRAINT [PK_CHINHANH] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHINHANH] ([MACN], [CHINHANH], [DIACHI], [SoDT]) VALUES (N'CN1       ', N'Chi nhánh 1 TP HCM', N'35 Trần Hưng Đạo P1 Q1 TP HCM', N'999111888')
INSERT [dbo].[CHINHANH] ([MACN], [CHINHANH], [DIACHI], [SoDT]) VALUES (N'CN2       ', N'Chi nhánh 2 TP Cần Thơ ', N'255 Nguyễn Huệ P1 Q1', N'888444777')
INSERT [dbo].[CHINHANH] ([MACN], [CHINHANH], [DIACHI], [SoDT]) VALUES (N'CN3       ', N'Chi nhánh 3', N'111 ABC', N'081234567')
/****** Object:  Table [dbo].[KHO]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[MAKHO] [nchar](10) NOT NULL,
	[TENKHO] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[MACN] [nchar](10) NOT NULL,
 CONSTRAINT [PK_KHO] PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [DIACHI], [MACN]) VALUES (N'K01CN1    ', N'KHO A', N'28-30 Ngô Quyền P1 Q5', N'CN1       ')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [DIACHI], [MACN]) VALUES (N'K01CN2    ', N'KHO D', N'123 LÊ LỢI, TPCẦN THƠ', N'CN2       ')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [DIACHI], [MACN]) VALUES (N'K02CN1    ', N'KHO B', N'78 Nguyen Trai, TPHCM', N'CN1       ')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [DIACHI], [MACN]) VALUES (N'K02CN2    ', N'CONG NGHIEP', N'555 Trần Hưng đạo', N'CN2       ')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [DIACHI], [MACN]) VALUES (N'K03CN1    ', N'KHO C', N'123, 3 tháng 2, TPHCM', N'CN1       ')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [DIACHI], [MACN]) VALUES (N'K03CN2    ', N'LONG PHU', N'127 Ngô Thì Nhậm', N'CN1       ')
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[PHAI] [nchar](4) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [smalldatetime] NOT NULL,
	[LUONG] [float] NOT NULL,
	[MACN] [nchar](10) NOT NULL,
	[HINH] [nvarchar](255) NULL,
	[GHICHU] [nvarchar](100) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TENNV] ON [dbo].[NHANVIEN] 
(
	[TEN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (2, N'PHAM DAN ', N'TRUONG', N'Nam ', N'200 Kỳ Đồng', CAST(0x6D260000 AS SmallDateTime), 9000000, N'CN2       ', N'E:\CSDL_PT\CT_QLVT\Hinh\DanTruong.jpg', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (4, N'NGUYEN THINH ', N'PHONG', N'Nam ', N'157 Dương Bá Trạc P1 Q8', CAST(0x79D00000 AS SmallDateTime), 10000000, N'CN2       ', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (5, N'THI NGOC', N'LAN', N'Nu  ', N'999, 3 tháng 2 P6 Q10 TPHCM ', CAST(0x7A9F0000 AS SmallDateTime), 10000000, N'CN1       ', N'E:\CSDL_PT\CT_QLVT\Hinh\ChauNgocLan.BMP', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (6, N'TRINH THI CAM', N'LY', N'Nu  ', N'46 Lê Lợi Q1,TP.HCM', CAST(0x7A2B0000 AS SmallDateTime), 8000000, N'CN2       ', N'E:\CSDL_PT\CT_QLVT\Hinh\CamLy.jpg', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (7, N'QUACH THI LAN', N'ANH', N'Nu  ', N'12 Lê Lợi P1 Q1 TP HCM', CAST(0x78730000 AS SmallDateTime), 9000000, N'CN1       ', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (8, N'CO THI', N'LAC', N'Nam ', N'123 MaCao,Trung Quốc', CAST(0x720B0000 AS SmallDateTime), 10000000, N'CN2       ', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (11, N'LÊ VĂN', N'AN', N'NAM ', NULL, CAST(0x8FE70000 AS SmallDateTime), 10000000, N'CN1       ', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [LUONG], [MACN], [HINH], [GHICHU]) VALUES (13, N'HOÀNG VĂN', N'ANH', N'NAM ', NULL, CAST(0x63DF0000 AS SmallDateTime), 12000000, N'CN3       ', NULL, NULL)
/****** Object:  StoredProcedure [dbo].[sp_TimNV]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TimNV]
  @X INT
AS
 DECLARE @MACN NVARCHAR(10), @HO NVARCHAR(50), @TEN NVARCHAR(10)
  if exists(select manv from  nhanvien where manv =@X)
 BEGIN
     
   	SELECT  @MACN = MACN,  @HO=HO, @TEN=TEN 
   	FROM NHANVIEN WHERE MANV=@X
       
   select tenCN= (SELECT  CHINHANH FROM CHINHANH WHERE MACN=@MACN),      		
          HO=@HO, TEN=@TEN
END
 else
    if exists(select manv from  link1.ql_VATTU.dbo.nhanvien where manv =@X)
     select TENCN = CHINHANH,  ho, ten
        from link1.ql_VATTU.dbo.CHINHANH CN, 
        link1.ql_VATTU.dbo.NHANVIEN NV
           where CN.MACN=NV.MACN  and  NV.MANV=@X
   
ELSE
      	raiserror ( 'Ma nhan vien ban tim khong co', 16, 0)
GO
/****** Object:  StoredProcedure [dbo].[SP_DSNV]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DSNV]
 AS
 SELECT * FROM 
  ( SELECT MANV, HOTEN= HO+TEN, TENCN = (SELECT CHINHANH FROM CHINHANH )
    FROM NHANVIEN  
   UNION 
    SELECT MANV, HOTEN= HO+TEN, TENCN = (SELECT CHINHANH FROM LINK1.QL_VATTU.DBO.CHINHANH )
     FROM LINK1.QL_VATTU.DBO.NHANVIEN  
   ) DSNV
  ORDER BY TENCN, MANV
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
   NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
GO
/****** Object:  Table [dbo].[PHATSINH]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHATSINH](
	[PHIEU] [nchar](10) NOT NULL,
	[NGAY] [smalldatetime] NOT NULL,
	[LOAI] [nchar](1) NOT NULL,
	[HOTENKH] [nvarchar](50) NOT NULL,
	[MANV] [int] NOT NULL,
	[LYDO] [nvarchar](100) NULL,
	[MAKHO] [nchar](10) NULL,
 CONSTRAINT [PK_PHATSINH] PRIMARY KEY CLUSTERED 
(
	[PHIEU] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0001CN2  ', CAST(0x99310000 AS SmallDateTime), N'N', N'TRỊNH Y KIỆN', 4, N' ', N'K01CN2    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0002CN1  ', CAST(0x99320000 AS SmallDateTime), N'N', N'LÊ HOÀNG KHANG', 8, N' ', N'K01CN2    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0002CX3  ', CAST(0x99320000 AS SmallDateTime), N'X', N'CHÂU TINH TRÌ', 8, N' ', N'K01CN2    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0003CX1  ', CAST(0x99310000 AS SmallDateTime), N'X', N'LÂM TÂM NHƯ', 5, N' ', N'K01CN1    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0003CX2  ', CAST(0x99320000 AS SmallDateTime), N'X', N'TRIỆU VI', 5, N' ', N'K01CN1    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0004CN1  ', CAST(0x99320000 AS SmallDateTime), N'N', N'LÝ HỒ VÂN', 2, N' ', N'K02CN2    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0005CN1  ', CAST(0x99550000 AS SmallDateTime), N'N', N'CHÂU BÁ THÔNG', 2, N'Cấp kinh phí', N'K02CN2    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0005CN3  ', CAST(0x99500000 AS SmallDateTime), N'N', N'TRỊNH NGUYÊN LÂN', 8, N' ', N'K02CN2    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0006CN1  ', CAST(0x99550000 AS SmallDateTime), N'N', N'TRẦN ĐĂNG KHOA', 7, N'Tra tiền', N'K01CN1    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0006CN3  ', CAST(0x99320000 AS SmallDateTime), N'N', N'LÂM Y THẦN', 6, N' ', N'K02CN2    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0007CN1  ', CAST(0xA69B0000 AS SmallDateTime), N'N', N'KVL', 5, NULL, N'K01CN1    ')
INSERT [dbo].[PHATSINH] ([PHIEU], [NGAY], [LOAI], [HOTENKH], [MANV], [LYDO], [MAKHO]) VALUES (N'P0007CN2  ', CAST(0x996F0000 AS SmallDateTime), N'N', N'LƯU ĐỨC HOÀ', 6, N' ', N'K01CN2    ')
/****** Object:  Table [dbo].[CT_PHATSINH]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHATSINH](
	[PHIEU] [nchar](10) NOT NULL,
	[MAVT] [nchar](10) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[trigia]  AS ([soluong]*[dongia]),
 CONSTRAINT [PK_CT_PHATSINH] PRIMARY KEY CLUSTERED 
(
	[PHIEU] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0001CN2  ', N'MX01      ', 5, 60)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0001CN2  ', N'MX02      ', 10, 50)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0002CN1  ', N'TV02      ', 5, 30)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0002CX3  ', N'MX07      ', 3, 50)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0003CX1  ', N'MX07      ', 1, 60)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0003CX2  ', N'MX02      ', 7, 60)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0006CN1  ', N'MX01      ', 5, 60)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0006CN1  ', N'MX02      ', 10, 60)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0006CN1  ', N'MX07      ', 20, 60)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0007CN1  ', N'MX02      ', 10, 60)
INSERT [dbo].[CT_PHATSINH] ([PHIEU], [MAVT], [SOLUONG], [DONGIA]) VALUES (N'P0007CN2  ', N'MX07      ', 5, 40)
/****** Object:  StoredProcedure [dbo].[SP_DSPX_NVLAP_TRONGNGAY]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DSPX_NVLAP_TRONGNGAY]
@MANV INT, @NGAY NVARCHAR (10)
AS
SET DATEFORMAT DMY
IF EXISTS (SELECT MANV FROM NHANVIEN WHERE MANV= @MANV )
  SELECT PHIEU, NGAY=@NGAY , 
        HOTENNV= (SELECT HO+ ' ' +TEN FROM NHANVIEN WHERE MANV= @MANV), 
        THANHTIEN
    FROM PHATSINH WHERE LOAI ='X' AND MANV= @MANV AND NGAY = @NGAY 
     
    
        
 ELSE
 IF EXISTS (SELECT MANV FROM L1.QL_VATTU.DBO.NHANVIEN WHERE MANV= @MANV )
  SELECT PHIEU, NGAY=@NGAY , 
        HOTENNV= (SELECT HO+ ' ' +TEN FROM L1.QL_VATTU.DBO.NHANVIEN WHERE MANV= @MANV), 
        THANHTIEN
    FROM L1.QL_VATTU.DBO.PHATSINH 
    WHERE LOAI ='X' AND MANV= @MANV AND NGAY = @NGAY 
     
 ELSE
  RAISERROR ('Ma NV khong ton tai', 16, 1)
GO
/****** Object:  StoredProcedure [dbo].[SP_DOANHTHU_TUNGTHANG_TRONGNAM]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DOANHTHU_TUNGTHANG_TRONGNAM]
@NAM INT
AS
SELECT  TENCN=(SELECT CHINHANH FROM CHINHANH),
  THANG= MONTH(NGAY), NAM = @NAM ,
  DOANHSO=SUM(THANHTIEN)
  FROM PHATSINH 
  WHERE LOAI ='X' AND YEAR (NGAY) =@NAM
  GROUP BY MONTH(NGAY)
UNION
SELECT  TENCN=(SELECT CHINHANH FROM LINK1.QL_VATTU.DBO.CHINHANH),
  THANG= MONTH(NGAY), NAM = @NAM ,
  DOANHSO=SUM(THANHTIEN)
  FROM LINK1.QL_VATTU.DBO.PHATSINH 
  WHERE LOAI ='X' AND YEAR (NGAY) =@NAM
  GROUP BY MONTH(NGAY)
GO
/****** Object:  StoredProcedure [dbo].[SP_THONGKEXUATHANG]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THONGKEXUATHANG]
@SOCACPX INT OUTPUT
AS
BEGIN
  SELECT NV.MANV, HO, TEN, 
    DOANHSO =SUM(THANHTIEN )
    FROM PHATSINH PS, NHANVIEN NV
    WHERE LOAI='X' AND PS.MANV=NV.MANV 
    GROUP BY NV.MANV, HO, TEN
  SELECT @SOCACPX= COUNT (PHIEU)
    FROM PHATSINH WHERE LOAI='X'
  RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_THONG_TIN_PHIEU]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THONG_TIN_PHIEU]
@PHIEU NVARCHAR (10) 
AS
  SET DATEFORMAT DMY
   DECLARE @MANV INT
   DECLARE @HOTENNV NVARCHAR(100)
   DECLARE @LOAI NVARCHAR (5)
   DECLARE @NGAY DATETIME
  if exists(select manv from  PHATSINH where PHIEU =@PHIEU)
 BEGIN
    SELECT @MANV=MANV, @LOAI=LOAI,@NGAY = NGAY
      FROM PHATSINH where PHIEU =@PHIEU
    SELECT @HOTENNV=HO+' '+TEN from  nhanvien 
       where manv =@MANV
   	
   	SELECT TENVT, SOLUONG, DONGIA,NGAY=@NGAY, 
   	 LOAI=@LOAI , 	 HOTENNV=@HOTENNV 
   	FROM (SELECT MAVT,SOLUONG , DONGIA 
   	   FROM dbo.CT_PHATSINH WHERE PHIEU =@PHIEU) CT, 
   	   VATTU VT
   	  WHERE  CT.MAVT = VT.MAVT  
END
 else
   if exists(select manv from  L1.QL_VATTU.DBO.PHATSINH 
              where PHIEU =@PHIEU)
 BEGIN
    SELECT @MANV=MANV, @LOAI=LOAI,@NGAY = NGAY
      FROM L1.QL_VATTU.DBO.PHATSINH where PHIEU =@PHIEU
    SELECT @HOTENNV=HO+' '+TEN from  L1.QL_VATTU.DBO.nhanvien 
       where manv =@MANV
   	
   	SELECT TENVT, SOLUONG, DONGIA,NGAY=@NGAY, 
   	 LOAI=@LOAI , 	 HOTENNV=@HOTENNV 
   	FROM (SELECT MAVT,SOLUONG , DONGIA 
   	   FROM L1.QL_VATTU.DBO.CT_PHATSINH WHERE PHIEU =@PHIEU) CT, 
   	   L1.QL_VATTU.DBO.VATTU VT
   	  WHERE  CT.MAVT = VT.MAVT 
END
ELSE
      	raiserror ( 'SO PHIEU MUON TIM KHONG CO', 16, 0)
GO
/****** Object:  StoredProcedure [dbo].[SP_SLTON_VATTU]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SLTON_VATTU]
@MAVT VARCHAR(4)
AS
BEGIN
  DECLARE @TGNHAP INT
  DECLARE @TGXUAT INT
  SELECT @TGNHAP=SUM(SOLUONG)
    FROM dbo.CT_PHATSINH CT, dbo.PHATSINH PS
    WHERE LOAI='N' AND MAVT= @MAVT AND PS.PHIEU = CT.PHIEU 
 
  SELECT @TGXUAT=SUM(SOLUONG)
    FROM dbo.CT_PHATSINH CT, dbo.PHATSINH PS
    WHERE LOAI='X' AND MAVT= @MAVT AND PS.PHIEU = CT.PHIEU
  SELECT MAVT =@MAVT, SOLUONGTON = @TGNHAP-ISNULL(@TGXUAT,0)
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PX_NV_LAP_NGAY]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PX_NV_LAP_NGAY]
@MANV INT, @NGAY NVARCHAR (12) 
AS
  SET DATEFORMAT DMY
   DECLARE @HOTENNV NVARCHAR(100)
  if exists(select manv from  nhanvien where manv =@MANV)
 BEGIN
     SELECT @HOTENNV=HO+TEN from  nhanvien where manv =@MANV
   	SELECT PS.PHIEU , NGAY ,HOTENNV=@HOTENNV,
   	  TENVT, SOLUONG, DONGIA,trigia
   	FROM PHATSINH PS,dbo.CT_PHATSINH CT, VATTU VT
   	  WHERE MANV=@MANV AND LOAI ='X' AND NGAY= @NGAY
   	    AND PS.PHIEU = CT.PHIEU AND CT.MAVT = VT.MAVT  
END
 else
   if exists(select manv from  LINK1.QL_VATTU.DBO.nhanvien where manv =@MANV)
 BEGIN
    SELECT @HOTENNV=HO+TEN from   LINK1.QL_VATTU.DBO.nhanvien     		where manv =@MANV
   	SELECT PS.PHIEU , NGAY ,HOTENNV=@HOTENNV,
   	  TENVT, SOLUONG, DONGIA,trigia
   	FROM  LINK1.QL_VATTU.DBO.PHATSINH PS,
   	   LINK1.QL_VATTU.DBO.CT_PHATSINH CT, 
   	    LINK1.QL_VATTU.DBO.VATTU VT
   	  WHERE MANV=@MANV AND LOAI ='X' AND NGAY= @NGAY
   	    AND PS.PHIEU = CT.PHIEU AND CT.MAVT = VT.MAVT  
END  
   
ELSE
      	raiserror ( 'Ma nhan vien ban tim khong co', 16, 0)
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuNvLapTrongNamTheoLoai ]    Script Date: 04/24/2017 09:47:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_PhieuNvLapTrongNamTheoLoai ]
 @MANV int, @LOAI CHAR , @NAM INT
 AS
   SELECT PS.PHIEU ,  NGAY, TENVT , SOLUONG , DONGIA ,
    TRIGIA = SOLUONG * DONGIA 
   FROM PHATSINH PS , CT_PHATSINH CT, VATTU VT
   WHERE YEAR (NGAY)  = @NAM AND LOAI = @LOAI AND MANV  = @MANV  
       AND PS.PHIEU = CT.PHIEU AND CT.MAVT =VT.MAVT 
   ORDER BY NGAY , PS.PHIEU
GO
/****** Object:  Default [DF_PHATSINH_LOAI]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[PHATSINH] ADD  CONSTRAINT [DF_PHATSINH_LOAI]  DEFAULT ('N') FOR [LOAI]
GO
/****** Object:  Check [CK_LUONG]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [CK_LUONG] CHECK  (([LUONG]>=(6000000)))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [CK_LUONG]
GO
/****** Object:  Check [CK_PHATSINH]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[PHATSINH]  WITH CHECK ADD  CONSTRAINT [CK_PHATSINH] CHECK  (([LOAI]='C' OR ([LOAI]='T' OR ([LOAI]='X' OR [LOAI]='N'))))
GO
ALTER TABLE [dbo].[PHATSINH] CHECK CONSTRAINT [CK_PHATSINH]
GO
/****** Object:  Check [CK_DONGIA]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[CT_PHATSINH]  WITH CHECK ADD  CONSTRAINT [CK_DONGIA] CHECK  (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CT_PHATSINH] CHECK CONSTRAINT [CK_DONGIA]
GO
/****** Object:  Check [CK_SOLUONG]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[CT_PHATSINH]  WITH CHECK ADD  CONSTRAINT [CK_SOLUONG] CHECK  (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CT_PHATSINH] CHECK CONSTRAINT [CK_SOLUONG]
GO
/****** Object:  ForeignKey [FK_NHANVIEN_CHINHANH]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHINHANH] FOREIGN KEY([MACN])
REFERENCES [dbo].[CHINHANH] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHINHANH]
GO
/****** Object:  ForeignKey [FK_PHATSINH_KHO]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[PHATSINH]  WITH CHECK ADD  CONSTRAINT [FK_PHATSINH_KHO] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[KHO] ([MAKHO])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHATSINH] CHECK CONSTRAINT [FK_PHATSINH_KHO]
GO
/****** Object:  ForeignKey [FK_PHATSINH_NHANVIEN]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[PHATSINH]  WITH CHECK ADD  CONSTRAINT [FK_PHATSINH_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHATSINH] CHECK CONSTRAINT [FK_PHATSINH_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_CT_PHATSINH_PHATSINH]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[CT_PHATSINH]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHATSINH_PHATSINH] FOREIGN KEY([PHIEU])
REFERENCES [dbo].[PHATSINH] ([PHIEU])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_PHATSINH] CHECK CONSTRAINT [FK_CT_PHATSINH_PHATSINH]
GO
/****** Object:  ForeignKey [FK_CT_PHATSINH_VATTU]    Script Date: 04/24/2017 09:47:25 ******/
ALTER TABLE [dbo].[CT_PHATSINH]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHATSINH_VATTU] FOREIGN KEY([MAVT])
REFERENCES [dbo].[VATTU] ([MAVT])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_PHATSINH] CHECK CONSTRAINT [FK_CT_PHATSINH_VATTU]
GO
