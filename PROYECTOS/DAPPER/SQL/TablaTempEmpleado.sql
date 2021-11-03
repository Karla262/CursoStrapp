

BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Empleado
	(
	idEmpleado int NOT NULL IDENTITY (1, 1),
	idPersona int NOT NULL,
	nombre varchar(50) NOT NULL,
	apellidoPaterno varchar(50) NOT NULL,
	apellidoMaterno varchar(50) NOT NULL,
	sexo char(1) NOT NULL,
	curp varchar(15) NOT NULL,
	telefono varchar(15) NOT NULL,
	correoElectronico varchar(25) NOT NULL,
	fechaNacimiento datetime NOT NULL,
	nacionalidad varchar(50) NOT NULL,
	idDireccion int NOT NULL,
	calle varchar(200) NOT NULL,
	numeroExterior varchar(25) NOT NULL,
	numeroInterior varchar(25) NOT NULL,
	colonia varchar(100) NOT NULL,
	municipio varchar(100) NOT NULL,
	estado varchar(100) NOT NULL,
	codigoPostal varchar(10) NOT NULL,
	RFC varchar(20) NOT NULL,
	puesto varchar(100) NOT NULL,
	fechaIngreso datetime NOT NULL,
	salarioDiario decimal(18, 2) NOT NULL,
	NSS int NOT NULL,
	horario varchar(50) NOT NULL,
	totalFaltas int NOT NULL,
	activo bit NOT NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_Empleado ON
GO

IF EXISTS(SELECT * FROM dbo.Empleado)
	 EXEC('INSERT INTO dbo.Tmp_Empleado (idEmpleado, idPersona, nombre, apellidoPaterno, apellidoMaterno, sexo, curp, telefono, correoElectronico, fechaNacimiento, nacionalidad, idDireccion, calle, numeroExterior, numeroInterior, colonia, municipio, estado, codigoPostal, RFC, puesto, fechaIngreso, salarioDiario, NSS, horario, totalFaltas, activo)
		SELECT idEmpleado, idPersona, nombre, apellidoPaterno, apellidoMaterno, sexo, curp, telefono, correoElectronico, fechaNacimiento, nacionalidad, idDireccion, calle, numeroExterior, numeroInterior, colonia, municipio, estado, codigoPostal, RFC, puesto, fechaIngreso, salarioDiario, NSS, horario, totalFaltas, activo FROM dbo.Empleado WITH (HOLDLOCK TABLOCKX)')
GO

SET IDENTITY_INSERT dbo.Tmp_Empleado OFF
GO

DROP TABLE dbo.Empleado
GO

EXECUTE sp_rename N'dbo.Tmp_Empleado', N'Empleado', 'OBJECT' 
GO

ALTER TABLE dbo.Empleado ADD CONSTRAINT
	PK_Empleado PRIMARY KEY CLUSTERED 
	(
	idEmpleado
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
--ROLLBACK
COMMIT
