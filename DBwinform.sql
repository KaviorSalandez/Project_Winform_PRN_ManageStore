USE [master]
GO
/****** Object:  Database [DB_PRN211_Project]    Script Date: 3/29/2023 9:24:45 AM ******/
CREATE DATABASE [DB_PRN211_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_PRN211_Project', FILENAME = N'D:\SQL2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_PRN211_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_PRN211_Project_log', FILENAME = N'D:\SQL2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_PRN211_Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_PRN211_Project] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_PRN211_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_PRN211_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_PRN211_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_PRN211_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_PRN211_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_PRN211_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_PRN211_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_PRN211_Project] SET  MULTI_USER 
GO
ALTER DATABASE [DB_PRN211_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_PRN211_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_PRN211_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_PRN211_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_PRN211_Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_PRN211_Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_PRN211_Project] SET QUERY_STORE = OFF
GO
USE [DB_PRN211_Project]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 3/29/2023 9:24:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[pasword] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[dob] [datetime] NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 3/29/2023 9:24:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/29/2023 9:24:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/29/2023 9:24:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Descrip] [nvarchar](500) NULL,
	[bid] [int] NULL,
	[cid] [int] NULL,
	[stock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/29/2023 9:24:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (1, N'khanhcd', N'1', N'0979039318', N'cankhanh343@gmail.com', CAST(N'2002-03-13T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (2, N'manhbaby', N'123', N'0999777888', N'manhbaby@gmail.com', CAST(N'2002-05-03T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (3, N'linhmp', N'123', N'0987654321', N'linhmp@gmail.com', CAST(N'2002-07-25T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (4, N'truongbq', N'123', N'0985963145', N'truong123@gmail.com', CAST(N'2002-09-15T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (5, N'longnh', N'456', N'0969262933', N'longbe@gmail.com', CAST(N'1989-05-25T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (6, N'quanshake', N'123', N'0963215681', N'quansake@tokuda.com', CAST(N'2000-06-20T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (7, N'truongtokuda', N'123', N'0979063925', N'truongtokuda@gmail.com', CAST(N'2000-04-23T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (9, N'user2', N'123', N'0985656624', N'user2@gmail.com', CAST(N'1998-09-05T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (10, N'user3', N'123', N'0848562656', N'user3@gmail.com', CAST(N'1989-06-08T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (11, N'user4', N'user4', N'09872656216', N'user4@gmail.com', CAST(N'2004-05-25T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (12, N'user5', N'user5', N'09945546446', N'user5@gmail.com', CAST(N'2003-12-25T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (13, N'user6', N'user6', N'0979841551', N'user6@gmail.com', CAST(N'2001-05-23T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (14, N'user7', N'user7', N'0985266266', N'user7@gmail.com', CAST(N'2000-03-05T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (15, N'nhanvien111', N'123', N'098979798', N'nhanvien1@tokuda.com', CAST(N'2000-07-13T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Accounts] ([id], [username], [pasword], [phone], [email], [dob], [role_id]) VALUES (17, N'test', N'123', N'09945546442424', N'test@gmail.com', CAST(N'2003-12-25T00:00:00.000' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([id], [Name]) VALUES (1, N'Akko')
INSERT [dbo].[Brands] ([id], [Name]) VALUES (2, N'Razer')
INSERT [dbo].[Brands] ([id], [Name]) VALUES (3, N'LeoPord')
INSERT [dbo].[Brands] ([id], [Name]) VALUES (4, N'Logitech')
INSERT [dbo].[Brands] ([id], [Name]) VALUES (5, N'KEYCHRON')
INSERT [dbo].[Brands] ([id], [Name]) VALUES (9, N'Logitech')
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([id], [Name]) VALUES (1, N'USB')
INSERT [dbo].[Categories] ([id], [Name]) VALUES (2, N'Có dây')
INSERT [dbo].[Categories] ([id], [Name]) VALUES (3, N'3 mode')
INSERT [dbo].[Categories] ([id], [Name]) VALUES (4, N'Wireless')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (1, N'Akko1', 200000, N'Bàn phím đẹp long lanh, đánh ra âm lượng hài hòa', 1, 1, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (2, N'Akko2', 800000, N'Sử dụng chất liệu nhựa PBT tại phần keycap vậy nên đem đến cho người dùng một cảm giác gõ rất tốt', 1, 2, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (3, N'Akko3', 1500000, N'switch người dùng những loại cao cấp nhất chính là Cherry Switch. ', 1, 3, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (4, N'Akko4', 900000, N'Xuất xứ từ Trung Quốc, thiết kế vô cùng thời trang và màu sắc', 1, 2, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (5, N'Razer1', 400000, N'Razer1 cho cảm giác gõ trong mức ổn', 2, 1, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (6, N'Razer2', 800000, N'Bàn phím cơ Razer2 sử dụng ánh sáng để nhận lệnh thay cho cơ chế cánh bướm kim loại truyền thống', 2, 2, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (7, N'Razer3', 1400000, N'Sản phẩm của Razer3 hướng về game thủ là phần lớn với phần đèn và hiệu ứng luôn rất được chú trọng', 2, 3, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (8, N'LeoPord1', 500000, N'Keycap chất liệu PBT Doubleshot siêu bền', 3, 1, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (9, N'LeoPord2', 700000, N'Sử dụng 100% Switch Cherry chất lượng cao nhất được chọn lọc kĩ càng', 3, 2, 0)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (10, N'LeoPord3', 1600000, N'Chất lượng gia công bàn phím cơ của LeoPold rất chắc chắn, khi nhấn vào rất “đã tay” không kém gì bàn phím Filcohất lượng gia công bàn phím cơ của LeoPold rất chắc chắn, khi nhấn vào rất “đã tay” không kém gì bàn phím Filco', 3, 3, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (11, N'Logitech1', 700000, N'Thương hiệu được yêu thích bởi rất nhiều phân khúc từ trung bình thấp, đến cao cấp đều có', 4, 1, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (12, N'Logitech2', 1500000, N'Giá thành phù hợp với mọi đối tượng', 4, 2, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (13, N'Logitech3', 1800000, N'Không tự rập khuôn vào một phong cách nhất định. Logitech3 có thể gọi là “con tắc kè hoa” trong làng công nghệ', 4, 3, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (14, N'KEYCHRON1', 400000, N'Thiết kế siêu mỏng, cùng switch low profile đòi hỏi ít lực hơn và sự di chuyển của ngón tay.', 5, 1, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (15, N'KEYCHRON2', 600000, N'bàn phím cơ này mày mang phong cách thiết kế vô cùng tối giản đơn giản.', 5, 2, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (16, N'KEYCHRON3', 1800000, N'đây thực sự là một loại bàn phím rất hữu dụng bên cạnh những bàn phím chuyên dụng dành cho Macbook.', 5, 3, 100)
INSERT [dbo].[Products] ([id], [Name], [Price], [Descrip], [bid], [cid], [stock]) VALUES (18, N'Akko5', 400000, N'Bàn phím đẹp long lanh, đánh ra âm lượng hài hòa đánh rất đầm tay', 1, 4, 100)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id], [Name]) VALUES (1, N'Quản lí ')
INSERT [dbo].[Roles] ([id], [Name]) VALUES (2, N'Nhân viên')
INSERT [dbo].[Roles] ([id], [Name]) VALUES (3, N'Khách hàng')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([bid])
REFERENCES [dbo].[Brands] ([id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([cid])
REFERENCES [dbo].[Categories] ([id])
GO
USE [master]
GO
ALTER DATABASE [DB_PRN211_Project] SET  READ_WRITE 
GO
