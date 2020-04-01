
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 22:55:28
-- Generated from EDMX file: C:\Users\carbu\source\repos\MyPhotos\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DataFileTag_DataFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DataFileTag] DROP CONSTRAINT [FK_DataFileTag_DataFile];
GO
IF OBJECT_ID(N'[dbo].[FK_DataFileTag_Tag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DataFileTag] DROP CONSTRAINT [FK_DataFileTag_Tag];
GO
IF OBJECT_ID(N'[dbo].[FK_DataFileAttribute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attributes] DROP CONSTRAINT [FK_DataFileAttribute];
GO
IF OBJECT_ID(N'[dbo].[FK_Photo_inherits_DataFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DataFiles_Photo] DROP CONSTRAINT [FK_Photo_inherits_DataFile];
GO
IF OBJECT_ID(N'[dbo].[FK_Video_inherits_DataFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DataFiles_Video] DROP CONSTRAINT [FK_Video_inherits_DataFile];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DataFiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataFiles];
GO
IF OBJECT_ID(N'[dbo].[Tags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tags];
GO
IF OBJECT_ID(N'[dbo].[Attributes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Attributes];
GO
IF OBJECT_ID(N'[dbo].[DataFiles_Photo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataFiles_Photo];
GO
IF OBJECT_ID(N'[dbo].[DataFiles_Video]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataFiles_Video];
GO
IF OBJECT_ID(N'[dbo].[DataFileTag]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataFileTag];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DataFiles'
CREATE TABLE [dbo].[DataFiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Deleted] bit  NULL,
    [Location] nvarchar(max)  NULL,
    [CreationDate] datetime  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Attributes'
CREATE TABLE [dbo].[Attributes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [DataFileId] int  NOT NULL
);
GO

-- Creating table 'DataFiles_Photo'
CREATE TABLE [dbo].[DataFiles_Photo] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'DataFiles_Video'
CREATE TABLE [dbo].[DataFiles_Video] (
    [Duration] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'DataFileTag'
CREATE TABLE [dbo].[DataFileTag] (
    [DataFiles_Id] int  NOT NULL,
    [Tags_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DataFiles'
ALTER TABLE [dbo].[DataFiles]
ADD CONSTRAINT [PK_DataFiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Attributes'
ALTER TABLE [dbo].[Attributes]
ADD CONSTRAINT [PK_Attributes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DataFiles_Photo'
ALTER TABLE [dbo].[DataFiles_Photo]
ADD CONSTRAINT [PK_DataFiles_Photo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DataFiles_Video'
ALTER TABLE [dbo].[DataFiles_Video]
ADD CONSTRAINT [PK_DataFiles_Video]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DataFiles_Id], [Tags_Id] in table 'DataFileTag'
ALTER TABLE [dbo].[DataFileTag]
ADD CONSTRAINT [PK_DataFileTag]
    PRIMARY KEY CLUSTERED ([DataFiles_Id], [Tags_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DataFiles_Id] in table 'DataFileTag'
ALTER TABLE [dbo].[DataFileTag]
ADD CONSTRAINT [FK_DataFileTag_DataFile]
    FOREIGN KEY ([DataFiles_Id])
    REFERENCES [dbo].[DataFiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tags_Id] in table 'DataFileTag'
ALTER TABLE [dbo].[DataFileTag]
ADD CONSTRAINT [FK_DataFileTag_Tag]
    FOREIGN KEY ([Tags_Id])
    REFERENCES [dbo].[Tags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DataFileTag_Tag'
CREATE INDEX [IX_FK_DataFileTag_Tag]
ON [dbo].[DataFileTag]
    ([Tags_Id]);
GO

-- Creating foreign key on [DataFileId] in table 'Attributes'
ALTER TABLE [dbo].[Attributes]
ADD CONSTRAINT [FK_DataFileAttribute]
    FOREIGN KEY ([DataFileId])
    REFERENCES [dbo].[DataFiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DataFileAttribute'
CREATE INDEX [IX_FK_DataFileAttribute]
ON [dbo].[Attributes]
    ([DataFileId]);
GO

-- Creating foreign key on [Id] in table 'DataFiles_Photo'
ALTER TABLE [dbo].[DataFiles_Photo]
ADD CONSTRAINT [FK_Photo_inherits_DataFile]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[DataFiles]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'DataFiles_Video'
ALTER TABLE [dbo].[DataFiles_Video]
ADD CONSTRAINT [FK_Video_inherits_DataFile]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[DataFiles]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------