USE [master]
GO
/****** Object:  Database [MediaCenter]    Script Date: 05.06.2022 23:08:31 ******/
CREATE DATABASE [MediaCenter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MediaCenter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVERSQLMS\MSSQL\DATA\MediaCenter.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MediaCenter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVERSQLMS\MSSQL\DATA\MediaCenter_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MediaCenter] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MediaCenter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MediaCenter] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MediaCenter] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MediaCenter] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MediaCenter] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MediaCenter] SET ARITHABORT OFF 
GO
ALTER DATABASE [MediaCenter] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MediaCenter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MediaCenter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MediaCenter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MediaCenter] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MediaCenter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MediaCenter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MediaCenter] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MediaCenter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MediaCenter] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MediaCenter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MediaCenter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MediaCenter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MediaCenter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MediaCenter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MediaCenter] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MediaCenter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MediaCenter] SET RECOVERY FULL 
GO
ALTER DATABASE [MediaCenter] SET  MULTI_USER 
GO
ALTER DATABASE [MediaCenter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MediaCenter] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MediaCenter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MediaCenter] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MediaCenter] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MediaCenter] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MediaCenter', N'ON'
GO
ALTER DATABASE [MediaCenter] SET QUERY_STORE = OFF
GO
USE [MediaCenter]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 05.06.2022 23:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 05.06.2022 23:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[Patronymic] [nvarchar](max) NOT NULL,
	[ID_User] [int] NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 05.06.2022 23:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Type] [int] NOT NULL,
	[ID_Client] [int] NOT NULL,
	[Duration] [int] NOT NULL,
	[NumberOfExitsPerDay] [int] NOT NULL,
	[NumberOfDays] [int] NOT NULL,
	[Cost] [money] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[StartDate] [date] NOT NULL,
	[ID_Manager] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 05.06.2022 23:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[PricePerMinute] [money] NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 05.06.2022 23:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[Access] [tinyint] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID], [Name], [Phone]) VALUES (1, N'Роман Ульянины', N'89017304831')
INSERT [dbo].[Client] ([ID], [Name], [Phone]) VALUES (2, N'Артем Горбачев', N'89010381750')
INSERT [dbo].[Client] ([ID], [Name], [Phone]) VALUES (3, N'Владимир Смирнв', N'89017502884')
INSERT [dbo].[Client] ([ID], [Name], [Phone]) VALUES (4, N'Николай Бывшев', N'89016633026')
INSERT [dbo].[Client] ([ID], [Name], [Phone]) VALUES (5, N'Максим Малахов', N'89016610739')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([ID], [Surname], [FirstName], [Patronymic], [ID_User]) VALUES (4, N'Смирнов', N'Владимир', N'Андреевич', 6)
SET IDENTITY_INSERT [dbo].[Manager] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [ID_Type], [ID_Client], [Duration], [NumberOfExitsPerDay], [NumberOfDays], [Cost], [Description], [StartDate], [ID_Manager]) VALUES (29, 1, 1, 10, 10, 30, 25000.0000, N'Реклама маломамлеевской школы', CAST(N'2022-06-05' AS Date), 4)
INSERT [dbo].[Orders] ([ID], [ID_Type], [ID_Client], [Duration], [NumberOfExitsPerDay], [NumberOfDays], [Cost], [Description], [StartDate], [ID_Manager]) VALUES (30, 2, 2, 30, 20, 30, 150000.0000, N'Реклама наториальной конторы', CAST(N'2022-06-05' AS Date), 4)
INSERT [dbo].[Orders] ([ID], [ID_Type], [ID_Client], [Duration], [NumberOfExitsPerDay], [NumberOfDays], [Cost], [Description], [StartDate], [ID_Manager]) VALUES (31, 3, 3, 60, 30, 30, 900000.0000, N'Реклама библиотеки', CAST(N'2022-06-05' AS Date), 4)
INSERT [dbo].[Orders] ([ID], [ID_Type], [ID_Client], [Duration], [NumberOfExitsPerDay], [NumberOfDays], [Cost], [Description], [StartDate], [ID_Manager]) VALUES (32, 4, 4, 90, 60, 30, 810000.0000, N'Реклама звукозаписывающей студии', CAST(N'2022-06-05' AS Date), 4)
INSERT [dbo].[Orders] ([ID], [ID_Type], [ID_Client], [Duration], [NumberOfExitsPerDay], [NumberOfDays], [Cost], [Description], [StartDate], [ID_Manager]) VALUES (33, 5, 5, 120, 60, 30, 1080000.0000, N'Реклама автосервиса', CAST(N'2022-06-05' AS Date), 4)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([ID], [Type], [PricePerMinute]) VALUES (1, N'Имиджевая', 500.0000)
INSERT [dbo].[Type] ([ID], [Type], [PricePerMinute]) VALUES (2, N'Информационная', 500.0000)
INSERT [dbo].[Type] ([ID], [Type], [PricePerMinute]) VALUES (3, N'Креативная', 1000.0000)
INSERT [dbo].[Type] ([ID], [Type], [PricePerMinute]) VALUES (4, N'Музыкальная', 300.0000)
INSERT [dbo].[Type] ([ID], [Type], [PricePerMinute]) VALUES (5, N'Джингл', 300.0000)
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [login], [password], [Access]) VALUES (4, N'111', N'111', 1)
INSERT [dbo].[User] ([ID], [login], [password], [Access]) VALUES (6, N'1', N'1', 0)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Access]  DEFAULT ((0)) FOR [Access]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_Manager_User] FOREIGN KEY([ID_User])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_Manager_User]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Client] FOREIGN KEY([ID_Client])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Client]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Manager] FOREIGN KEY([ID_Manager])
REFERENCES [dbo].[Manager] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Manager]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Type] FOREIGN KEY([ID_Type])
REFERENCES [dbo].[Type] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Type]
GO
USE [master]
GO
ALTER DATABASE [MediaCenter] SET  READ_WRITE 
GO
