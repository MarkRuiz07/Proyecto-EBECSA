--Creando procedimiento almacenamiento de ProyectoBD

use ProyectoBD

Create PROCEDURE Pr_Aseguradora
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

Create PROCEDURE Pr_Cobertura 
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

/*Create PROCEDURE Pr_Categoria
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
GO*/

Create PROCEDURE Pr_Prospecto
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


Create PROCEDURE Pr_Proveedor 
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

Create PROCEDURE Pr_seguros 
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

Create PROCEDURE Pr_Vehiculo 
@b int, @idVehiculo int,@marca varchar(30),@modelo varchar(50),@color varchar(20),@colorSecundario varchar(20),
@añoFabricacion int,@VersionCaracteristicas varchar(max),@NumeroPasajero int,@NumeroCirculacion varchar(30),@idProspecto int, @idseguros int
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Vehiculo VALUES (@marca,@modelo,@color,@colorSecundario,@añoFabricacion,@VersionCaracteristicas,@NumeroPasajero,@NumeroCirculacion,@idProspecto,@idseguros);
IF @b=2
DELETE FROM Vehiculo WHERE idVehiculo=@idVehiculo;
IF @b=3
SELECT * FROM Vehiculo
IF @b=4
UPDATE Vehiculo SET marca=@marca WHERE idVehiculo=@idVehiculo;
IF @b=5
SELECT * FROM Vehiculo
WHERE modelo LIKE '%' + @modelo + '%' OR
 NumeroCirculacion LIKE '%' + @NumeroCirculacion + '%'
END
GO