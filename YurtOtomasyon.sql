USE [master]
GO
/****** Object:  Database [YurtOtomasyon]    Script Date: 26.09.2024 21:22:33 ******/
CREATE DATABASE [YurtOtomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YurtOtomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\YurtOtomasyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YurtOtomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\YurtOtomasyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [YurtOtomasyon] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YurtOtomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YurtOtomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YurtOtomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YurtOtomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YurtOtomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [YurtOtomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YurtOtomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YurtOtomasyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YurtOtomasyon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [YurtOtomasyon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [YurtOtomasyon] SET QUERY_STORE = OFF
GO
USE [YurtOtomasyon]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Yoneticiid] [tinyint] IDENTITY(1,1) NOT NULL,
	[YoneticiAd] [varchar](50) NULL,
	[YoneticiSifre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[Bolumid] [tinyint] IDENTITY(1,1) NOT NULL,
	[BolumAd] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borclar]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borclar](
	[Ogrid] [int] NULL,
	[OgrAd] [varchar](50) NULL,
	[OgrSoyad] [varchar](50) NULL,
	[OgrKalanBorc] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giderler]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giderler](
	[Odemeid] [smallint] IDENTITY(1,1) NOT NULL,
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[Doğalgaz] [int] NULL,
	[İnternet] [int] NULL,
	[Gıda] [int] NULL,
	[Personel] [int] NULL,
	[Diger] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasa]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasa](
	[OdemeAy] [varchar](50) NULL,
	[OdemeMiktar] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[Odaid] [tinyint] IDENTITY(1,1) NOT NULL,
	[OdaNo] [char](3) NULL,
	[OdaKapasite] [char](1) NULL,
	[OdaAktif] [char](1) NULL,
	[OdaDurum] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[Ogrid] [int] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](50) NULL,
	[OgrSoyad] [varchar](50) NULL,
	[OgrTc] [char](11) NULL,
	[OgrTelefon] [varchar](20) NULL,
	[OgrDogum] [varchar](12) NULL,
	[OgrBolum] [varchar](50) NULL,
	[OgrMail] [varchar](50) NULL,
	[OgrOdaNo] [char](3) NULL,
	[OgrVeliAdSoyad] [varchar](50) NULL,
	[OgrVeliTelefon] [varchar](50) NULL,
	[OgrAdres] [varchar](50) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[Ogrid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 26.09.2024 21:22:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Personelid] [tinyint] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [varchar](50) NULL,
	[PersonelDepartman] [varchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Borclar] ADD  CONSTRAINT [DF_Borclar_OgrKalanBorc]  DEFAULT ((3000)) FOR [OgrKalanBorc]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaAktif]  DEFAULT ((0)) FOR [OdaAktif]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaDurum]  DEFAULT ((1)) FOR [OdaDurum]
GO
USE [master]
GO
ALTER DATABASE [YurtOtomasyon] SET  READ_WRITE 
GO
