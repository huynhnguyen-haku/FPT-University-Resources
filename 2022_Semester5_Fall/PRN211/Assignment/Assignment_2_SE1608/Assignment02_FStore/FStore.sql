USE [master]
GO

CREATE DATABASE [FStore]
GO
ALTER DATABASE [FStore] SET COMPATIBILITY_LEVEL = 150
GO

GO
ALTER DATABASE [FStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [FStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FStore] SET  MULTI_USER 
GO
ALTER DATABASE [FStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FStore] SET QUERY_STORE = OFF
GO
USE [FStore]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitStock] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'NguyenHHK@gmail.com', N'FPT Software', N'Ho Chi Minh', N'Viet Nam', N'123123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'BoDT@gmail.com', N'HAGL Football Club', N'Binh Duong', N'Viet Nam', N'123456')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'nhilinh@gmail.com', N'Shang Hai Cosplayer', N'Tianxuan', N'China', N'111111')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'hongngoc@gmail.com', N'BabaMuqin Company', N'Benjing', N'China', N'222333')
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2022-10-15T00:00:00.000' AS DateTime), CAST(N'2022-10-18T00:00:00.000' AS DateTime), CAST(N'2022-10-18T00:00:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2022-09-30T00:00:00.000' AS DateTime), CAST(N'2022-10-01T00:00:00.000' AS DateTime), CAST(N'2022-10-01T00:00:00.000' AS DateTime), 3.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 1, CAST(N'2022-07-08T00:00:00.000' AS DateTime), CAST(N'2022-07-08T00:00:00.000' AS DateTime), CAST(N'2022-07-08T00:00:00.000' AS DateTime), 6.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (4, 1, CAST(N'2022-06-06T00:00:00.000' AS DateTime), CAST(N'2022-06-06T00:00:00.000' AS DateTime), CAST(N'2022-06-06T00:00:00.000' AS DateTime), 3.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (5, 1, CAST(N'2022-06-04T00:00:00.000' AS DateTime), CAST(N'2022-06-04T00:00:00.000' AS DateTime), CAST(N'2022-06-04T00:00:00.000' AS DateTime), 4.0000)

GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 1, 120000.0000, 1, 0)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 456.0000, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 3, 435.0000, 3, 0)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 1, 6543.0000, 10, 20)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitStock]) VALUES (1, 1, N'Asus Rog Strix', N'1', 10000.0000, 1)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitStock]) VALUES (2, 1, N'Acer Predator Helios', N'1', 5555.0000, 2)
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Member]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
USE [master]
GO
ALTER DATABASE [FStore] SET  READ_WRITE 
GO
