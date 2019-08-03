--Creando procedimiento almacenamiento de ProyectoBD

use ProyectoBD

CREATE PROCEDURE Pr_Aseguradora
@b int,@idAseguradora int, @nombreAs varchar(50),@idseguros int, @idProveedor int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Aseguradora VALUES (@nombreas,@idseguros,@idProveedor);
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

CREATE PROCEDURE Pr_Cobertura 
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

CREATE PROCEDURE Pr_Categoria
@b int, @idcategoria int, @tipo varchar(20)
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Categoria VALUES(@tipo);
IF @b=2
DELETE FROM Categoria WHERE idcategoria=@idcategoria;
IF @b=3
SELECT * FROM Categoria
IF @b=4
UPDATE Categoria SET tipo=@tipo WHERE idcategoria=@idcategoria;
IF @b=5
SELECT * FROM Categoria
WHERE tipo=@tipo
END
GO

CREATE PROCEDURE Pr_Prospecto
@b int, @idProspecto int,@cedula varchar (14),@nombres varchar (50),@apellidospaterno varchar(50),@apellidosmaterno varchar(50),
@correoelectronico varchar(80),@TelefonoP varchar(10)
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Prospecto VALUES (@cedula,@nombres,@apellidospaterno,@apellidosmaterno,@correoelectronico,@TelefonoP);
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


CREATE PROCEDURE Pr_Proveedor 
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

CREATE PROCEDURE Pr_seguros 
@b int, @idseguros int ,@MontoSeguro int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Seguros VALUES (@MontoSeguro);
IF @b=2
DELETE FROM Seguros WHERE idseguros=@idseguros;
IF @b=3
SELECT * FROM Seguros
IF @b=4
UPDATE Seguros SET MontoSeguro=@MontoSeguro WHERE idseguros=@idseguros;
IF @b=5
SELECT * FROM Seguros
WHERE MontoSeguro=@MontoSeguro
END
GO

CREATE PROCEDURE Pr_Vehiculo 
@b int, @idVehiculo int,@marca varchar(30),@modelo varchar(50),@color varchar(20),@colorsecundario varchar(20),
@añofabricacion int,@version varchar(max),@numeropasajero int,@numerocirculacion int,@idProspecto int, @idseguros int, @idcategoria int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Vehiculo VALUES (@marca,@modelo,@color,@colorsecundario,@añofabricacion,@version,@numeropasajero,@numerocirculacion,@idProspecto,@idseguros,@idvehiculo);
IF @b=2
DELETE FROM Vehiculo WHERE idVehiculo=@idVehiculo;
IF @b=3
SELECT * FROM Vehiculo
IF @b=4
UPDATE Vehiculo SET marca=@marca WHERE idVehiculo=@idVehiculo;
IF @b=5
SELECT * FROM Vehiculo
WHERE modelo LIKE '%' + @modelo + '%' OR
 numerocirculacion LIKE '%' + @numerocirculacion + '%'
END
GO