USE [Empleados]
GO

INSERT INTO Empleado (idPersona, nombre, apellidoPaterno, apellidoMaterno, sexo,
curp, telefono, correoElectronico, fechaNacimiento, nacionalidad, idDireccion, calle,
numeroExterior, numeroInterior, colonia, municipio, estado, codigoPostal, RFC, puesto,
fechaIngreso, salarioDiario, NSS, horario, totalFaltas, activo)
VALUES (@idPersona, @nombre, @apellidoPaterno, @apellidoMaterno, @sexo, 
@curp, @telefono, @correoElectronico, @fechaNacimiento, @nacionalidad, @idDireccion, @calle,
@numeroExterior, @numeroInterior, @colonia, @municipio, @estado, @codigoPostal, @RFC,
@puesto, @fechaIngreso, @salarioDiario, @NSS, @horario, @totalFaltas, @activo)
SELECT SCOPE_IDENTITY() AS idEmpleado

select * from Empleado






