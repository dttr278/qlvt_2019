USE [master]
GO
/****** Object:  Database [QLVT]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE DATABASE [QLVT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLVT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLVT.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLVT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLVT_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLVT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLVT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLVT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLVT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLVT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLVT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLVT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLVT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLVT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLVT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLVT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLVT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLVT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLVT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLVT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLVT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLVT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLVT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLVT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLVT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLVT] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [QLVT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLVT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLVT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLVT] SET RECOVERY FULL 
GO
ALTER DATABASE [QLVT] SET  MULTI_USER 
GO
ALTER DATABASE [QLVT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLVT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLVT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLVT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLVT] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLVT', N'ON'
GO
ALTER DATABASE [QLVT] SET QUERY_STORE = OFF
GO
USE [QLVT]
GO
/****** Object:  User [QLVT_HTKN]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE USER [QLVT_HTKN] FOR LOGIN [QLVT_HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [MSmerge_9FA4049B564D4838A4D0ED481DA955FD]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE ROLE [MSmerge_9FA4049B564D4838A4D0ED481DA955FD]
GO
/****** Object:  DatabaseRole [MSmerge_2FB97212A0D94C0684F4B630DE89DCEE]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE ROLE [MSmerge_2FB97212A0D94C0684F4B630DE89DCEE]
GO
ALTER ROLE [db_owner] ADD MEMBER [QLVT_HTKN]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_9FA4049B564D4838A4D0ED481DA955FD]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_2FB97212A0D94C0684F4B630DE89DCEE]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
USE [QLVT]
GO
/****** Object:  Sequence [dbo].[id_seq]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE SEQUENCE [dbo].[id_seq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 2
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[ChiNhanhId] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ChiNhanhId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_INFO_CN]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_INFO_CN]
AS
SELECT        dbo.ChiNhanh.*
FROM            dbo.ChiNhanh
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[NhanVienId] [bigint] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Ho] [nvarchar](50) NOT NULL,
	[Phai] [bit] NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SoDienThoai] [nvarchar](12) NULL,
	[TrangThai] [int] NOT NULL,
	[NgaySinh] [date] NULL,
	[ChiNhanhId] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NhanVienId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_NHANVIEN_DS]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_NHANVIEN_DS]
AS
SELECT        NhanVienId, Ho + N' ' + Ten AS HoTen, Phai, DiaChi, SoDienThoai, NgaySinh, ChiNhanhId
FROM            dbo.NhanVien
WHERE        (TrangThai <> 1)
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[LoaiHangId] [bigint] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LoaiHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MatHangId] [bigint] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[LoaiHangId] [bigint] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MatHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_MATHANG]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_MATHANG]
AS
SELECT        mh.MatHangId, mh.LoaiHangId, mh.Ten AS TenMatHang, lh.Ten AS TenLoaiHang, mh.DonViTinh
FROM            dbo.MatHang AS mh INNER JOIN
                         dbo.LoaiHang AS lh ON mh.LoaiHangId = lh.LoaiHangId
GO
/****** Object:  View [dbo].[V_CN]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_CN]
AS
SELECT        sub.subscriber_server, cn.ChiNhanhId, cn.Ten
FROM            dbo.sysmergepublications AS pub INNER JOIN
                         dbo.sysmergesubscriptions AS sub ON pub.pubid = sub.pubid AND pub.publisher <> sub.subscriber_server INNER JOIN
                         dbo.ChiNhanh AS cn ON pub.description = cn.ChiNhanhId
GO
/****** Object:  Table [dbo].[CTDatHang]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDatHang](
	[DatHangId] [bigint] NOT NULL,
	[MatHangId] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTDatHang] PRIMARY KEY CLUSTERED 
(
	[DatHangId] ASC,
	[MatHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[HoaDonId] [bigint] NOT NULL,
	[MatHangId] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTHoaDon] PRIMARY KEY CLUSTERED 
(
	[HoaDonId] ASC,
	[MatHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[PhieuNhapId] [bigint] NOT NULL,
	[MatHangId] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[PhieuNhapId] ASC,
	[MatHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[DatHangId] [bigint] NOT NULL,
	[NhanVienId] [bigint] NOT NULL,
	[NhaCungCapId] [bigint] NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DatHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[HoaDonId] [bigint] NOT NULL,
	[KhoId] [bigint] NOT NULL,
	[KhachHangId] [bigint] NOT NULL,
	[NhanVienId] [bigint] NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HoaDonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[KhachHangId] [bigint] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](250) NOT NULL,
	[SoDienThoai] [nvarchar](12) NOT NULL,
	[ChiNhanhId] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KhachHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[KhoId] [bigint] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[ViTri] [nvarchar](250) NULL,
	[ChiNhanhId] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KhoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[NhaCungCapId] [bigint] NOT NULL,
	[Ten] [nvarchar](150) NOT NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SoDienThoai] [nvarchar](12) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NhaCungCapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[KhoId] [bigint] NOT NULL,
	[NhanVienId] [bigint] NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[DatHangId] [bigint] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DatHangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_597577167]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_597577167] ON [dbo].[ChiNhanh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1045578763]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1045578763] ON [dbo].[CTDatHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1525580473]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1525580473] ON [dbo].[CTHoaDon]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1253579504]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1253579504] ON [dbo].[CTPhieuNhap]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_949578421]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_949578421] ON [dbo].[DatHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1413580074]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1413580074] ON [dbo].[HoaDon]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1349579846]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1349579846] ON [dbo].[KhachHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_725577623]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_725577623] ON [dbo].[Kho]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_837578022]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_837578022] ON [dbo].[LoaiHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_885578193]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_885578193] ON [dbo].[MatHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_789577851]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_789577851] ON [dbo].[NhaCungCap]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_629577281]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_629577281] ON [dbo].[NhanVien]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1157579162]    Script Date: 2/8/2020 9:31:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1157579162] ON [dbo].[PhieuNhap]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_D0F0A057D4BE4D78BC9E312E685CCE5B]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDatHang] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[CTDatHang] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[CTDatHang] ADD  CONSTRAINT [MSmerge_df_rowguid_7DF60874D30448F49BCD47C9EC0A031D]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTHoaDon] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[CTHoaDon] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[CTHoaDon] ADD  CONSTRAINT [MSmerge_df_rowguid_4F15FF877F7748E48E9387D10AC09D07]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTPhieuNhap] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[CTPhieuNhap] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[CTPhieuNhap] ADD  CONSTRAINT [MSmerge_df_rowguid_875D273B6F13424883B9019BBD3DE6E9]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[DatHang] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [DatHangId]
GO
ALTER TABLE [dbo].[DatHang] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [MSmerge_df_rowguid_888F1C2729294336BBFD0B5B229D9863]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [HoaDonId]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [MSmerge_df_rowguid_6EEA89EA82324AA8BDB1613464E70566]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [KhachHangId]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [MSmerge_df_rowguid_7B641148E35A460BA7A8DBE253C72F4D]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Kho] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [KhoId]
GO
ALTER TABLE [dbo].[Kho] ADD  CONSTRAINT [MSmerge_df_rowguid_4672A1244E694CADB03E7CF3A72558BF]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LoaiHang] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [LoaiHangId]
GO
ALTER TABLE [dbo].[LoaiHang] ADD  CONSTRAINT [MSmerge_df_rowguid_818166EB9CC647659305AD5A76BCFB2D]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[MatHang] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [MatHangId]
GO
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [MSmerge_df_rowguid_EED77F5F3B8747538F4011430A87D542]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [NhaCungCapId]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [MSmerge_df_rowguid_48843A515FD24C7CAD95B2D7ACEED2AD]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (NEXT VALUE FOR [id_seq]) FOR [NhanVienId]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((0)) FOR [Phai]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_8F9A1F73AE4D4E05995FC14EA881511C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [MSmerge_df_rowguid_08C5FA46EE7A4CFD98D8F266BEDE909C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDatHang]  WITH CHECK ADD FOREIGN KEY([DatHangId])
REFERENCES [dbo].[DatHang] ([DatHangId])
GO
ALTER TABLE [dbo].[CTDatHang]  WITH CHECK ADD FOREIGN KEY([MatHangId])
REFERENCES [dbo].[MatHang] ([MatHangId])
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD FOREIGN KEY([HoaDonId])
REFERENCES [dbo].[HoaDon] ([HoaDonId])
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD FOREIGN KEY([MatHangId])
REFERENCES [dbo].[MatHang] ([MatHangId])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MatHangId])
REFERENCES [dbo].[MatHang] ([MatHangId])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([PhieuNhapId])
REFERENCES [dbo].[PhieuNhap] ([DatHangId])
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD FOREIGN KEY([NhaCungCapId])
REFERENCES [dbo].[NhaCungCap] ([NhaCungCapId])
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD FOREIGN KEY([NhanVienId])
REFERENCES [dbo].[NhanVien] ([NhanVienId])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([KhachHangId])
REFERENCES [dbo].[KhachHang] ([KhachHangId])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([KhoId])
REFERENCES [dbo].[Kho] ([KhoId])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([NhanVienId])
REFERENCES [dbo].[NhanVien] ([NhanVienId])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([ChiNhanhId])
REFERENCES [dbo].[ChiNhanh] ([ChiNhanhId])
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD FOREIGN KEY([ChiNhanhId])
REFERENCES [dbo].[ChiNhanh] ([ChiNhanhId])
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD FOREIGN KEY([LoaiHangId])
REFERENCES [dbo].[LoaiHang] ([LoaiHangId])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([ChiNhanhId])
REFERENCES [dbo].[ChiNhanh] ([ChiNhanhId])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([DatHangId])
REFERENCES [dbo].[DatHang] ([DatHangId])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([KhoId])
REFERENCES [dbo].[Kho] ([KhoId])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([NhanVienId])
REFERENCES [dbo].[NhanVien] ([NhanVienId])
GO
/****** Object:  StoredProcedure [dbo].[INSERT_CT_HOA_DON]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[INSERT_CT_HOA_DON] @MatHangId bigint,@HoaDonId bigint,@SoLuong int,@DonGia int
as
begin

SET XACT_ABORT ON 
BEGIN DISTRIBUTED TRANSACTION;
declare @KetQua int
set @KetQua = -999
declare @nhap int,@xuat int,@nhap1 int,@xuat1 int

select @nhap=sum(SoLuong) from CTPhieuNhap where MatHangId=@MatHangId
select @xuat=sum(SoLuong) from CTHoaDon where MatHangId=@MatHangId
select @nhap1=sum(SoLuong) from LINK1.QLVT.dbo.CTPhieuNhap where MatHangId=@MatHangId
select @xuat1 =sum(SoLuong) from LINK1.QLVT.dbo.CTHoaDon where MatHangId=@MatHangId
if(@nhap is null)
set @nhap = 0
if(@nhap1 is null)
set @nhap1 = 0
if(@xuat is null)
set @xuat = 0
if(@xuat1 is null)
set @xuat1 = 0

declare @TonKho int
set @TonKho = ((@nhap+@nhap1)-(@xuat+@xuat1)) 

set @KetQua = -1

if(@TonKho>=@SoLuong)
begin
	insert CTHoaDon (MatHangId,HoaDonId,SoLuong,DonGia)
	values(@MatHangId,@HoaDonId,@SoLuong,@DonGia)	
end
else
begin
	set @KetQua = @TonKho
end
select @KetQua KetQua
COMMIT

end






GO
/****** Object:  StoredProcedure [dbo].[SP_CHANGE_PASS]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CHANGE_PASS] @login nvarchar(100), @newpass nvarchar(100), @oldpass nvarchar(100)
as
begin
DECLARE @SQLString NVARCHAR(500)
SET @SQLString = 'ALTER LOGIN ' + @login + ' WITH PASSWORD= '' + @newpass + '' OLD_PASSWORD= '' + @oldpass + '''
EXEC(@SQLString)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DATHANG]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DATHANG] @NhanVien bigint, @NhaCungCap bigint
as
begin
	SET XACT_ABORT ON 
	SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN TRANSACTION
	insert into DatHang (NhanVienId,NhaCungCapId) values(@NhanVien,@NhaCungCap);
	SELECT current_value FROM sys.sequences WHERE name = 'id_seq';
	COMMIT TRAN
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_LOGIN_FROM_USER]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_GET_LOGIN_FROM_USER] @username NVARCHAR(100)
as
begin
	select l.name from sys.sysusers u,sys.syslogins l  where u.name=@username and u.sid=l.sid
end
GO
/****** Object:  StoredProcedure [dbo].[SP_HOAT_DONG_NV]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_HOAT_DONG_NV] @begin varchar(10),@end varchar(10),@nv bigint
as
begin

select KhoId,ThoiGian,DatHangId as Ma,'Nhap' as Loai into #pn from PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103) and NhanVienId=@nv
select KhoId,ThoiGian,Ma,Loai,SoLuong,MatHangId,DonGia,SoLuong*DonGia as ThanhTien into #pn_ct from #pn inner join CTPhieuNhap ctpn on #pn.Ma=ctpn.PhieuNhapId
select KhoId,ThoiGian,Ma,Loai,SoLuong,#pn_ct.MatHangId,mh.Ten,DonGia,ThanhTien into #pn_ct_mh from #pn_ct inner join MatHang mh on #pn_ct.MatHangId=mh.MatHangId
select k.KhoId,k.Ten TenKho,ThoiGian,Ma,Loai,SoLuong,MatHangId,#pn_ct_mh.Ten TenMatHang,DonGia,ThanhTien into #Nhap from #pn_ct_mh inner join Kho k on #pn_ct_mh.KhoId=k.KhoId

select KhoId,ThoiGian,HoaDonId as Ma,'Xuat' as Loai into #hd from HoaDon where ThoiGian between CONVERT(DATETIME,'2-2-2002',103) AND CONVERT(DATETIME,'2-2-2020',103) and NhanVienId=1
select KhoId,ThoiGian,Ma,Loai,SoLuong,MatHangId,DonGia,SoLuong*DonGia as ThanhTien into #hd_ct from #hd inner join CTHoaDon cthd on #hd.Ma=cthd.HoaDonId
select KhoId,ThoiGian,Ma,Loai,SoLuong,#hd_ct.MatHangId,mh.Ten,DonGia,ThanhTien into #hd_ct_mh from #hd_ct inner join MatHang mh on #hd_ct.MatHangId=mh.MatHangId
select k.KhoId,k.Ten TenKho,ThoiGian,Ma,Loai,SoLuong,MatHangId,#hd_ct_mh.Ten TenMatHang,DonGia,ThanhTien into #Xuat from #hd_ct_mh inner join Kho k on #hd_ct_mh.KhoId=k.KhoId


select * from #Nhap union all select * from #Xuat order by ThoiGian,Ma

end
GO
/****** Object:  StoredProcedure [dbo].[SP_INFOLOGIN]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_INFOLOGIN] @lgname NVARCHAR(100)
AS
BEGIN
	--DECLARE @manv INT
	--SELECT name AS manv,groupuid INTO #t1 FROM sys.sysusers,sys.sysmembers
	--	WHERE sid=(SUSER_SID(@lgname)) AND uid=memberuid
	--SELECT manv,name AS ROLE INTO #t2 FROM #t1,sys.sysusers WHERE #t1.groupuid=uid
	--SELECT NhanVien.MANV,HOTEN=HO+TEN,ROLE FROM #t2 ,dbo.NhanVien WHERE #t2.manv=dbo.NhanVien.MANV

	DECLARE @TENUSER NVARCHAR(50)
	SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@lgname)
 
	 SELECT USERNAME = @TENUSER, 
	   TENNHOM= NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					 FROM SYS.SYSMEMBERS 
					   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										  WHERE NAME=@TENUSER))


END
GO
/****** Object:  StoredProcedure [dbo].[SP_REMOVEDH]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_REMOVEDH] @DatHangId bigint
as
begin
	SET XACT_ABORT ON 
	SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN TRANSACTION
	DECLARE @pn int;
	select @pn=count(*) from PhieuNhap where DatHangId = @DatHangId;
	if(@pn>0)
		return 1;
	else
	begin
		delete from CTDatHang where DatHangId=@DatHangId;
		delete from DatHang where DatHangId=@DatHangId;
		return 0;
	end
	COMMIT TRAN
end

GO
/****** Object:  StoredProcedure [dbo].[SP_RP_NHAP_HANG]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_RP_NHAP_HANG] @begin varchar(10),@end varchar(10) ,@ct int
as
begin
select Year,MonthYear,tb1.MatHangId,mh.Ten,DonGia,SoLuong,Tong into #tonghop from
(select pn.Year,pn.MonthYear ,ctpn.MatHangId, ctpn.DonGia,SUM(ctpn.SoLuong) SoLuong,SUM(ctpn.SoLuong) * ctpn.DonGia Tong from
(select DatHangId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103))
as pn inner join CTPhieuNhap ctpn on pn.DatHangId=ctpn.PhieuNhapId group by pn.Year,pn.MonthYear,ctpn.MatHangId,ctpn.DonGia) tb1
inner join MatHang mh on mh.MatHangId=tb1.MatHangId
if(@ct=0)
begin
select * from #tonghop
end
else

begin
select Year,MonthYear,tb11.MatHangId,mh1.Ten,DonGia,SoLuong,Tong into #tmp from
(select pn1.Year, pn1.MonthYear ,ctpn1.MatHangId, ctpn1.DonGia,SUM(ctpn1.SoLuong) SoLuong,SUM(ctpn1.SoLuong) * ctpn1.DonGia Tong from
(select DatHangId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from LINK1.QLVT.dbo.PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103))
as pn1 inner join LINK1.QLVT.dbo.CTPhieuNhap ctpn1 on pn1.DatHangId=ctpn1.PhieuNhapId group by pn1.Year,pn1.MonthYear,ctpn1.MatHangId,ctpn1.DonGia) tb11
inner join LINK1.QLVT.dbo.MatHang mh1 on mh1.MatHangId=tb11.MatHangId


select Year,MonthYear,MatHangId,Ten,DonGia,SUM(SoLuong) SoLuong,SUM(Tong) Tong from 
	(select * from #tonghop union all select * from #tmp) rs group by Year, MonthYear, MatHangId,Ten,DonGia
end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_RP_XUAT_HANG]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_RP_XUAT_HANG] @begin varchar(10), @end varchar(10),@ct int
as
begin
select Year,MonthYear,tb1.MatHangId,mh.Ten,SoLuong,DonGia,Tong into #tonghop from
(select hd.Year,hd.MonthYear ,cthd.MatHangId, cthd.DonGia,SUM(cthd.SoLuong) SoLuong,SUM(cthd.SoLuong) * cthd.DonGia Tong from
(select HoaDonId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103))
as hd inner join CTHoaDon cthd on hd.HoaDonId=cthd.HoaDonId group by hd.Year,hd.MonthYear,cthd.MatHangId,cthd.DonGia) tb1
inner join MatHang mh on mh.MatHangId=tb1.MatHangId
if(@ct=0)
begin
select * from #tonghop
end
else
begin
select Year,MonthYear,tb11.MatHangId,mh1.Ten,SoLuong,DonGia,Tong into #tmp from
(select hd1.MonthYear,hd1.Year ,cthd1.MatHangId, cthd1.DonGia,SUM(cthd1.SoLuong) SoLuong,SUM(cthd1.SoLuong) * cthd1.DonGia Tong from
(select HoaDonId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from LINK1.QLVT.dbo.HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103))
as hd1 inner join LINK1.QLVT.dbo.CTHoaDon cthd1 on hd1.HoaDonId=cthd1.HoaDonId group by hd1.Year, hd1.MonthYear,cthd1.MatHangId,cthd1.DonGia) tb11
inner join MatHang mh1 on mh1.MatHangId=tb11.MatHangId

select Year,MonthYear,MatHangId,Ten,DonGia,SUM(SoLuong) SoLuong,SUM(Tong) Tong from 
	(select * from #tonghop union all select * from #tmp) rs group by Year,MonthYear, MatHangId,Ten,DonGia
end
end

GO
/****** Object:  StoredProcedure [dbo].[SP_SO_LUONG_VAT_TU]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SO_LUONG_VAT_TU] @MAVT bigint
as
begin
SET XACT_ABORT ON 
BEGIN DISTRIBUTED TRANSACTION;

declare @nhap int,@xuat int,@nhap1 int,@xuat1 int

select @nhap=sum(SoLuong) from CTPhieuNhap where MatHangId=@MAVT
select @xuat=sum(SoLuong) from CTHoaDon where MatHangId=@MAVT
select @nhap1=sum(SoLuong) from LINK1.QLVT.dbo.CTPhieuNhap where MatHangId=@MAVT
select @xuat1 =sum(SoLuong) from LINK1.QLVT.dbo.CTHoaDon where MatHangId=@MAVT
if(@nhap is null)
set @nhap = 0
if(@nhap1 is null)
set @nhap1 = 0
if(@xuat is null)
set @xuat = 0
if(@xuat1 is null)
set @xuat1 = 0


select ((@nhap+@nhap1)-(@xuat+@xuat1)) SoLuong
COMMIT
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOHOADON]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TAOHOADON] @NhanVien bigint, @Kho bigint, @KhachHang bigint
as
begin
	SET XACT_ABORT ON 
	SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN TRANSACTION
	insert into HoaDon (NhanVienId,KhoId,KhachHangId) values(@NhanVien,@Kho,@KhachHang);
	SELECT current_value FROM sys.sequences WHERE name = 'id_seq';
	COMMIT TRAN
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[SP_TAOTAIKHOAN]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50),
	@return INT OUTPUT
AS
BEGIN
  SET @return=0
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLVT'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
  	 SET @return=1
     RETURN 1
  END
	 

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
	   SET @return=2
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'CONGTY' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'CHINHANH'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'USER'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_THNX_THEO_NGAY]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_THNX_THEO_NGAY] @begin varchar(10),@end varchar(10),@ct int
as
 begin

select ThoiGian,DatHangId  Ma into #pn from PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
select FORMAT(ThoiGian,'dd/MM/yyyy')  Ngay,sum(SoLuong*DonGia)  TongNhap into #pn_ct from #pn inner join CTPhieuNhap ctpn on #pn.Ma=ctpn.PhieuNhapId
group by FORMAT(ThoiGian,'dd/MM/yyyy')

select ThoiGian,HoaDonId  Ma into #hd from HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
select FORMAT(ThoiGian,'dd/MM/yyyy')  Ngay,sum(SoLuong*DonGia)  TongXuat into #hd_ct from #hd inner join CTHoaDon cthd on #hd.Ma=cthd.HoaDonId
group by FORMAT(ThoiGian,'dd/MM/yyyy')

select IIF(#hd_ct.Ngay is null,#pn_ct.Ngay,#hd_ct.Ngay) Ngay,IIF(#pn_ct.TongNhap is null,0,#pn_ct.TongNhap)  TongNhap,IIF(#hd_ct.TongXuat is null,0,#hd_ct.TongXuat)   TongXuat into #tonghop from #hd_ct full join #pn_ct on #pn_ct.Ngay = #hd_ct.Ngay
if(@ct=0)
begin
select * from #tonghop order by Ngay
end
else
begin
select ThoiGian,DatHangId  Ma into #pn1 from LINK1.QLVT.dbo.PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
select FORMAT(ThoiGian,'dd/MM/yyyy')  Ngay,sum(SoLuong*DonGia)  TongNhap into #pn_ct1 from #pn1 inner join LINK1.QLVT.dbo.CTPhieuNhap ctpn1 on #pn1.Ma=ctpn1.PhieuNhapId
group by FORMAT(ThoiGian,'dd/MM/yyyy')

select ThoiGian,HoaDonId  Ma into #hd1 from LINK1.QLVT.dbo.HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
select FORMAT(ThoiGian,'dd/MM/yyyy')  Ngay,sum(SoLuong*DonGia)  TongXuat into #hd_ct1 from #hd1 inner join LINK1.QLVT.dbo.CTHoaDon cthd1 on #hd1.Ma=cthd1.HoaDonId
group by FORMAT(ThoiGian,'dd/MM/yyyy')

select IIF(#hd_ct1.Ngay is null,#pn_ct1.Ngay,#hd_ct1.Ngay) Ngay,IIF(#pn_ct1.TongNhap is null,0,#pn_ct1.TongNhap)  TongNhap,IIF(#hd_ct1.TongXuat is null,0,#hd_ct1.TongXuat)   TongXuat into #tmp from #hd_ct1 full join #pn_ct1 on #pn_ct1.Ngay = #hd_ct1.Ngay

select Ngay,sum(TongXuat) TongXuat,sum(TongNhap) TongNhap from 
	(select * from #tonghop union all select * from #tmp) rs group by Ngay
end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TONG_HOP_CTNX_THANG]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TONG_HOP_CTNX_THANG] 
@begin nvarchar(10), --ddd-MM-yyyy
@end varchar(10), --ddd-MM-yyyy
@ct int --@ct = 0 : lay du lieu trong chi nhanh ; <> 0 lấy toàn bộ công ty
as
begin
--BEGIN lấy thông tin Nhập hàng********************************
--lấy thông tin phiếu nhập trong khoản thời gian
select DatHangId, FORMAT(ThoiGian,'MM/yyyy') MonthYear, FORMAT(ThoiGian,'yyyy') Year into #pn  from PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
--join phieu nhap va ctpn
select #pn.MonthYear,#pn.Year ,ctpn.MatHangId, ctpn.DonGia,SUM(ctpn.SoLuong) SoLuong,SUM(ctpn.SoLuong) * ctpn.DonGia Tong into #pn_ct from
#pn inner join CTPhieuNhap ctpn on #pn.DatHangId=ctpn.PhieuNhapId group by #pn.Year,#pn.MonthYear,ctpn.MatHangId,ctpn.DonGia 
--join ctpn , mặt hàng
select Year,MonthYear,#pn_ct.MatHangId,mh.Ten,DonGia,SoLuong SoLuongNhap,Tong TongNhap into #Nhap from
#pn_ct inner join MatHang mh on mh.MatHangId=#pn_ct.MatHangId
--END lấy thông tin Nhập hàng*********************************

--BEGIN lấy thông tin Hóa đơn********************************
--lấy thông tin hóa đơn trong khoản thời gian
select HoaDonId, FORMAT(ThoiGian,'MM/yyyy') MonthYear, FORMAT(ThoiGian,'yyyy') Year into #hd from HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
--join hd với cthd
select #hd.Year,#hd.MonthYear ,cthd.MatHangId, cthd.DonGia,SUM(cthd.SoLuong) SoLuong,SUM(cthd.SoLuong) * cthd.DonGia Tong into #hd_ct from
#hd inner join CTHoaDon cthd on #hd.HoaDonId=cthd.HoaDonId group by #hd.Year,#hd.MonthYear,cthd.MatHangId,cthd.DonGia
--join cthd với mặt hàng
select Year,MonthYear,#hd_ct.MatHangId,mh.Ten,SoLuong SoLuongXuat,DonGia,Tong TongXuat into #Xuat from
#hd_ct inner join MatHang mh on mh.MatHangId=#hd_ct.MatHangId
--End lấy thông tin Hóa đơn********************************

--Begin join thông tin hóa đơn và phiếu xuất********************************
--join nhập và xuất giựa trên month/year, MatHangId, DonGia
select  
IIF(#Nhap.Year is null,#Xuat.Year,#Nhap.Year) Year,
IIF(#Nhap.MonthYear is null,#Xuat.MonthYear,#Nhap.MonthYear) MonthYear,
IIF(#Nhap.MatHangId is null,#Xuat.MatHangId,#Nhap.MatHangId) MatHangId,
IIF(#Nhap.Ten is null,#Xuat.Ten,#Nhap.Ten) Ten,
IIF(#Nhap.DonGia is null,#Xuat.DonGia,#Nhap.DonGia) DonGia,
IIF(SoLuongNhap IS NULL,0,SoLuongNhap) AS SoLuongNhap,
IIF(TongNhap IS NULL,0,TongNhap)AS TongNhap, 
IIF(SoLuongXuat IS NULL,0,SoLuongXuat) AS SoLuongXuat,
IIF(TongXuat IS NULL,0,TongXuat)AS TongXuat 

into #tonghop from #Nhap full join  #Xuat 
on #Nhap.MonthYear=#Xuat.MonthYear and #Nhap.MatHangId = #Xuat.MatHangId and #Nhap.DonGia = #Xuat.DonGia

group by 
#Nhap.Year,#Xuat.Year,
#Nhap.MonthYear,#Xuat.MonthYear,
#Nhap.MatHangId,#Xuat.MatHangId,
#Nhap.Ten,#Xuat.Ten,
#Nhap.DonGia,#Xuat.DonGia,
#Nhap.SoLuongNhap,#Xuat.SoLuongXuat,
#Nhap.Tongnhap,#Xuat.TongXuat
--End join thông tin hóa đơn và phiếu xuất********************************
if(@ct=0)
begin
	select Year,MonthYear,MatHangId,Ten
	--,DonGia
	,SUM(SoLuongNhap) SoLuongNhap,sum(TongNhap) TongNhap,sum(SoLuongXuat) SoLuongXuat,sum(TongXuat) TongXuat from 
	#tonghop group by Year,MonthYear,MatHangId,Ten
	--, DonGia
end
else
begin
	
	--lấy thông tin phiếu nhập trong khoản thời gian
	select DatHangId, FORMAT(ThoiGian,'MM/yyyy') MonthYear, FORMAT(ThoiGian,'yyyy') Year into #pn1  from PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
	--join phieu nhap va ctpn
	select #pn1.MonthYear,#pn1.Year ,ctpn1.MatHangId, ctpn1.DonGia,SUM(ctpn1.SoLuong) SoLuong,SUM(ctpn1.SoLuong) * ctpn1.DonGia Tong into #pn_ct1 from
	#pn1 inner join CTPhieuNhap ctpn1 on #pn1.DatHangId=ctpn1.PhieuNhapId group by #pn1.Year,#pn1.MonthYear,ctpn1.MatHangId,ctpn1.DonGia 
	--join ctpn , mặt hàng
	select Year,MonthYear,#pn_ct1.MatHangId,mh1.Ten,DonGia,SoLuong SoLuongNhap,Tong TongNhap into #Nhap1 from
	#pn_ct1 inner join MatHang mh1 on mh1.MatHangId=#pn_ct1.MatHangId

	--lấy thông tin hóa đơn trong khoản thời gian
	select HoaDonId, FORMAT(ThoiGian,'MM/yyyy') MonthYear, FORMAT(ThoiGian,'yyyy') Year into #hd1 from HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)
	--join hd với cthd
	select #hd1.Year,#hd1.MonthYear ,cthd1.MatHangId, cthd1.DonGia,SUM(cthd1.SoLuong) SoLuong,SUM(cthd1.SoLuong) * cthd1.DonGia Tong into #hd_ct1 from
	#hd1 inner join CTHoaDon cthd1 on #hd1.HoaDonId=cthd1.HoaDonId group by #hd1.Year,#hd1.MonthYear,cthd1.MatHangId,cthd1.DonGia
	--join cthd với mặt hàng
	select Year,MonthYear,#hd_ct1.MatHangId,mh1.Ten,SoLuong SoLuongXuat,DonGia,Tong TongXuat into #Xuat1 from
	#hd_ct1 inner join MatHang mh1 on mh1.MatHangId=#hd_ct1.MatHangId

	--join nhập và xuất giựa trên month/year, MatHangId, DonGia
	select  
	IIF(#Nhap1.Year is null,#Xuat1.Year,#Nhap1.Year) Year,
	IIF(#Nhap1.MonthYear is null,#Xuat1.MonthYear,#Nhap1.MonthYear) MonthYear,
	IIF(#Nhap1.MatHangId is null,#Xuat1.MatHangId,#Nhap1.MatHangId) MatHangId,
	IIF(#Nhap1.Ten is null,#Xuat1.Ten,#Nhap1.Ten) Ten,
	IIF(#Nhap1.DonGia is null,#Xuat1.DonGia,#Nhap1.DonGia) DonGia,
	IIF(SoLuongNhap IS NULL,0,SoLuongNhap) AS SoLuongNhap,
	IIF(TongNhap IS NULL,0,TongNhap)AS TongNhap, 
	IIF(SoLuongXuat IS NULL,0,SoLuongXuat) AS SoLuongXuat,
	IIF(TongXuat IS NULL,0,TongXuat)AS TongXuat 

	into #tmp from #Nhap1 full join  #Xuat1 
	on #Nhap1.MonthYear=#Xuat1.MonthYear and #Nhap1.MatHangId = #Xuat1.MatHangId and #Nhap1.DonGia = #Xuat1.DonGia

	group by 
	#Nhap1.Year,#Xuat1.Year,
	#Nhap1.MonthYear,#Xuat1.MonthYear,
	#Nhap1.MatHangId,#Xuat1.MatHangId,
	#Nhap1.Ten,#Xuat1.Ten,
	#Nhap1.DonGia,#Xuat1.DonGia,
	#Nhap1.SoLuongNhap,#Xuat1.SoLuongXuat,
	#Nhap1.Tongnhap,#Xuat1.TongXuat

	select Year,MonthYear,MatHangId,Ten
	--,DonGia
	,SUM(SoLuongNhap) SoLuongNhap,sum(TongNhap) TongNhap,sum(SoLuongXuat) SoLuongXuat,sum(TongXuat) TongXuat from 
	(select * from #tonghop union all select * from #tmp)as rs group by Year,MonthYear,MatHangId,Ten
	--, DonGia

end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TONG_HOP_THU_CHI]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TONG_HOP_THU_CHI] @begin nvarchar(10),@end varchar(10),@ct int
as
begin

select hd.Year,hd.MonthYear ,SUM(cthd.SoLuong * cthd.DonGia) Thu into #thu from
(select HoaDonId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)) as hd 
inner join CTHoaDon cthd on hd.HoaDonId=cthd.HoaDonId group by hd.Year,hd.MonthYear

select pn.Year,pn.MonthYear ,SUM(ctpn.SoLuong * ctpn.DonGia) Chi into #chi  from
(select DatHangId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103))
as pn inner join CTPhieuNhap ctpn on pn.DatHangId=ctpn.PhieuNhapId group by pn.Year,pn.MonthYear

select IIF(#thu.Year is null,#chi.Year,#thu.Year) Year,IIF(#thu.MonthYear is null,#chi.MonthYear,#thu.MonthYear) MonthYear,IIF(Thu IS NULL,0,Thu) AS Thu,IIF(Chi IS NULL,0,Chi)AS Chi into #tonghop from #thu full join  #chi 
on #thu.MonthYear=#chi.MonthYear 
group by #thu.Year,#chi.Year,#thu.MonthYear,#chi.MonthYear,#thu.Thu,#chi.Chi

if(@ct=0)
begin
select * from #tonghop
end
else
begin
	select hd1.Year,hd1.MonthYear ,SUM(cthd1.SoLuong * cthd1.DonGia) Thu into #thu1 from
	(select HoaDonId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from LINK1.QLVT.dbo.HoaDon where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103)) as hd1 
	inner join LINK1.QLVT.dbo.CTHoaDon cthd1 on hd1.HoaDonId=cthd1.HoaDonId group by hd1.Year,hd1.MonthYear

	select pn1.Year,pn1.MonthYear ,SUM(ctpn1.SoLuong * ctpn1.DonGia) Chi into #chi1  from
	(select DatHangId, FORMAT(ThoiGian,'MM/yyyy') MonthYear,FORMAT(ThoiGian,'yyyy') Year from LINK1.QLVT.dbo.PhieuNhap where ThoiGian between CONVERT(DATETIME,@begin,103) AND CONVERT(DATETIME,@end,103))
	as pn1 inner join LINK1.QLVT.dbo.CTPhieuNhap ctpn1 on pn1.DatHangId=ctpn1.PhieuNhapId group by pn1.Year,pn1.MonthYear

	select IIF(#thu1.Year is null,#chi1.Year,#thu1.Year) Year,IIF(#thu1.MonthYear is null,#chi1.MonthYear,#thu1.MonthYear) MonthYear,IIF(Thu IS NULL,0,Thu) AS Thu,IIF(Chi IS NULL,0,Chi)AS Chi into #tmpBus from #thu1 full join  #chi1 
	on #thu1.MonthYear=#chi1.MonthYear 
	group by #thu1.Year,#chi1.Year,#thu1.MonthYear,#chi1.MonthYear,#thu1.Thu,#chi1.Chi

	select Year,MonthYear,SUM(Thu) Thu,sum(Chi) Chi from 
	(select * from #tonghop union all select * from #tmpBus)as rs group by Year,MonthYear
end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TONGHOP_VT]    Script Date: 2/8/2020 9:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TONGHOP_VT] 
as 
begin
select mh.Ten,mh.MatHangId,mh.DonViTinh,mh.LoaiHangId,lh.Ten TenLoaiHang into #mh from MatHang mh inner join LoaiHang lh on mh.LoaiHangId=lh.LoaiHangId
select #mh.Ten,#mh.MatHangId,#mh.DonViTinh,#mh.LoaiHangId,#mh.TenLoaiHang, sum(ctpn.SoLuong) SoLuong into #nhap from #mh left join CTPhieuNhap ctpn on ctpn.MatHangId=#mh.MatHangId
group by #mh.MatHangId, #mh.Ten,#mh.DonViTinh,#mh.LoaiHangId,#mh.TenLoaiHang
select #mh.Ten,#mh.MatHangId,#mh.DonViTinh,#mh.LoaiHangId,#mh.TenLoaiHang, sum(cthd.SoLuong) SoLuong into #xuat from #mh left join CTHoaDon cthd on #mh.MatHangId=cthd.MatHangId
group by #mh.MatHangId, #mh.Ten,#mh.DonViTinh,#mh.LoaiHangId,#mh.TenLoaiHang
select #nhap.Ten,#nhap.MatHangId,#nhap.DonViTinh,#nhap.LoaiHangId,#nhap.TenLoaiHang, 
IIF(#xuat.SoLuong is null,#nhap.SoLuong,(#nhap.SoLuong-#xuat.SoLuong)) SoLuong into #sv1
from #nhap left join #xuat on #nhap.MatHangId=#xuat.MatHangId

select mh1.Ten,mh1.MatHangId,mh1.DonViTinh,mh1.LoaiHangId,lh1.Ten TenLoaiHang into #mh1 from LINK1.QLVT.dbo.MatHang mh1 inner join LINK1.QLVT.dbo.LoaiHang lh1 on mh1.LoaiHangId=lh1.LoaiHangId
select #mh1.Ten,#mh1.MatHangId,#mh1.DonViTinh,#mh1.LoaiHangId,#mh1.TenLoaiHang, sum(ctpn1.SoLuong) SoLuong into #nhap1 from #mh1 left join LINK1.QLVT.dbo.CTPhieuNhap ctpn1 on ctpn1.MatHangId=#mh1.MatHangId
group by #mh1.MatHangId, #mh1.Ten,#mh1.DonViTinh,#mh1.LoaiHangId,#mh1.TenLoaiHang
select #mh1.Ten,#mh1.MatHangId,#mh1.DonViTinh,#mh1.LoaiHangId,#mh1.TenLoaiHang, sum(cthd1.SoLuong) SoLuong into #xuat1 from #mh1 left join LINK1.QLVT.dbo.CTHoaDon cthd1 on #mh1.MatHangId=cthd1.MatHangId
group by #mh1.MatHangId, #mh1.Ten,#mh1.DonViTinh,#mh1.LoaiHangId,#mh1.TenLoaiHang
select #nhap1.Ten,#nhap1.MatHangId,#nhap1.DonViTinh,#nhap1.LoaiHangId,#nhap1.TenLoaiHang, 
IIF(#xuat1.SoLuong is null,#nhap1.SoLuong,(#nhap1.SoLuong-#xuat1.SoLuong)) SoLuong into #sv2
from #nhap1 left join #xuat1 on #nhap1.MatHangId=#xuat1.MatHangId

select Ten,MatHangId,DonViTinh,LoaiHangId,TenLoaiHang,iif(SUM(SoLuong) is null,0,SUM(SoLuong)) SoLuong from (select * from #sv1 union all select * from #sv2) rs group by MatHangId,Ten,DonViTinh,LoaiHangId,TenLoaiHang

end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "mh"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "lh"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_MATHANG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_MATHANG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NhanVien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NHANVIEN_DS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NHANVIEN_DS'
GO
USE [master]
GO
ALTER DATABASE [QLVT] SET  READ_WRITE 
GO
