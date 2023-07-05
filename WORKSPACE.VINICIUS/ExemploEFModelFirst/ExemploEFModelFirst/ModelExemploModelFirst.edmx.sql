
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/18/2017 10:23:56
-- Generated from EDMX file: C:\Nova pasta\TREINAMENTO T.201702.1\WORKSPACE.VINICIUS\ExemploEFModelFirst\ExemploEFModelFirst\ModelExemploModelFirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EXEMPLO_MODELFIRST];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [DataNascimento] datetime  NULL,
    [RG] nvarchar(20)  NULL
);
GO

-- Creating table 'Estado'
CREATE TABLE [dbo].[Estado] (
    [IdEstado] int IDENTITY(1,1) NOT NULL,
    [Sigla] nvarchar(2)  NOT NULL,
    [Descricao] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Municipio'
CREATE TABLE [dbo].[Municipio] (
    [IdMunicipio] int IDENTITY(1,1) NOT NULL,
    [CodIBGE] nvarchar(7)  NOT NULL,
    [Descricao] nvarchar(100)  NOT NULL,
    [IdEstado] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdUsuario] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdEstado] in table 'Estado'
ALTER TABLE [dbo].[Estado]
ADD CONSTRAINT [PK_Estado]
    PRIMARY KEY CLUSTERED ([IdEstado] ASC);
GO

-- Creating primary key on [IdMunicipio] in table 'Municipio'
ALTER TABLE [dbo].[Municipio]
ADD CONSTRAINT [PK_Municipio]
    PRIMARY KEY CLUSTERED ([IdMunicipio] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEstado] in table 'Municipio'
ALTER TABLE [dbo].[Municipio]
ADD CONSTRAINT [FK_EstadoMunicipio]
    FOREIGN KEY ([IdEstado])
    REFERENCES [dbo].[Estado]
        ([IdEstado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoMunicipio'
CREATE INDEX [IX_FK_EstadoMunicipio]
ON [dbo].[Municipio]
    ([IdEstado]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------