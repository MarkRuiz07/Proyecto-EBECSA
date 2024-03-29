USE [master]
GO
/****** Object:  Database [ProyectoBD]    Script Date: 21/8/2019 13:48:29 ******/
CREATE DATABASE [ProyectoBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoBD', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ProyectoBD.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProyectoBD_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ProyectoBD_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProyectoBD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoBD] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProyectoBD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoBD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectoBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoBD] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ProyectoBD]
GO
/****** Object:  StoredProcedure [dbo].[obtenerMontoSeguro]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtenerMontoSeguro] 
	@idseguros int 
AS
BEGIN
	
	SET NOCOUNT ON;
    SELECT MontoSeguro
    from Seguros 
    where idseguros = @idseguros
END

GO
/****** Object:  StoredProcedure [dbo].[Pr_Aseguradora]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Pr_Aseguradora]
@b int,@idAseguradora int, @nombreAs varchar(50),@idseguros int, @idProveedor int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Aseguradora VALUES (@nombreAs,@idseguros,@idProveedor);
IF @b=2
DELETE FROM Aseguradora WHERE idAseguradora=@idAseguradora;
IF @b=3
SELECT * FROM Aseguradora
IF @b=4
UPDATE Aseguradora SET nombreAs=@nombreAs WHERE idAseguradora=@idAseguradora;
IF @b=5
SELECT * FROM Aseguradora
WHERE nombreAs=@nombreas
END

GO
/****** Object:  StoredProcedure [dbo].[Pr_Cobertura]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Pr_Cobertura] 
@b int, @idcobertura int,@descripcion varchar(max),@sumaAsegurada smallmoney,@idseguros int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Cobertura VALUES (@descripcion,@sumaAsegurada,@idseguros);
IF @b=2
DELETE FROM Cobertura WHERE idcobertura=@idcobertura;
IF @b=3
SELECT * FROM Cobertura
IF @b=4
UPDATE Cobertura SET sumaAsegurada=@sumaAsegurada WHERE idcobertura=@idcobertura;
IF @b=5
SELECT * FROM Cobertura
WHERE sumaAsegurada=@sumaAsegurada
END

GO
/****** Object:  StoredProcedure [dbo].[Pr_detalles]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pr_detalles]
AS
BEGIN
	
	select p.nombres,p.cedula,s.tipo,v.modelo,v.NumeroCirculacion, s.MontoSeguro,co.sumaAsegurada,co.descripcion
    from Vehiculo as v join Seguros as s 
	on v.idVehiculo = s.idseguros inner join Prospecto as p
	 on  v.idProspecto=p.idProspecto inner join Cobertura as co
	  on co.idcobertura=s.idseguros
END

GO
/****** Object:  StoredProcedure [dbo].[Pr_Prospecto]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Pr_Prospecto]
@b int, @idProspecto int,@cedula varchar (14),@nombres varchar (50),@apellidoPaterno varchar(50),@apellidoMaterno varchar(50),
@correoElectronico varchar(80),@TelefonP varchar(10)
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Prospecto VALUES (@cedula,@nombres,@apellidoPaterno,@apellidoMaterno,@correoElectronico,@TelefonP);
IF @b=2
DELETE FROM Prospecto WHERE idProspecto=@idProspecto;
IF @b=3
SELECT * FROM Prospecto
IF @b=4
UPDATE Prospecto SET nombres=@nombres WHERE idProspecto=@idProspecto;
IF @b=5
SELECT * FROM Prospecto 
WHERE nombres LIKE '%' + @nombres + '%' OR
 cedula LIKE '%' + @cedula+ '%'
END

GO
/****** Object:  StoredProcedure [dbo].[Pr_Proveedor]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Pr_Proveedor] 
@b int, @idProveedor int,@nombreprov varchar(30),@email varchar (50),@telefonoprov int,@cargo varchar (20)
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Proveedor VALUES (@nombreprov,@email,@telefonoprov,@cargo);
IF @b=2
DELETE FROM Proveedor WHERE idProveedor=@idProveedor;
IF @b=3
SELECT * FROM Proveedor
IF @b=4
UPDATE Proveedor SET telefonoprov=@telefonoprov WHERE idProveedor=@idProveedor;
IF @b=5
SELECT * FROM Proveedor
WHERE nombreprov=@nombreprov
END

GO
/****** Object:  StoredProcedure [dbo].[Pr_seguros]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Pr_seguros] 
@b int, @idseguros int ,@tipo varchar(50),@MontoSeguro int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Seguros VALUES (@tipo,@MontoSeguro);
IF @b=2
DELETE FROM Seguros WHERE idseguros=@idseguros;
IF @b=3
SELECT * FROM Seguros
IF @b=4
UPDATE Seguros SET MontoSeguro=@MontoSeguro WHERE idseguros=@idseguros;
IF @b=5
SELECT * FROM Seguros
WHERE MontoSeguro LIKE '%' + @MontoSeguro + '%' OR
tipo LIKE '%' + @tipo + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[Pr_Vehiculo]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pr_Vehiculo] 
	@b int,
	@idVehiculo int,
	@marca varchar(30),
	@modelo varchar(50),
	@color varchar(20),
	@colorSecundario varchar(20),
	@añoFabricacion int,
	@VersionCaracteristicas varchar(max),
	@NumeroPasajeros int,
	@NumeroCirculacion varchar(30),
	@idProspecto int,
	@idseguros int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
	INSERT INTO Vehiculo VALUES (@marca,@modelo,@color,@colorSecundario,@añoFabricacion,@VersionCaracteristicas,@NumeroPasajeros,@NumeroCirculacion,@idProspecto,@idseguros);
IF @b=2
	DELETE FROM Vehiculo WHERE idVehiculo=@idVehiculo;
IF @b=3
	SELECT * FROM Vehiculo
IF @b=4
	UPDATE Vehiculo SET marca=@marca WHERE idVehiculo=@idVehiculo;
IF @b=5
	SELECT * FROM
		Vehiculo
	WHERE
		modelo LIKE '%' + @modelo + '%'
	OR
		NumeroCirculacion LIKE '%' + @NumeroCirculacion + '%'
END

GO
/****** Object:  Table [dbo].[Aseguradora]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aseguradora](
	[idAseguradora] [int] IDENTITY(1,1) NOT NULL,
	[nombreAs] [varchar](50) NULL,
	[idseguros] [int] NULL,
	[idProveedor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idAseguradora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cobertura]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cobertura](
	[idcobertura] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](max) NULL,
	[sumaAsegurada] [smallmoney] NULL,
	[idseguros] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idcobertura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prospecto]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prospecto](
	[idProspecto] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](14) NULL,
	[nombres] [varchar](50) NULL,
	[apellidoPaterno] [varchar](50) NULL,
	[apellidoMaterno] [varchar](50) NULL,
	[correoElectronico] [varchar](80) NULL,
	[TelefonP] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProspecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Prospecto_Cedula] UNIQUE NONCLUSTERED 
(
	[cedula] ASC,
	[correoElectronico] ASC,
	[TelefonP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombreprov] [varchar](30) NULL,
	[email] [varchar](50) NULL,
	[telefonoprov] [int] NULL,
	[cargo] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Seguros]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seguros](
	[idseguros] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NULL,
	[MontoSeguro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idseguros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 21/8/2019 13:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[idVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](30) NULL,
	[modelo] [varchar](50) NULL,
	[color] [varchar](20) NULL,
	[colorSecundario] [varchar](20) NULL,
	[añoFabricacion] [int] NULL,
	[VersionCaracteristicas] [varchar](max) NULL,
	[NumeroPasajeros] [int] NULL,
	[NumeroCirculacion] [varchar](30) NULL,
	[idProspecto] [int] NULL,
	[idseguros] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [NumeroCirculacion_modelo] UNIQUE NONCLUSTERED 
(
	[NumeroCirculacion] ASC,
	[modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Aseguradora]  WITH CHECK ADD FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Aseguradora]  WITH CHECK ADD FOREIGN KEY([idseguros])
REFERENCES [dbo].[Seguros] ([idseguros])
GO
ALTER TABLE [dbo].[Cobertura]  WITH CHECK ADD FOREIGN KEY([idseguros])
REFERENCES [dbo].[Seguros] ([idseguros])
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD FOREIGN KEY([idProspecto])
REFERENCES [dbo].[Prospecto] ([idProspecto])
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD FOREIGN KEY([idseguros])
REFERENCES [dbo].[Seguros] ([idseguros])
GO
USE [master]
GO
ALTER DATABASE [ProyectoBD] SET  READ_WRITE 
GO
