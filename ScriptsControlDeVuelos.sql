CREATE DATABASE DB_ControlDeVuelos
GO
USE DB_ControlDeVuelos

--DDL
GO

CREATE TABLE Tbl_Identificacion(
	ID_Identificacion INT CONSTRAINT [PK_Identificacion]PRIMARY KEY IDENTITY,
	Tipo VARCHAR(40) NOT NULL,
	Datos VARCHAR(100) NOT NULL
);
GO 
CREATE TABLE Tbl_Persona(
	ID_Persona INT CONSTRAINT [PK_Persona] PRIMARY KEY IDENTITY,
	ID_Identificacion INT FOREIGN KEY REFERENCES TBL_Identificacion(ID_Identificacion),
	Nombre VARCHAR(40) NOT NULL,
	Apellido VARCHAR(40) NOT NULL,
	Telefono CHAR(10) NOT NULL,
	FechaRegistro DATETIME NOT NULL CONSTRAINT [DF_FechaRegistroPersona] DEFAULT GETDATE()
);
GO
CREATE TABLE Tbl_Rol(
	ID_Rol INT CONSTRAINT [PK_Rol] PRIMARY KEY IDENTITY,
	Tipo VARCHAR(70) NOT NULL,
	FechaRegistro DATETIME NOT NULL CONSTRAINT [DF_FechaRegistroRol] DEFAULT GETDATE()
);
GO 
CREATE TABLE Tbl_Pais(
	ID_Pais INT CONSTRAINT [PK_Pais] PRIMARY KEY IDENTITY,
	Nombre VARCHAR(40) NOT NULL
);
GO
CREATE TABLE Tbl_Estado(
	ID_Estado INT CONSTRAINT [PK_Estado] PRIMARY KEY IDENTITY,
	ID_Pais INT FOREIGN KEY REFERENCES Tbl_Pais(ID_Pais),
	Nombre VARCHAR(100) NOT NULL
);
GO
CREATE TABLE Tbl_Ciudad(
	ID_Ciudad INT CONSTRAINT [PK_Ciudad] PRIMARY KEY IDENTITY,
	ID_Estado INT FOREIGN KEY REFERENCES Tbl_Estado(ID_Estado),
	Nombre VARCHAR(100) NOT NULL
);
GO
CREATE TABLE Tbl_Aeropuerto(
	ID_Aeropuerto INT CONSTRAINT [PK_Aeropuerto] PRIMARY KEY IDENTITY,
	ID_Ciudad INT FOREIGN KEY REFERENCES Tbl_Ciudad(ID_Ciudad),
	Nombre VARCHAR(100) NOT NULL,
	Estado BIT NOT NULL,
	FechaRegistro DATETIME NOT NULL CONSTRAINT [DF_FechaRegistroAeropuerto] DEFAULT GETDATE()
);
GO
CREATE TABLE Tbl_Aerolinea(
	ID_Aerolinea INT CONSTRAINT [PK_Aerolinea] PRIMARY KEY IDENTITY,
	ID_Pais INT FOREIGN KEY REFERENCES Tbl_Pais(ID_Pais),
	Nombre VARCHAR(40) NOT NULL,
	FechaRegistro DATETIME NOT NULL CONSTRAINT [DF_FechaRegistroAerolinea] DEFAULT GETDATE()
);
GO
CREATE TABLE Tbl_Aerolinea_Aeropuerto(
	ID_AerolineaAeropuerto INT CONSTRAINT [PK_Aerolinea_Aeropuerto] PRIMARY KEY IDENTITY,
	ID_Aerolinea INT FOREIGN KEY REFERENCES Tbl_Aerolinea(ID_Aerolinea),
	ID_Aeropuerto INT FOREIGN KEY REFERENCES Tbl_Aeropuerto(ID_Aeropuerto)
);
GO
CREATE TABLE Tbl_Avion(
	ID_Avion INT CONSTRAINT [PK_Avion] PRIMARY KEY IDENTITY,
	Familia VARCHAR(40) NOT NULL,
	Serie VARCHAR(20) NOT NULL,
	FechaRegistro DATETIME CONSTRAINT [DF_FechaRegistroAvion] DEFAULT GETDATE()
);
GO
CREATE TABLE Tbl_Aerolinea_Avion(
	ID_Aerolinea_Avion INT PRIMARY KEY IDENTITY,
	ID_Aerolinea INT FOREIGN KEY REFERENCES Tbl_Aerolinea(ID_Aerolinea),
	ID_Avion INT FOREIGN KEY REFERENCES Tbl_Avion(ID_Avion),
	
);
GO
CREATE TABLE Tbl_Vuelo(
	ID_Vuelo INT CONSTRAINT [PK_Vuelo] PRIMARY KEY IDENTITY,
	Codigo VARCHAR(100) NOT NULL,
	ID_Avion INT FOREIGN KEY REFERENCES Tbl_Avion(ID_Avion),
	ID_Aerolinea INT FOREIGN KEY REFERENCES Tbl_Aerolinea(ID_Aerolinea),
	ID_AeropuertoSalida INT FOREIGN KEY REFERENCES Tbl_Aeropuerto(ID_Aeropuerto),
	ID_AeropuertoLlegada INT FOREIGN KEY REFERENCES Tbl_Aeropuerto(ID_Aeropuerto),
	FechaSalida DATETIME NOT NULL,
	FechaLlegada DATETIME NOT NULL,
	Estado BIT NOT NULL
);
GO
CREATE TABLE Tbl_Personal(
	ID_Personal INT CONSTRAINT [PK_Personal] PRIMARY KEY IDENTITY,
	ID_Persona INT FOREIGN KEY REFERENCES Tbl_Persona(ID_Persona),
	ID_Rol INT FOREIGN KEY REFERENCES Tbl_Rol(ID_Rol),
	ID_Aerolinea INT FOREIGN KEY REFERENCES Tbl_Aerolinea(ID_Aerolinea),
	Estado BIT NOT NULL
);
GO
CREATE TABLE Tbl_LogPersonal(
	ID_LogPersonal INT CONSTRAINT [PK_LogPersonal] PRIMARY KEY IDENTITY,
	ID_Personal INT FOREIGN KEY REFERENCES Tbl_Personal(ID_Personal),
	UsuarioCreador VARCHAR(100),
	Estado BIT NOT NULL,
	FechaDeEntrada DATETIME NOT NULL,
	FechaDeSalida DATETIME NULL
);
GO
CREATE TABLE Tbl_Personal_Vuelo(
	ID_Personal_Vuelo INT CONSTRAINT [PK_Personal_Vuelo] PRIMARY KEY IDENTITY,
	ID_Personal INT FOREIGN KEY REFERENCES Tbl_Personal(ID_Personal),
	ID_Vuelo INT FOREIGN KEY REFERENCES Tbl_Vuelo(ID_Vuelo)
);
GO
DROP TABLE Tbl_Personal_Vuelo
DROP TABLE Tbl_LogPersonal
DROP TABLE Tbl_Personal
DROP TABLE Tbl_Vuelo
DROP TABLE Tbl_Aerolinea_Avion
DROP TABLE Tbl_Avion
DROP TABLE Tbl_Aerolinea_Aeropuerto
DROP TABLE Tbl_Aerolinea
DROP TABLE Tbl_Aeropuerto
DROP TABLE Tbl_Ciudad
DROP TABLE Tbl_Estado
DROP TABLE Tbl_Pais
DROP TABLE Tbl_Rol
DROP TABLE Tbl_Persona
DROP TABLE Tbl_Identificacion
GO
TRUNCATE TABLE Tbl_Personal
TRUNCATE TABLE Tbl_Aerolinea_Aeropuerto
TRUNCATE TABLE Tbl_Pais
GO

--DML

--Procedures:

--Insertar un registro en la tabla identificacion
CREATE PROCEDURE dbo.STP_Identificacion_INS
	@varTipo VARCHAR(40),
	@varDatos VARCHAR(100)

	AS 

	INSERT INTO Tbl_Identificacion(Tipo, Datos) VALUES (@varTipo, @varDatos)
GO
EXEC dbo.STP_Identificacion_INS 'cedula', 'asdfasdf'

GO

--Insertar un registro en la tabla persona
CREATE PROCEDURE dbo.STP_Persona_INS
	@varId_Identificacion INT,
	@varNombre VARCHAR(40),
	@varApellido VARCHAR(40),
	@varTelefono CHAR(10)

	AS
	
	INSERT INTO Tbl_Persona(ID_Identificacion, Nombre, Apellido, Telefono) VALUES ('1','Emil','Payano', '0123456789')
GO
EXEC dbo.STP_Persona_INS 1,'Emil','Payano', '0123456789'

GO

--Insertar un registro en la tabla rol
CREATE PROCEDURE dbo.STP_Rol_INS
	@varTipo VARCHAR(40)

	AS 

	INSERT INTO Tbl_Rol(Tipo) VALUES (@varTipo)
GO
EXEC dbo.STP_Rol_INS 'Piloto'

GO
--Insertar un registro en la tabla Pais
ALTER PROCEDURE dbo.STP_Pais_INS
	@Nombre VARCHAR(40)

	AS 

	INSERT INTO Tbl_Pais(Nombre) VALUES (@Nombre)
GO
EXEC DBO.STP_Pais_INS 'Estados Unidos'
EXEC DBO.STP_Pais_INS 'Brazil'
GO
--Insertar un registro en la tabla estado
CREATE PROCEDURE dbo.STP_Estado_INS
	@varIDPais INT,
	@varNombre VARCHAR(100)

	AS

	INSERT INTO Tbl_Estado(ID_Pais,Nombre) VALUES (@varIDPais,@varNombre)
GO
EXEC dbo.STP_Estado_INS 1, 'New Jersey'
EXEC dbo.STP_Estado_INS 2, 'Rio de Janeiro'
GO

--Insertar un registro en la tabla ciudad
CREATE PROCEDURE dbo.STP_Ciudad_INS
	@varIDEstado INT,
	@varNombre VARCHAR(100)

	AS 

	INSERT INTO Tbl_Ciudad(ID_Estado, Nombre) VALUES (@varIDEstado, @varNombre)
GO
EXEC dbo.STP_Ciudad_INS 1, 'Newark y Elizabeth'
EXEC DBO.STP_Ciudad_INS 2, 'Rio de Janeiro'
GO
--Insertar un registro en la tabla Aeropuerto
CREATE PROCEDURE dbo.STP_Aeropuerto_INS
	@varIDCiudad INT,
	@varNombre VARCHAR(100),
	@varEstado BIT

	AS 

	INSERT INTO Tbl_Aeropuerto(ID_Ciudad, Nombre, Estado) VALUES (@varIDCiudad, @varNombre, @varEstado)
GO
EXEC dbo.STP_Aeropuerto_INS 1,'Aeropuerto Internacional Libertad de Newark', 1
EXEC dbo.STP_Aeropuerto_INS 2, 'Aeropuerto Internacional Antônio Carlos Jobim', 2
GO
--Insertar un registro en la tabla Aerolinea
CREATE PROCEDURE dbo.STP_Aerolinea_INS
	@varNombre VARCHAR(40),
	@varIDPais INT

	AS 

	INSERT INTO Tbl_Aerolinea(Nombre, ID_Pais) VALUES (@varNombre, @varIDPais)
GO
EXEC dbo.STP_Aerolinea_INS 'United Airlines', 1
EXEC dbo.STP_Aerolinea_INS 'Jetblue', 2
GO

--Insertar un registro en la tabla Aerolinea_Aeropuerto
CREATE PROCEDURE dbo.STP_Aerolinea_Aeropuerto_INS
	@varIDAerolina INT,
	@varIDAeropuerto INT

	AS

	INSERT INTO Tbl_Aerolinea_Aeropuerto(ID_Aerolinea, ID_Aeropuerto) VALUES (@varIDAerolina,@varIDAeropuerto)
GO
EXEC dbo.STP_Aerolinea_Aeropuerto_INS 1,1
EXEC dbo.STP_Aerolinea_Aeropuerto_INS 2,2
GO
--Insertar un registro en la tabla Avion
CREATE PROCEDURE dbo.STP_Avion_INS
	@varFamilia VARCHAR(40),
	@varSerie VARCHAR(20)

	AS
	
	INSERT INTO Tbl_Avion(Familia,Serie) VALUES (@varFamilia, @varSerie)
GO
EXEC dbo.STP_Avion_INS 'BOEING', '747-8'
EXEC dbo.STP_Avion_INS 'Airbus', 'A320'
GO
--Inserta un registro en la tabla Aerolina_Avion
CREATE PROCEDURE dbo_STP_Aerolinea_Avion_INS
	@varIDAvion INT,
	@varIDAerolinea INT

	AS

	INSERT INTO Tbl_Aerolinea_Avion (ID_Aerolinea, ID_Avion) VALUES (@varIDAvion,@varIDAerolinea)
GO
EXEC dbo.dbo_STP_Aerolinea_Avion_INS 1,1
EXEC dbo.dbo_STP_Aerolinea_Avion_INS 2,2
GO
--Insertar un registro en la tabla vuelo
CREATE PROCEDURE dbo.STP_Vuelo_INS
	@varCodigo VARCHAR(100),
	@varID_Avion INT,
	@varID_Aerolinea INT,
	@varIDAeropuertoSalida INT,
	@varIDAeropuertoLlegada INT,
	@FechaSalida DATETIME,
	@FechaLlegada DATETIME,
	@Estado BIT

	AS

	INSERT INTO Tbl_Vuelo(Codigo, ID_Avion,ID_Aerolinea, ID_AeropuertoSalida, ID_AeropuertoLlegada, FechaSalida, FechaLlegada, Estado) VALUES (@varCodigo, @varID_Avion, @varID_Aerolinea, @varIDAeropuertoSalida, @varIDAeropuertoLlegada, @FechaSalida, @FechaLlegada, @Estado)
GO
EXEC dbo.STP_Vuelo_INS 'AILN-1',1,1,1,1,'4/7/2021','4/8/2021',1
EXEC dbo.STP_Vuelo_INS 'BA2490',2,2,2,2,'4/10/2021','4/11/2021',2
GO

--Insertar un registro en la tabla personal
ALTER PROCEDURE dbo.STP_Personal_INS
	@varIDPersona INT, 
	@varIDRol INT,
	@varIDAerolinea INT,
	@Estado BIT

	AS

	INSERT INTO Tbl_Personal(ID_Persona, ID_Rol, ID_Aerolinea,Estado) VALUES (@varIDPersona, @varIDRol, @varIDAerolinea,@Estado)
GO
EXEC dbo.STP_Personal_INS 1,1,1,1
GO
--Insertar un registro en la tabla Personal_Vuelo
CREATE PROCEDURE dbo.STP_Personal_Vuelo_INS
	@varIDPersonal INT,
	@varIDVuelo INT

	AS

	INSERT INTO Tbl_Personal_Vuelo (ID_Personal, ID_Vuelo) VALUES (@varIDPersonal, @varIDVuelo)
GO
EXEC dbo.STP_Personal_Vuelo_INS 1,1
GO

--Update
--Modificar un registro de la tabla Personal_Vuelo
CREATE PROCEDURE dbo.STP_Personal_Vuelo_UPD
	@varIDPeronalAnterior INT,
	@varIDPersonalNuevo INT,
	@varIDVueloNuevo INT

	AS
	UPDATE Tbl_Personal_Vuelo
	SET ID_Personal=@varIDPersonalNuevo, ID_Vuelo=@varIDVueloNuevo
	WHERE ID_Personal=@varIDPeronalAnterior
GO
EXEC dbo.STP_Personal_Vuelo_UPD 1,1,1
GO
--Modificar un registro de la tabla Identificacion
CREATE PROCEDURE dbo.STP_Identificacion_UPD
	@varTipoPasado VARCHAR(40),
	@varTipoNuevo VARCHAR(40),
	@varDatos VARCHAR(100)

	AS 
	UPDATE Tbl_Identificacion
	SET Tipo=@varTipoNuevo, Datos=@varDatos
	WHERE Tipo=@varTipoPasado
GO
EXEC dbo.STP_Identificacion_UPD 'Cedula','Carnet','123123'
GO
--Modificar un registro de la tabla persona
CREATE PROCEDURE dbo.STP_Persona_UPD
	@varId_IdentificacionNueva INT,
	@varNombre VARCHAR(40),
	@varApellido VARCHAR(40),
	@varTelefono CHAR(10)

	AS
	UPDATE Tbl_Persona
	SET ID_Identificacion=@varId_IdentificacionNueva, Nombre=@varNombre, Apellido=@varApellido, Telefono=@varTelefono
	WHERE Telefono=@varTelefono
GO
EXEC dbo.STP_Persona_UPD 1,'Emil','Garcia','0123456789'
GO
--Modificar un registro de la tabla rol
CREATE PROCEDURE dbo.STP_Rol_UPD
	@varTipoAnterior VARCHAR(70),
	@varTipoNuevo VARCHAR(70)

	AS
	UPDATE Tbl_Rol
	SET TIPO=@varTipoNuevo
	WHERE TIPO=@varTipoAnterior
GO
EXEC dbo.STP_Rol_UPD 'Piloto','Conductor'
GO
--Modificar un registro de la tabla Estado
CREATE PROCEDURE dbo.STP_Estado_UPD
	@varIDPais INT,
	@varNombreAnterior VARCHAR(100),
	@varNombreNuevo VARCHAR(100)

	AS 
	UPDATE Tbl_Estado
	SET Nombre=@varNombreNuevo, ID_Pais=@varIDPais
	WHERE Nombre=@varNombreAnterior
GO
EXEC dbo.STP_Estado_UPD 1,'New jersey', 'New York'
GO
--Modificar un registro de la tabla Ciudad
CREATE PROCEDURE dbo.STP_Ciudad_UPD
	@varCiudadAnterior VARCHAR(100),
	@varCiudadNueva VARCHAR(100),
	@varEstadoNuevo INT


	AS
	UPDATE Tbl_Ciudad
	SET ID_Estado=@varEstadoNuevo, Nombre=@varCiudadNueva
	WHERE Nombre=@varCiudadAnterior
GO
EXEC dbo.STP_Ciudad_UPD 'Newark y Elizabeth', 'New Jersey', 1

GO
--Modificar un registro de la tabla Aeropuerto
CREATE PROCEDURE dbo.STP_Aeropuerto_UPD
	@varNombreAnterior VARCHAR(100),
	@varNombreNuevo VARCHAR(100),
	@varIDCiudad INT,
	@varEstado BIT

	AS
	UPDATE Tbl_Aeropuerto
	SET ID_Ciudad=@varIDCiudad, Nombre=@varNombreNuevo, Estado=@varEstado
	WHERE Nombre=@varNombreAnterior
GO
EXEC dbo.STP_Aeropuerto_UPD 'Aeropuerto Internacional Libertad de Newark', 'Aeropuerto Internacional Libertad de New York', 1, 0
GO
--Modificar un registro de la tabla pais
CREATE PROCEDURE dbo.STP_Pais_UPD
	@varNombreAnterior VARCHAR(40),
	@varNombreNuevo VARCHAR(40)

	AS
	UPDATE Tbl_Pais
	SET Nombre=@varNombreNuevo
	WHERE Nombre=@varNombreAnterior
GO
EXEC dbo.STP_Pais_UPD 'Estados Unidos', 'Inglaterra'
GO
--Modificar un registro de la tabla Aerolinea
CREATE PROCEDURE dbo.STP_Aerolinea_UPD
	@varNombreAnterior VARCHAR(40),
	@varNombreNuevo VARCHAR(40),
	@varIDPais INT
	

	AS
	UPDATE Tbl_Aerolinea
	SET Nombre=@varNombreNuevo
	WHERE Nombre=@varNombreAnterior
GO
EXEC dbo.STP_Aerolinea_UPD 'United Airlines','Jet Blue', 1
GO
--Modificar un registro de la tabla Aerolinea_Aeropuerto
CREATE PROCEDURE dbo.STP_Aerolinea_Aeropuerto_UPD
	@varIDAerolineaAnterior INT,
	@varIDAerolineaNueva INT,
	@varIDAeroPuertoNuevo INT

	AS
	UPDATE Tbl_Aerolinea_Aeropuerto
	SET ID_Aerolinea=@varIDAerolineaNueva, ID_Aeropuerto=@varIDAeroPuertoNuevo
	WHERE ID_Aerolinea=@varIDAerolineaAnterior
GO
EXEC dbo.STP_Aerolinea_Aeropuerto_UPD 1,1,1
GO
--Modificar un registro de la tabla Avion
CREATE PROCEDURE dbo.STP_Avion_UPD
	@varSerieAnterior VARCHAR(20),
	@varSerieNueva VARCHAR(20)


	AS
	UPDATE Tbl_Avion
	SET Serie=@varSerieNueva
	WHERE Serie=@varSerieAnterior
GO
EXEC dbo.STP_Avion_UPD  '747-8', '747-7'
GO
--Modificar un registro de la tabla Aerolinea_Avion
CREATE PROCEDURE dbo.STP_Aerolinea__Avion_UPD
	@varIDAerolineaAnterior INT,
	@varIDAerolineaNueva INT,
	@varIDAvionAnterior INT,
	@varIDAvionNuevo INT

	AS
	UPDATE Tbl_Aerolinea_Avion
	SET ID_Aerolinea=@varIDAerolineaNueva, ID_Avion=@varIDAvionNuevo
	WHERE ID_Aerolinea=@varIDAerolineaAnterior OR ID_Avion=@varIDAvionAnterior
GO
EXEC dbo.STP_Aerolinea__Avion_UPD 1,1,1,1
GO
--Modificar un registro de la tabla Vuelo
CREATE PROCEDURE dbo.STP_Vuelo_UPD
	@varCodigo VARCHAR(100),
	@varIDAvionNuevo INT,
	@varIDAerolineaNueva INT,
	@varIDAeropuertoSalidaNuevo INT,
	@varIDAeropuertoLlegadaNuevo INT,
	@varFechaSalidaNueva DATETIME,
	@varFechaLlegadaNueva DATETIME,
	@varEstadoNuevo BIT

	AS 
	UPDATE Tbl_Vuelo
	SET ID_Avion=@varIDAvionNuevo, ID_Aerolinea=@varIDAerolineaNueva, ID_Aeropuertosalida=@varIDAeropuertoSalidaNuevo, ID_AeropuertoLlegada=@varIDAeropuertoLlegadaNuevo, FechaSalida=@varFechaSalidaNueva, FechaLlegada=@varFechaLlegadaNueva, Estado=@varEstadoNuevo
	Where Codigo=@varCodigo
GO
--Modificar un regsitro de la tabla LogPersonal
CREATE PROCEDURE dbo.STP_LogPersonal_UPD
	@varIDLogPersonaAnterior INT,
	@varIDLogPersonaNueva INT,
	@varEstadoNuevo BIT,
	@varFechaDeEntrada DATETIME,
	@varFechaDeSalida DATETIME

	AS 
	UPDATE Tbl_LogPersonal
	SET ID_Personal=@varIDLogPersonaNueva, Estado=@varEstadoNuevo, FechaDeEntrada=@varFechaDeEntrada, FechaDeSalida=@varFechaDeSalida
	WHERE ID_Personal=@varIDLogPersonaAnterior
GO
--Modificar un registro de la tabla Personal
ALTER PROCEDURE dbo.STP_Personal_UPD
	@varIDPersonaAnterior INT,
	@varIDPersonaNueva INT,
	@varIDRolNuevo INT,
	@varIDAerolinea INT,
	@varEstadoNuevo BIT

	AS 
	UPDATE Tbl_Personal
	SET ID_Persona=@varIDPersonaNueva, ID_Rol=@varIDRolNuevo, ID_Aerolinea=@varIDAerolinea, Estado=@varEstadoNuevo
	WHERE ID_Persona=@varIDPersonaAnterior
GO

--Delete
--Eliminar un registro de la tabla Personal_Vuelo
CREATE PROCEDURE dbo.STP_Personal_Vuelo_DLT
	@varIDPersonal INT,
	@varIDVuelo INT

	AS
	DELETE FROM Tbl_Personal_Vuelo WHERE ID_Personal=@varIDPersonal AND ID_Vuelo=@varIDVuelo
GO
EXEC DBO.STP_Personal_Vuelo_DLT 1,1
GO
--Eliminar un registro de la tabla Personal
CREATE PROCEDURE dbo.STP_Personal_DLT
	@varIDPersonal INT

	AS
	DELETE FROM Tbl_Personal WHERE ID_Personal=@varIDPersonal
GO
EXEC dbo.STP_Personal_DLT 1
GO
--Eliminar un registro de la tabla vuelo
CREATE PROCEDURE dbo.STP_Vuelo_DLT
	@varIDVuelo INT

	AS
	DELETE FROM Tbl_Vuelo WHERE ID_Vuelo=@varIDVuelo
GO
EXEC dbo.STP_Vuelo_DLT 1
GO
--Eliminar un registro de la tabla Aerolinea_Avion
CREATE PROCEDURE dbo.STP_Aerolinea_Avion_DLT
	@varIDAerolineaAvion INT

	AS
	DELETE FROM Tbl_Aerolinea_Avion WHERE ID_Aerolinea_Avion=@varIDAerolineaAvion
GO
EXEC dbo.STP_Aerolinea_Avion_DLT 1
GO
--Eliminar un registro de la tabla Avion
CREATE PROCEDURE dbo.STP_Avion_DLT
	@varIDAvion INT

	AS 
	DELETE FROM Tbl_Avion WHERE ID_Avion=@varIDAvion
GO
EXEC dbo.STP_Avion_DLT 1
GO
--Eliminar un registro de la tabla Aerolinea_Aeropuerto
CREATE PROCEDURE dbo.STP_Aerolinea_Aeropuerto_DLT
	@varIDAerolineaAeropuerto INT

	AS
	DELETE FROM Tbl_Aerolinea_Aeropuerto WHERE ID_AerolineaAeropuerto=@varIDAerolineaAeropuerto
GO
EXEC dbo.STP_Aerolinea_Aeropuerto_DLT 1
GO
--Elminar un registro de la tabla Aerolinea
CREATE PROCEDURE dbo.STP_Aerolinea_DLT
	@varIDAerolinea INT

	AS
	DELETE FROM Tbl_Aerolinea WHERE ID_Aerolinea=@varIDAerolinea
GO
EXEC dbo.STP_Aerolinea_DLT 1
GO
--Eliminar un registro de la tabla pais
CREATE PROCEDURE dbo.STP_Pais_DLT
	@varIDPais INT

	AS
	DELETE FROM Tbl_Pais WHERE ID_Pais=@varIDPais
GO
EXEC dbo.STP_Pais_DLT 1
GO
--Eliminar un registro de la tabla aeropuerto
CREATE PROCEDURE dbo.STP_Aeropuerto_DLT
	@varIDAeropuerto INT

	AS
	DELETE FROM Tbl_Aeropuerto WHERE ID_Aeropuerto=@varIDAeropuerto
GO
EXEC dbo.STP_Aeropuerto_DLT 1
GO
--Eliminar un registro de la tabla ciudad
CREATE PROCEDURE dbo.STP_Ciudad_DLT
	@varIDCiudad INT

	AS
	DELETE FROM Tbl_Ciudad WHERE ID_Ciudad=@varIDCiudad
GO
EXEC dbo.STP_Ciudad_DLT 1
GO
--Eliminar un registro de la tabla estado
CREATE PROCEDURE dbo.STP_Estado_DLT
	@varIDEstado INT

	AS
	DELETE FROM Tbl_Estado WHERE ID_Estado=@varIDEstado
GO
EXEC dbo.STP_Estado_DLT 1
GO
--Eliminar un registro de la tabla rol
CREATE PROCEDURE dbo.STP_Rol_DLT
	@varIDRol INT

	AS
	DELETE FROM Tbl_Rol WHERE ID_Rol=@varIDRol
GO
EXEC dbo.STP_Rol_DLT 1
--Eliminar un registro de la tabla persona
CREATE PROCEDURE dbo.STP_Persona_DLT
	@varIDPersona INT 

	AS
	DELETE FROM Tbl_Persona WHERE ID_Persona=@varIDPersona
GO
EXEC dbo.STP_Persona_DLT 1
GO
--Eliminar un registro de la tabla Identificacion
CREATE PROCEDURE dbo.STP_Identificacion_DLT
	@varIDIdentificacion INT

	AS
	DELETE FROM Tbl_Identificacion WHERE ID_Identificacion=@varIDIdentificacion
GO
EXEC dbo.STP_Identificacion_DLT 1
GO

--Select
--Seleccionar todos los registros de la tabla LogPersonal
CREATE PROCEDURE dbo.STP_LogPersonal_SLTALL


	AS
	SELECT PR.Nombre, PR.Apellido, R.Tipo AS Rol, LP.FechaDeEntrada, LP.FechaDeSalida FROM Tbl_LogPersonal AS LP
	INNER JOIN Tbl_Personal AS P ON LP.ID_Personal=P.ID_Personal
	INNER JOIN Tbl_Persona AS PR ON P.ID_Persona=PR.ID_Persona
	INNER JOIN Tbl_Rol AS R ON P.ID_Rol=R.ID_Rol

GO
EXEC dbo.STP_LogPersonal_SLTALL
GO
--Seleccionar todos los registros de la tabla Personal_Vuelo
CREATE PROCEDURE dbo.STP_Personal_Vuelo_SLTALL
	
	AS
	SELECT PR.Nombre, PR.Apellido, R.Tipo AS Rol, V.ID_Vuelo FROM Tbl_Personal_Vuelo AS PV
	INNER JOIN Tbl_Personal AS P ON PV.ID_Personal=P.ID_Personal
	INNER JOIN Tbl_Persona AS PR ON P.ID_Persona=PR.ID_Persona
	INNER JOIN Tbl_Rol AS R ON P.ID_Rol=R.ID_Rol
	INNER JOIN Tbl_Vuelo AS V ON PV.ID_Vuelo=V.ID_Vuelo
GO
EXEC dbo.STP_Personal_Vuelo_SLTALL
GO
--Seleccionar todos los registros de la tabla personal
ALTER PROCEDURE dbo.STP_Personal_SLTALL
	
	AS
	SELECT P.Nombre, P.Apellido, AE.Nombre AS Aerolinea,PL.Estado FROM TbL_Personal AS PL
	INNER JOIN Tbl_Persona AS  P ON PL.ID_Persona=P.ID_Persona
	INNER JOIN Tbl_Rol AS R ON PL.ID_Rol=R.ID_Rol
	INNER JOIN Tbl_Aerolinea AS AE ON PL.ID_Aerolinea=AE.ID_Aerolinea
GO
EXEC dbo.STP_Personal_SLTALL
GO
--Selecciona todos los registros de la tabla vuelo
CREATE PROCEDURE dbo.STP_Vuelo_SLTALL
	
	AS
	SELECT V.ID_Vuelo,V.Codigo, AE.Nombre, A.Familia, A.Serie, AE.Nombre, AER.Nombre AS AeropuertoSalida, AER2.Nombre AS AeropuertoLlegada, V.FechaSalida, V.FechaLLegada FROM TBL_Vuelo AS V
	INNER JOIN Tbl_Avion AS A ON V.ID_Avion=A.ID_Avion
	INNER JOIN Tbl_Aerolinea AS AE ON V.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Aeropuerto AS AER ON V.ID_AeropuertoSalida=AER.ID_Aeropuerto
	INNER JOIN Tbl_Aeropuerto AS AER2 ON V.ID_AeropuertoLlegada=AER2.ID_Aeropuerto

GO
EXEC dbo.STP_Vuelo_SLTALL
GO
--Selecciona todos los registros de la tabla Aerolinea_Avion
CREATE PROCEDURE dbo.STP_Aerolinea_Avion_SLTALL

	AS
	SELECT AE.Nombre AS Aerolinea, A.Familia, A.Serie FROM Tbl_Aerolinea_Avion AS AEA
	INNER JOIN Tbl_Aerolinea AS AE ON AEA.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Avion AS A ON AEA.ID_Avion=A.ID_Avion

GO
EXEC dbo.STP_Aerolinea_Avion_SLTALL
GO
--Selecciona todos los registros de la tabla Avion
CREATE PROCEDURE dbo.STP_Avion_SLTALL

	AS
	SELECT * FROM Tbl_Avion
GO
EXEC dbo.STP_Avion_SLTALL
GO
--Selecciona todos los registros de la tabla Aerolinea_Aeropuerto
CREATE PROCEDURE dbo.STP_Aerolinea_Aeropuerto_SLTALL

	AS
	SELECT AE.Nombre AS Aerolinea, A.Nombre AS Aeropuerto FROM Tbl_Aerolinea_Aeropuerto AS AEA
	INNER JOIN Tbl_Aerolinea AS AE ON AEA.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Aeropuerto AS A ON AEA.ID_Aeropuerto=A.ID_Aeropuerto
GO
EXEC dbo.STP_Aerolinea_Aeropuerto_SLTALL
GO
--Selecciona todos los registros de la tabla Aerolinea
CREATE PROCEDURE dbo.STP_Aerolinea_SLTALL

	AS
	SELECT P.Nombre AS Pais, AE.Nombre AS Aerolinea, AE.FechaRegistro FROM Tbl_Aerolinea AS AE
	INNER JOIN Tbl_Pais AS P on AE.ID_Pais=P.ID_Pais
GO
EXEC dbo.STP_Aerolinea_SLTALL
GO
--Selecciona todos los registros de la tabla pais
CREATE PROCEDURE dbo.STP_Pais_SLTALL

	AS
	SELECT * FROM Tbl_Pais
GO
EXEC dbo.STP_Pais_SLTALL
GO
--Selecciona todos los registros de la tabla aeropuerto
CREATE PROCEDURE dbo.STP_Aeropuerto_SLTALL

	AS
	SELECT AE.Nombre AS Aeropuerto, C.Nombre AS Ciudad, AE.Estado AS Activo,E.Nombre AS Estado, P.Nombre AS Pais, AE.FechaRegistro FROM Tbl_Aeropuerto AS AE
	INNER JOIN Tbl_Ciudad AS C ON AE.ID_Ciudad=C.ID_Ciudad
	INNER JOIN Tbl_Estado AS E ON C.ID_Estado=E.ID_Estado
	INNER JOIN Tbl_Pais AS P ON E.ID_Pais=P.ID_Pais
GO
EXEC dbo.STP_Aeropuerto_SLTALL
GO
--Selecciona todos los registros de la tabla ciudad
CREATE PROCEDURE dbo.STP_Ciudad_SLTALL

	AS
	SELECT E.Nombre AS Estado, C.Nombre AS Ciudad FROM Tbl_Ciudad AS C
	INNER JOIN Tbl_Estado AS E ON C.ID_Estado=E.ID_Estado
GO
EXEC dbo.STP_Ciudad_SLTALL
GO
--Seleccionar todos los registros de la tabla estado
CREATE PROCEDURE dbo.STP_Estado_SLTALL

	AS
	SELECT * FROM Tbl_Estado
GO
EXEC dbo.STP_Estado_SLTALL
GO
--Seleccionar todos los registros de la tabla rol
CREATE PROCEDURE dbo.STP_Rol_SLTALL

	AS
	SELECT * FROM Tbl_Rol
GO
EXEC dbo.STP_Rol_SLTALL
GO
--Seleccionar todos los registros de la tabla Persona
CREATE PROCEDURE dbo.STP_Persona_SLTALL

	AS
	SELECT I.Tipo AS Identificacion, I.Datos, P.Nombre, P.Apellido, P.Telefono, P.FechaRegistro FROM Tbl_Persona AS P
	INNER JOIN Tbl_Identificacion AS I ON I.ID_Identificacion=P.ID_Identificacion
GO
EXEC dbo.STP_Persona_SLTALL
GO
--Seleccionar todos los registros de la tabla Identificacion
CREATE PROCEDURE dbo.STP_Identificacion_SLTALL

	AS
	SELECT * FROM Tbl_Identificacion
GO
EXEC dbo.STP_Identificacion_SLTALL
GO
--Seleccionar un registro de al tabla personal
ALTER PROCEDURE dbo.STP_Personal_SLTONE
	@varNombrePersona VARCHAR(40),
	@varApellidoPersona VARCHAR(40)
	AS
	SELECT  P.Nombre, P.Apellido, PL.Estado, AE.Nombre AS Aerolinea FROM TbL_Personal AS PL
	INNER JOIN Tbl_Persona AS  P ON PL.ID_Persona=P.ID_Persona
	INNER JOIN Tbl_Rol AS R ON PL.ID_Rol=R.ID_Rol
	INNER JOIN Tbl_Aerolinea AS AE ON PL.ID_Aerolinea=AE.ID_Aerolinea
	WHERE P.Nombre=@varNombrePersona AND P.Apellido=@varApellidoPersona
GO
EXEC dbo.STP_Personal_SLTONE 'Emil', 'Payano'
GO
--Seleccionar un registro de la tabla Personal_Vuelo
ALTER PROCEDURE dbo.STP_Personal_Vuelo_SLTONE
	@varNombrePersonal VARCHAR(40),
	@varApellidoPersonal VARCHAR(40)
	

	AS
	SELECT P.Nombre, P.Apellido, PV.ID_Vuelo AS Vuelo, AE.Nombre AS Aerolinea FROM Tbl_Personal_Vuelo AS PV
	INNER JOIN Tbl_Personal AS  PR ON PV.ID_Personal=PR.ID_Personal
	INNER JOIN Tbl_Persona AS  P ON PR.ID_Persona=P.ID_Persona
	INNER JOIN Tbl_Aerolinea AS AE ON PR.ID_Aerolinea=AE.ID_Aerolinea

	WHERE P.Nombre=@varNombrePersonal  AND P.Apellido=@varApellidoPersonal
GO
EXEC dbo.STP_Personal_Vuelo_SLTONE 'Emil','Payano'
GO
--Selecciona un registro de la tabla logpersonal
ALTER PROCEDURE dbo.STP_LogPersonal_SLTONE
	@varNombrePersonal VARCHAR(40),
	@varApellidoPersonal VARCHAR(40)
	
	AS
	SELECT PR.Nombre, PR.Apellido, R.Tipo AS Rol, LP.FechaDeEntrada, LP.FechaDeSalida, AE.Nombre AS Aerolinea FROM Tbl_LogPersonal AS LP
	INNER JOIN Tbl_Personal AS P ON LP.ID_Personal=P.ID_Personal
	INNER JOIN Tbl_Persona AS PR ON P.ID_Persona=PR.ID_Persona
	INNER JOIN Tbl_Rol AS R ON P.ID_Rol=R.ID_Rol
	INNER JOIN Tbl_Aerolinea AS AE ON P.ID_Aerolinea=AE.ID_Aerolinea
	WHERE PR.Nombre=@varNombrePersonal AND PR.Apellido=@varApellidoPersonal
GO
EXEC dbo.STP_LogPersonal_SLTONE 'Emil','Payano'
GO
--Selecciona un regsitro de la tabla vuelo
CREATE PROCEDURE dbo.STP_Vuelo_SLTONE
	@varIDVuelo INT
	AS
	SELECT V.ID_Vuelo,V.Codigo, AE.Nombre, A.Familia, A.Serie, AE.Nombre, AER.Nombre AS AeropuertoSalida, AER2.Nombre AS AeropuertoLlegada, V.FechaSalida, V.FechaLLegada FROM TBL_Vuelo AS V
	INNER JOIN Tbl_Avion AS A ON V.ID_Avion=A.ID_Avion
	INNER JOIN Tbl_Aerolinea AS AE ON V.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Aeropuerto AS AER ON V.ID_AeropuertoSalida=AER.ID_Aeropuerto
	INNER JOIN Tbl_Aeropuerto AS AER2 ON V.ID_AeropuertoLlegada=AER2.ID_Aeropuerto
	WHERE V.ID_Vuelo=@varIDVuelo
GO
EXEC dbo.STP_Vuelo_SLTONE 1
GO
--Seleccionar un registro de la tabla Aerolinea_Avion
CREATE PROCEDURE dbo.STP_Aerolinea_Avion_SLTONE
	@varNombreAerolinea VARCHAR(40)
	AS
	SELECT AE.Nombre AS Aerolinea, A.Familia AS Familia_Avion, A.Serie FROM Tbl_Aerolinea_Avion AS AEA
	INNER JOIN Tbl_Aerolinea AS AE ON AEA.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Avion AS A ON AEA.ID_Avion=A.ID_Avion
	WHERE AE.Nombre=@varNombreAerolinea
GO
EXEC dbo.STP_Aerolinea_Avion_SLTONE 'United Airlines'
GO
--Seleccionar un registro de la tabla Avion
CREATE PROCEDURE dbo.STP_Avion_SLTONE
	@varFamiliaAvion VARCHAR(40),
	@varSerie VARCHAR(40)
	AS
	SELECT * FROM Tbl_Avion
	WHERE Familia=@varFamiliaAvion AND Serie=@varSerie
GO
EXEC dbo.STP_Avion_SLTONE 'BOEING', '747-8' 
GO
--Seleccionar un registro de la tabla Aerolinea_Aeropuerto
CREATE PROCEDURE dbo.STP_Aerolinea_Aeropuerto_SLTONE
	@varAerolineaNombre VARCHAR(40)

	AS
	SELECT AE.Nombre AS Aerolinea, A.Nombre AS Aeropuerto FROM Tbl_Aerolinea_Aeropuerto AS AEA
	INNER JOIN Tbl_Aerolinea AS AE ON AEA.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Aeropuerto AS A ON AEA.ID_Aeropuerto=A.ID_Aeropuerto
	WHERE AE.Nombre=@varAerolineaNombre
GO
EXEC dbo.STP_Aerolinea_Aeropuerto_SLTONE 'United Airlines'
GO
--Seleccionar un registro de la tabla Aerolinea
CREATE PROCEDURE dbo.STP_Aerolinea_SLTONE
	@varAerolineaNombre VARCHAR(40)
	AS
	SELECT P.Nombre AS Pais, AE.Nombre AS Aerolinea, AE.FechaRegistro FROM Tbl_Aerolinea AS AE
	INNER JOIN Tbl_Pais AS P on AE.ID_Pais=P.ID_Pais
	WHERE AE.Nombre=@varAerolineaNombre
GO
EXEC dbo.STP_Aerolinea_SLTONE 'United Airlines'
GO
--Seleccionar un registro de la tabla Pais
CREATE PROCEDURE dbo.STP_Pais_SLTONE
	@varNombrePais VARCHAR(40)
	AS
	SELECT * FROM Tbl_Pais
	WHERE Nombre=@varNombrePais
GO
EXEC dbo.STP_Pais_SLTONE 'Estados Unidos'
GO
--Seleccionar un registro de la tabla aeropuerto
CREATE PROCEDURE dbo.STP_Aeropuerto_SLTONE
	@varNombreAeropuerto VARCHAR(100)
	AS
	SELECT AE.Nombre AS Aeropuerto, C.Nombre AS Ciudad, AE.Estado, AE.FechaRegistro FROM Tbl_Aeropuerto AS AE
	INNER JOIN Tbl_Ciudad AS C ON AE.ID_Ciudad=C.ID_Ciudad
	WHERE AE.Nombre=@varNombreAeropuerto
GO
EXEC dbo.STP_Aeropuerto_SLTONE 'Aeropuerto Internacional Libertad de Newark'
GO
--Selecciona un registro de la tabla ciudad
CREATE PROCEDURE dbo.STP_Ciudad_SLTONE
	@varNombreCiudad VARCHAR(100)
	AS
	SELECT E.Nombre AS Estado, C.Nombre AS Ciudad FROM Tbl_Ciudad AS C
	INNER JOIN Tbl_Estado AS E ON C.ID_Estado=E.ID_Estado
	WHERE C.Nombre=@varNombreCiudad
GO
EXEC dbo.STP_Ciudad_SLTONE 'Newark y Elizabeth'
GO
--Selecciona un registro de la tabla estado
CREATE PROCEDURE dbo.STP_Estado_SLTONE
	@varNombreEstado VARCHAR(100)
	AS
	SELECT * FROM Tbl_Estado
	WHERE Nombre=@varNombreEstado
GO
EXEC dbo.STP_Estado_SLTONE 'New Jersey'
GO
--Selecciona un registro de la tabla Rol
CREATE PROCEDURE dbo.STP_Rol_SLTONE
	@varNombreRol VARCHAR(70)
	AS
	SELECT * FROM Tbl_Rol
	WHERE Tipo=@varNombreRol
GO
EXEC dbo.STP_Rol_SLTONE 'Piloto'
GO
--Selecciona un registro de la tabla persona
CREATE PROCEDURE dbo.STP_Persona_SLTONE
	@varNombrePersona VARCHAR(40),
	@varApellidoPersona VARCHAR(40)
	AS
	SELECT I.Tipo AS Identificacion, I.Datos, P.Nombre, P.Apellido, P.Telefono, P.FechaRegistro FROM Tbl_Persona AS P
	INNER JOIN Tbl_Identificacion AS I ON I.ID_Identificacion=P.ID_Identificacion
	WHERE Nombre=@varNombrePersona AND Apellido=@varApellidoPersona
GO
EXEC dbo.STP_Persona_SLTONE
GO
--Selecciona un regsitro de la tabla identificacion
CREATE PROCEDURE dbo.STP_Identificacion_SLTONE
	@varTipo VARCHAR(40),
	@varDatos VARCHAR(100)
	AS
	SELECT * FROM Tbl_Identificacion
	WHERE Tipo=@varTipo AND Datos=@varDatos
GO
EXEC dbo.STP_Identificacion_SLTONE 'cedula', 'asdfasdf'
GO
--Insertar en la tabla logPersonal
CREATE TRIGGER TGR_Personal
	ON [dbo].[Tbl_Personal] --Tabla a asignar el Trigger
	FOR INSERT --Evento que se desea lanzar Trigger
	AS
	DECLARE @varIDPersonal INT
	DECLARE @varUsuarioCreador VARCHAR(100)
	DECLARE @varEstado BIT
	DECLARE @varFechaEntrada DATETIME
	DECLARE @varFechaSalida DATETIME

	SET @varIDPersonal = (SELECT ID_Personal FROM Inserted)
	SET @varUsuarioCreador = (SELECT system_user)
	SET @varEstado = (SELECT Estado FROM Inserted)
	SET @varFechaEntrada = (SELECT GETDATE())
	SET @varFechaSalida = (SELECT NULL)
		
	INSERT INTO dbo.TBL_LogPersonal(ID_Personal,UsuarioCreador,Estado,FechaDeEntrada,FechaDeSalida) 
	VALUES (@varIDPersonal,@varUsuarioCreador,@varEstado,@varFechaEntrada,@varFechaSalida)
GO
--Selects de listar por paramatros
--Listar todos los vuelos por aeropuerto
CREATE PROCEDURE dbo.STP_VuelosPorAeropuerto_SLT
	@varNombreAeropuerto VARCHAR(100)

	AS
	SELECT V.ID_Vuelo,V.Codigo, AE.Nombre, A.Familia, A.Serie, AE.Nombre, AER.Nombre AS AeropuertoSalida, AER2.Nombre AS AeropuertoLlegada, V.FechaSalida, V.FechaLLegada FROM TBL_Vuelo AS V
	INNER JOIN Tbl_Avion AS A ON V.ID_Avion=A.ID_Avion
	INNER JOIN Tbl_Aerolinea AS AE ON V.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Aeropuerto AS AER ON V.ID_AeropuertoSalida=AER.ID_Aeropuerto
	INNER JOIN Tbl_Aeropuerto AS AER2 ON V.ID_AeropuertoLlegada=AER2.ID_Aeropuerto
	WHERE AER.Nombre=@varNombreAeropuerto
GO
EXEC dbo.STP_VuelosPorAeropuerto_SLT 'Aeropuerto Internacional Libertad de Newark'
GO
--Listar todos los vuelos por aeropuerto y por aerolinea
CREATE PROCEDURE dbo.STP_VuelosPorAeropuertoPorAerolinea_SLT
	@varNombreAeropuerto VARCHAR(100),
	@varNombreAerolinea VARCHAR(40)
	AS
	SELECT V.ID_Vuelo,V.Codigo, AE.Nombre, A.Familia, A.Serie, AE.Nombre, AER.Nombre AS AeropuertoSalida, AER2.Nombre AS AeropuertoLlegada, V.FechaSalida, V.FechaLLegada FROM TBL_Vuelo AS V
	INNER JOIN Tbl_Avion AS A ON V.ID_Avion=A.ID_Avion
	INNER JOIN Tbl_Aerolinea AS AE ON V.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Aeropuerto AS AER ON V.ID_AeropuertoSalida=AER.ID_Aeropuerto
	INNER JOIN Tbl_Aeropuerto AS AER2 ON V.ID_AeropuertoLlegada=AER2.ID_Aeropuerto
	WHERE AER.Nombre=@varNombreAeropuerto AND AE.Nombre=@varNombreAerolinea
GO
EXEC dbo.STP_VuelosPorAeropuertoPorAerolinea_SLT 'Aeropuerto Internacional Libertad de Newark', 'United Airlines'
GO
--Listar todos los vuelos por aeropuerto, por aerolinea y entre fechas
CREATE PROCEDURE dbo.STP_VuelosPorAeropuertoPorAerolineaEntreFechas_SLT
	@varNombreAeropuerto VARCHAR(100),
	@varNombreAerolinea VARCHAR(40),
	@varFecha1 DATE,
	@varFecha2 DATE
	AS
	SELECT V.ID_Vuelo,V.Codigo, AE.Nombre AS Aerolinea, A.Familia, A.Serie, AER.Nombre AS AeropuertoSalida, AER2.Nombre AS AeropuertoLlegada, V.FechaSalida, V.FechaLLegada FROM TBL_Vuelo AS V
	INNER JOIN Tbl_Avion AS A ON V.ID_Avion=A.ID_Avion
	INNER JOIN Tbl_Aerolinea AS AE ON V.ID_Aerolinea=AE.ID_Aerolinea
	INNER JOIN Tbl_Aeropuerto AS AER ON V.ID_AeropuertoSalida=AER.ID_Aeropuerto
	INNER JOIN Tbl_Aeropuerto AS AER2 ON V.ID_AeropuertoLlegada=AER2.ID_Aeropuerto
	WHERE AER.Nombre=@varNombreAeropuerto AND AE.Nombre=@varNombreAerolinea AND V.FechaSalida BETWEEN @varFecha1 AND @varFecha2
GO
EXEC dbo.STP_VuelosPorAeropuertoPorAerolineaEntreFechas_SLT 'Aeropuerto Internacional Libertad de Newark', 'United Airlines', '4/7/2021', '7/7/2021'
GO
--Listar Aerolineas por pais
CREATE PROCEDURE dbo.STP_AerolineaPorPais_SLT
	@varAerolineaPais VARCHAR(40)
	AS
	SELECT P.Nombre AS Pais, AE.Nombre AS Aerolinea, AE.FechaRegistro FROM Tbl_Aerolinea AS AE
	INNER JOIN Tbl_Pais AS P on AE.ID_Pais=P.ID_Pais
	WHERE P.Nombre=@varAerolineaPais
GO
EXEC dbo.STP_AerolineaPorPais_SLT 'Estados Unidos'
GO
--Listar Aeropuertos por pais
CREATE PROCEDURE dbo.STP_AeropuertoPorPais_SLT
	@varNombrePais VARCHAR(40)
	AS
	SELECT P.Nombre AS Pais, AE.Nombre AS Aeropuerto, C.Nombre AS Ciudad, AE.Estado, AE.FechaRegistro FROM Tbl_Aeropuerto AS AE
	INNER JOIN Tbl_Ciudad AS C ON AE.ID_Ciudad=C.ID_Ciudad
	INNER JOIN Tbl_Estado AS E ON C.ID_Estado=E.ID_Estado
	INNER JOIN Tbl_Pais AS P ON E.ID_Pais=P.ID_Pais
	WHERE P.Nombre=@varNombrePais
GO
EXEC dbo.STP_AeropuertoPorPais_SLT 'Estados Unidos'
--Listar Personal por aerolinea
CREATE PROCEDURE dbo.STP_PersonalPorAerolinea_SLT
	@varAerolineaNombre VARCHAR(40)
	AS
	SELECT P.Nombre, P.Apellido, AE.Nombre AS Aerolinea,PL.Estado FROM TbL_Personal AS PL
	INNER JOIN Tbl_Persona AS  P ON PL.ID_Persona=P.ID_Persona
	INNER JOIN Tbl_Rol AS R ON PL.ID_Rol=R.ID_Rol
	INNER JOIN Tbl_Aerolinea AS AE ON PL.ID_Aerolinea=AE.ID_Aerolinea
	WHERE AE.Nombre=@varAerolineaNombre
GO
EXEC dbo.STP_PersonalPorAerolinea_SLT 'United Airlines'