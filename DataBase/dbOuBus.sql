USE [master]
GO
/****** Object:  Database [OuBus]    Script Date: 1/14/2022 12:26:09 AM ******/
CREATE DATABASE [OuBus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OuBus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\OuBus.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OuBus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\OuBus_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OuBus] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OuBus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OuBus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OuBus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OuBus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OuBus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OuBus] SET ARITHABORT OFF 
GO
ALTER DATABASE [OuBus] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OuBus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OuBus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OuBus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OuBus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OuBus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OuBus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OuBus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OuBus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OuBus] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OuBus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OuBus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OuBus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OuBus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OuBus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OuBus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OuBus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OuBus] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OuBus] SET  MULTI_USER 
GO
ALTER DATABASE [OuBus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OuBus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OuBus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OuBus] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [OuBus] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OuBus] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [OuBus] SET QUERY_STORE = OFF
GO
USE [OuBus]
GO
/****** Object:  Table [dbo].[BaoCaoDoanhThuChuyenDi]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoDoanhThuChuyenDi](
	[MaChuyenDi] [int] NOT NULL,
	[DoanhThu] [int] NULL,
	[SoVe] [int] NULL,
	[Ngay] [datetime] NULL,
 CONSTRAINT [PK_BaoCaoDoanhThuChuyenDi] PRIMARY KEY CLUSTERED 
(
	[MaChuyenDi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenDi]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenDi](
	[MaChuyenDi] [int] NOT NULL,
	[MaXe] [int] NULL,
	[NgayKhoiHanh] [date] NULL,
	[ThoiGianKhoiHanh] [time](7) NULL,
	[DiemKhoiHanh] [nvarchar](50) NULL,
	[DiemKetThuc] [nvarchar](50) NULL,
	[SoGheTrong] [int] NULL,
	[SoGheDat] [int] NULL,
	[GiaVe] [int] NULL,
 CONSTRAINT [PK_ChuyenDi] PRIMARY KEY CLUSTERED 
(
	[MaChuyenDi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[MaLoaiNhanVien] [int] NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[CMND] [nvarchar](20) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanLoaiNhanVien]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLoaiNhanVien](
	[MaLoaiNhanVien] [int] NOT NULL,
	[TenLoaiNhanVien] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhanLoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanDangNhap]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanDangNhap](
	[TaiKhoan] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[MaNhanVien] [int] NULL,
	[MaQuyen] [int] NULL,
	[HoTen] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_TaiKhoanDangNhap] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeXe]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeXe](
	[MaVe] [int] IDENTITY(1,1) NOT NULL,
	[MaChuyenDi] [int] NULL,
	[MaNhanVien] [int] NULL,
	[TenKhachHang] [nvarchar](20) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[NgayDat] [date] NULL,
	[VitriGhe] [varchar](5) NULL,
	[TinhTrang] [nvarchar](10) NULL,
 CONSTRAINT [PK_VeXe] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XeKhach]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XeKhach](
	[MaXe] [int] NOT NULL,
	[MaNhanVien] [int] NULL,
	[BienSoXe] [varchar](10) NULL,
	[SoGhe] [int] NULL,
 CONSTRAINT [PK_XeKhach] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChuyenDi] ([MaChuyenDi], [MaXe], [NgayKhoiHanh], [ThoiGianKhoiHanh], [DiemKhoiHanh], [DiemKetThuc], [SoGheTrong], [SoGheDat], [GiaVe]) VALUES (2, 1, CAST(N'2022-01-01' AS Date), CAST(N'07:00:00' AS Time), N'Ninh Thuận', N'Vũng Tàu', 29, 0, 200000)
INSERT [dbo].[ChuyenDi] ([MaChuyenDi], [MaXe], [NgayKhoiHanh], [ThoiGianKhoiHanh], [DiemKhoiHanh], [DiemKetThuc], [SoGheTrong], [SoGheDat], [GiaVe]) VALUES (3, 2, CAST(N'2022-01-01' AS Date), CAST(N'07:00:00' AS Time), N'Ninh Thuận', N'Vũng Tàu', 25, 0, 200000)
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaLoaiNhanVien], [NgaySinh], [QueQuan], [CMND]) VALUES (6, N'Trần Quốc Hưng', 2, CAST(N'2001-11-18' AS Date), N'Ninh Thuận', N'123456789')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaLoaiNhanVien], [NgaySinh], [QueQuan], [CMND]) VALUES (7, N'Lê Cẩm Hoàng Lâm', 2, CAST(N'2001-01-01' AS Date), N'TP.HCM', N'123454567')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaLoaiNhanVien], [NgaySinh], [QueQuan], [CMND]) VALUES (8, N'Lê Đặng Thành Đạt', 2, CAST(N'2001-01-01' AS Date), N'TP.HCM', N'123456789')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaLoaiNhanVien], [NgaySinh], [QueQuan], [CMND]) VALUES (9, N'Trần Khải Vy', 1, CAST(N'2001-01-01' AS Date), N'TP.HCM', N'123456789')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaLoaiNhanVien], [NgaySinh], [QueQuan], [CMND]) VALUES (10, N'Nguyễn Vũ Ngọc Thiện', 1, CAST(N'2001-10-26' AS Date), N'TP.HCM', N'79')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
INSERT [dbo].[PhanLoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (1, N'Bán Vé')
INSERT [dbo].[PhanLoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (2, N'Chăm Sóc Khách Hàng')
INSERT [dbo].[PhanLoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (3, N'Markerting')
INSERT [dbo].[PhanLoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (4, N'Tài Xế')
GO
SET IDENTITY_INSERT [dbo].[PhanQuyen] ON 

INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (1, N'Nhân Viên')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (2, N'Quản Lý')
SET IDENTITY_INSERT [dbo].[PhanQuyen] OFF
GO
INSERT [dbo].[TaiKhoanDangNhap] ([TaiKhoan], [MatKhau], [MaNhanVien], [MaQuyen], [HoTen], [Email], [NgaySinh]) VALUES (N'quochung', N'123456', 6, 2, N'Trần Quốc Hưng', N'tqhung1234@gmail.com', CAST(N'2001-11-18' AS Date))
INSERT [dbo].[TaiKhoanDangNhap] ([TaiKhoan], [MatKhau], [MaNhanVien], [MaQuyen], [HoTen], [Email], [NgaySinh]) VALUES (N'Thien3721', N'Thien26102001', 5, 1, N'Nguyễn Vũ Ngọc Thiện', N'Thien@ou.edu.vn', CAST(N'2001-10-26' AS Date))
GO
INSERT [dbo].[XeKhach] ([MaXe], [MaNhanVien], [BienSoXe], [SoGhe]) VALUES (1, NULL, N'1', 29)
INSERT [dbo].[XeKhach] ([MaXe], [MaNhanVien], [BienSoXe], [SoGhe]) VALUES (2, NULL, N'2', 25)
GO
ALTER TABLE [dbo].[BaoCaoDoanhThuChuyenDi]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoDoanhThuChuyenDi_ChuyenDi] FOREIGN KEY([MaChuyenDi])
REFERENCES [dbo].[ChuyenDi] ([MaChuyenDi])
GO
ALTER TABLE [dbo].[BaoCaoDoanhThuChuyenDi] CHECK CONSTRAINT [FK_BaoCaoDoanhThuChuyenDi_ChuyenDi]
GO
ALTER TABLE [dbo].[ChuyenDi]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenDi_XeKhach] FOREIGN KEY([MaXe])
REFERENCES [dbo].[XeKhach] ([MaXe])
GO
ALTER TABLE [dbo].[ChuyenDi] CHECK CONSTRAINT [FK_ChuyenDi_XeKhach]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhanLoaiNhanVien] FOREIGN KEY([MaLoaiNhanVien])
REFERENCES [dbo].[PhanLoaiNhanVien] ([MaLoaiNhanVien])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhanLoaiNhanVien]
GO
ALTER TABLE [dbo].[TaiKhoanDangNhap]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanDangNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoanDangNhap] CHECK CONSTRAINT [FK_TaiKhoanDangNhap_NhanVien]
GO
ALTER TABLE [dbo].[TaiKhoanDangNhap]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanDangNhap_PhanQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[TaiKhoanDangNhap] CHECK CONSTRAINT [FK_TaiKhoanDangNhap_PhanQuyen]
GO
ALTER TABLE [dbo].[VeXe]  WITH CHECK ADD  CONSTRAINT [FK_VeXe_ChuyenDi] FOREIGN KEY([MaChuyenDi])
REFERENCES [dbo].[ChuyenDi] ([MaChuyenDi])
GO
ALTER TABLE [dbo].[VeXe] CHECK CONSTRAINT [FK_VeXe_ChuyenDi]
GO
ALTER TABLE [dbo].[VeXe]  WITH CHECK ADD  CONSTRAINT [FK_VeXe_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[VeXe] CHECK CONSTRAINT [FK_VeXe_NhanVien]
GO
ALTER TABLE [dbo].[XeKhach]  WITH CHECK ADD  CONSTRAINT [FK_XeKhach_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[XeKhach] CHECK CONSTRAINT [FK_XeKhach_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinChuyenDi]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaThongTinChuyenDi] @machuyendi int, @maxe int, @ngay date, @thoigian time, @khoihanh nvarchar(50), @ketthuc nvarchar(50), @giave nvarchar(20)
as
begin
	update ChuyenDi 
	set MaChuyenDi = @machuyendi, NgayKhoiHanh = @ngay, ThoiGianKhoiHanh = @thoigian, DiemKhoiHanh = @khoihanh, DiemKetThuc = @ketthuc, GiaVe = @giave
	where @machuyendi = MaChuyenDi
end

GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinNV]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaThongTinNV] @manv int, @maloai int, @ten nvarchar(50),@ngaysinh date, @quequan nvarchar(50), @cmnd nvarchar(12)
as
begin
	update NhanVien 
	set MaLoaiNhanVien = @maloai, TenNhanVien = @ten, NgaySinh = @ngaysinh, QueQuan = @quequan, CMND = @cmnd
	where @manv = MaNhanVien
end


GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinVeXe]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaThongTinVeXe] @mave int,@manhanvien int , @machuyendi int, @ten nvarchar(20), @sdt int, @vitri varchar(5)
as
begin
	declare @ngaydat Date
	update VeXe 
	set MaChuyenDi = @machuyendi,MaNhanVien = @manhanvien, NgayDat = @ngaydat, TenKhachHang = @ten, SoDienThoai = @sdt, VitriGhe = @vitri
	where @mave = MaVe
end

GO
/****** Object:  StoredProcedure [dbo].[ThemChuyenDi]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemChuyenDi] @machuyendi int, @maxe int, @ngay date, @thoigian time, @khoihanh nvarchar(50), @ketthuc nvarchar(50), @giave nvarchar(20)
as
begin
	insert into dbo.ChuyenDi(MaChuyenDi, MaXe, NgayKhoiHanh, ThoiGianKhoiHanh, DiemKhoiHanh, DiemKetThuc, GiaVe)
		values(@machuyendi, @maxe, @ngay, @thoigian, @khoihanh, @ketthuc , @giave)
	update ChuyenDi
	set SoGheTrong = 29, SoGheDat = 0
	where MaChuyenDi = @machuyendi and @maxe = 1
	update ChuyenDi
	set SoGheTrong = 25, SoGheDat = 0
	where MaChuyenDi = @machuyendi and @maxe = 2
end

GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ThemTaiKhoan] @taikhoan varchar(20), @matkhau varchar(20), @manv int, @maquyen int, @ten nvarchar(50), @email nvarchar(50), @ngaysinh date
as
begin
	insert into dbo.TaiKhoanDangNhap(TaiKhoan, MatKhau, MaNhanVien, MaQuyen, HoTen, Email, NgaySinh)
		values(@taikhoan , @matkhau , @manv, @maquyen, @ten, @email, @ngaysinh)
end


GO
/****** Object:  StoredProcedure [dbo].[ThemThongTinNV]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemThongTinNV] @maloai int, @ten nvarchar(50),@ngaysinh date, @quequan nvarchar(50), @cmnd nvarchar(12)
as
begin
	insert into dbo.NhanVien( MaLoaiNhanVien, TenNhanVien, NgaySinh, QueQuan, CMND)
		values( @maloai , @ten, @ngaysinh, @quequan, @cmnd )
end


GO
/****** Object:  StoredProcedure [dbo].[ThemVeXe]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemVeXe] @machuyendi int,@manhanvien int, @ten nvarchar(20), @sdt nvarchar(20), @vitri varchar(5)
as
begin
	insert into dbo.VeXe(MaChuyenDi,MaNhanVien, TenKhachHang, SoDienThoai, ViTriGhe)
		values(@machuyendi, @manhanvien, @ten, @sdt, @vitri)
	declare @ngaydat Date
	set @ngaydat = getdate()
	update VeXe set NgayDat = @ngaydat
end

GO
/****** Object:  StoredProcedure [dbo].[XoaChuyenDi]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[XoaChuyenDi] 
	@MaChuyenDi int
AS
BEGIN	
	DELETE FROM VeXe WHERE MaChuyenDi = @MaChuyenDi

	DELETE FROM ChuyenDi WHERE MaChuyenDi = @MaChuyenDi

	
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoan]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaTaiKhoan] @manhanvien int
as
begin
	delete from TaiKhoanDangNhap
	where @manhanvien = MaNhanVien
end


GO
/****** Object:  StoredProcedure [dbo].[XoaThongTinNV]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[XoaThongTinNV] @manv int
as
begin
	delete from VeXe
	where @manv = MaNhanVien

	delete from TaiKhoanDangNhap
	where @manv = MaNhanVien

	delete from NhanVien
	where @manv = MaNhanVien
end


GO
/****** Object:  StoredProcedure [dbo].[XoaVeXe]    Script Date: 1/14/2022 12:26:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaVeXe] @mave int
as
begin
	delete from VeXe
	where @mave = MaVe
end


GO
USE [master]
GO
ALTER DATABASE [OuBus] SET  READ_WRITE 
GO
