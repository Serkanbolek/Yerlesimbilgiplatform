USE [YerlesımDb]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Apartmentnumbers]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apartmentnumbers](
	[ApartmentnumberID] [int] IDENTITY(1,1) NOT NULL,
	[apartmentnumber] [nvarchar](20) NULL,
	[BuildingNumberID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Apartmentnumbers] PRIMARY KEY CLUSTERED 
(
	[ApartmentnumberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BuildingNumbers]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuildingNumbers](
	[BuildingNumberID] [int] IDENTITY(1,1) NOT NULL,
	[BuildingNumberName] [nvarchar](20) NULL,
	[StreetID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.BuildingNumbers] PRIMARY KEY CLUSTERED 
(
	[BuildingNumberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comments]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[CommentContents] [nvarchar](max) NULL,
	[CommentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Comments] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Districts]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Districts](
	[DistrictID] [int] NOT NULL,
	[DistrictName] [nvarchar](20) NOT NULL,
	[ilID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Neighbourhoods]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Neighbourhoods](
	[NeighbourhoodID] [int] NOT NULL,
	[NeighbourhoodName] [nvarchar](200) NULL,
	[DistrictID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Points]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Points](
	[PointID] [int] IDENTITY(1,1) NOT NULL,
	[PointNumber] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Points] PRIMARY KEY CLUSTERED 
(
	[PointID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[ProvinceID] [int] NOT NULL,
	[ProvinceName] [nvarchar](20) NULL,
 CONSTRAINT [PK_dbo.Provinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Streets]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Streets](
	[StreetID] [int] NOT NULL,
	[StreetName] [nvarchar](500) NULL,
	[NeighbourhoodID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Streets] PRIMARY KEY CLUSTERED 
(
	[StreetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 4.07.2023 23:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserMail] [nvarchar](50) NULL,
	[UserPassword] [nvarchar](20) NULL,
	[UserImage] [nvarchar](max) NULL,
	[CommentID] [int] NOT NULL,
	[StreetID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Comments] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [CommentDate]
GO
ALTER TABLE [dbo].[Districts] ADD  CONSTRAINT [DF__Districts__ilID__7B5B524B]  DEFAULT ((0)) FOR [ilID]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [CommentID]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [StreetID]
GO
ALTER TABLE [dbo].[Points]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Points_dbo.Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Points] CHECK CONSTRAINT [FK_dbo.Points_dbo.Users_UserID]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Users_dbo.Comments_CommentID] FOREIGN KEY([CommentID])
REFERENCES [dbo].[Comments] ([CommentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_dbo.Users_dbo.Comments_CommentID]
GO
