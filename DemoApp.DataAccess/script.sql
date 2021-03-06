USE [master]
GO
/****** Object:  Database [PMI]    Script Date: 1/22/2020 4:10:11 PM ******/
CREATE DATABASE [PMI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PMIScriptTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PMIScriptTest.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PMIScriptTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PMIScriptTest_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PMI] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PMI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PMI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PMI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PMI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PMI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PMI] SET ARITHABORT OFF 
GO
ALTER DATABASE [PMI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PMI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PMI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PMI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PMI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PMI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PMI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PMI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PMI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PMI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PMI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PMI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PMI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PMI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PMI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PMI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PMI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PMI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PMI] SET  MULTI_USER 
GO
ALTER DATABASE [PMI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PMI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PMI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PMI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PMI] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PMI]
GO
/****** Object:  Table [dbo].[ATSInformationPMIs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ATSInformationPMIs](
	[ATSInformationPMI_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationID] [bigint] NULL,
	[EquipmentType] [varchar](200) NULL,
	[EquipmentCode] [varchar](200) NULL,
	[ATSMake] [varchar](200) NULL,
	[ATSModel] [varchar](200) NULL,
	[ATSSerial] [varchar](200) NULL,
	[InstalledDate] [datetime] NULL,
	[IsCompleted] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
	[PMITypeID] [int] NULL,
 CONSTRAINT [PK_ATSInformationPMIs] PRIMARY KEY CLUSTERED 
(
	[ATSInformationPMI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerOwnerUserId] [int] NULL,
	[ParentCustomerId] [int] NULL,
	[PrimaryCustomerID] [int] NULL,
	[CustomerTypeId] [int] NULL,
	[IndustryTypeId] [int] NULL,
	[DisplayID] [varchar](10) NULL,
	[CustomerStatusID] [int] NOT NULL,
	[CustomerName] [varchar](100) NULL,
	[AccountNumber] [nvarchar](50) NULL,
	[SubAccountNumber] [nvarchar](50) NULL,
	[StreetAddress] [varchar](100) NULL,
	[City] [varchar](50) NULL,
	[StateID] [int] NULL,
	[CountryID] [int] NULL,
	[ZipCode] [varchar](50) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Phone] [varchar](25) NULL,
	[Fax] [varchar](15) NULL,
	[EmaiId] [varchar](50) NULL,
	[ContactCustomer] [bit] NULL,
	[IsPriorityCustomer] [bit] NULL,
	[IsTTSSurveyNeeded] [bit] NULL,
	[SAType] [char](3) NULL,
	[IsSensitive] [bit] NULL,
	[IsGTCAttached] [bit] NULL,
	[Website] [varchar](100) NULL,
	[Employees] [int] NULL,
	[AnnualRevenue] [decimal](19, 4) NULL,
	[InvoiceSubmittalEmail] [varchar](50) NULL,
	[Description] [varchar](max) NULL,
	[AttentionTo] [varchar](150) NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[AgentFee] [varchar](20) NULL,
	[BEN] [varchar](300) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmailTemplates]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmailTemplates](
	[EmailTemplateID] [int] IDENTITY(1,1) NOT NULL,
	[Subject] [varchar](1000) NULL,
	[Description] [varchar](50) NOT NULL,
	[Path] [varchar](100) NOT NULL,
	[TaskID] [int] NULL,
	[IsEmail] [bit] NULL,
	[IsNotification] [bit] NULL,
	[IsActive] [bit] NULL,
	[ScheduleID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[IsEditable] [bit] NULL,
	[IsSilent] [bit] NULL,
	[AssociatedDocumentType] [int] NULL,
 CONSTRAINT [PK_EmailTemplates] PRIMARY KEY CLUSTERED 
(
	[EmailTemplateID] ASC,
	[Description] ASC,
	[Path] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EquipmentInformationPMIs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EquipmentInformationPMIs](
	[EquipmentInformationPMI_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationID] [bigint] NULL,
	[EquipmentType] [varchar](200) NULL,
	[EquipmentSerial] [varchar](200) NULL,
	[Floor] [varchar](200) NULL,
	[Enclosure] [varchar](200) NULL,
	[IsCompleted] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
	[PMITypeID] [int] NULL,
 CONSTRAINT [PK_EquipmentInformationPMIs] PRIMARY KEY CLUSTERED 
(
	[EquipmentInformationPMI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FireSystemManufacturerMasterPMIs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FireSystemManufacturerMasterPMIs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FSManufacturer] [varchar](200) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_FireSystemManufacturerMasterPMIs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FireSystemPMIs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FireSystemPMIs](
	[FireSystemPMI_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationID] [bigint] NULL,
	[EquipmentType] [varchar](200) NULL,
	[EquipmentCode] [varchar](200) NULL,
	[FSManufacturerId] [int] NULL,
	[FSType] [varchar](200) NULL,
	[FSSerial] [varchar](200) NULL,
	[InstalledDate] [datetime] NULL,
	[IsCompleted] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
	[PMIType] [int] NULL,
 CONSTRAINT [PK_FireSystemPMIs] PRIMARY KEY CLUSTERED 
(
	[FireSystemPMI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FireSystemTypeMasterPMIs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FireSystemTypeMasterPMIs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FireSystemType] [varchar](200) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_FireSystemTypeMasterPMIs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GeneratorInformationPMIs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GeneratorInformationPMIs](
	[GNPMI_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationID] [bigint] NULL,
	[EquipmentType] [varchar](200) NULL,
	[EquipmentCode] [varchar](200) NULL,
	[GN_Manufacturer] [varchar](200) NULL,
	[GN_Serial] [varchar](200) NULL,
	[Gn_KW_Rating] [varchar](200) NULL,
	[InstalledDate] [datetime] NULL,
	[EngineMake] [varchar](200) NULL,
	[EngineModel] [varchar](200) NULL,
	[EngineSerial] [varchar](200) NULL,
	[EngineFuelType] [varchar](200) NULL,
	[IsCompleted] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
	[PMITypeID] [int] NULL,
 CONSTRAINT [PK_GeneratorInformationPMIs] PRIMARY KEY CLUSTERED 
(
	[GNPMI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HVACInformationPMIs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HVACInformationPMIs](
	[HVAC_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationID] [bigint] NULL,
	[EquipmentType] [varchar](200) NULL,
	[EquipmentCode] [varchar](200) NULL,
	[UnitManufacture] [varchar](200) NULL,
	[UnitModel] [varchar](200) NULL,
	[UnitSerial] [varchar](200) NULL,
	[UnitKWRating] [varchar](200) NULL,
	[InstalledDate] [datetime] NULL,
	[IsCompleted] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
	[PMITypeID] [int] NULL,
 CONSTRAINT [PK_HVACInformationPMIs] PRIMARY KEY CLUSTERED 
(
	[HVAC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LetterTemplates]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LetterTemplates](
	[LetterTemplateID] [int] IDENTITY(1,1) NOT NULL,
	[LetterTypeID] [int] NULL,
	[DisplayName] [nvarchar](50) NULL,
	[FileName] [nvarchar](200) NULL,
	[Subject] [varchar](200) NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_LetterTemplates] PRIMARY KEY CLUSTERED 
(
	[LetterTemplateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LetterTypes]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LetterTypes](
	[LetterTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
	[Template] [varchar](50) NULL,
	[IsNotification] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsPMI] [bit] NULL,
 CONSTRAINT [PK_LetterTypes] PRIMARY KEY CLUSTERED 
(
	[LetterTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocationAssignedToUsers]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationAssignedToUsers](
	[LocationAssignedToUsersID] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationID] [bigint] NULL,
	[UserID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
 CONSTRAINT [PK_LocationAssignedToUsers] PRIMARY KEY CLUSTERED 
(
	[LocationAssignedToUsersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Locations]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[LocTypeID] [int] NULL,
	[StreetID] [int] NOT NULL,
	[OffNetFootageID] [int] NULL,
	[LocationName] [varchar](100) NOT NULL,
	[Demarc] [varchar](100) NULL,
	[isLocDiverseEntry] [bit] NULL,
	[LocNote] [varchar](200) NULL,
	[UBID] [int] NULL,
	[ClliCode] [varchar](100) NULL,
	[NotInBuilding] [bit] NULL,
	[Handoff] [int] NULL,
	[BuildingFiberStatusID] [int] NULL,
	[BuildingServiceStatusID] [int] NULL,
	[ThirdPartyBuildingStatusID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[CLLICode1] [varchar](100) NULL,
	[LATA] [varchar](max) NULL,
	[FTPDemarc] [varchar](100) NULL,
	[OSPDemarcNotes] [varchar](2000) NULL,
	[ISPDemarcNotes] [varchar](2000) NULL,
	[UPNHubStatusID] [int] NULL,
	[LocationRecordID] [int] NULL,
	[ParentLocationID] [bigint] NULL,
	[BuildingSubTypeIds] [varchar](500) NULL,
	[IsClliCodeUpdate] [bit] NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Photo]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Photo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Url] [varchar](50) NULL,
	[Description] [varchar](150) NULL,
	[DateAdded] [date] NULL,
	[IsMain] [bit] NULL,
	[UserId] [int] NULL,
	[PublicId] [varchar](50) NULL,
 CONSTRAINT [PK_Photo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMICategoryTypeMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMICategoryTypeMasters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryType] [varchar](200) NOT NULL,
	[PMITypeID] [int] NOT NULL,
	[CreatedTime] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[IsArchived] [bit] NOT NULL,
	[PMIMasterID] [int] NULL,
 CONSTRAINT [PK_PMICategoryTypeMasters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMIChecklistHistoryLogs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PMIChecklistHistoryLogs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PMITypeID] [int] NULL,
	[PMI_ID] [bigint] NULL,
	[CategoryTypeId] [int] NULL,
	[CategoryType] [nvarchar](500) NULL,
	[Question] [nvarchar](1000) NULL,
	[Status] [nvarchar](100) NULL,
	[Comments] [nvarchar](500) NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[IsArchived] [bit] NOT NULL,
	[IsCompleted] [bit] NULL,
 CONSTRAINT [PK_PMIChecklistHistoryLogs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PMIChecklistQuestionMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMIChecklistQuestionMasters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PMITypeID] [int] NOT NULL,
	[Question] [varchar](1000) NULL,
	[CategoryType] [varchar](200) NULL,
	[CategoryTypeId] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
 CONSTRAINT [PK_PMIChecklistQuestionMasters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMIChecklists]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMIChecklists](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PMITypeID] [int] NULL,
	[PMI_ID] [bigint] NULL,
	[CategoryTypeId] [int] NULL,
	[QuestionID] [bigint] NULL,
	[StatusTypeID] [int] NULL,
	[Comments] [varchar](500) NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
 CONSTRAINT [PK_PMIChecklists] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMIChecklistStatusMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PMIChecklistStatusMasters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Description] [nvarchar](1000) NULL,
	[IsActive] [bit] NOT NULL,
	[IsArchived] [bit] NOT NULL,
 CONSTRAINT [PK_PMIChecklistStatusMasters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PMIEmailLogs]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMIEmailLogs](
	[LogID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmailTemplateID] [int] NULL,
	[RenderedSubject] [varchar](1000) NULL,
	[RenderedBody] [nvarchar](max) NULL,
	[RenderedTo] [nvarchar](max) NULL,
	[RenderedCc] [varchar](1000) NULL,
	[RenderedBcc] [varchar](1000) NULL,
	[TypeID] [bigint] NULL,
	[Type] [int] NULL,
	[SentTime] [datetime] NULL,
 CONSTRAINT [PK_PMIEmailLogs] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMIHistories]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PMIHistories](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NULL,
	[Type] [nvarchar](250) NULL,
	[OldValue] [nvarchar](500) NULL,
	[NewValue] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_PMIHistories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PMIMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMIMasters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
	[CreatedTime] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
 CONSTRAINT [PK_PMIMasters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMIMasterTableInformations]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMIMasterTableInformations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[TableName] [varchar](100) NOT NULL,
	[KeyColumn] [varchar](100) NOT NULL,
	[ValueColumn] [varchar](100) NULL,
	[IsAddAllowed] [bit] NOT NULL,
	[IsActiveAllowed] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_PMIMasterTableInformations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMITypeMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PMITypeMasters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PMIType] [nvarchar](200) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsArchived] [bit] NULL,
	[PMIMasterID] [int] NULL,
 CONSTRAINT [PK_PMITypeMasters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StateMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StateMasters](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[RegionID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[Name] [varchar](100) NULL,
	[IsMarket] [bit] NULL,
 CONSTRAINT [PK_StateMasters] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StreetMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StreetMasters](
	[StreetID] [int] IDENTITY(1,1) NOT NULL,
	[MarketID] [int] NULL,
	[LocationTypeID] [int] NULL,
	[BuildingTypeID] [int] NULL,
	[Description] [varchar](100) NOT NULL,
	[StAddress] [varchar](200) NULL,
	[City] [varchar](50) NULL,
	[StateID] [int] NULL,
	[COUNTY] [varchar](50) NULL,
	[Zip] [varchar](20) NULL,
	[Floor] [varchar](50) NULL,
	[Suite] [varchar](50) NULL,
	[IsDiverseEntrance] [bit] NULL,
	[LocationNote] [varchar](200) NULL,
	[Longitude] [varchar](50) NULL,
	[Latitude] [varchar](50) NULL,
	[ViewProdMgmt] [bit] NULL,
	[NotInBuilding] [bit] NULL,
	[CLLICode] [varchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[VerificationStatus] [int] NULL,
	[AlternateAddress] [nvarchar](max) NULL,
	[Cage] [varchar](100) NULL,
	[Rack] [varchar](100) NULL,
	[Market] [int] NULL,
	[SubMarketID] [int] NULL,
	[LocationType] [int] NULL,
	[BuildingSubTypeID] [int] NULL,
	[BuildingServiceTypeID] [int] NULL,
	[StatusChangeNotes] [varchar](2000) NULL,
	[AuditVerification] [bit] NULL,
	[LastAuditedDate] [datetime] NULL,
	[LastAuditedBy] [int] NULL,
	[ValidatationStatus] [int] NULL,
 CONSTRAINT [PK_StreetMasters] PRIMARY KEY CLUSTERED 
(
	[StreetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Test]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Test](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varbinary](50) NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](150) NULL,
	[PasswordHash] [binary](500) NULL,
	[PasswordSalt] [binary](500) NULL,
	[Age] [int] NULL,
	[Gender] [varchar](50) NULL,
	[Created] [date] NULL,
	[Country] [varchar](50) NULL,
	[KnownAs] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Interests] [varchar](50) NULL,
	[Introduction] [varchar](50) NULL,
	[LastActive] [date] NULL,
	[LookingFor] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserMasters](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[RoleID] [int] NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsAcceptedTermsConditions] [bit] NULL,
	[UserTypeId] [int] NULL,
	[TTSRole] [varchar](50) NULL,
	[MOPRole] [varchar](50) NULL,
	[CMSRoleID] [int] NULL,
	[IsCPAccessAllowed] [bit] NULL,
	[IsCIAccessAllowed] [bit] NULL,
	[DepartmentId] [int] NULL,
	[ShouldNotified] [bit] NULL,
	[MobileNumber] [varchar](50) NULL,
	[ContactTypeID] [int] NULL,
	[TTSUserGroupID] [int] NULL,
	[Token_ID] [nvarchar](50) NULL,
	[Token_Created_On] [datetime] NULL,
	[LocationId] [int] NULL,
	[OfficeId] [int] NULL,
	[DesignationId] [int] NULL,
	[ImageURL] [nvarchar](500) NULL,
	[ReportTo] [int] NULL,
	[LastOSSLoginTime] [datetime] NULL,
	[LastCRMLoginTime] [datetime] NULL,
	[LastTTSLoginTime] [datetime] NULL,
 CONSTRAINT [PK_UserMasters] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_AccountsDetails]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_AccountsDetails](
	[CustomerId] [int] NOT NULL,
	[AccountOwner] [varchar](101) NULL,
	[AccountId] [char](10) NOT NULL,
	[Accountname] [varchar](100) NOT NULL,
	[ParentAccount] [varchar](100) NULL,
	[Phone] [varchar](25) NULL,
	[Email] [varchar](50) NOT NULL,
	[PrimaryAddress] [varchar](306) NULL,
	[AccountStatus] [varchar](8) NOT NULL,
	[AccountType] [varchar](100) NULL,
	[AccountOwnerId] [int] NULL,
	[AccountTypeId] [int] NULL,
	[IndustryTypeId] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[CustomerJobs] [varchar](max) NOT NULL,
	[Industry_type] [varchar](50) NOT NULL,
	[Fax] [varchar](15) NULL,
	[Website] [varchar](100) NULL,
	[AgentFee] [varchar](20) NULL,
	[Annual_Revenue] [decimal](19, 4) NULL,
	[Employees] [int] NULL,
	[Description] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_ActivityDetails]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_ActivityDetails](
	[Id] [bigint] NOT NULL,
	[Subject] [varchar](100) NULL,
	[TaskEmail] [varchar](5) NOT NULL,
	[DueDate] [datetime] NULL,
	[Status] [varchar](30) NULL,
	[Priority] [varchar](30) NOT NULL,
	[AssignedBy] [varchar](101) NULL,
	[AssignedTo] [varchar](101) NULL,
	[Attachments] [nvarchar](max) NULL,
	[EntityValue] [int] NULL,
	[EntityTypeId] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ISActive] [bit] NULL,
	[TaskStatusId] [int] NULL,
	[AssignToUserId] [int] NULL,
	[CreatedBy] [int] NULL,
	[EntityValueName] [varchar](101) NULL,
	[StageTypeId] [int] NULL,
	[RelatedToEntityValue] [bigint] NULL,
 CONSTRAINT [PK_VW_ActivityDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[TaskEmail] ASC,
	[Priority] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_CircuitDetailsList]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_CircuitDetailsList](
	[JobOptionID] [bigint] NULL,
	[CircuitDetailID] [bigint] NOT NULL,
	[PTPCircuitID] [varchar](50) NOT NULL,
	[IsColoSpaceRequired] [varchar](3) NOT NULL,
	[IsTypeIIRequired] [varchar](3) NOT NULL,
	[RequestedBandwidth] [varchar](55) NULL,
	[DarkFibersNo] [varchar](50) NULL,
	[LocationA] [varchar](175) NULL,
	[IsLocADuplicate] [int] NOT NULL,
	[LocADuplicateData] [nvarchar](max) NOT NULL,
	[LocationZ] [varchar](174) NULL,
	[IsLocZDuplicate] [int] NOT NULL,
	[LocZDuplicateData] [nvarchar](max) NOT NULL,
	[ExistingTracker] [varchar](50) NOT NULL,
	[UpdatedTracker] [varchar](50) NOT NULL,
	[OrderType] [varchar](50) NULL,
	[ProductType] [varchar](50) NULL,
	[PrimaryCircuitId] [bigint] NULL,
	[ChildProductType] [varchar](50) NULL,
	[TypeID] [int] NULL,
	[LocAVerificationStatus] [int] NOT NULL,
	[LocZVerificationStatus] [int] NOT NULL,
	[LocationAID] [int] NULL,
	[LocationZID] [int] NULL,
	[LocAStreetId] [int] NOT NULL,
	[LocZStreetId] [int] NOT NULL,
	[IsCircuitIdCreated] [bit] NOT NULL,
	[IsCircuitReInitiated] [bit] NOT NULL,
	[UpdatedCircuitTypeID] [int] NOT NULL,
	[IsLocASameForSelectedProduct] [int] NOT NULL,
	[LocACLLICode] [varchar](100) NULL,
	[LocZCLLICode] [varchar](100) NULL,
	[CircuitStatusID] [int] NULL,
	[CircuitStatus] [varchar](100) NULL,
	[ParentCOCircuitDetailId] [bigint] NULL,
	[IsCrossConnect] [varchar](3) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_GetLocationListNew]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_GetLocationListNew](
	[LocationRecord] [varchar](9) NOT NULL,
	[CLLICode1] [varchar](100) NULL,
	[LocationID] [int] NOT NULL,
	[LocationName] [varchar](100) NOT NULL,
	[StreetDescription] [varchar](100) NOT NULL,
	[City] [varchar](50) NULL,
	[StateDescription] [varchar](100) NULL,
	[Zip] [varchar](20) NULL,
	[ClliCode] [varchar](100) NULL,
	[IsActive] [bit] NOT NULL,
	[Latitude] [varchar](50) NULL,
	[Longitude] [varchar](50) NULL,
	[Floor] [varchar](50) NULL,
	[Suite] [varchar](50) NULL,
	[COUNTY] [varchar](50) NULL,
	[BuildingType] [varchar](50) NULL,
	[BuildingFiberStatus] [varchar](50) NULL,
	[BuildingServiceStatus] [varchar](50) NULL,
	[ThirdPartyBuildingStatus] [varchar](50) NULL,
	[VerificationStatus] [int] NULL,
	[StreetID] [int] NOT NULL,
	[BuildingTypeNew] [int] NULL,
	[LATA] [varchar](max) NULL,
	[AlternateAddress] [nvarchar](max) NULL,
	[FTPDemarc] [varchar](100) NULL,
	[OspDermicNotes] [varchar](2000) NULL,
	[Cage] [varchar](100) NULL,
	[Rack] [varchar](100) NULL,
	[ISPDemarcNotes] [varchar](2000) NULL,
	[StatusChangeNotes] [varchar](2000) NULL,
	[LastModifiedDate] [datetime] NULL,
	[Auditverification] [varchar](3) NOT NULL,
	[LastAuditDate] [datetime] NULL,
	[LastAuditedBy] [int] NULL,
	[LastAuditByName] [varchar](101) NULL,
	[LastModifiedBy] [varchar](101) NULL,
	[SubBuildingType] [varchar](50) NULL,
	[Market] [varchar](50) NULL,
	[SubMarket] [varchar](50) NULL,
	[UpnHubStatus] [varchar](50) NULL,
	[LocationtypeNew] [nvarchar](50) NULL,
	[LocationTypeID] [int] NULL,
	[BuildingServiceType] [varchar](50) NULL,
	[ValidatationStatus] [varchar](20) NOT NULL,
	[LocStatus] [varchar](8) NOT NULL,
	[OpportnityAccountList] [varchar](5000) NULL,
	[OrderAccountList] [varchar](5000) NULL,
	[AssociatedProjects] [varchar](5000) NULL,
 CONSTRAINT [PK_VW_GetLocationListNew] PRIMARY KEY CLUSTERED 
(
	[LocationRecord] ASC,
	[LocationID] ASC,
	[LocationName] ASC,
	[StreetDescription] ASC,
	[IsActive] ASC,
	[StreetID] ASC,
	[Auditverification] ASC,
	[ValidatationStatus] ASC,
	[LocStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_UserAuthenticate]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_UserAuthenticate](
	[UserID] [int] NOT NULL,
	[loginName] [varchar](50) NULL,
	[UserName] [varchar](101) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[DepartmentIds] [varchar](500) NULL,
	[DepartmentID] [varchar](500) NOT NULL,
	[Department] [varchar](200) NULL,
	[DepartmentNames] [varchar](5000) NULL,
	[RoleIds] [varchar](800) NULL,
	[RoleNames] [varchar](8000) NULL,
	[DeptWisepermissions] [varchar](8000) NULL,
	[AllPermissions] [varchar](8000) NULL,
	[groupIds] [nvarchar](500) NULL,
	[groupNames] [nvarchar](4000) NULL,
	[RoleID] [int] NOT NULL,
	[IsAcceptedTermsConditions] [bit] NOT NULL,
	[UserTypeid] [int] NOT NULL,
	[IsCPAccessAllowed] [int] NOT NULL,
	[IsCIAccessAllowed] [int] NOT NULL,
	[TTSRole] [varchar](50) NOT NULL,
	[DepartmentMasterIds] [varchar](500) NOT NULL,
	[DepartmentMasterNames] [varchar](800) NOT NULL,
	[ImageURL] [nvarchar](500) NULL,
 CONSTRAINT [PK_VW_UserAuthenticate] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[DepartmentID] ASC,
	[RoleID] ASC,
	[IsAcceptedTermsConditions] ASC,
	[UserTypeid] ASC,
	[IsCPAccessAllowed] ASC,
	[IsCIAccessAllowed] ASC,
	[TTSRole] ASC,
	[DepartmentMasterIds] ASC,
	[DepartmentMasterNames] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_UserAuthenticateWithRole]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_UserAuthenticateWithRole](
	[UserID] [int] NOT NULL,
	[loginName] [varchar](50) NULL,
	[UserName] [varchar](101) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[ImageURL] [nvarchar](500) NULL,
	[RoleIds] [varchar](800) NULL,
	[RoleNames] [varchar](8000) NULL,
	[DepartmentId] [varchar](500) NULL,
	[DeptWisepermissions] [varchar](max) NULL,
	[RoleID] [int] NOT NULL,
	[UserTypeid] [int] NOT NULL,
	[TTSRole] [varchar](50) NULL,
	[MyTeams] [varchar](max) NULL,
	[MyVerticals] [varchar](8000) NULL,
 CONSTRAINT [PK_VW_UserAuthenticateWithRole] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[RoleID] ASC,
	[UserTypeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_UserAuthenticateWithRolePMI]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_UserAuthenticateWithRolePMI](
	[UserID] [int] NOT NULL,
	[loginName] [varchar](50) NULL,
	[UserName] [varchar](101) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[ImageURL] [nvarchar](500) NULL,
	[TTSRole] [varchar](50) NULL,
	[RoleIds] [varchar](800) NULL,
	[RoleNames] [varchar](8000) NULL,
	[DepartmentId] [varchar](500) NULL,
	[DeptWisepermissions] [varchar](max) NULL,
	[RoleID] [int] NOT NULL,
	[UserTypeid] [int] NOT NULL,
	[MyTeams] [varchar](max) NULL,
	[MyVerticals] [varchar](8000) NULL,
 CONSTRAINT [PK_VW_UserAuthenticateWithRolePMI] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[RoleID] ASC,
	[UserTypeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VW_WorkflowNotificationDetail]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VW_WorkflowNotificationDetail](
	[OppotunityOwner] [varchar](101) NULL,
	[TrackerNumber] [varchar](50) NULL,
	[OpportunityName] [varchar](100) NULL,
	[CloseDate] [datetime] NULL,
	[AccountName] [varchar](100) NULL,
	[OpportunityType] [varchar](50) NOT NULL,
	[CoreMarket] [varchar](50) NOT NULL,
	[City] [varchar](100) NULL,
	[State] [varchar](100) NOT NULL,
	[NetworkScope] [varchar](50) NULL,
	[LogicalDrawingComplete] [datetime] NULL,
	[OptionName] [varchar](100) NULL,
	[TypeIIColo] [varchar](3) NOT NULL,
	[JobOptionId] [bigint] NULL,
	[EstimationRequestID] [bigint] NULL,
	[RegionName] [nvarchar](max) NULL,
	[CreatedTime] [datetime] NULL,
	[RequestNumber] [varchar](30) NULL,
	[WorkflowInstanceStatus] [nvarchar](max) NULL,
	[ParentJobId] [bigint] NOT NULL,
	[JobID] [bigint] NULL,
	[IsCancelled] [bit] NULL,
	[CancelReason] [varchar](500) NULL,
	[VerticalMarket] [varchar](50) NULL,
	[CrmJobOptionId] [bigint] NOT NULL,
	[OptionRegionName] [nvarchar](max) NULL,
	[EstimationNotes] [varchar](max) NULL,
 CONSTRAINT [PK_VW_WorkflowNotificationDetail] PRIMARY KEY CLUSTERED 
(
	[OpportunityType] ASC,
	[CoreMarket] ASC,
	[State] ASC,
	[TypeIIColo] ASC,
	[ParentJobId] ASC,
	[CrmJobOptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VWTaskScheduleTaskDetails]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VWTaskScheduleTaskDetails](
	[TaskScheduleID] [bigint] NOT NULL,
	[ParentTaskScheduleID] [bigint] NULL,
	[JobID] [bigint] NULL,
	[CircuitID] [bigint] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Term] [int] NULL,
	[minimumTerm] [int] NULL,
	[AssignedTo] [int] NULL,
	[PPlannedInstallDate] [datetime] NULL,
	[PActualInstallDate] [datetime] NULL,
	[ActualStartDate] [datetime] NULL,
	[ActualEndDate] [datetime] NULL,
	[PlannedStartDate] [datetime] NULL,
	[PlannedEndDate] [datetime] NULL,
	[CompletionDate] [datetime] NULL,
	[IsOpen] [bit] NULL,
	[IsCompleted] [bit] NULL,
	[IsActive] [bit] NULL,
	[WorkFlowTaskID] [int] NOT NULL,
	[DepartmentID] [int] NULL,
	[WorkFlowTypeID] [int] NULL,
	[TaskID] [int] NOT NULL,
	[TaskName] [varchar](150) NOT NULL,
	[DeptGroupID] [int] NULL,
	[TrackingTaskName] [varchar](150) NOT NULL,
	[WebPage] [varchar](500) NULL,
	[JobNumber] [varchar](50) NULL,
	[PTPCircuitID] [int] NULL,
	[CustomerDesiredDate] [int] NULL,
	[CustomerID] [int] NULL,
	[IsPermitsTask] [bit] NULL,
	[IsImplementationTask] [bit] NULL,
	[ServiceTypeID] [int] NOT NULL,
	[IsNA] [bit] NULL,
	[CompletedBy] [int] NULL,
	[IsJobLevel] [bit] NULL,
	[WorkFlowTaskStatusID] [int] NULL,
	[IsNew] [bit] NULL,
	[Description] [nvarchar](2000) NULL,
	[IsMailDue] [bit] NULL,
	[IsNotificationDue] [bit] NULL,
	[IsProgress] [bit] NULL,
	[IsNotificationProgress] [bit] NULL,
	[MailGUID] [varchar](100) NULL,
	[IsEarlyComplete] [bit] NULL,
	[IsDropCable] [bit] NULL,
	[IsMOU] [bit] NULL,
	[IsHold] [int] NOT NULL,
	[CircuitGroupID] [int] NULL,
	[CircuitIsParent] [int] NULL,
	[IsGroupable] [bit] NULL,
	[IsJeopardy] [int] NULL,
	[DepartmentName] [varchar](100) NOT NULL,
	[FOCDate] [int] NULL,
	[TaskCode] [varchar](10) NULL,
	[CustomerTypeID] [int] NULL,
	[DeptGroupName] [nvarchar](50) NULL,
	[SequenceID] [bigint] NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[TIMESTAMP] [binary](8) NULL,
	[DepartmentGroupDetailId] [int] NULL,
	[ServiceItemMasterID] [int] NULL,
	[ServiceItem] [varchar](1) NOT NULL,
	[ServiceType] [varchar](1) NOT NULL,
	[ServiceId] [int] NULL,
	[ServiceLevelSDM] [varchar](1) NOT NULL,
	[ServicelevelSDMGroup] [varchar](1) NOT NULL,
	[OrderCreatedBy] [int] NULL,
	[TaskStage] [varchar](16) NOT NULL,
	[FullTaskCode] [varchar](46) NOT NULL,
	[OnHoldReason] [nvarchar](max) NULL,
	[IsOnHold] [bit] NULL,
	[OnHoldBy] [int] NULL,
	[OnHoldDate] [datetime] NULL,
	[ResumeDate] [datetime] NULL,
	[WorkFlowID] [int] NULL,
 CONSTRAINT [PK_VWTaskScheduleTaskDetails] PRIMARY KEY CLUSTERED 
(
	[TaskScheduleID] ASC,
	[WorkFlowTaskID] ASC,
	[TaskID] ASC,
	[TaskName] ASC,
	[TrackingTaskName] ASC,
	[ServiceTypeID] ASC,
	[IsHold] ASC,
	[DepartmentName] ASC,
	[ServiceItem] ASC,
	[ServiceType] ASC,
	[ServiceLevelSDM] ASC,
	[ServicelevelSDMGroup] ASC,
	[TaskStage] ASC,
	[FullTaskCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WorkFlowTypeMasters]    Script Date: 1/22/2020 4:10:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WorkFlowTypeMasters](
	[WorkFlowTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedTime] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsActivityType] [bit] NOT NULL,
 CONSTRAINT [PK_WorkFlowTypeMasters] PRIMARY KEY CLUSTERED 
(
	[WorkFlowTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Photo] ON 

INSERT [dbo].[Photo] ([Id], [Url], [Description], [DateAdded], [IsMain], [UserId], [PublicId]) VALUES (1, N'/images/Image_2.jfif', N'Teszt', CAST(N'2020-01-22' AS Date), 0, 1, N'1')
INSERT [dbo].[Photo] ([Id], [Url], [Description], [DateAdded], [IsMain], [UserId], [PublicId]) VALUES (2, N'/images/Image_3.jfif', N'32424', CAST(N'2020-01-22' AS Date), 0, 1, N'2')
INSERT [dbo].[Photo] ([Id], [Url], [Description], [DateAdded], [IsMain], [UserId], [PublicId]) VALUES (3, N'/images/Image_4.jfif', N'45621345', CAST(N'2020-01-22' AS Date), 1, 6, N'3')
INSERT [dbo].[Photo] ([Id], [Url], [Description], [DateAdded], [IsMain], [UserId], [PublicId]) VALUES (4, N'/images/Image_5.jfif', N'3423423', CAST(N'2020-01-22' AS Date), 1, 6, N'4')
SET IDENTITY_INSERT [dbo].[Photo] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Username], [PasswordHash], [PasswordSalt], [Age], [Gender], [Created], [Country], [KnownAs], [City], [Interests], [Introduction], [LastActive], [LookingFor], [Name]) VALUES (1, N'test', 0xA67932F51AF0AB68171137DC8DAB496311B6F0EDA4782906099AF2366FE8C72C908DE58125A56D195C78712AEE5C71DBAFC1A01D773FA23915495A63D3B22F9600000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 0xAB6CB20668923BF09AA5BE4744129B6C9E219B27594EE369E39B9E018B633B3A2B9D29B7B0937831BCAAB4D9CA18D223C607A54F4662633EBDCAA9DDED749D9D7F327B3163D68DE035B1FCCD9536D32146F88C807B2331A4625AF5EF1E5B3162913D1E1E7E88CB73D24A1627E7D093B3B9EE26C6679FDB6F797C6B4D91961EF6000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 24, N'Female', CAST(N'2020-01-22' AS Date), N'India', N'Rekha', N'Chandhighar', N'Test Test', N'erererwrwerwer', CAST(N'2020-01-22' AS Date), N'Rana', N'Rekha')
INSERT [dbo].[User] ([Id], [Username], [PasswordHash], [PasswordSalt], [Age], [Gender], [Created], [Country], [KnownAs], [City], [Interests], [Introduction], [LastActive], [LookingFor], [Name]) VALUES (2, N'test1', 0x4DE54E9B301EEC13538E9D4EAEB1E95C1725FC4F6F39219B898CEE24323DCBF29BEDC0F7A952D8F633E108FEC9C90DA52A1250482028A2D0E0936669945DA06F00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 0xC46E99E04266EFC094B56554A5BB98C128711ACBEB02A626DB7C1381FAD041136FA70912E30DBEC7887AAA58615E9D3395B3579B0C56A85468259B33A0E3B9A58C66D8173C386AB58C1CEB3E35CA2805B95CF52D5F25DB2F0743BFF5D91075FB8BE075922B9255FB51076187052D946F74DA899FB67922E6B96A85D8535BABFA000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 26, N'Male', CAST(N'2020-01-22' AS Date), N'India', N'Nidhi', N'x', N'weqwe', N'weqweqwe', CAST(N'2020-01-22' AS Date), N'erew', NULL)
INSERT [dbo].[User] ([Id], [Username], [PasswordHash], [PasswordSalt], [Age], [Gender], [Created], [Country], [KnownAs], [City], [Interests], [Introduction], [LastActive], [LookingFor], [Name]) VALUES (3, N'test2', 0x9C03DC6973B5B2E913E67007B8AEDE7A4160E2FC40F26CBD3AC22FC6B7CD6A45A111133274939D55C8A8CE25BB8C712D1E043BE061FBC38932F8058FBAD2794600000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 0x3824601C3138B1A73CE4322B3828C3444A089F5CEF93F7085DE7367EC57A7318D59383CDD7160BB81C5D2903D677593A8B883D3992766BC5BBDA2C44AC6DE92E1FB7DAE25A4401B7E48592046BDEF3E20F844B0D5FC4979C38E2ECC67525C78AE37E1256CEEB28F01339F6A1825DB2E987C85708FD0E6FE237632907E1C93EF4000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 44, N'Male', CAST(N'2020-01-22' AS Date), N'India', N'Rekha', N'Chandhighar', N'weqweqwe', N'weqweqwe', CAST(N'2020-01-22' AS Date), N'wer', NULL)
INSERT [dbo].[User] ([Id], [Username], [PasswordHash], [PasswordSalt], [Age], [Gender], [Created], [Country], [KnownAs], [City], [Interests], [Introduction], [LastActive], [LookingFor], [Name]) VALUES (5, N'rekharana12', 0xF8A992C013A8C9BB69CCFA0033E5798BA5A961E28C8D60F1C8B68539BF6BC19679AE49363A55D9E44C89B39FF13498D4EA0D2983CDEC0115025D4E6D4416318D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 0xBF754ACD8B3FB4457D4FFB6997B6C6A444BA72EC3EFD16BFAEA944BCC04A12ED0328A944C2D3EAA0EB2BFED20723695B79AFD1B3C0196722E6D35DCD50F30CCF4B6172953F68739777A0C5CF861D30DB1EA25E3F010D70207C5C12F896CC2E11B714B856B133F523FF5AC8D86FB2E34F5A4E96A0629C92281A68A2E5A5ACDD66000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 43, N'Female', CAST(N'2020-01-22' AS Date), N'India', N'Rekha', N'Chandhighar', N'weqweqwe', N'weqweqwe', CAST(N'2020-01-22' AS Date), N'wer', NULL)
INSERT [dbo].[User] ([Id], [Username], [PasswordHash], [PasswordSalt], [Age], [Gender], [Created], [Country], [KnownAs], [City], [Interests], [Introduction], [LastActive], [LookingFor], [Name]) VALUES (6, N'rekharana', 0xB077E332AC302CED19DD2B3FE03C3FBF6B5E9B7CCEC768ACED927103D7B49EDCA30EE9DC88DD6D7B1B8E97BFC68E21901E3DCD8EA280A862525AAF2D047C7F6100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 0xDF678205017FBA86286818C934A421ECAFAE0C5E9BA2783C7E7B5C6DEDAA9C3A736B73E1B74C12C9E154D8C6A6195EA7361B1B4F9918F63E0FF77D2B9054A9CC053966C48834CD7F333F8F83F0FF68546EB9AAE12B006631F8AAC7AA87AEB99387D75C83089AE857796D5B055A5BF5375487F53AEC1F6619559B00C24D93C676000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000, 345, N'Female', CAST(N'2020-01-22' AS Date), N'India', N'Rekha', N'Chandhighar', N'weqweqwe', N'weqweqwe', CAST(N'2020-01-22' AS Date), N'wer', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[UserMasters] ON 

INSERT [dbo].[UserMasters] ([UserID], [FirstName], [LastName], [RoleID], [UserName], [Password], [PhoneNumber], [Email], [CreatedBy], [CreatedTime], [ModifiedBy], [ModifiedTime], [IsActive], [IsAcceptedTermsConditions], [UserTypeId], [TTSRole], [MOPRole], [CMSRoleID], [IsCPAccessAllowed], [IsCIAccessAllowed], [DepartmentId], [ShouldNotified], [MobileNumber], [ContactTypeID], [TTSUserGroupID], [Token_ID], [Token_Created_On], [LocationId], [OfficeId], [DesignationId], [ImageURL], [ReportTo], [LastOSSLoginTime], [LastCRMLoginTime], [LastTTSLoginTime]) VALUES (1, N'Rekha', N'Rana', 1, N'rekharana', N'123456', N'1234567890', N'rekha.rana@netsmartz.com', 1, NULL, 1, NULL, 1, NULL, 1, N'1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[UserMasters] OFF
/****** Object:  Index [IX_FK_Customer_Customer]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Customer_Customer] ON [dbo].[Customers]
(
	[ParentCustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Customer_UserMaster]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Customer_UserMaster] ON [dbo].[Customers]
(
	[CustomerOwnerUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_LetterTemplate_LetterTypeID]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_LetterTemplate_LetterTypeID] ON [dbo].[LetterTemplates]
(
	[LetterTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Location_StreetMaster]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Location_StreetMaster] ON [dbo].[Locations]
(
	[StreetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PMICategoryTypeMaster_PMITypeMaster]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_PMICategoryTypeMaster_PMITypeMaster] ON [dbo].[PMICategoryTypeMasters]
(
	[PMITypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PMIChecklistQuestionMaster_PMICategoryTypeMaster]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_PMIChecklistQuestionMaster_PMICategoryTypeMaster] ON [dbo].[PMIChecklistQuestionMasters]
(
	[CategoryTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PMIChecklistQuestionMaster_PMITypeMaster]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_PMIChecklistQuestionMaster_PMITypeMaster] ON [dbo].[PMIChecklistQuestionMasters]
(
	[PMITypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PMIChecklist_PMITypeMaster]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_PMIChecklist_PMITypeMaster] ON [dbo].[PMIChecklists]
(
	[PMITypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_StreetMaster_StateMaster]    Script Date: 1/22/2020 4:10:12 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_StreetMaster_StateMaster] ON [dbo].[StreetMasters]
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Customer] FOREIGN KEY([ParentCustomerId])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customer_Customer]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customer_UserMaster] FOREIGN KEY([CustomerOwnerUserId])
REFERENCES [dbo].[UserMasters] ([UserID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customer_UserMaster]
GO
ALTER TABLE [dbo].[LetterTemplates]  WITH CHECK ADD  CONSTRAINT [FK_LetterTemplate_LetterTypeID] FOREIGN KEY([LetterTypeID])
REFERENCES [dbo].[LetterTypes] ([LetterTypeID])
GO
ALTER TABLE [dbo].[LetterTemplates] CHECK CONSTRAINT [FK_LetterTemplate_LetterTypeID]
GO
ALTER TABLE [dbo].[Locations]  WITH CHECK ADD  CONSTRAINT [FK_Location_StreetMaster] FOREIGN KEY([StreetID])
REFERENCES [dbo].[StreetMasters] ([StreetID])
GO
ALTER TABLE [dbo].[Locations] CHECK CONSTRAINT [FK_Location_StreetMaster]
GO
ALTER TABLE [dbo].[Photo]  WITH CHECK ADD  CONSTRAINT [FK_Photo_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Photo] CHECK CONSTRAINT [FK_Photo_User]
GO
ALTER TABLE [dbo].[PMICategoryTypeMasters]  WITH CHECK ADD  CONSTRAINT [FK_PMICategoryTypeMaster_PMITypeMaster] FOREIGN KEY([PMITypeID])
REFERENCES [dbo].[PMITypeMasters] ([ID])
GO
ALTER TABLE [dbo].[PMICategoryTypeMasters] CHECK CONSTRAINT [FK_PMICategoryTypeMaster_PMITypeMaster]
GO
ALTER TABLE [dbo].[PMIChecklistQuestionMasters]  WITH CHECK ADD  CONSTRAINT [FK_PMIChecklistQuestionMaster_PMICategoryTypeMaster] FOREIGN KEY([CategoryTypeId])
REFERENCES [dbo].[PMICategoryTypeMasters] ([ID])
GO
ALTER TABLE [dbo].[PMIChecklistQuestionMasters] CHECK CONSTRAINT [FK_PMIChecklistQuestionMaster_PMICategoryTypeMaster]
GO
ALTER TABLE [dbo].[PMIChecklistQuestionMasters]  WITH CHECK ADD  CONSTRAINT [FK_PMIChecklistQuestionMaster_PMITypeMaster] FOREIGN KEY([PMITypeID])
REFERENCES [dbo].[PMITypeMasters] ([ID])
GO
ALTER TABLE [dbo].[PMIChecklistQuestionMasters] CHECK CONSTRAINT [FK_PMIChecklistQuestionMaster_PMITypeMaster]
GO
ALTER TABLE [dbo].[PMIChecklists]  WITH CHECK ADD  CONSTRAINT [FK_PMIChecklist_PMITypeMaster] FOREIGN KEY([PMITypeID])
REFERENCES [dbo].[PMITypeMasters] ([ID])
GO
ALTER TABLE [dbo].[PMIChecklists] CHECK CONSTRAINT [FK_PMIChecklist_PMITypeMaster]
GO
ALTER TABLE [dbo].[StreetMasters]  WITH CHECK ADD  CONSTRAINT [FK_StreetMaster_StateMaster] FOREIGN KEY([StateID])
REFERENCES [dbo].[StateMasters] ([StateID])
GO
ALTER TABLE [dbo].[StreetMasters] CHECK CONSTRAINT [FK_StreetMaster_StateMaster]
GO
USE [master]
GO
ALTER DATABASE [PMI] SET  READ_WRITE 
GO
