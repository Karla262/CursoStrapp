CREATE TABLE Persons (
Personid int IDENTITY(1,1) PRIMARY KEY,
Lastname varchar(255) NOT NULL,
FirstName varchar(255),
Age int
);

--PARA INSERTAR DATOS EN UN IDENTITY
SET IDENTITY_INSERT dbo.Persons ON
GO

INSERT INTO Persons(Personid, Lastname, FirstName,Age) VALUES (2, 'GOMEZ', 'MARIA', 23)

SET IDENTITY_INSERT dbo.Persons OFF
GO

--PARA INSERTAR DATOS EN UNA TABLA CON IDENTITY
INSERT INTO Persons(Lastname, FirstName,Age) VALUES ('PEREZ', 'ALEJANDRO', 25)
SELECT Personid, Lastname, FirstName, Age FROM Persons