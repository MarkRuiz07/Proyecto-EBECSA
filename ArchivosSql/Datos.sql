use ProyectoBD

--datos TABLA aseguradora

SET IDENTITY_INSERT Aseguradora off
go

INSERT INTO Aseguradora (nombreAs)
VALUES 
 ( 'INISER'),
  ('AMERICA'),
  ('LAFISE'),
  ('ASSA')


---datos TABLA cobertura

INSERT INTO Cobertura(descripcion,sumaAsegurada)
VALUES
 ('Muerte o Lesiones Corporales a una Persona',2500),
 ('Muerte o Lesiones Corporales a Dos o más Personas',2500 ),
 ('Daños Materiales Causados a Terceros en sus Bienes',2500)

--datos Tabla Categoria

 insert into Categoria (tipo)
 values
        ('Vehiculo Particular'),
        ('Moto'),
        ('Camion Liviano menor a 3 Toneladas'),
		('Camion Mayor a 3.5 Toneladas'),
		('Cabezal')

	select * from Categoria

--datos Tablas Seguros

insert into Seguros(MontoSeguro)
values
      (35),
      (55),
	  (80),
	  (150)

insert into Proveedor(nombreprov,cargo,telefonoprov,email)
values 
       ('Rixi Moreno Alvarez','Gerente',57225796,'Riximoreno@gmail.com')