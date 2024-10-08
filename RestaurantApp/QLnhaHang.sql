use [QLNhaHang]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[HoTen] [nchar](50) NOT NULL,
	[SoDienThoai] [nvarchar](20) NOT NULL,
	[DiemTichLuy] [int] NULL,
	[NgaySinh] [date] NOT NULL,
	[LoaiKhachHang] [nchar](20) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[NgayXuat] [date] NOT NULL,
	[LoaiHoaDon] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioLamViec]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioLamViec](
	[MaCaTruc] [nchar](10) NOT NULL,
	[Ngay] [date] NULL,
	[LoaiCaTruc] [nchar](20) NULL,
 CONSTRAINT [PK_CaTruc] PRIMARY KEY CLUSTERED 
(
	[MaCaTruc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachTaiKhoan]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachTaiKhoan](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_DanhSachTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachBan]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachBan](
	[MaBan] [nchar](10) NOT NULL,
	[NgayDatBan] [date] NOT NULL,
	[SoLuongKhach] [int] NOT NULL,
	[ThongTinThem] [nchar](20) NULL,
 CONSTRAINT [PK_DanhSachBan] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDanhMuc] [nchar](10) NOT NULL,
	[TenDanhMuc] [nchar](20) NULL,
	[MoTa] [nchar](50) NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nchar](10) NOT NULL,
	[HoNV] [nchar](10) NOT NULL,
	[TenNV] [nchar](20) NOT NULL,
	[SoDienThoai] [nchar](20) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[NgayVaoLam] [date] NOT NULL,
	[ChucVu] [nchar](10) NOT NULL,
	[LuongThang] [money] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nchar](10) NOT NULL,
	[TenNhaCungCap] [nchar](20) NOT NULL,
	[DiaChi] [nchar](50) NULL,
	[SoDienThoai] [int] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietGioLamViec]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietGioLamViec](
	[MaCaTruc] [nchar](10) NOT NULL,
	[MaNhanVien] [nchar](10) NOT NULL,
	[TienThuong] [money] NULL,
	[LoaiCaTruc] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietCaTruc] PRIMARY KEY CLUSTERED 
(
	[MaCaTruc] ASC,
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [nchar](10) NOT NULL,
	[TenNL] [nchar](10) NOT NULL,
	[NgayNhap] [date] NULL,
	[NgayTonKho] [int] NULL,
	[MaNhaCungCap] [nchar](10) NOT NULL,
	[SoLuongTonkho] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [nchar](10) NOT NULL,
	[TenMonAn] [nchar](50) NOT NULL,
	[GiaTien] [money] NOT NULL,
	[MaDanhMuc] [nchar](10) NOT NULL,
	[TenDanhMuc] [nchar](20) NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietMonAn]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietMonAn](
	[MaMonAn] [nchar](10) NOT NULL,
	[MaNguyenLieu] [nchar](10) NOT NULL,
	[TenMonAn] [nchar](30) NOT NULL,
	[TenNguyenLieu] [nchar](30) NOT NULL,
	[GiaTien] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietMonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 03/30/2017 14:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaMonAn] [nchar](10) NOT NULL,
	[MaHoaDon] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_ChiTietGioLamViec_GioLamViec]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[ChiTietGioLamViec]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioLamViec_GioLamViec] FOREIGN KEY([MaCaTruc])
REFERENCES [dbo].[GioLamViec] ([MaCaTruc])
GO
ALTER TABLE [dbo].[ChiTietGioLamViec] CHECK CONSTRAINT [FK_ChiTietGioLamViec_GioLamViec]
GO
/****** Object:  ForeignKey [FK_ChiTietGioLamViec_NhanVien]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[ChiTietGioLamViec]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioLamViec_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ChiTietGioLamViec] CHECK CONSTRAINT [FK_ChiTietGioLamViec_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HoaDon]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_MonAn]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_MonAn]
GO
/****** Object:  ForeignKey [FK_ChiTietMonAn_MonAn]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[ChiTietMonAn]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMonAn_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[ChiTietMonAn] CHECK CONSTRAINT [FK_ChiTietMonAn_MonAn]
GO
/****** Object:  ForeignKey [FK_ChiTietMonAn_NguyenLieu]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[ChiTietMonAn]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMonAn_NguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[ChiTietMonAn] CHECK CONSTRAINT [FK_ChiTietMonAn_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_MonAn_DanhMuc]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_DanhMuc] FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_DanhMuc]
GO
/****** Object:  ForeignKey [FK_NguyenLieu_NhaCungCap]    Script Date: 03/30/2017 14:54:33 ******/
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_NhaCungCap]
GO
