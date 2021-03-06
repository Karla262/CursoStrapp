--- PARA CREAR UNA BASE DE DATOS
CREATE DATABASE Empleados;
--- PARA USAR LA BASE DE DATOS
USE Empleados;
--- PARA CREAR UNA TABLA 

--CREATE TABLE table_name (
--	column1 datatype
--	column2 datatype
--	column3 datatype
--....
--)

CREATE TABLE Persona (
idPersona INT NOT NULL,
nombre VARCHAR(50) NOT NULL,
apellidoPaterno VARCHAR(50) NOT NULL,
apellidoMaterno VARCHAR(50) NOT NULL,
sexo CHAR NOT NULL,
curp VARCHAR(15) NOT NULL,
telefono VARCHAR(15) NOT NULL,
correoElectronico VARCHAR(25) NOT NULL,
fechaNacimiento DATETIME NOT NULL,
nacionalidad VARCHAR(50) NOT NULL,
);

--PARA INSERTAR REGISTROS EN LA TABLA 
--INSERT INTO name_table (column1, column2, column3, ...)
--VALUES (value1, value2, value3, ...)
INSERT INTO Persona(idPersona,nombre,apellidoPaterno,apellidoMaterno,
					sexo,curp,telefono,correoElectronico,
					fechaNacimiento,nacionalidad)
VALUES(3,'JUANITO','LOPEZ','LOPEZ',
		'M','XXXX890101','44444444','JUANITO@CORREO',
		'2010-01-01','CHILENO')


--**SELECCIONAR REGISTROS DE TABLA**
--SELECT column1, column2, ...
--FROM table_name
SELECT idPersona, nombre, apellidoPaterno, apellidoMaterno,
					sexo, curp, telefono, correoElectronico, 
					fechaNacimiento, nacionalidad
FROM Persona

--**SELECCIONAR REGISTRO DE UNA TABLA CON FILTROS** WHERE SON CONDICIONES
--SELECT column1, column2, ...
--FROM table_name
--WHERE condition
SELECT idPersona, nombre, apellidoPaterno, apellidoMaterno,
					sexo, curp, telefono, correoElectronico, 
					fechaNacimiento, nacionalidad
FROM Persona
WHERE idPersona = 1

SELECT idPersona, nombre, apellidoPaterno, apellidoMaterno,
					sexo, curp, telefono, correoElectronico, 
					fechaNacimiento, nacionalidad
FROM Persona
WHERE fechaNacimiento >= '2000-01-01' AND nacionalidad ='CHILENO'

--PARA ACTUALIZAR REGISTROS DE UNA TABLA
--UPDATE tablename
--SET column1 = value1, column2 = value2,... 
--WHERE condition
UPDATE Persona
SET nacionalidad ='MEXICANA'
WHERE nacionalidad = 'CHILENO' OR nacionalidad = 'COLOMBIANO'
SELECT * FROM Persona

--PARA ELIMINAR REGISTRIS DE UNA TABLA 
--DELETE FROM table_name WHERE condition
DELETE 
FROM Persona
WHERE idPersona = 1



--CREATE FUNCTION functionName(Param1,Param2,Param3)
--RETURNS returnType
--AS
--BEGIN
	--instruccion1
	--instruccion2
	--instruccion3
	--instruccion4
	--....
	--RETURN @value
--END
--GO
DROP FUNCTION calcularEdad
CREATE FUNCTION FN_CALCULAR_EDAD(@fechaNacimiento DATETIME)
RETURNS INT
AS
BEGIN
	RETURN ( SELECT DATEDIFF([year], @fechaNacimiento, GETDATE()) -
					CASE	
						WHEN (MONTH(GETDATE()) * 100) + DAY(GETDATE()) < (MONTH(@fechaNacimiento) * 100) + DAY(@fechaNacimiento) THEN 1
						ELSE 0
						END
					);
END
GO

SELECT *, dbo.calcularEdad(fechaNacimiento) AS edad FROM Persona


-- PARA CREAR UN ALMACENAMIENTO ALMACENADO
-- CREATE PROCEDURE procedure_name
	--@parameter1 datetype
	--@parameter2 datetype
	--@parameter3 datetype
--AS
	--sql_statement
--END
--GO
ALTER PROCEDURE SP_PERSONA_INSERT
	@idPersona INT,
	@nombre VARCHAR(50),
	@apellidoPaterno VARCHAR(50),
	@apellidoMaterno VARCHAR(50),
	@sexo CHAR,
	@curp VARCHAR(15),
	@telefono VARCHAR(15),
	@correoElectronico VARCHAR(25),
	@fechaNacimiento DATETIME,
	@nacionalidad VARCHAR(50)
AS
BEGIN

	IF @OPCION = 1
	BEGIN
		INSERT INTO Persona(idPersona, nombre, apellidoPaterno, apellidoMaterno,
							sexo, curp, telefono, correoElectronico,
							fechaNacimiento, nacionalidad)
		VALUES( @idPersona, @nombre, @apellidoPaterno, @apellidoMaterno,
							@sexo, @curp, @telefono,@correoElectronico,
							@fechaNacimiento, @nacionalidad)
	END

	IF @OPCION = 2
	BEGIN
		UPDATE
	END

	IF @OPCION = 2
	BEGIN
		DELETE
	END

	IF @OPCION = 2
	BEGIN
		SELECT
	END

END
GO

EXEC SP_PERSONA_INSERT 1,'PEDRO','SANCHEZ','LOPEZ','M','SALP200101ABC','11111111111','PEDRO@CORREO.COM','1995-02-01','MEXICANO'

