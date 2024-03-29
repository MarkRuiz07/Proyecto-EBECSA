USE [ProyectoBD]
GO
/****** Object:  StoredProcedure [dbo].[Pr_Prospecto]    Script Date: 28/7/2019 10:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Pr_Prospecto]
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
