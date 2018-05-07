USE [master]
GO
/****** Object:  Database [Main Database]    Script Date: 7.05.2018 17:37:42 ******/
CREATE DATABASE [Main Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Main Database', FILENAME = N'D:\SQL Server 2017\MSSQL14.MSSQLSERVER\MSSQL\DATA\Main Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Main Database_log', FILENAME = N'D:\SQL Server 2017\MSSQL14.MSSQLSERVER\MSSQL\DATA\Main Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Main Database] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Main Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Main Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Main Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Main Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Main Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Main Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [Main Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Main Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Main Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Main Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Main Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Main Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Main Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Main Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Main Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Main Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Main Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Main Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Main Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Main Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Main Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Main Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Main Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Main Database] SET RECOVERY FULL 
GO
ALTER DATABASE [Main Database] SET  MULTI_USER 
GO
ALTER DATABASE [Main Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Main Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Main Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Main Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Main Database] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Main Database', N'ON'
GO
ALTER DATABASE [Main Database] SET QUERY_STORE = OFF
GO
USE [Main Database]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Main Database]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 7.05.2018 17:37:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NOT NULL,
	[name] [varchar](25) NOT NULL,
	[description] [varchar](160) NULL,
	[course_day] [varchar](25) NULL,
	[is_active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_id] [int] NULL,
	[name] [varchar](25) NOT NULL,
	[surname] [varchar](25) NOT NULL,
	[gender] [char](1) NOT NULL,
	[age] [smallint] NOT NULL,
	[email] [varchar](75) NULL,
	[phone_number] [bigint] NULL,
	[address] [varchar](160) NULL,
	[birth_date] [date] NULL,
	[date_joined] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipments]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[equipment_name] [varchar](100) NULL,
	[price] [float] NULL,
	[condition] [varchar](100) NULL,
	[date_of_arrival] [date] NULL,
	[warranty] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facilities]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facilities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[permission_id] [int] NOT NULL,
	[name] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member Improvements]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member Improvements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[member_id] [int] NOT NULL,
	[weight] [smallint] NULL,
	[height] [smallint] NULL,
	[date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[payment_id] [int] NOT NULL,
	[permission_id] [int] NOT NULL,
	[name] [varchar](25) NOT NULL,
	[surname] [varchar](25) NOT NULL,
	[gender] [char](1) NOT NULL,
	[age] [smallint] NOT NULL,
	[email] [varchar](75) NULL,
	[phone_number] [bigint] NULL,
	[address] [varchar](160) NULL,
	[height] [smallint] NULL,
	[weight] [smallint] NULL,
	[birth_date] [date] NOT NULL,
	[date_joined] [date] NOT NULL,
	[membership_expiry_date] [date] NOT NULL,
	[weekly_entrance_right] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Memberships]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Memberships](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[member_id] [int] NOT NULL,
	[new_payment_id] [int] NULL,
	[new_expiry_date] [date] NULL,
	[new_entrance_right] [int] NULL,
	[payment_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[amount] [int] NOT NULL,
	[payment_due_date] [date] NULL,
	[description] [varchar](160) NULL,
	[is_paid] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perms]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[facility_access_level] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[permission_id] [int] NOT NULL,
	[role_name] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salaries]    Script Date: 7.05.2018 17:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salaries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NULL,
	[amount] [int] NULL,
	[date] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employees] ([id])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Facilities]  WITH CHECK ADD FOREIGN KEY([permission_id])
REFERENCES [dbo].[Perms] ([id])
GO
ALTER TABLE [dbo].[Member Improvements]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[Members] ([id])
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD FOREIGN KEY([payment_id])
REFERENCES [dbo].[Payments] ([id])
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD FOREIGN KEY([permission_id])
REFERENCES [dbo].[Perms] ([id])
GO
ALTER TABLE [dbo].[Memberships]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[Members] ([id])
GO
ALTER TABLE [dbo].[Memberships]  WITH CHECK ADD FOREIGN KEY([new_payment_id])
REFERENCES [dbo].[Payments] ([id])
GO
ALTER TABLE [dbo].[Roles]  WITH CHECK ADD FOREIGN KEY([permission_id])
REFERENCES [dbo].[Perms] ([id])
GO
ALTER TABLE [dbo].[Salaries]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employees] ([id])
GO
USE [master]
GO
ALTER DATABASE [Main Database] SET  READ_WRITE 
GO
