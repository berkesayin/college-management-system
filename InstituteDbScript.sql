USE [master]
GO
/****** Object:  Database [InstituteDb]    Script Date: 9.05.2020 17:27:34 ******/
CREATE DATABASE [InstituteDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InstituteDb', FILENAME = N'C:\Users\Berke' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InstituteDb_log', FILENAME = N'C:\Users\Berke' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InstituteDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InstituteDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InstituteDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InstituteDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InstituteDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InstituteDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InstituteDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [InstituteDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [InstituteDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InstituteDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InstituteDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InstituteDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InstituteDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InstituteDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InstituteDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InstituteDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InstituteDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [InstituteDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InstituteDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InstituteDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InstituteDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InstituteDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InstituteDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InstituteDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InstituteDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InstituteDb] SET  MULTI_USER 
GO
ALTER DATABASE [InstituteDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InstituteDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InstituteDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InstituteDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InstituteDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InstituteDb] SET QUERY_STORE = OFF
GO
USE [InstituteDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [InstituteDb]
GO
/****** Object:  Table [dbo].[Academicians]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Academicians](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Gender] [varchar](255) NULL,
	[Age] [int] NULL,
	[College] [varchar](255) NULL,
	[Department] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CollegeStudents]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollegeStudents](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Gender] [varchar](255) NULL,
	[Age] [int] NULL,
	[College] [varchar](255) NULL,
	[Department] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnglishBooks]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnglishBooks](
	[Id] [int] NOT NULL,
	[BookName] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NULL,
	[KindOfBook] [varchar](255) NULL,
	[AuthorName] [varchar](255) NULL,
	[Price] [int] NULL,
	[Available] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ForeignMembers]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ForeignMembers](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Gender] [varchar](255) NULL,
	[Age] [int] NULL,
	[Nationality] [varchar](255) NULL,
	[Job] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralBooks]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneralBooks](
	[Id] [int] NOT NULL,
	[BookName] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NULL,
	[KindOfBook] [varchar](255) NULL,
	[AuthorName] [varchar](255) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralMembers]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneralMembers](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Gender] [varchar](255) NULL,
	[Age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Journals]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Journals](
	[Id] [int] NOT NULL,
	[JournalName] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NOT NULL,
	[SubjectOfIt] [varchar](255) NULL,
	[Country] [varchar](255) NOT NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiteratureBooks]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiteratureBooks](
	[Id] [int] NOT NULL,
	[BookName] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NULL,
	[KindOfBook] [varchar](255) NULL,
	[AuthorName] [varchar](255) NULL,
	[Price] [int] NULL,
	[Country] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MathematicalBooks]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MathematicalBooks](
	[Id] [int] NOT NULL,
	[BookName] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NULL,
	[KindOfBook] [varchar](255) NULL,
	[AuthorName] [varchar](255) NULL,
	[Price] [int] NULL,
	[Branch] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Newspapers]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Newspapers](
	[Id] [int] NOT NULL,
	[NewspapersName] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NOT NULL,
	[Contry] [varchar](255) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderList]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderList](
	[Id] [int] NOT NULL,
	[KindOfText] [varchar](255) NULL,
	[NameOfText] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NULL,
	[Price] [int] NULL,
	[DeliveryDay] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Researchers]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Researchers](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Gender] [varchar](255) NULL,
	[Age] [int] NULL,
	[College] [varchar](255) NULL,
	[Department] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocialBooks]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocialBooks](
	[Id] [int] NOT NULL,
	[BookName] [varchar](255) NULL,
	[LanguageOfIt] [varchar](255) NULL,
	[KindOfBook] [varchar](255) NULL,
	[AuthorName] [varchar](255) NULL,
	[Price] [int] NULL,
	[Branch] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 9.05.2020 17:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Gender] [varchar](255) NULL,
	[Age] [int] NULL,
	[College] [varchar](255) NULL,
	[Department] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (2, N'Akhtar ', N'Jamil', N'Male', 35, N'Zaim University', N'Software,Computer')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (3, N'Selim', N'Kalin', N'Male', 40, N'Istanbul University', N'Political Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (4, N'Volkan', N'Cekip', N'Male', 45, N'Medipol University', N'Biology and Health')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (5, N'Serhat', N'Gudogan', N'Male', 48, N'Bogazici University', N'Physics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (6, N'Irmak', N'Tahsinoglu', N'Female', 44, N'Aydin University', N'English Teaching')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (7, N'Veysel', N'Celik', N'Male', 45, N'Koc University', N'Biology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (8, N'Yasar', N'Savurgan', N'Male', 50, N'Konya Tech.Uni.', N'Mechanical Engineering')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (9, N'Remzi ', N'Elyigit', N'Male', 45, N'ODTU(METU)', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (10, N'Mehmet Akif', N'Polast', N'Male', 48, N'Ist.Tech.University', N'Statistics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (11, N'Salih ', N'Faydali', N'Male', 49, N'Bogazici University', N'Education')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (12, N'Münevver ', N'Ayaoku', N'Female', 40, N'Karadeniz Tech.Uni.', N'Software')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (13, N'Muhammet', N'Kuzucuoglu', N'Male', 41, N'Ankara University', N'Dermatology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (14, N'Nazlican ', N'Özsimitçi', N'Female', 45, N'Gazi University', N'Neuroscience')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (15, N'Arya', N'Unlumamülleri', N'Female', 46, N'Kocaeli University', N'Medicine')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (16, N'Döne', N'Gurbetoglu', N'Female', 48, N'Sakarya University', N'Biochemistry')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (17, N'Emirhan ', N'Selim', N'Male', 50, N'Bursa Uludag Uni.', N'Biology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (18, N'Soner', N'Ülgen', N'Male', 55, N'Yeditepe University', N'Education')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (19, N'Çetin', N'Börklü', N'Male', 60, N'Aydin University', N'Literature')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (20, N'Ezgi', N'Ibukürtüncü', N'Female', 62, N'Zaim University', N'Philosophy')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (21, N'Hazar', N'Üregil', N'Female', 48, N'Bezmialem University', N'Sociology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (22, N'Aykut ', N'Suyur', N'Male', 49, N'Medipol University', N'Psychology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (23, N'Onur', N'Kirit', N'Male', 50, N'Bahçesehir University', N'History')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (24, N'Songül ', N'Tükezim', N'Female', 57, N'Özyegin University', N'Art')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (25, N'Berkay', N'Pirinçal', N'Male', 45, N'Cambridge University', N'Political Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (26, N'Anil', N'Güldü', N'Male', 46, N'Harvard University', N'Economics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (27, N'Sami', N'Ökçe', N'Male', 52, N'M.I.T.', N'Artificial Intelligence')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (28, N'Muzaffer', N'Agaçkesen', N'Male', 58, N'Stanford University', N'Bussiness')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (29, N'Nimet ', N'Haydarv', N'Female', 48, N'California University', N'Law School')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (30, N'Mina', N'Kalo', N'Female', 49, N'College London', N'Lingusitics Department')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (31, N'Müzeyyen', N'Katlan', N'Female', 55, N'Chicago University', N'Dermatology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (32, N'Miraç', N'Özyönüm', N'Male', 54, N'Edinburgh University', N'Neuroscience')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (33, N'Mina', N'Mikyaz', N'Female', 49, N'Hong Kong University', N'Biochemistry')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (34, N'Erkan', N'Kiroglu', N'Male', 50, N'Seoul National University', N'Biology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (35, N'Rojin', N'Aksöz', N'Female', 55, N'McGill University', N'Mechanical Engineer.ng')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (36, N'Fikret', N'Denizalp', N'Male', 56, N'University of Queensland', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (37, N'Elifnur ', N'Kurucu', N'Female', 60, N'Munich Technical University', N'Statistics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (38, N'Muhammet Ali', N'Sayar', N'Male', 66, N'Tokyo Technology Institute', N'Computer Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (39, N'Sare', N'Ilis', N'Female', 65, N'Osaka University', N'Artificial Intelligence')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (40, N'Tülin', N'Göksun', N'Female', 45, N'University of Zurich', N'Physics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (41, N'Remzi', N'Nuralan', N'Male', 48, N'Moscow State University', N'Education')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (42, N'Elif Naz', N'Dabanlioglu', N'Female', 49, N'Konya Tech.Uni.', N'Statistics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (43, N'Abdurrahman', N'Günesdogdu', N'Male', 55, N'ODTU(METU)', N'Computer Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (44, N'Muzaffer', N'Aydogmus', N'Male', 58, N'Ist.Tech.Uni', N'Physics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (45, N'Nazli', N'Örnek', N'Female', 55, N'Bogazici University', N'Psychology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (46, N'Serdar', N'Sapçi', N'Male', 58, N'Karadeniz Tech.Uni.', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (47, N'Ali', N'Incecik', N'Male', 50, N'Ankara University', N'History')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (48, N'Ayse', N'Abdelkader', N'Female', 51, N'Gazi University', N'Art')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (49, N'Riza', N'Erturgut', N'Male', 52, N'Kocaeli University', N'Political Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (50, N'Fikret', N'Siray', N'Male', 51, N'Sakarya University', N'Economics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (51, N'Zeki', N'Biriciklioglu', N'Male', 55, N'Bursa Uludag Uni.', N'Bussiness')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (52, N'Hüseyin', N'Volkan', N'Male', 48, N'Yeditepe University', N'Law School')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (53, N'Çigdem', N'Karadayi', N'Female', 55, N'Aydin University', N'Linguistics Department')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (55, N'Azat ', N'Aynaoglu', N'Male', 62, N'Bezmialem University', N'Neuroscience')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (56, N'Sudenaz', N'Tasdemir', N'Female', 63, N'Medipol University', N'Medicine')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (57, N'Birsen', N'Akkor', N'Female', 65, N'Bahçesehir University', N'Biochemistry')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (58, N'Gülsüm ', N'Bikeç', N'Female', 66, N'Ozyegin University', N'Biology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (59, N'Hamdi', N'Kökbulak', N'Male', 58, N'Cambridge University', N'Mechanical Engineering')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (60, N'Sevda', N'Akçan', N'Female', 59, N'Harvard University', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (61, N'Sebahat', N'Sarali', N'Female', 50, N'M.I.T', N'Statistics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (62, N'Irmak ', N'Hamidi', N'Female', 51, N'Stanford University', N'Software')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (63, N'Sabri', N'Kariman', N'Male', 52, N'California University', N'Computer Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (64, N'Tugçe', N'Akkoç', N'Female', 53, N'College London', N'Artificial Intelligence')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (65, N'Necdet', N'Erçam', N'Male', 54, N'Edinburgh University', N'Physics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (66, N'Ahmet', N'Incikapi', N'Male', 48, N'Hong Kong University', N'Education')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (67, N'Arif', N'Temeloglu', N'Male', 60, N'Seoul National University', N'Literature')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (68, N'Elif', N'Özçelikbas', N'Female', 58, N'McGill  University', N'Philosophy')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (69, N'Ali Eymen', N'Deve', N'Male', 55, N'University of Queensland', N'History')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (70, N'Muhammed Ali', N'Abdullah', N'Male', 59, N'Munich Technical University', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (71, N'Nazife ', N'Deve', N'Female', 55, N'Tokyo Technology Institute', N'Physics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (72, N'Cuma', N'Kazikli', N'Male', 50, N'Osaka University', N'Art')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (73, N'Ihsan', N'Havas', N'Male', 60, N'University of Zurich', N'Political Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (74, N'Dilan', N'Dokuyucu', N'Female', 61, N'Moscow State University', N'Economics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (75, N'Selim', N'Özbay', N'Male', 45, N'Konya Technical University', N'Software')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (76, N'Yasin', N'Agagül', N'Male', 55, N'ODTU(METU)', N'Computer Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (77, N'Mehmet Emir', N'Serçe', N'Male', 55, N'Ist.Tech.Uni.', N'Physics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (78, N'Ömer Faruk', N'Kocanoglu', N'Male', 52, N'Bogaizi University', N'Bussiness')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (79, N'Özcan', N'Küçükiravul', N'Male', 57, N'Karadeniz Tech.Uni.', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (80, N'Gökçe ', N'Ferak', N'Female', 57, N'Ankara Uni.', N'Law school')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (81, N'Nazmiye ', N'Türksari', N'Female', 58, N'Gazi University', N'Linguistics Department')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (82, N'Naz ', N'Sahan', N'Female', 59, N'Kocaeli University', N'Dermatology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (83, N'Eren', N'Canli', N'Male', 60, N'Sakarya University', N'Neuroscience')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (84, N'Kubra', N'Sungurlu', N'Female', 61, N'Bursa Uludag Uni.', N'Medicine')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (85, N'Onur', N'Eyyüboglu', N'Male', 49, N'Yeditepe University', N'Biochemistry')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (86, N'Mete', N'Madenüs', N'Male', 55, N'Aydin University', N'Biology')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (87, N'Muhammed Emin', N'Sarigöl', N'Male', 58, N'Zaim University', N'Mechanical Engineering')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (88, N'Demet', N'Barisçakir', N'Female', 55, N'Bezmialem University', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (89, N'Habibe', N'Baban', N'Female', 45, N'Medipol University', N'Statistics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (90, N'Cengiz', N'Kahveciler', N'Male', 61, N'Bahcesehir University', N'Software')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (91, N'Pakize ', N'Basar', N'Female', 55, N'Ozyegin University', N'Computer Science')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (92, N'Savas', N'Neyal', N'Male', 58, N'Cambridge University', N'Artificial Intelligence')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (93, N'Bulent', N'Kacaroglu', N'Male', 55, N'Harvard University', N'Physics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (94, N'Helin', N'Terkes', N'Female', 54, N'M.I.T', N'Artificial Intelligence')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (95, N'Zekiye', N'Hatay', N' ', 65, N'Stanford University', N'Education')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (97, N'Ahmet', N'Demir', N'Male', 45, N'Zaim University', N'Mathematics')
INSERT [dbo].[Academicians] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (98, N'Selim', N'Yavas', N'Male', 49, N'Istanbul University', N'Law School')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (1, N'Enes', N'Damlayici', N'Male', 22, N'Zaim University', N'Sociology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (2, N'Ibrahim Sami', N'Ince', N'Male', 22, N'Zaim University', N'Turkish Teaching')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (3, N'Hasan ', N'Ozdogan', N'Male', 23, N'Zaim University', N'Political Science')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (4, N'Ali ', N'Balbars', N'Male', 24, N'Kocaeli University', N'Computer Science')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (5, N'Arya', N'Kise', N'Female', 23, N'Konya Tech.Uni.', N'Mechanical Engineering')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (6, N'Nimet ', N'Citirak', N'Female', 25, N'ODTU(METU)', N'Mathematics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (7, N'Ela Nur', N'Serek', N'Female', 22, N'Ist.Tech.Uni.', N'Statistics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (8, N'Ayhan Ozcil', NULL, N'Male', 18, N'Karadeniz Tech.Uni.', N'Physics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (9, N'Azad', N'Onur', N'Male', 19, N'Ankara University', N'Dermatology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (10, N'Sude', N'Kamuran', N'Female', 26, N'Bogazici University', N'Neuroscience')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (11, N'Ozkan', N'Derilioglu', N'Male', 27, N'Gazi University', N'Medicine')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (12, N'Can', N'Dolar', N'Male', 19, N'Kocaeli University', N'Biochemistry')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (13, N'Haydar', N'Demirkapi', N'Male', 22, N'Sakarya University', N'Biology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (14, N'Nisa Nur', N'Duysak', N'Female', 24, N'Bursa Uludag Uni.', N'Software')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (15, N'Naciye', N'Inat', N'Female', 24, N'Yeditepe University', N'Computer Science')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (16, N'Canan', N'Koksalici', N'Female', 28, N'Aydin University', N'Artificial Intelligence')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (17, N'Baran', N'Salpal', N'Male', 22, N'Zaim University', N'Education')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (18, N'Azra', N'Tutuncu', N'Female', 21, N'Bezmialem University', N'Literature')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (19, N'Mira', N'Tuter', N'Female', 20, N'Medipol University', N'Philosophy')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (20, N'Baris', N'Ozcagli', N'Male', 20, N'Bahcesehir University', N'Sociology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (21, N'Isa', N'Boluk', N'Male', 20, N'Ozyegin University', N'Psychology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (22, N'Ada', N'Vapur', N'Female', 19, N'Konya Tech.Uni.', N'Mechanical Engineering')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (23, N'Naciye', N'Alniacik', N'Female', 24, N'ODTU(METU)', N'Mathematics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (24, N'Sengul', N'Adacan', N'Female', 25, N'Medeniyet University', N'Statistics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (25, N'Emel', N'Aslan', N'Female', 24, N'Marmara University', N'History')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (26, N'Guler ', N'Nurkan', N'Female', 25, N'Marmara University', N'Art')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (27, N'Aslihan', N'Dolay', N'Female', 24, N'Istanbul University', N'Political Science')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (28, N'Abdurrahman', N'Altingoz', N'Male', 25, N'Istanbul University', N'Economics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (29, N'Taner', N'Karacasulu', N'Male', 26, N'Istanbul University', N'Bussiness')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (30, N'Leyla', N'Aylanc', N'Female', 22, N'Medeniyet University', N'Law School')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (31, N'Umut', N'Safaltin', N'Male', 23, N'Medeniyet University', N'Linguistics Department')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (32, N'Nazife', N'Mirzali', N'Female', 25, N'Marmara University', N'Dermatology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (33, N'Neslihan', N'Karakose', N'Female', 21, N'Istanbul University', N'Neuroscience')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (34, N'Tuncay', N'Ozgu', N'Male', 23, N'Istanbul University', N'Medicine')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (35, N'Sami', N'Alemdaroglu', N'Male', 19, N'Marmara University', N'Biochemistry')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (36, N'Emrah', N'Karaat', N'Male', 18, N'Istanbul University', N'Biology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (37, N'Birgul', N'Aliminyum', N'Female', 22, N'Medipol Unversity', N'Mechanical Engineering')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (38, N'Zahide', N'Bassaka', N'Female', 21, N'Zaim University', N'Mathematics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (39, N'Tansu', N'Kafe', N'Male', 18, N'Yeditepe University', N'Statistics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (40, N'Nisa', N'Tuzun', N'Female', 19, N'Ist.Tech.Uni.', N'Physics')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (41, N'Yagiz', N'Begendi', N'Male', 22, N'Karadeniz Tech.Uni.', N'Software')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (42, N'Orhan', N'Isin', N'Male', 23, N'Ankara University', N'Computer Science')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (43, N'Rumeysa', N'Incedal', N'Female', 19, N'Bogazici University', N'Artificial Intelligence')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (44, N'Mucahit', N'Karip', N'Male', 24, N'Gazi University', N'Education')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (45, N'Sabahattin', N'Sukusturan', N'Male', 25, N'Kocaeli University', N'Literature')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (46, N'Defne', N'Enguzel', N'Female', 26, N'Sakarya University', N'Philosophy')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (47, N'Suat', N'Giray', N'Male', 23, N'Bursa Uludag University', N'Sociology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (48, N'Sabri', N'Dovme', N'Male', 21, N'Yeditepe University', N'Psychology')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (49, N'Berna', N'Efendioglu', N'Female', 22, N'Aydin University', N'History')
INSERT [dbo].[CollegeStudents] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (50, N'Efe', N'Birsan', N'Male', 22, N'Zaim University', N'Art')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (1, N'The Grand Chessboard', N'English', N'International Policy', N'Zbigniew Brzezinski', 30, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (2, N'Western Heritage 1', N'English', N'History', N'Donald Kagan', 75, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (3, N'Western Heritage 2', N'English', N'History', N'Steven Ozment', 75, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (4, N'Winter is Coming', N'English', N'Policy', N'Garry Kasparov', 35, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (5, N'A Tale of Two Cities', N'English', N'Sociopolitic book', N'Charles Dickens', 20, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (6, N'1984', N'English', N'Literature', N'George Orwell', 20, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (7, N'Animal Farm', N'English', N'Policy', N'George Orwell', 20, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (8, N'Strategic Vision', N'English', N'Policy', N'Zbigniew Brzezinski', 25, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (9, N'Notes from the Underground ', N'English', N'Philosophy', N'Dostoyevski', 10, N'Yes')
INSERT [dbo].[EnglishBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Available]) VALUES (10, N'What Men Live By', N'English', N'Philosophy', N'Tolstoy', 8, N'Yes')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (1, N'Shah Niaz', N'Ahmad', N'Male', 40, N'Canada', N'English Teacher')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (2, N'Amjad', N'Hussain', N'Male', 35, N'Norway', N'Academician(Theology)')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (3, N'Akhtar', N'Jamil', N'Male', 40, N'India', N'Software Expert.Academician')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (4, N'Hiroaki Ali', N'Kawanishi', N'Male', 25, N'Japan', N'Phd Student')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (5, N'Usman', N'Khan', N'Male', 25, N'India', N'Phd Student at Int.Rel.')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (6, N'Hasan', N'Spyker', N'Male', 40, N'England', N'Expert Sociologist ')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (7, N'Owais', N'Khan', N'Male', 41, N'India', N'Researcher')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (8, N'Farzad', N'Khan', N'Male', 44, N'Endonesia', N'Academician(History)')
INSERT [dbo].[ForeignMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Nationality], [Job]) VALUES (9, N'Naoki', N'Yamamoto', N'Male', 40, N'Japan', N'Academician(Civilization)')
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (1, N'Hayvan Çiftligi', N'Turkish', N'Literature', N'George Orwell', 13)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (2, N'1984', N'Turkish', N'Literature', N'George Orwell', 15)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (3, N'Sefiller', N'Turkish', N'Literature', N'Victor Hugo', 10)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (4, N'Bir Idam Mahkumunun Son Günü', N'Turkish', N'Literature', N'Victor Hugo', 5)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (5, N'Karamazov Kardesler', N'Turkish', N'Literature', N'Dostoyevski', 20)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (6, N'Yeraltindan Notlar', N'Turkish', N'Literature', N'Dostoyevski', 10)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (7, N'Ezilenler', N'Turkish', N'Literature', N'Dostoyevski', 15)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (8, N'Insanciklar', N'Turkish', N'Literature', N'Dostoyevski', 10)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (9, N'Suç ve Ceza', N'Turkish', N'Literature', N'Dostoyevski', 15)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (10, N'Oblomov', N'Turkish', N'Literature', N'Ivan Goncarov', 25)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (11, N'Tek Kanatli Bir Kus', N'Turkish', N'Literature', N'Yasar Kemal', 10)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (12, N'Kuslar Da Gitti', N'Turkish', N'Literature', N'Yasar Kemal', 8)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (13, N'Ince Memed', N'Turkish', N'Literature', N'Yasar Kemal', 30)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (14, N'Aziz Istanbul', N'Turkish', N'Literature', N'Yahya Kemal Beyatli', 10)
INSERT [dbo].[GeneralBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price]) VALUES (15, N'Bas Kaldiran Insan', N'Turkish', N'Literature', N'Albert Camus', 12)
INSERT [dbo].[GeneralMembers] ([Id], [FirstName], [LastName], [Gender], [Age]) VALUES (1, N'Berke', N'Sayin', N'Male', 21)
INSERT [dbo].[GeneralMembers] ([Id], [FirstName], [LastName], [Gender], [Age]) VALUES (2, N'Mehdi', N'Ay', N'Male', 23)
INSERT [dbo].[GeneralMembers] ([Id], [FirstName], [LastName], [Gender], [Age]) VALUES (3, N'Fatih', N'Aykaç', N'Male', 22)
INSERT [dbo].[GeneralMembers] ([Id], [FirstName], [LastName], [Gender], [Age]) VALUES (4, N'Faruk', N'Özkan', N'Male', 22)
INSERT [dbo].[GeneralMembers] ([Id], [FirstName], [LastName], [Gender], [Age]) VALUES (5, N'Mücteba ', N'Karabey', N'Male', 22)
INSERT [dbo].[Journals] ([Id], [JournalName], [LanguageOfIt], [SubjectOfIt], [Country], [Price]) VALUES (1, N'The Economist', N'English', N'Economy,Bussiness', N'USA', 15)
INSERT [dbo].[Journals] ([Id], [JournalName], [LanguageOfIt], [SubjectOfIt], [Country], [Price]) VALUES (2, N'The Financial Times', N'English', N'Economy,Bussiness', N'UK', 15)
INSERT [dbo].[Journals] ([Id], [JournalName], [LanguageOfIt], [SubjectOfIt], [Country], [Price]) VALUES (3, N'Fortune ', N'English', N'Economy,Bussiness', N'USA', 20)
INSERT [dbo].[Journals] ([Id], [JournalName], [LanguageOfIt], [SubjectOfIt], [Country], [Price]) VALUES (4, N'Forbes', N'English', N'Economy,Bussiness', N'USA', 15)
INSERT [dbo].[LiteratureBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Country]) VALUES (1, N'Suç ve Ceza', N'Turkce', N'Literature', N'F.M.Dostoyevski', 15, N'Russia')
INSERT [dbo].[LiteratureBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Country]) VALUES (2, N'Bab-I Esrar', N'Turkce', N'Dedective', N'Ahmet Umit', 10, N'Turkey')
INSERT [dbo].[LiteratureBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Country]) VALUES (3, N'Karamazov Kardesler', N'Turkce', N'Literature', N'F.M.Dostoyevski', 10, N'Russia')
INSERT [dbo].[LiteratureBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Country]) VALUES (4, N'Fareler ve Insanlar', N'Turkce ', N'Literature', N'John Steinback', 8, N'USA')
INSERT [dbo].[LiteratureBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Country]) VALUES (5, N'Ince Memed 1', N'Turkce', N'Literature', N'Yasar Kemal', 16, N'Turkey')
INSERT [dbo].[MathematicalBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Branch]) VALUES (1, N'Calculus 1', N'English', N'Academic Research', N'Pearson Publish', 150, N'Mathematics')
INSERT [dbo].[MathematicalBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Branch]) VALUES (2, N'Calculus 2 ', N'English', N'Academic Research', N'Pearson Publish', 150, N'Mathematics')
INSERT [dbo].[MathematicalBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Branch]) VALUES (3, N'Geometry Intro', N'English', N'Academic Research', N'Pearson Publish', 120, N'Mathematics')
INSERT [dbo].[MathematicalBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Branch]) VALUES (4, N'Trigonometry Intro', N'English', N'Academic Research', N'Pearson Publish', 100, N'Mathematics')
INSERT [dbo].[MathematicalBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Branch]) VALUES (5, N'Probability', N'English', N'Academic Research', N'Pearson Publish', 80, N'Mathematics')
INSERT [dbo].[MathematicalBooks] ([Id], [BookName], [LanguageOfIt], [KindOfBook], [AuthorName], [Price], [Branch]) VALUES (6, N'Statistics', N'English', N'Academic Research', N'Pearson Publish', 100, N'Mathematics')
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (1, N'BBC News', N'English', N'UK', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (2, N'The New York Times', N'English', N'USA', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (3, N'Al-Jazeera', N'English', N'Qatar', 4)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (4, N'The Washington Post', N'English', N'USA', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (5, N'The Guardian', N'English', N'UK', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (6, N'Los Angeles Times', N'English', N'USA', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (7, N'CBC News', N'English', N'Canada', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (8, N'Daily Express', N'English', N'UK', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (9, N'Independent', N'English', N'UK', 5)
INSERT [dbo].[Newspapers] ([Id], [NewspapersName], [LanguageOfIt], [Contry], [Price]) VALUES (10, N'The St.Petersburg Times', N'English', N'Russia', 5)
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (1, N'Usman', N'Khan', N'Male', 24, N'Zaim University', N'Political Science')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (2, N'Owais', N'Khan', N'Male', 30, N'Zaim University', N'International Relations')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (3, N'Raziye', N'Erguzer', N'Female', 25, N'Medeniyet University', N'Dermatology')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (4, N'Nihal ', N'Kayar', N'Female', 28, N'Marmara University', N'Neuroscience')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (5, N'Serap', N'Tatlioglu', N'Female', 26, N'Istanbul University', N'Medicine')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (6, N'Gamze', N'Dal', N'Female', 30, N'Konya Tech.Uni.', N'Mechanical Engineering')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (7, N'Ozcan', N'Kaya', N'Female', 29, N'ODTU(METU)', N'Mathematics')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (8, N'Muhammed Ali', N'Oruc', N'Male', 27, N'Ist.Tech.uni.', N'Statistics')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (9, N'Eymen', N'Palabiyik', N'Male', 28, N'Karadeniz Tech.Uni.', N'Physics')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (10, N'Elif Ada', N'Plaket', N'Female', 25, N'Ankara University', N'Biochemistry')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (11, N'Bayram ', N'Ipekus', N'Male', 26, N'Bogazici University', N'Biology')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (12, N'Sabahat', N'Cilalitas', N'Female', 26, N'Gazi University', N'Education')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (13, N'Ege', N'Kostekci', N'Male', 25, N'Kocaeli University', N'Literature')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (14, N'Vedat ', N'Ugur', N'Male', 29, N'Sakarya University', N'Philosphy')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (15, N'Doruk', N'Ozturkdemir', N'Male', 29, N'Bursa Uludag University', N'Sociology')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (16, N'Sena', N'Giritlioglu', N'Female', 32, N'Yeditepe University', N'Psychology')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (17, N'Kerme ', N'Oktay', N'Male', 28, N'Aydin University', N'History')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (18, N'Gonul', N'Atilanevlat', N'Female', 29, N'Zaim University', N'Art')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (19, N'Nurettin', N'Buyukay', N'Male', 28, N'Bezmialem University', N'Political Science')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (20, N'Mira', N'Engin', N'Female', 27, N'Medipol University', N'Economics')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (21, N'Deniz ', N'Bender', N'Female', 28, N'Bahcesehir University', N'Bussiness')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (22, N'Can', N'Taser', N'Male', 29, N'Ozyegin University', N'Law School')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (23, N'Muharrem', N'Gokmenoglu', N'Male', 30, N'M.I.T.', N'Software')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (24, N'Adil', N'Kinali', N'Male', 31, N'Munich Technical Uni.', N'Computer Science')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (25, N'Ramazan', N'Dinckurt', N'Male', 29, N'Tokyo Technology Institute', N'Artificial Intelligence')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (26, N'Muzaffer ', N'Murt', N'Male', 28, N'Cambridge University', N'Dermatology')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (27, N'Necati', N'Dogukan', N'Male', 27, N'Harvard University', N'Lingusitics Department')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (28, N'Zubeyde', N'Tatlici', N'Female', 26, N'Stanford University', N'Dermatology')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (29, N'Beyzanur', N'Ardahan', N'Female', 25, N'University of California', N'Neuroscience')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (30, N'Saadet ', N'Balimre', N'Female', 30, N'College London', N'Medicine')
INSERT [dbo].[Researchers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (31, N'Asel', N'Buyukmutlu', N'Female', 32, N'Yeditepe University', N'Medicine')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (1, N'Ahmet', N'Soylu', N'Male', 35, N'Bogazici University', N'Mathematics')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (2, N'Mehmet', N'Demir', N'Male', 30, N'Bogazici University', N'Physics')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (3, N'Selim', N'Sahin', N'Male', 35, N'Istanbul High School', N'Turkish Teaching')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (4, N'Mustafa', N'Öztürk', N'Male', 40, N'Beyoglu High Schhol', N'Mathematics')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (5, N'Semra', N'Gocmez', N'Female', 35, N'Kadikoy High School', N'Biology')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (6, N'Cihan', N'Karadeli', N'Male', 33, N'Besiktas High School', N'Literature')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (7, N'Hediye', N'Sagdic', N'Male', 35, N'Fatih High School', N'Social Lectures')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (8, N'Asli ', N'Gune', N'Female', 36, N'Beyoglu High School', N'Mathematics')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (9, N'Irfan', N'Kocaoz', N'Male', 29, N'Umraniye High School', N'Chemistry')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (10, N'Polat', N'Sengezen', N'Male', 36, N'Marmara University', N'Physics')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (11, N'Melisa', N'Bagdat', N'Female', 37, N'Istanbul University', N'Turkish Teaching')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (12, N'Batuhan', N'Karaguney', N'Male', 35, N'Bulgurlu High School', N'Biology')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (13, N'Berkay', N'Cete', N'Male', 34, N'Medeniyet University', N'History')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (14, N'Kubra', N'Kurtulu', N'Female', 36, N'Kadikoy High School', N'Philospohy')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (15, N'Dogan', N'Uzatma', N'Male', 39, N'Fatih High School', N'Mathematics')
INSERT [dbo].[Teachers] ([Id], [FirstName], [LastName], [Gender], [Age], [College], [Department]) VALUES (16, N'Erhan', N'Buyuklu', N'Male', 40, N'Bulgurlu High School', N'Literature')
USE [master]
GO
ALTER DATABASE [InstituteDb] SET  READ_WRITE 
GO
