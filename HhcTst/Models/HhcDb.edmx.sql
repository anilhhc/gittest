
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/21/2018 15:15:04
-- Generated from EDMX file: C:\Users\ANI\Source\Repos\gittest\HhcTst\Models\HhcDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HhcDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CITies_STATEs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CITies] DROP CONSTRAINT [FK_CITies_STATEs];
GO
IF OBJECT_ID(N'[dbo].[FK_STATEs_Zones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[STATEs] DROP CONSTRAINT [FK_STATEs_Zones];
GO
IF OBJECT_ID(N'[dbo].[FK_subareaCITies_CITies]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubArea] DROP CONSTRAINT [FK_subareaCITies_CITies];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[CITies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CITies];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Hdivisions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hdivisions];
GO
IF OBJECT_ID(N'[dbo].[hhcAdminLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hhcAdminLogins];
GO
IF OBJECT_ID(N'[dbo].[hhcControlPanelIPStats]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hhcControlPanelIPStats];
GO
IF OBJECT_ID(N'[dbo].[hhcprimarysales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hhcprimarysales];
GO
IF OBJECT_ID(N'[dbo].[hhcsecondarysales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hhcsecondarysales];
GO
IF OBJECT_ID(N'[dbo].[Hproductslistdescriptions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hproductslistdescriptions];
GO
IF OBJECT_ID(N'[dbo].[Hproductslists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hproductslists];
GO
IF OBJECT_ID(N'[dbo].[Hstockistdetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hstockistdetails];
GO
IF OBJECT_ID(N'[dbo].[hstockistuploads]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hstockistuploads];
GO
IF OBJECT_ID(N'[dbo].[Htherapatics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Htherapatics];
GO
IF OBJECT_ID(N'[dbo].[Hvendordetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hvendordetails];
GO
IF OBJECT_ID(N'[dbo].[Hvproductslists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hvproductslists];
GO
IF OBJECT_ID(N'[dbo].[Hvsales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hvsales];
GO
IF OBJECT_ID(N'[dbo].[OtherAdminLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OtherAdminLogins];
GO
IF OBJECT_ID(N'[dbo].[OtherAdminPermissions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OtherAdminPermissions];
GO
IF OBJECT_ID(N'[dbo].[secondarysales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[secondarysales];
GO
IF OBJECT_ID(N'[dbo].[STATEs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[STATEs];
GO
IF OBJECT_ID(N'[dbo].[Stockists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stockists];
GO
IF OBJECT_ID(N'[dbo].[SubArea]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubArea];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[tbl_registration]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbl_registration];
GO
IF OBJECT_ID(N'[dbo].[UploadedFiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UploadedFiles];
GO
IF OBJECT_ID(N'[dbo].[UploadFileNames]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UploadFileNames];
GO
IF OBJECT_ID(N'[dbo].[UserAdminLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserAdminLogins];
GO
IF OBJECT_ID(N'[dbo].[USERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERS];
GO
IF OBJECT_ID(N'[dbo].[Usershetroes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usershetroes];
GO
IF OBJECT_ID(N'[dbo].[VENDORSPECIALIZATIONs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENDORSPECIALIZATIONs];
GO
IF OBJECT_ID(N'[dbo].[VENDORSPECIALIZATIONs1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENDORSPECIALIZATIONs1];
GO
IF OBJECT_ID(N'[dbo].[VENDORSUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENDORSUsers];
GO
IF OBJECT_ID(N'[dbo].[VENDORTYPES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENDORTYPES];
GO
IF OBJECT_ID(N'[dbo].[VENDORTYPESpecialisationsentries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENDORTYPESpecialisationsentries];
GO
IF OBJECT_ID(N'[dbo].[Zones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zones];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [CategoryName] varchar(40)  NULL,
    [ParentCategoryId] int  NULL,
    [Remarks] nvarchar(max)  NULL
);
GO

-- Creating table 'CITies'
CREATE TABLE [dbo].[CITies] (
    [CITYID] int IDENTITY(1,1) NOT NULL,
    [CITYNAME] nvarchar(100)  NULL,
    [STATEID] int  NULL,
    [ACTIVE] char(1)  NOT NULL,
    [CreatedOn] datetime  NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Address] nvarchar(50)  NOT NULL,
    [Country] nvarchar(50)  NOT NULL,
    [City] nvarchar(50)  NOT NULL,
    [Mobile] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'Hdivisions'
CREATE TABLE [dbo].[Hdivisions] (
    [HdivisionID] int IDENTITY(1,1) NOT NULL,
    [HdivisionDESC] nvarchar(max)  NULL,
    [heterodivisoncode] nvarchar(50)  NULL,
    [hdname] nvarchar(50)  NULL,
    [Active] nvarchar(50)  NULL
);
GO

-- Creating table 'hhcControlPanelIPStats'
CREATE TABLE [dbo].[hhcControlPanelIPStats] (
    [CPIPID] int IDENTITY(1,1) NOT NULL,
    [CPIP] nvarchar(50)  NULL,
    [CPLoginTime] datetime  NULL,
    [CPLogoutTime] datetime  NULL,
    [CPLoginID] nvarchar(100)  NULL
);
GO

-- Creating table 'hhcprimarysales'
CREATE TABLE [dbo].[hhcprimarysales] (
    [hhcprimarysalesID] int IDENTITY(1,1) NOT NULL,
    [billingdocument] nvarchar(500)  NULL,
    [billingdate] datetime  NULL,
    [stockistcode] nvarchar(50)  NULL,
    [stockistsapid] nvarchar(50)  NULL,
    [stockistname] nvarchar(500)  NULL,
    [headquarter] nvarchar(200)  NULL,
    [heterosapproductcode] nvarchar(100)  NULL,
    [heterosapproductname] nvarchar(max)  NULL,
    [sapproductquantity] nvarchar(50)  NULL,
    [rate] int  NULL,
    [value] int  NULL
);
GO

-- Creating table 'hhcsecondarysales'
CREATE TABLE [dbo].[hhcsecondarysales] (
    [hhcsecondarysalesID] int IDENTITY(1,1) NOT NULL,
    [stockistname] nvarchar(500)  NULL,
    [stockistid] nvarchar(50)  NULL,
    [month] nvarchar(50)  NULL,
    [year] nvarchar(50)  NULL,
    [stockistproductcode] nvarchar(500)  NULL,
    [stockistproductname] nvarchar(500)  NULL,
    [package] nvarchar(50)  NULL,
    [openingstock] int  NULL,
    [purshcasequantity] int  NULL,
    [salequanitity] int  NULL,
    [purchasereturn] int  NULL,
    [salereturn] int  NULL,
    [closing] int  NULL,
    [filepath] nvarchar(max)  NULL,
    [heteroproductid] nvarchar(50)  NULL,
    [heteroproductname] nvarchar(max)  NULL,
    [headquaterid] nvarchar(50)  NULL,
    [headquartername] nvarchar(500)  NULL,
    [heteroproductsapid] nvarchar(50)  NULL
);
GO

-- Creating table 'Hproductslistdescriptions'
CREATE TABLE [dbo].[Hproductslistdescriptions] (
    [HproductslistdescriptionID] int IDENTITY(1,1) NOT NULL,
    [HproductslistdescriptionDESC] nvarchar(max)  NULL,
    [STATUS] nvarchar(60)  NULL,
    [Hproductslistcompanyid] nvarchar(50)  NULL,
    [hpdquantityperpack] nvarchar(50)  NULL,
    [hpdquantityperstrip] nvarchar(50)  NULL,
    [hpdratevalidform] datetime  NULL,
    [hpdpricetoretailer] nvarchar(50)  NULL,
    [hpdmrp] nvarchar(50)  NULL,
    [hpdstandardrate] nvarchar(50)  NULL,
    [hpdpricetostockist] nvarchar(50)  NULL,
    [hpdbrandname] nvarchar(50)  NULL,
    [hdpcategoryname] nvarchar(50)  NULL,
    [hpddivisionname] nvarchar(50)  NULL,
    [hdpmanfacturename] nvarchar(50)  NULL
);
GO

-- Creating table 'Hproductslists'
CREATE TABLE [dbo].[Hproductslists] (
    [HproductslistID] int IDENTITY(1,1) NOT NULL,
    [HproductslistNAME] nvarchar(255)  NULL,
    [HproductslistDESC] nvarchar(max)  NULL,
    [Hproductslistcompanyid] nvarchar(50)  NULL
);
GO

-- Creating table 'Hstockistdetails'
CREATE TABLE [dbo].[Hstockistdetails] (
    [HstockistdetailsID] int IDENTITY(1,1) NOT NULL,
    [hsfullname] nvarchar(50)  NULL,
    [hslastname] nvarchar(50)  NULL,
    [hsemailid] nvarchar(50)  NULL,
    [hsmobile] nvarchar(50)  NULL,
    [hspwd] nvarchar(50)  NULL,
    [hssapcustomerid] nvarchar(50)  NULL,
    [hsplotno] nvarchar(50)  NULL,
    [hsadressone] nvarchar(max)  NULL,
    [hsadresstwo] nvarchar(max)  NULL,
    [hscountry] nvarchar(50)  NULL,
    [hsstate] nvarchar(50)  NULL,
    [hsheadquater] nvarchar(50)  NULL,
    [hssubarea] nvarchar(50)  NULL,
    [hsdivision] nvarchar(50)  NULL,
    [hscnf] nvarchar(50)  NULL,
    [hstherapatic] nvarchar(50)  NULL,
    [hspincode] nvarchar(50)  NULL,
    [hstelephone] nvarchar(50)  NULL,
    [hsfax] nvarchar(50)  NULL,
    [hsgstprovisionalid] nvarchar(50)  NULL,
    [hspan] nvarchar(50)  NULL,
    [hsspocname] nvarchar(50)  NULL,
    [hsspocmobile] nvarchar(50)  NULL,
    [hsssistatus] nvarchar(50)  NULL,
    [hsdruglicenceno] nvarchar(50)  NULL,
    [hszone] nvarchar(50)  NULL
);
GO

-- Creating table 'hstockistuploads'
CREATE TABLE [dbo].[hstockistuploads] (
    [hstockistuploadID] int IDENTITY(1,1) NOT NULL,
    [filedescription] nvarchar(max)  NULL,
    [month] int  NULL,
    [year] int  NULL,
    [filenumber] int  NULL,
    [fileuploaddate] datetime  NULL,
    [filepath] nvarchar(max)  NULL,
    [monthname] nvarchar(50)  NULL,
    [stockistid] nvarchar(50)  NULL,
    [Status] nvarchar(50)  NULL
);
GO

-- Creating table 'Htherapatics'
CREATE TABLE [dbo].[Htherapatics] (
    [HtherapaticID] int IDENTITY(1,1) NOT NULL,
    [HtherapaticDESC] nvarchar(max)  NULL,
    [HtherapaticSTATUS] nvarchar(60)  NULL,
    [htheterocode] nvarchar(50)  NULL,
    [hthetroname] nvarchar(50)  NULL,
    [htdivisionid] nvarchar(50)  NULL
);
GO

-- Creating table 'Hvendordetails'
CREATE TABLE [dbo].[Hvendordetails] (
    [HvendordetailsID] int IDENTITY(1,1) NOT NULL,
    [vfullname] nvarchar(200)  NULL,
    [vlogo] nvarchar(10)  NULL
);
GO

-- Creating table 'Hvproductslists'
CREATE TABLE [dbo].[Hvproductslists] (
    [HvproductslistID] int IDENTITY(1,1) NOT NULL,
    [HvproductslistNAME] nvarchar(255)  NULL,
    [HvproductslistDESC] nvarchar(max)  NULL,
    [Hvproductslistcompanyid] nvarchar(50)  NULL,
    [Hproductslistcompanyid] nvarchar(50)  NULL,
    [hvstockistid] nvarchar(50)  NULL,
    [Hproductslistcompanyname] nvarchar(50)  NULL,
    [hvstockistname] nvarchar(50)  NULL
);
GO

-- Creating table 'Hvsales'
CREATE TABLE [dbo].[Hvsales] (
    [HvsalesID] int IDENTITY(1,1) NOT NULL,
    [HvproductslistNAME] nvarchar(255)  NULL,
    [HvproductslistDESC] nvarchar(16)  NULL,
    [Hvproductslistcompanyid] nvarchar(50)  NULL,
    [Hproductslistcompanyid] nvarchar(50)  NULL,
    [Hproductsquantity] nvarchar(50)  NULL
);
GO

-- Creating table 'OtherAdminLogins'
CREATE TABLE [dbo].[OtherAdminLogins] (
    [OtherAdminId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [UserPwd] nvarchar(50)  NULL,
    [Name] nvarchar(50)  NULL,
    [Branch] nvarchar(50)  NULL,
    [Permissions] nvarchar(max)  NULL,
    [EmailID] nvarchar(50)  NULL,
    [ActiveStatus] nchar(1)  NULL
);
GO

-- Creating table 'OtherAdminPermissions'
CREATE TABLE [dbo].[OtherAdminPermissions] (
    [OtherAdminPermissionID] int IDENTITY(1,1) NOT NULL,
    [OtherAdminId] int  NULL,
    [SectionPermitted] nvarchar(50)  NULL
);
GO

-- Creating table 'secondarysales'
CREATE TABLE [dbo].[secondarysales] (
    [secondarysalesID] int IDENTITY(1,1) NOT NULL,
    [month] nvarchar(50)  NULL,
    [year] nvarchar(50)  NULL,
    [filepath] nvarchar(max)  NULL,
    [stockistid] nvarchar(50)  NULL,
    [productcode] nvarchar(500)  NULL,
    [productname] nvarchar(500)  NULL,
    [pack] nvarchar(50)  NULL,
    [purshcasequantity] int  NULL,
    [purchasereturn] int  NULL,
    [openingquantity] int  NULL,
    [salequanitity] int  NULL,
    [salereturn] int  NULL,
    [closing] int  NULL,
    [heteroproductid] nvarchar(50)  NULL
);
GO

-- Creating table 'Stockists'
CREATE TABLE [dbo].[Stockists] (
    [StockistId] int IDENTITY(1,1) NOT NULL,
    [StockistName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [CreatedOn] datetime  NULL,
    [ACTIVE] char(1)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'UploadFileNames'
CREATE TABLE [dbo].[UploadFileNames] (
    [UploadFileId] int IDENTITY(1,1) NOT NULL,
    [UploadFileName1] nvarchar(100)  NOT NULL,
    [FileType] nvarchar(50)  NULL,
    [FilePath] nvarchar(200)  NULL,
    [Section] nvarchar(200)  NULL,
    [UploadedDate] datetime  NULL,
    [UploadedBy] nvarchar(50)  NULL
);
GO

-- Creating table 'UserAdminLogins'
CREATE TABLE [dbo].[UserAdminLogins] (
    [OtherAdminId] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(50)  NULL,
    [UserPwd] nvarchar(50)  NULL,
    [FirstName] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NULL,
    [Permissions] nvarchar(max)  NULL,
    [Adress] nvarchar(50)  NULL,
    [ActiveStatus] nchar(1)  NULL,
    [State] nvarchar(50)  NULL,
    [country] nvarchar(50)  NULL,
    [Mobile] nvarchar(50)  NULL
);
GO

-- Creating table 'USERS'
CREATE TABLE [dbo].[USERS] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(20)  NULL,
    [UserPwd] nvarchar(10)  NULL,
    [UserRole] nvarchar(50)  NULL
);
GO

-- Creating table 'Usershetroes'
CREATE TABLE [dbo].[Usershetroes] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Address] nvarchar(150)  NULL,
    [ContactNo] varchar(50)  NULL
);
GO

-- Creating table 'VENDORSPECIALIZATIONs'
CREATE TABLE [dbo].[VENDORSPECIALIZATIONs] (
    [SPECIALIZATIONID] int IDENTITY(1,1) NOT NULL,
    [SPECIALIZATIONNAME] nvarchar(255)  NULL,
    [SPECIALIZATIONDESC] nvarchar(16)  NULL,
    [Procedures] nvarchar(50)  NULL,
    [ACTIVE] char(1)  NOT NULL,
    [Vendortype] nvarchar(50)  NULL
);
GO

-- Creating table 'VENDORSPECIALIZATIONs1'
CREATE TABLE [dbo].[VENDORSPECIALIZATIONs1] (
    [SPECIALIZATIONID] int IDENTITY(1,1) NOT NULL,
    [SPECIALIZATIONNAME] nvarchar(255)  NULL,
    [SPECIALIZATIONDESC] nvarchar(16)  NULL,
    [Procedures] nvarchar(50)  NULL,
    [ACTIVE] char(1)  NOT NULL,
    [Vendortype] nvarchar(50)  NULL,
    [ratingrtype] nvarchar(50)  NULL
);
GO

-- Creating table 'VENDORSUsers'
CREATE TABLE [dbo].[VENDORSUsers] (
    [VENDORID] int IDENTITY(1,1) NOT NULL,
    [VendorSPECIALISATION] nvarchar(400)  NULL,
    [QUALIFICATION] nvarchar(400)  NULL,
    [AGE] int  NULL,
    [GENDER] nchar(1)  NULL,
    [ADDRESS] nvarchar(1000)  NULL,
    [CITY] nvarchar(50)  NULL,
    [STATE] nvarchar(50)  NULL,
    [COUNTRY] nchar(10)  NULL,
    [ZIP] int  NULL,
    [MOBILE] nvarchar(50)  NULL,
    [ACTIVE] nchar(1)  NOT NULL,
    [PHOTO] nvarchar(60)  NULL,
    [Designation] nvarchar(500)  NULL,
    [BriefProfile] nvarchar(max)  NULL,
    [PresentPosition] nvarchar(max)  NULL,
    [Qualifications] nvarchar(max)  NULL,
    [SpecialTraining] nvarchar(max)  NULL,
    [Experience] nvarchar(max)  NULL,
    [Expertise] nvarchar(max)  NULL,
    [AchievementsBreakthroughCases] nvarchar(max)  NULL,
    [Publications] nvarchar(max)  NULL,
    [AwardsAndHonors] nvarchar(max)  NULL,
    [AcademicExposure] nvarchar(max)  NULL,
    [TalkDelivered] nvarchar(max)  NULL,
    [Other] nvarchar(max)  NULL,
    [Media] nvarchar(max)  NULL,
    [Firstname] nvarchar(50)  NULL,
    [Lastname] nvarchar(50)  NULL,
    [Email] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL,
    [vendortype] nvarchar(50)  NULL
);
GO

-- Creating table 'VENDORTYPES'
CREATE TABLE [dbo].[VENDORTYPES] (
    [VENDORTYPEID] int IDENTITY(1,1) NOT NULL,
    [VENDORTYPENAME] nvarchar(100)  NULL,
    [HomePageText] nvarchar(max)  NULL,
    [About] nvarchar(max)  NULL,
    [DisplayOrder] int  NULL,
    [ACTIVE] char(1)  NOT NULL
);
GO

-- Creating table 'VENDORTYPESpecialisationsentries'
CREATE TABLE [dbo].[VENDORTYPESpecialisationsentries] (
    [BSID] int IDENTITY(1,1) NOT NULL,
    [DivisionID] int  NULL,
    [BranchID] int  NULL
);
GO

-- Creating table 'Zones'
CREATE TABLE [dbo].[Zones] (
    [ZoneID] int IDENTITY(1,1) NOT NULL,
    [ZoneName] nvarchar(100)  NULL,
    [ACTIVE] char(1)  NOT NULL,
    [CreatedOn] datetime  NULL
);
GO

-- Creating table 'hhcAdminLogins'
CREATE TABLE [dbo].[hhcAdminLogins] (
    [hhcAdminLoginsId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [UserPwd] nvarchar(50)  NULL,
    [Name] nvarchar(50)  NULL,
    [Permissions] nvarchar(max)  NULL,
    [EmailID] nvarchar(50)  NULL,
    [ActiveStatus] nchar(1)  NULL,
    [CreatedOn] datetime  NULL
);
GO

-- Creating table 'STATEs'
CREATE TABLE [dbo].[STATEs] (
    [STATEID] int IDENTITY(1,1) NOT NULL,
    [STATENAME] nvarchar(100)  NULL,
    [Zone] int  NULL,
    [ACTIVE] char(1)  NOT NULL,
    [CreatedOn] datetime  NULL
);
GO

-- Creating table 'SubAreas'
CREATE TABLE [dbo].[SubAreas] (
    [SubAreaID] int IDENTITY(1,1) NOT NULL,
    [SubArea1] nvarchar(100)  NULL,
    [CITYID] int  NULL,
    [ACTIVE] char(1)  NOT NULL,
    [CreatedOn] datetime  NULL
);
GO

-- Creating table 'tbl_registration'
CREATE TABLE [dbo].[tbl_registration] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Email] varchar(50)  NULL,
    [Password] varchar(50)  NULL,
    [City] varchar(50)  NULL,
    [Address] varchar(50)  NULL,
    [CreatedOn] datetime  NULL,
    [ContactNo] varchar(50)  NULL
);
GO

-- Creating table 'UploadedFiles'
CREATE TABLE [dbo].[UploadedFiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FileName] nvarchar(500)  NULL,
    [FileDescription] nvarchar(max)  NULL,
    [FilePath] nvarchar(max)  NULL,
    [UploadedTime] datetime  NULL,
    [States] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [CITYID] in table 'CITies'
ALTER TABLE [dbo].[CITies]
ADD CONSTRAINT [PK_CITies]
    PRIMARY KEY CLUSTERED ([CITYID] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [HdivisionID] in table 'Hdivisions'
ALTER TABLE [dbo].[Hdivisions]
ADD CONSTRAINT [PK_Hdivisions]
    PRIMARY KEY CLUSTERED ([HdivisionID] ASC);
GO

-- Creating primary key on [CPIPID] in table 'hhcControlPanelIPStats'
ALTER TABLE [dbo].[hhcControlPanelIPStats]
ADD CONSTRAINT [PK_hhcControlPanelIPStats]
    PRIMARY KEY CLUSTERED ([CPIPID] ASC);
GO

-- Creating primary key on [hhcprimarysalesID] in table 'hhcprimarysales'
ALTER TABLE [dbo].[hhcprimarysales]
ADD CONSTRAINT [PK_hhcprimarysales]
    PRIMARY KEY CLUSTERED ([hhcprimarysalesID] ASC);
GO

-- Creating primary key on [hhcsecondarysalesID] in table 'hhcsecondarysales'
ALTER TABLE [dbo].[hhcsecondarysales]
ADD CONSTRAINT [PK_hhcsecondarysales]
    PRIMARY KEY CLUSTERED ([hhcsecondarysalesID] ASC);
GO

-- Creating primary key on [HproductslistdescriptionID] in table 'Hproductslistdescriptions'
ALTER TABLE [dbo].[Hproductslistdescriptions]
ADD CONSTRAINT [PK_Hproductslistdescriptions]
    PRIMARY KEY CLUSTERED ([HproductslistdescriptionID] ASC);
GO

-- Creating primary key on [HproductslistID] in table 'Hproductslists'
ALTER TABLE [dbo].[Hproductslists]
ADD CONSTRAINT [PK_Hproductslists]
    PRIMARY KEY CLUSTERED ([HproductslistID] ASC);
GO

-- Creating primary key on [HstockistdetailsID] in table 'Hstockistdetails'
ALTER TABLE [dbo].[Hstockistdetails]
ADD CONSTRAINT [PK_Hstockistdetails]
    PRIMARY KEY CLUSTERED ([HstockistdetailsID] ASC);
GO

-- Creating primary key on [hstockistuploadID] in table 'hstockistuploads'
ALTER TABLE [dbo].[hstockistuploads]
ADD CONSTRAINT [PK_hstockistuploads]
    PRIMARY KEY CLUSTERED ([hstockistuploadID] ASC);
GO

-- Creating primary key on [HtherapaticID] in table 'Htherapatics'
ALTER TABLE [dbo].[Htherapatics]
ADD CONSTRAINT [PK_Htherapatics]
    PRIMARY KEY CLUSTERED ([HtherapaticID] ASC);
GO

-- Creating primary key on [HvendordetailsID] in table 'Hvendordetails'
ALTER TABLE [dbo].[Hvendordetails]
ADD CONSTRAINT [PK_Hvendordetails]
    PRIMARY KEY CLUSTERED ([HvendordetailsID] ASC);
GO

-- Creating primary key on [HvproductslistID] in table 'Hvproductslists'
ALTER TABLE [dbo].[Hvproductslists]
ADD CONSTRAINT [PK_Hvproductslists]
    PRIMARY KEY CLUSTERED ([HvproductslistID] ASC);
GO

-- Creating primary key on [HvsalesID] in table 'Hvsales'
ALTER TABLE [dbo].[Hvsales]
ADD CONSTRAINT [PK_Hvsales]
    PRIMARY KEY CLUSTERED ([HvsalesID] ASC);
GO

-- Creating primary key on [OtherAdminId] in table 'OtherAdminLogins'
ALTER TABLE [dbo].[OtherAdminLogins]
ADD CONSTRAINT [PK_OtherAdminLogins]
    PRIMARY KEY CLUSTERED ([OtherAdminId] ASC);
GO

-- Creating primary key on [OtherAdminPermissionID] in table 'OtherAdminPermissions'
ALTER TABLE [dbo].[OtherAdminPermissions]
ADD CONSTRAINT [PK_OtherAdminPermissions]
    PRIMARY KEY CLUSTERED ([OtherAdminPermissionID] ASC);
GO

-- Creating primary key on [secondarysalesID] in table 'secondarysales'
ALTER TABLE [dbo].[secondarysales]
ADD CONSTRAINT [PK_secondarysales]
    PRIMARY KEY CLUSTERED ([secondarysalesID] ASC);
GO

-- Creating primary key on [StockistId] in table 'Stockists'
ALTER TABLE [dbo].[Stockists]
ADD CONSTRAINT [PK_Stockists]
    PRIMARY KEY CLUSTERED ([StockistId] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [UploadFileId] in table 'UploadFileNames'
ALTER TABLE [dbo].[UploadFileNames]
ADD CONSTRAINT [PK_UploadFileNames]
    PRIMARY KEY CLUSTERED ([UploadFileId] ASC);
GO

-- Creating primary key on [OtherAdminId] in table 'UserAdminLogins'
ALTER TABLE [dbo].[UserAdminLogins]
ADD CONSTRAINT [PK_UserAdminLogins]
    PRIMARY KEY CLUSTERED ([OtherAdminId] ASC);
GO

-- Creating primary key on [UserID] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [PK_USERS]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [UserID] in table 'Usershetroes'
ALTER TABLE [dbo].[Usershetroes]
ADD CONSTRAINT [PK_Usershetroes]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [SPECIALIZATIONID] in table 'VENDORSPECIALIZATIONs'
ALTER TABLE [dbo].[VENDORSPECIALIZATIONs]
ADD CONSTRAINT [PK_VENDORSPECIALIZATIONs]
    PRIMARY KEY CLUSTERED ([SPECIALIZATIONID] ASC);
GO

-- Creating primary key on [SPECIALIZATIONID] in table 'VENDORSPECIALIZATIONs1'
ALTER TABLE [dbo].[VENDORSPECIALIZATIONs1]
ADD CONSTRAINT [PK_VENDORSPECIALIZATIONs1]
    PRIMARY KEY CLUSTERED ([SPECIALIZATIONID] ASC);
GO

-- Creating primary key on [VENDORID] in table 'VENDORSUsers'
ALTER TABLE [dbo].[VENDORSUsers]
ADD CONSTRAINT [PK_VENDORSUsers]
    PRIMARY KEY CLUSTERED ([VENDORID] ASC);
GO

-- Creating primary key on [VENDORTYPEID] in table 'VENDORTYPES'
ALTER TABLE [dbo].[VENDORTYPES]
ADD CONSTRAINT [PK_VENDORTYPES]
    PRIMARY KEY CLUSTERED ([VENDORTYPEID] ASC);
GO

-- Creating primary key on [BSID] in table 'VENDORTYPESpecialisationsentries'
ALTER TABLE [dbo].[VENDORTYPESpecialisationsentries]
ADD CONSTRAINT [PK_VENDORTYPESpecialisationsentries]
    PRIMARY KEY CLUSTERED ([BSID] ASC);
GO

-- Creating primary key on [ZoneID] in table 'Zones'
ALTER TABLE [dbo].[Zones]
ADD CONSTRAINT [PK_Zones]
    PRIMARY KEY CLUSTERED ([ZoneID] ASC);
GO

-- Creating primary key on [hhcAdminLoginsId] in table 'hhcAdminLogins'
ALTER TABLE [dbo].[hhcAdminLogins]
ADD CONSTRAINT [PK_hhcAdminLogins]
    PRIMARY KEY CLUSTERED ([hhcAdminLoginsId] ASC);
GO

-- Creating primary key on [STATEID] in table 'STATEs'
ALTER TABLE [dbo].[STATEs]
ADD CONSTRAINT [PK_STATEs]
    PRIMARY KEY CLUSTERED ([STATEID] ASC);
GO

-- Creating primary key on [SubAreaID] in table 'SubAreas'
ALTER TABLE [dbo].[SubAreas]
ADD CONSTRAINT [PK_SubAreas]
    PRIMARY KEY CLUSTERED ([SubAreaID] ASC);
GO

-- Creating primary key on [Id] in table 'tbl_registration'
ALTER TABLE [dbo].[tbl_registration]
ADD CONSTRAINT [PK_tbl_registration]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UploadedFiles'
ALTER TABLE [dbo].[UploadedFiles]
ADD CONSTRAINT [PK_UploadedFiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Zone] in table 'STATEs'
ALTER TABLE [dbo].[STATEs]
ADD CONSTRAINT [FK_STATEs_Zones]
    FOREIGN KEY ([Zone])
    REFERENCES [dbo].[Zones]
        ([ZoneID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_STATEs_Zones'
CREATE INDEX [IX_FK_STATEs_Zones]
ON [dbo].[STATEs]
    ([Zone]);
GO

-- Creating foreign key on [STATEID] in table 'CITies'
ALTER TABLE [dbo].[CITies]
ADD CONSTRAINT [FK_CITies_STATEs]
    FOREIGN KEY ([STATEID])
    REFERENCES [dbo].[STATEs]
        ([STATEID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CITies_STATEs'
CREATE INDEX [IX_FK_CITies_STATEs]
ON [dbo].[CITies]
    ([STATEID]);
GO

-- Creating foreign key on [CITYID] in table 'SubAreas'
ALTER TABLE [dbo].[SubAreas]
ADD CONSTRAINT [FK_subareaCITies_CITies]
    FOREIGN KEY ([CITYID])
    REFERENCES [dbo].[CITies]
        ([CITYID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_subareaCITies_CITies'
CREATE INDEX [IX_FK_subareaCITies_CITies]
ON [dbo].[SubAreas]
    ([CITYID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------