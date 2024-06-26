USE [master]
GO
/****** Object:  Database [FellowsAndMembersDb]    Script Date: 10.05.2020 01:13:46 ******/
CREATE DATABASE [FellowsAndMembersDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FellowsAndMembersDb', FILENAME = N'C:\Users\Berke' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FellowsAndMembersDb_log', FILENAME = N'C:\Users\Berke' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FellowsAndMembersDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FellowsAndMembersDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FellowsAndMembersDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FellowsAndMembersDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FellowsAndMembersDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FellowsAndMembersDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FellowsAndMembersDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FellowsAndMembersDb] SET  MULTI_USER 
GO
ALTER DATABASE [FellowsAndMembersDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FellowsAndMembersDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FellowsAndMembersDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FellowsAndMembersDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FellowsAndMembersDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FellowsAndMembersDb] SET QUERY_STORE = OFF
GO
USE [FellowsAndMembersDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [FellowsAndMembersDb]
GO
/****** Object:  Table [dbo].[tblMembers]    Script Date: 10.05.2020 01:13:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMembers](
	[TemporaryMemberId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_tblMembers] PRIMARY KEY CLUSTERED 
(
	[TemporaryMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblMembers] ON 

INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (1, N'Hamza', N'Gündüz', N'Male', N'Hamza Samurai', N'hamza123456', N'College Student')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (2, N'Hasan', N'Özdogan', N'Male', N'Hasan Muhtar', N'samirMehdi123', N'College Student')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (3, N'Ali Furkan', N'Demirkalp', N'Male', N'Ali Demir', N'bossAli', N'College Student')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (4, N'Sami', N'Ince', N'Male', N'Ibrahim Sami', N'InceUzun123', N'College Student')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (5, N'Selçuk ', N'Yilmaz', N'Male', N'SelçukBJK', N'selçuk789', N'College Student')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (1002, N'Berke', N'Sayin', N'Male', N'Director', N'berkedirector', N'Manager')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (2002, N'Nihat', N'Ucan', N'Male', N'ucanNihat', N'1234nihat', N'Academician')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (3002, N'Mehdi', N'Ay', N'Male', N'mehdiAy', N'mehdiManager', N'Manager')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (3003, N'Faruk', N'Ozkan', N'Male', N'ozkanFaruk', N'farukManager', N'Manager')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (3004, N'Fatih', N'Aykac', N'Male', N'aykacFatih', N'fatihManager', N'Manager')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (3005, N'Mucteba', N'Karabey', N'Male', N'muctebaKarabey', N'muctebaManager', N'Manager')
INSERT [dbo].[tblMembers] ([TemporaryMemberId], [FirstName], [LastName], [Gender], [Username], [Password], [Status]) VALUES (4002, N'Ahmet', N'Dinlenir', N'Male', N'ahmetDinlenir', N'123ahmet', N'Academician')
SET IDENTITY_INSERT [dbo].[tblMembers] OFF
/****** Object:  StoredProcedure [dbo].[MemberAdd]    Script Date: 10.05.2020 01:13:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MemberAdd]
@FirstName varchar(50),
@LastName varchar(50),
@Gender varchar(50),
@Username varchar(50),
@Password varchar(50),
@Status varchar(50)
AS
	INSERT INTO tblMembers(FirstName,LastName,Gender,Username,Password,Status)
	VALUES(@FirstName,@LastName,@Gender,@Username,@Password,@Status)
GO
USE [master]
GO
ALTER DATABASE [FellowsAndMembersDb] SET  READ_WRITE 
GO
