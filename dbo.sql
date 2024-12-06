/*
 Navicat Premium Dump SQL

 Source Server         : SqlServer
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : KAI\SQLEXPRESS:1433
 Source Catalog        : quanLyThueXe
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 06/12/2024 18:08:36
*/


-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type IN ('U'))
	DROP TABLE [dbo].[__EFMigrationsHistory]
GO

CREATE TABLE [dbo].[__EFMigrationsHistory] (
  [MigrationId] nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProductVersion] nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[__EFMigrationsHistory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241206073655_themDuongDanAnhChoXe', N'8.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241206085429_themTrangThai', N'8.0.11')
GO


-- ----------------------------
-- Table structure for tblChucVu
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblChucVu]') AND type IN ('U'))
	DROP TABLE [dbo].[tblChucVu]
GO

CREATE TABLE [dbo].[tblChucVu] (
  [iMaCV] int  IDENTITY(1,1) NOT NULL,
  [sTenCV] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [fLuongCoBan] float(53)  NULL
)
GO

ALTER TABLE [dbo].[tblChucVu] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblChucVu
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblChucVu] ON
GO

SET IDENTITY_INSERT [dbo].[tblChucVu] OFF
GO


-- ----------------------------
-- Table structure for tblHoaDon
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoaDon]') AND type IN ('U'))
	DROP TABLE [dbo].[tblHoaDon]
GO

CREATE TABLE [dbo].[tblHoaDon] (
  [iMaHoaDon] int  NOT NULL,
  [iMaNV] int  NULL,
  [iMaKH] int  NULL,
  [iPhuongTien] int  NULL,
  [dNgayTra] datetime  NULL,
  [dNgayThue] datetime  NULL,
  [fTienCoc] float(53)  NULL,
  [fTienThue] float(53)  NULL
)
GO

ALTER TABLE [dbo].[tblHoaDon] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblHoaDon
-- ----------------------------

-- ----------------------------
-- Table structure for tblKhachHang
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblKhachHang]') AND type IN ('U'))
	DROP TABLE [dbo].[tblKhachHang]
GO

CREATE TABLE [dbo].[tblKhachHang] (
  [iMaKH] int  NOT NULL,
  [sTenKH] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sSDT] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sGioiTinh] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sCCCD] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sDiaChi] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblKhachHang] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblKhachHang
-- ----------------------------

-- ----------------------------
-- Table structure for tblLoaiPhuongTien
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLoaiPhuongTien]') AND type IN ('U'))
	DROP TABLE [dbo].[tblLoaiPhuongTien]
GO

CREATE TABLE [dbo].[tblLoaiPhuongTien] (
  [iMaLoaiPhuongTien] int  NOT NULL,
  [sLoaiPhuongTien] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblLoaiPhuongTien] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblLoaiPhuongTien
-- ----------------------------
INSERT INTO [dbo].[tblLoaiPhuongTien] ([iMaLoaiPhuongTien], [sLoaiPhuongTien]) VALUES (N'1', N'Xe 5 chỗ')
GO

INSERT INTO [dbo].[tblLoaiPhuongTien] ([iMaLoaiPhuongTien], [sLoaiPhuongTien]) VALUES (N'2', N'Xe 7 chỗ')
GO

INSERT INTO [dbo].[tblLoaiPhuongTien] ([iMaLoaiPhuongTien], [sLoaiPhuongTien]) VALUES (N'3', N'Xe 14 chỗ')
GO


-- ----------------------------
-- Table structure for tblNhaCungCap
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblNhaCungCap]') AND type IN ('U'))
	DROP TABLE [dbo].[tblNhaCungCap]
GO

CREATE TABLE [dbo].[tblNhaCungCap] (
  [sMaNCC] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [sTenNCC] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblNhaCungCap] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblNhaCungCap
-- ----------------------------

-- ----------------------------
-- Table structure for tblNhanVien
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblNhanVien]') AND type IN ('U'))
	DROP TABLE [dbo].[tblNhanVien]
GO

CREATE TABLE [dbo].[tblNhanVien] (
  [iMaNV] int  NOT NULL,
  [iMaCV] int  NULL,
  [sTenNV] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sSDT] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sGioiTinh] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sCCCD] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sDiaChi] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblNhanVien] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblNhanVien
-- ----------------------------

-- ----------------------------
-- Table structure for tblPhieuBaoTri
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPhieuBaoTri]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPhieuBaoTri]
GO

CREATE TABLE [dbo].[tblPhieuBaoTri] (
  [sMaBT] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [iMaPhuongTien] int  NULL,
  [sGhiChu] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [iMaNV] int  NULL,
  [dThoiGian] datetime  NULL
)
GO

ALTER TABLE [dbo].[tblPhieuBaoTri] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPhieuBaoTri
-- ----------------------------
INSERT INTO [dbo].[tblPhieuBaoTri] ([sMaBT], [iMaPhuongTien], [sGhiChu], [iMaNV], [dThoiGian]) VALUES (N'BT01', N'2', N'Ô tô này đã được bảo trì định kỳ với các công việc bao gồm thay dầu động cơ, kiểm tra và thay thế bộ lọc gió, kiểm tra hệ thống phanh, và thay dầu phanh. Các bộ phận khác như lọc nhiên liệu, bugi, dây curoa, và hệ thống làm mát cũng đã được kiểm tra kỹ lưỡng và thay thế nếu cần thiết. Hệ thống lốp xe đã được kiểm tra độ mòn và bơm khí đầy đủ. Ngoài ra, hệ thống điện, đèn chiếu sáng và các cảm biến cũng đã được kiểm tra và hiệu chỉnh để đảm bảo xe hoạt động ổn định và an toàn trong mọi điều kiện di chuyển.', NULL, N'2024-12-06 15:20:23.000')
GO


-- ----------------------------
-- Table structure for tblPhieuNhapKho
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPhieuNhapKho]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPhieuNhapKho]
GO

CREATE TABLE [dbo].[tblPhieuNhapKho] (
  [iMaPhieuNhap] int  NOT NULL,
  [iMaPhuongTien] int  NULL,
  [fTongGiaNhap] float(53)  NULL,
  [sMaNCC] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [iMaNV] int  NULL
)
GO

ALTER TABLE [dbo].[tblPhieuNhapKho] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPhieuNhapKho
-- ----------------------------

-- ----------------------------
-- Table structure for tblPhieuXuatXe
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPhieuXuatXe]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPhieuXuatXe]
GO

CREATE TABLE [dbo].[tblPhieuXuatXe] (
  [iMaPhieuXuat] int  NOT NULL,
  [iMaNV] int  NULL,
  [iTongSLX] int  NULL,
  [fTongTien] float(53)  NULL
)
GO

ALTER TABLE [dbo].[tblPhieuXuatXe] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPhieuXuatXe
-- ----------------------------

-- ----------------------------
-- Table structure for tblPhuongTien
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPhuongTien]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPhuongTien]
GO

CREATE TABLE [dbo].[tblPhuongTien] (
  [iMaPhuongTien] int  IDENTITY(1,1) NOT NULL,
  [sTenPhuongTien] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [iMaLoaiPhuongTien] int  NULL,
  [fGiaChoThue] float(53)  NULL,
  [sBienSoXe] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sDuongDan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sTrangThai] bit  NULL
)
GO

ALTER TABLE [dbo].[tblPhuongTien] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPhuongTien
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblPhuongTien] ON
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'1', N'Vinfast Lux A', N'1', N'2000000', N'29A-12345', N'img/luxa.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'2', N'Vinfast VF8', N'2', N'2000000', N'29A-23456', N'img/vf8.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'3', N'Vinfast VF9', N'2', N'2000000', N'29A-34567', N'img/vf9.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'6', N'Mazda 3', N'1', N'1800000', N'30A-12345', N'img/mazda3.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'7', N'Toyota Camry', N'1', N'2500000', N'30A-23456', N'img/camry.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'8', N'Honda Accord', N'1', N'2400000', N'30A-34567', N'img/accord.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'9', N'Hyundai Sonata', N'1', N'2200000', N'30A-45678', N'img/sonata.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'10', N'BMW X5', N'1', N'5000000', N'31A-12345', N'img/bmx5.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'11', N'Mercedes-Benz E-Class', N'1', N'5500000', N'31A-23456', N'img/eclass.jpg', N'0')
GO

INSERT INTO [dbo].[tblPhuongTien] ([iMaPhuongTien], [sTenPhuongTien], [iMaLoaiPhuongTien], [fGiaChoThue], [sBienSoXe], [sDuongDan], [sTrangThai]) VALUES (N'12', N'Audi A6', N'1', N'4800000', N'31A-34567', N'img/audi.jpg', N'0')
GO

SET IDENTITY_INSERT [dbo].[tblPhuongTien] OFF
GO


-- ----------------------------
-- Table structure for tblTaiKhoan
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTaiKhoan]') AND type IN ('U'))
	DROP TABLE [dbo].[tblTaiKhoan]
GO

CREATE TABLE [dbo].[tblTaiKhoan] (
  [iMaTK] int  IDENTITY(1,1) NOT NULL,
  [sTaiKhoan] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [sMatKhau] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [iMaNV] int  NULL,
  [dNgayCapTK] datetime DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[tblTaiKhoan] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblTaiKhoan
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblTaiKhoan] ON
GO

SET IDENTITY_INSERT [dbo].[tblTaiKhoan] OFF
GO


-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE [dbo].[__EFMigrationsHistory] ADD CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for tblChucVu
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[tblChucVu]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table tblChucVu
-- ----------------------------
ALTER TABLE [dbo].[tblChucVu] ADD CONSTRAINT [PK__tblChucV__F20AE40C630966F5] PRIMARY KEY CLUSTERED ([iMaCV])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblHoaDon
-- ----------------------------
ALTER TABLE [dbo].[tblHoaDon] ADD CONSTRAINT [PK__tblHoaDo__0F47ABC494F45C73] PRIMARY KEY CLUSTERED ([iMaHoaDon])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblKhachHang
-- ----------------------------
ALTER TABLE [dbo].[tblKhachHang] ADD CONSTRAINT [PK__tblKhach__F20AA508F1D84BF4] PRIMARY KEY CLUSTERED ([iMaKH])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblLoaiPhuongTien
-- ----------------------------
ALTER TABLE [dbo].[tblLoaiPhuongTien] ADD CONSTRAINT [PK__tblLoaiP__303AFA6AE4CEB5F4] PRIMARY KEY CLUSTERED ([iMaLoaiPhuongTien])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblNhaCungCap
-- ----------------------------
ALTER TABLE [dbo].[tblNhaCungCap] ADD CONSTRAINT [PK__tblNhaCu__FDC9EEF61C4ED364] PRIMARY KEY CLUSTERED ([sMaNCC])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblNhanVien
-- ----------------------------
ALTER TABLE [dbo].[tblNhanVien] ADD CONSTRAINT [PK__tblNhanV__F20A8D79A40A2006] PRIMARY KEY CLUSTERED ([iMaNV])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPhieuBaoTri
-- ----------------------------
ALTER TABLE [dbo].[tblPhieuBaoTri] ADD CONSTRAINT [PK__tblPhieu__328E3D8222659195] PRIMARY KEY CLUSTERED ([sMaBT])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPhieuNhapKho
-- ----------------------------
ALTER TABLE [dbo].[tblPhieuNhapKho] ADD CONSTRAINT [PK__tblPhieu__23AF4DB19C5E385D] PRIMARY KEY CLUSTERED ([iMaPhieuNhap])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPhieuXuatXe
-- ----------------------------
ALTER TABLE [dbo].[tblPhieuXuatXe] ADD CONSTRAINT [PK__tblPhieu__EECC13AC92BAB950] PRIMARY KEY CLUSTERED ([iMaPhieuXuat])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for tblPhuongTien
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[tblPhuongTien]', RESEED, 12)
GO


-- ----------------------------
-- Primary Key structure for table tblPhuongTien
-- ----------------------------
ALTER TABLE [dbo].[tblPhuongTien] ADD CONSTRAINT [PK__tblPhuon__BAC9562E134F554D] PRIMARY KEY CLUSTERED ([iMaPhuongTien])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for tblTaiKhoan
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[tblTaiKhoan]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table tblTaiKhoan
-- ----------------------------
ALTER TABLE [dbo].[tblTaiKhoan] ADD CONSTRAINT [PK__tblTaiKh__F20A5E341E113505] PRIMARY KEY CLUSTERED ([iMaTK])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table tblHoaDon
-- ----------------------------
ALTER TABLE [dbo].[tblHoaDon] ADD CONSTRAINT [FK__tblHoaDon__iMaNV__0E6E26BF] FOREIGN KEY ([iMaNV]) REFERENCES [dbo].[tblNhanVien] ([iMaNV]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tblHoaDon] ADD CONSTRAINT [FK__tblHoaDon__iMaKH__0F624AF8] FOREIGN KEY ([iMaKH]) REFERENCES [dbo].[tblKhachHang] ([iMaKH]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tblHoaDon] ADD CONSTRAINT [FK__tblHoaDon__iPhuo__10566F31] FOREIGN KEY ([iPhuongTien]) REFERENCES [dbo].[tblPhuongTien] ([iMaPhuongTien]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tblPhieuBaoTri
-- ----------------------------
ALTER TABLE [dbo].[tblPhieuBaoTri] ADD CONSTRAINT [FK__tblPhieuB__iMaPh__1332DBDC] FOREIGN KEY ([iMaPhuongTien]) REFERENCES [dbo].[tblPhuongTien] ([iMaPhuongTien]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tblPhieuBaoTri] ADD CONSTRAINT [FK__tblPhieuB__iMaNV__14270015] FOREIGN KEY ([iMaNV]) REFERENCES [dbo].[tblNhanVien] ([iMaNV]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tblPhieuNhapKho
-- ----------------------------
ALTER TABLE [dbo].[tblPhieuNhapKho] ADD CONSTRAINT [FK__tblPhieuN__iMaPh__17036CC0] FOREIGN KEY ([iMaPhuongTien]) REFERENCES [dbo].[tblPhuongTien] ([iMaPhuongTien]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tblPhieuNhapKho] ADD CONSTRAINT [FK__tblPhieuN__sMaNC__17F790F9] FOREIGN KEY ([sMaNCC]) REFERENCES [dbo].[tblNhaCungCap] ([sMaNCC]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tblPhieuNhapKho] ADD CONSTRAINT [FK__tblPhieuN__iMaNV__18EBB532] FOREIGN KEY ([iMaNV]) REFERENCES [dbo].[tblNhanVien] ([iMaNV]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tblPhieuXuatXe
-- ----------------------------
ALTER TABLE [dbo].[tblPhieuXuatXe] ADD CONSTRAINT [FK__tblPhieuX__iMaNV__1BC821DD] FOREIGN KEY ([iMaNV]) REFERENCES [dbo].[tblNhanVien] ([iMaNV]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tblPhuongTien
-- ----------------------------
ALTER TABLE [dbo].[tblPhuongTien] ADD CONSTRAINT [FK__tblPhuong__iMaLo__0B91BA14] FOREIGN KEY ([iMaLoaiPhuongTien]) REFERENCES [dbo].[tblLoaiPhuongTien] ([iMaLoaiPhuongTien]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tblTaiKhoan
-- ----------------------------
ALTER TABLE [dbo].[tblTaiKhoan] ADD CONSTRAINT [FK__tblTaiKho__iMaNV__03F0984C] FOREIGN KEY ([iMaNV]) REFERENCES [dbo].[tblNhanVien] ([iMaNV]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

