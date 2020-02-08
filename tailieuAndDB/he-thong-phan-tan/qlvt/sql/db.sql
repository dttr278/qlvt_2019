

USE [QLVT]
GO
/****** Object:  Sequence [dbo].[id_seq]    Script Date: 11/7/2019 9:44:56 PM ******/
CREATE SEQUENCE [dbo].[id_seq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 2
 MINVALUE 0
 MAXVALUE 9223372036854775807
 CACHE 
GO
/*************    database    ***************/
-- Create a new table called 'ChiNhanh' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE ChiNhanh
(
    ChiNhanhId INT NOT NULL PRIMARY KEY ,
    -- primary key column
    Ten [NVARCHAR](50)
);
GO

-- Create a new table called 'NhanVien' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE NhanVien
(
    NhanVienId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    Ten [NVARCHAR](50) NOT NULL,
    Ho [NVARCHAR](50) NOT NULL,
    Phai [BIT] DEFAULT 0,
    DiaChi [NVARCHAR](250),
    SoDienThoai [NVARCHAR](12),
    TrangThai [INT] NOT NULL DEFAULT 0,
    NgaySinh [DATE] ,
    ChiNhanhId INT NOT NULL FOREIGN KEY REFERENCES ChiNhanh(ChiNhanhId)
);
GO

-- Create a new table called 'Kho' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE Kho
(
    KhoId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    Ten [NVARCHAR](50) NOT NULL,
    ViTri [NVARCHAR](250) ,
    ChiNhanhId INT NOT NULL FOREIGN KEY REFERENCES ChiNhanh(ChiNhanhId)
);
GO



-- Create a new table called 'NhaCungCap' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE NhaCungCap
(
    NhaCungCapId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    Ten [NVARCHAR](150) NOT NULL,
    DiaChi [NVARCHAR](250),
    SoDienThoai [NVARCHAR](12)
);
GO

-- Create a new table called 'LoaiHang' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE LoaiHang
(
    LoaiHangId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    Ten [NVARCHAR](50) NOT NULL
);
GO

-- Create a new table called 'MatHang' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE MatHang
(
    MatHangId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    Ten [NVARCHAR](50) NOT NULL,
    DonViTinh [NVARCHAR](10),
    LoaiHangId BIGINT NOT NULL FOREIGN KEY REFERENCES LoaiHang(LoaiHangId)
);
GO
-- Create a new table called 'DatHang' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE DatHang
(
    DatHangId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    NhanVienId BIGINT NOT NULL FOREIGN KEY REFERENCES NhanVien(NhanVienId),
    NhaCungCapId BIGINT NOT NULL FOREIGN KEY REFERENCES NhaCungCap(NhaCungCapId),
    ThoiGian DATETIME NOT NULL DEFAULT getdate()
);
GO

-- Create a new table called 'CTDatHang' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE CTDatHang
(
    DatHangId BIGINT NOT NULL FOREIGN KEY REFERENCES DatHang(DatHangId),
    MatHangId BIGINT NOT NULL FOREIGN KEY REFERENCES MatHang(MatHangId),
    SoLuongTon INT NOT NULL DEFAULT 0,
    SoLuong INT NOT NULL DEFAULT 0,
    DonGia INT NOT NULL DEFAULT 0,
    CONSTRAINT PK_CTDatHang PRIMARY KEY (DatHangId, MatHangId)
);
GO

-- Create a new table called 'PhieuNhap' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE PhieuNhap
(
    KhoId BIGINT NOT NULL FOREIGN KEY REFERENCES Kho(KhoId),
    NhanVienId BIGINT NOT NULL FOREIGN KEY REFERENCES NhanVien(NhanVienId),
    ThoiGian DATETIME NOT NULL DEFAULT getdate(),
    DatHangId BIGINT NOT NULL  FOREIGN KEY REFERENCES DatHang(DatHangId) PRIMARY KEY
);
GO

-- Create a new table called 'CTPhieuNhap' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE CTPhieuNhap
(
    PhieuNhapId BIGINT NOT NULL FOREIGN KEY REFERENCES PhieuNhap(DatHangId),
    MatHangId BIGINT NOT NULL FOREIGN KEY REFERENCES MatHang(MatHangId),
    SoLuong INT NOT NULL DEFAULT 0,
    DonGia INT NOT NULL DEFAULT 0,
    CONSTRAINT PK_CTPhieuNhap PRIMARY KEY (PhieuNhapId, MatHangId)
);
GO

-- Create a new table called 'KhachHang' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE KhachHang
(
    KhachHangId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    Ten [NVARCHAR](50) NOT NULL,
    Ho [NVARCHAR](50) NOT NULL,
    DiaChi [NVARCHAR](250) NOT NULL,
    SoDienThoai [NVARCHAR](12) NOT NULL,
    ChiNhanhId INT NOT NULL FOREIGN KEY REFERENCES ChiNhanh(ChiNhanhId)
);
GO

-- Create a new table called 'HoaDon' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE HoaDon
(
    HoaDonId BIGINT NOT NULL PRIMARY KEY DEFAULT (NEXT VALUE FOR [id_seq]),
    -- primary key column
    KhoId BIGINT NOT NULL FOREIGN KEY REFERENCES Kho(KhoId),
    KhachHangId BIGINT NOT NULL FOREIGN KEY REFERENCES KhachHang(KhachHangId),
    NhanVienId BIGINT NOT NULL FOREIGN KEY REFERENCES NhanVien(NhanVienId),
    ThoiGian DATETIME NOT NULL DEFAULT getdate()
);
GO

-- Create a new table called 'CTHoaDon' in schema 'QLVT'

-- Create the table in the specified schema
CREATE TABLE CTHoaDon
(
    HoaDonId BIGINT NOT NULL FOREIGN KEY REFERENCES HoaDon(HoaDonId),
    MatHangId BIGINT NOT NULL FOREIGN KEY REFERENCES MatHang(MatHangId),
    SoLuong INT NOT NULL DEFAULT 0,
    DonGia INT NOT NULL DEFAULT 0,
    CONSTRAINT PK_CTHoaDon PRIMARY KEY (HoaDonId, MatHangId)
);
GO

/******************************end database script *****************************/
/******************************begin view **************************************/
/****** Object:  View [dbo].[V_CN]    Script Date: 11/12/2019 9:31:20 PM ******/
CREATE VIEW [dbo].[V_CN]
AS
SELECT        sub.subscriber_server, cn.ChiNhanhId, cn.Ten
FROM            dbo.sysmergepublications AS pub INNER JOIN
                        dbo.sysmergesubscriptions AS sub ON pub.pubid = sub.pubid AND pub.publisher <> sub.subscriber_server INNER JOIN
                        dbo.ChiNhanh AS cn ON pub.description = cn.ChiNhanhId

CREATE VIEW [dbo].[V_INFO_CN]
AS
SELECT        dbo.ChiNhanh.*
FROM            dbo.ChiNhanh
GO


CREATE VIEW [dbo].[V_NHANVIEN_DS]
AS
SELECT        NhanVienId, Ten + ' ' + Ho AS HoTen, Phai, DiaChi, SoDienThoai, NgaySinh, ChiNhanhId
FROM            dbo.NhanVien
WHERE        (TrangThai <> 1)
/***********************************end view****************************************/
/************************************start proc*************************************/

create PROC [dbo].[SP_INFOLOGIN] @lgname NVARCHAR(100)
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
	  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE NhanVienId = @TENUSER ),
	   TENNHOM= NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					 FROM SYS.SYSMEMBERS 
					   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										  WHERE NAME=@TENUSER))


END

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



CREATE proc SP_DATHANG @NhanVien bigint, @NhaCungCap bigint
as
begin
	SET XACT_ABORT ON 
	SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN TRANSACTION
	insert into DatHang (NhanVienId,NhaCungCapId) values(@NhanVien,@NhaCungCap);
	SELECT current_value FROM sys.sequences WHERE name = 'id_seq';
	COMMIT TRAN
end



CREATE proc SP_REMOVEDH @DatHangId bigint
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


create proc SP_TAOHOADON @NhanVien bigint, @Kho bigint, @KhachHang bigint
as
begin
	SET XACT_ABORT ON 
	SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN TRANSACTION
	insert into HoaDon (NhanVienId,KhoId,KhachHangId) values(@NhanVien,@Kho,@KhachHang);
	SELECT current_value FROM sys.sequences WHERE name = 'id_seq';
	COMMIT TRAN
end

/******************************end proc**********************************/