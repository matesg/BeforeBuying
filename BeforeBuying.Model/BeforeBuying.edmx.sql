
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/10/2020 10:00:25
-- Generated from EDMX file: C:\Projects\CSharp\BeforeBuying\BeforeBuying.Model\BeforeBuying.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BeforeBuying];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ItemPrice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceSet] DROP CONSTRAINT [FK_ItemPrice];
GO
IF OBJECT_ID(N'[dbo].[FK_ShopPrice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceSet] DROP CONSTRAINT [FK_ShopPrice];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ItemSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemSet];
GO
IF OBJECT_ID(N'[dbo].[ShopSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ShopSet];
GO
IF OBJECT_ID(N'[dbo].[PriceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PriceSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ItemSet'
CREATE TABLE [dbo].[ItemSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [EAN] nvarchar(max)  NOT NULL,
    [UnitOfMeasure] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ShopSet'
CREATE TABLE [dbo].[ShopSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PriceSet'
CREATE TABLE [dbo].[PriceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PriceInclVAT] decimal(18,0)  NOT NULL,
    [ItemId] int  NOT NULL,
    [ShopId] int  NOT NULL,
    [PricePerUnit] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'DiscountSet'
CREATE TABLE [dbo].[DiscountSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DiscountFrom] datetime  NOT NULL,
    [DiscountTo] datetime  NOT NULL,
    [Percent] smallint  NOT NULL,
    [PriceInclVAT] decimal(18,0)  NOT NULL,
    [PriceId] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ItemSet'
ALTER TABLE [dbo].[ItemSet]
ADD CONSTRAINT [PK_ItemSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ShopSet'
ALTER TABLE [dbo].[ShopSet]
ADD CONSTRAINT [PK_ShopSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [PK_PriceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiscountSet'
ALTER TABLE [dbo].[DiscountSet]
ADD CONSTRAINT [PK_DiscountSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ItemId] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [FK_ItemPrice]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[ItemSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemPrice'
CREATE INDEX [IX_FK_ItemPrice]
ON [dbo].[PriceSet]
    ([ItemId]);
GO

-- Creating foreign key on [ShopId] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [FK_ShopPrice]
    FOREIGN KEY ([ShopId])
    REFERENCES [dbo].[ShopSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ShopPrice'
CREATE INDEX [IX_FK_ShopPrice]
ON [dbo].[PriceSet]
    ([ShopId]);
GO

-- Creating foreign key on [PriceId] in table 'DiscountSet'
ALTER TABLE [dbo].[DiscountSet]
ADD CONSTRAINT [FK_PriceDiscount]
    FOREIGN KEY ([PriceId])
    REFERENCES [dbo].[PriceSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PriceDiscount'
CREATE INDEX [IX_FK_PriceDiscount]
ON [dbo].[DiscountSet]
    ([PriceId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------