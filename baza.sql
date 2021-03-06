USE [master]
GO
/****** Object:  Database [GuitarShopBlazor]    Script Date: 2/19/2020 5:58:18 PM ******/
CREATE DATABASE [GuitarShopBlazor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GuitarShopBlazor', FILENAME = N'C:\Users\pinos\GuitarShopBlazor.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GuitarShopBlazor_log', FILENAME = N'C:\Users\pinos\GuitarShopBlazor_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GuitarShopBlazor] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GuitarShopBlazor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GuitarShopBlazor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET ARITHABORT OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GuitarShopBlazor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GuitarShopBlazor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GuitarShopBlazor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GuitarShopBlazor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GuitarShopBlazor] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GuitarShopBlazor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GuitarShopBlazor] SET  MULTI_USER 
GO
ALTER DATABASE [GuitarShopBlazor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GuitarShopBlazor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GuitarShopBlazor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GuitarShopBlazor] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GuitarShopBlazor] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GuitarShopBlazor] SET QUERY_STORE = OFF
GO
USE [GuitarShopBlazor]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [GuitarShopBlazor]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2/19/2020 5:58:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuitarBillItem]    Script Date: 2/19/2020 5:58:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuitarBillItem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[GuitarId] [int] NULL,
	[GuitarBillId] [int] NULL,
 CONSTRAINT [PK_GuitarBillItem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuitarBills]    Script Date: 2/19/2020 5:58:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuitarBills](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_GuitarBills] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guitars]    Script Date: 2/19/2020 5:58:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guitars](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Guitars] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2/19/2020 5:58:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200219164354_Initial', N'3.1.0')
SET IDENTITY_INSERT [dbo].[GuitarBillItem] ON 

INSERT [dbo].[GuitarBillItem] ([id], [Number], [GuitarId], [GuitarBillId]) VALUES (1, 4, 7, 1)
INSERT [dbo].[GuitarBillItem] ([id], [Number], [GuitarId], [GuitarBillId]) VALUES (2, 1, 9, 1)
INSERT [dbo].[GuitarBillItem] ([id], [Number], [GuitarId], [GuitarBillId]) VALUES (3, 1, 10, 1)
SET IDENTITY_INSERT [dbo].[GuitarBillItem] OFF
SET IDENTITY_INSERT [dbo].[GuitarBills] ON 

INSERT [dbo].[GuitarBills] ([id], [Date], [UserId]) VALUES (1, CAST(N'2020-02-19T16:54:03.0000000' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[GuitarBills] OFF
SET IDENTITY_INSERT [dbo].[Guitars] ON 

INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (1, N'Gibson Les Paul', CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (2, N'Fender Stratocaster', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (3, N'Fender Telecaster', CAST(900.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (4, N'Gibson SE', CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (5, N'Ibanez Gio', CAST(350.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (6, N'Epiphone Les Paul', CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (7, N'Epiphone Lucile', CAST(890.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (8, N'Squier Strat', CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (9, N'Fender Jazzmaster', CAST(2100.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (10, N'Fender Custom Build', CAST(3600.00 AS Decimal(18, 2)))
INSERT [dbo].[Guitars] ([id], [Name], [Price]) VALUES (11, N'Squier Tele', CAST(190.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Guitars] OFF
/****** Object:  Index [IX_GuitarBillItem_GuitarBillId]    Script Date: 2/19/2020 5:58:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_GuitarBillItem_GuitarBillId] ON [dbo].[GuitarBillItem]
(
	[GuitarBillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GuitarBillItem_GuitarId]    Script Date: 2/19/2020 5:58:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_GuitarBillItem_GuitarId] ON [dbo].[GuitarBillItem]
(
	[GuitarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GuitarBills_UserId]    Script Date: 2/19/2020 5:58:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_GuitarBills_UserId] ON [dbo].[GuitarBills]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GuitarBillItem]  WITH CHECK ADD  CONSTRAINT [FK_GuitarBillItem_GuitarBills_GuitarBillId] FOREIGN KEY([GuitarBillId])
REFERENCES [dbo].[GuitarBills] ([id])
GO
ALTER TABLE [dbo].[GuitarBillItem] CHECK CONSTRAINT [FK_GuitarBillItem_GuitarBills_GuitarBillId]
GO
ALTER TABLE [dbo].[GuitarBillItem]  WITH CHECK ADD  CONSTRAINT [FK_GuitarBillItem_Guitars_GuitarId] FOREIGN KEY([GuitarId])
REFERENCES [dbo].[Guitars] ([id])
GO
ALTER TABLE [dbo].[GuitarBillItem] CHECK CONSTRAINT [FK_GuitarBillItem_Guitars_GuitarId]
GO
ALTER TABLE [dbo].[GuitarBills]  WITH CHECK ADD  CONSTRAINT [FK_GuitarBills_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[GuitarBills] CHECK CONSTRAINT [FK_GuitarBills_User_UserId]
GO
USE [master]
GO
ALTER DATABASE [GuitarShopBlazor] SET  READ_WRITE 
GO
