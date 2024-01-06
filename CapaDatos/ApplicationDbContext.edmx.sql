
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/26/2023 10:34:23
-- Generated from EDMX file: C:\Users\tig9\source\repos\TP Integrados Programacion\CapaDatos\ApplicationDbContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TPIntegrador_Programacion_Enzo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Administrativo_inherits_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas_Administrativo] DROP CONSTRAINT [FK_Administrativo_inherits_Persona];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleado_inherits_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas_Empleado] DROP CONSTRAINT [FK_Empleado_inherits_Persona];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Peliculas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Peliculas];
GO
IF OBJECT_ID(N'[dbo].[Personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas];
GO
IF OBJECT_ID(N'[dbo].[Personas_Administrativo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas_Administrativo];
GO
IF OBJECT_ID(N'[dbo].[Personas_Empleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas_Empleado];
GO
IF OBJECT_ID(N'[dbo].[Sucursales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sucursales];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Cuil] nvarchar(max)  NOT NULL,
    [Edad] nvarchar(max)  NOT NULL,
    [HorarioTrabajo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Sucursales'
CREATE TABLE [dbo].[Sucursales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Horarios] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Peliculas'
CREATE TABLE [dbo].[Peliculas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Duracion] nvarchar(max)  NOT NULL,
    [Genero] nvarchar(max)  NOT NULL,
    [Idioma] nvarchar(max)  NOT NULL,
    [Subtitulos] nvarchar(max)  NOT NULL,
    [Ideoma] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Personas_Administrativo'
CREATE TABLE [dbo].[Personas_Administrativo] (
    [Sector] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Personas_Empleado'
CREATE TABLE [dbo].[Personas_Empleado] (
    [SecursalAsignada] nvarchar(max)  NOT NULL,
    [AdministradorAsignado] nvarchar(max)  NOT NULL,
    [NroCaja] nvarchar(max)  NOT NULL,
    [BoletosVendidos] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sucursales'
ALTER TABLE [dbo].[Sucursales]
ADD CONSTRAINT [PK_Sucursales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Peliculas'
ALTER TABLE [dbo].[Peliculas]
ADD CONSTRAINT [PK_Peliculas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas_Administrativo'
ALTER TABLE [dbo].[Personas_Administrativo]
ADD CONSTRAINT [PK_Personas_Administrativo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [PK_Personas_Empleado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'Personas_Administrativo'
ALTER TABLE [dbo].[Personas_Administrativo]
ADD CONSTRAINT [FK_Administrativo_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [FK_Empleado_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------