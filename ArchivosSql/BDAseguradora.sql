CREATE DATABASE ProyectoBD
go

use ProyectoBD

Create table Prospecto(
idProspecto int primary key identity (1,1),
cedula varchar (14),
nombres varchar (50),
apellidoPaterno varchar (50),
apellidoMaterno varchar (50),
correoElectronico varchar (80),
TelefonP varchar (10),
CONSTRAINT Prospecto_Cedula UNIQUE (cedula,correoElectronico,TelefonP),
);

Create Table Seguros(
idseguros int Primary Key identity (1,1),
MontoSeguro int,
);

Create table Categoria(
idcategoria int primary key identity(1,1),
tipo varchar(50),
);

Create table Vehiculo(
idVehiculo int primary key identity (1,1),
marca varchar(30),
modelo varchar (50),
color varchar (20),
colorSecundario Varchar (20),
añoFabricacion int,
VersionCaracteristicas varchar(max),
NumeroPasajeros int,
NumeroCirculacion varchar(30),
idProspecto int,
idseguros int,
idcategoria int,
CONSTRAINT NumeroCirculacion_modelo UNIQUE (NumeroCirculacion,modelo),
foreign key (idProspecto) references Prospecto (idProspecto),
foreign key (idseguros) references Seguros (idseguros),
foreign key (idcategoria) references Categoria (idcategoria),
);

Create Table Cobertura(
idcobertura int primary key identity(1,1),
descripcion varchar(max),
sumaAsegurada smallmoney,
idseguros int,
foreign key (idseguros) references Seguros (idseguros),
);

Create Table Proveedor(
idProveedor int primary key identity (1,1),
nombreprov varchar(30),
email varchar(50),
telefonoprov int,
cargo varchar(20),
);


Create Table Aseguradora(
idAseguradora int primary key identity (1,1),
nombreAs Varchar (50),
idseguros int,
idProveedor int,
foreign key (idseguros) references Seguros (idseguros),
foreign key (idProveedor) references Proveedor (idProveedor),
);








