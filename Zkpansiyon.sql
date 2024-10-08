USE [master]
GO
/****** Object:  Database [Zkpansiyon]    Script Date: 26.09.2024 21:21:37 ******/
CREATE DATABASE [Zkpansiyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Zkpansiyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Zkpansiyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Zkpansiyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Zkpansiyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Zkpansiyon] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Zkpansiyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Zkpansiyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Zkpansiyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Zkpansiyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Zkpansiyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Zkpansiyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [Zkpansiyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Zkpansiyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Zkpansiyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Zkpansiyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Zkpansiyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Zkpansiyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Zkpansiyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Zkpansiyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Zkpansiyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Zkpansiyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Zkpansiyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Zkpansiyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Zkpansiyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Zkpansiyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Zkpansiyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Zkpansiyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Zkpansiyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Zkpansiyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Zkpansiyon] SET  MULTI_USER 
GO
ALTER DATABASE [Zkpansiyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Zkpansiyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Zkpansiyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Zkpansiyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Zkpansiyon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Zkpansiyon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Zkpansiyon] SET QUERY_STORE = OFF
GO
USE [Zkpansiyon]
GO
/****** Object:  Table [dbo].[AdminGiris]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGiris](
	[Kullanici] [varchar](50) NULL,
	[Şifre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[İnternet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajlar]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajlar](
	[Mesajid] [int] IDENTITY(1,1) NOT NULL,
	[Adsoyad] [varchar](50) NULL,
	[Mesaj] [varchar](1500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MüsteriEkle]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MüsteriEkle](
	[Müsteriid] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL,
	[Cinsiyet] [varchar](5) NULL,
	[Telefon] [varchar](15) NULL,
	[Mail] [varchar](50) NULL,
	[TC] [varchar](12) NULL,
	[OdaNo] [varchar](5) NULL,
	[Ucret] [int] NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda101]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda101](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda102]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda102](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda103]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda103](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda104]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda104](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda105]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda105](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda106]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda106](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda107]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda107](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda108]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda108](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda109]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda109](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 26.09.2024 21:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[Gıda] [int] NULL,
	[İcecek] [int] NULL,
	[Cerezler] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MüsteriEkle] ADD  CONSTRAINT [DF_MüsteriEkle_GirisTarihi]  DEFAULT (getdate()) FOR [GirisTarihi]
GO
ALTER TABLE [dbo].[MüsteriEkle] ADD  CONSTRAINT [DF_Table_1_CıkısTarihi]  DEFAULT (getdate()) FOR [CikisTarihi]
GO
USE [master]
GO
ALTER DATABASE [Zkpansiyon] SET  READ_WRITE 
GO
