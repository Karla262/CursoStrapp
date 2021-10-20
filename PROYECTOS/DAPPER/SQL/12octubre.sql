INSERT INTO Customers (FirstName, LastName, Email) Values ('Carson', 'Alexander', 'carson.alexander@example.com');

SELECT * FROM Customers

SELECT * FROM Customers WHERE CustomerID = 5

customer:
	FirstName: 'JUANITO'
	LastName: 'PEREZ'
	Email: 'CORREO'

INSERT INTO Customers (FirstName, LastName, Email) VALUES('JUANITO', 'PEREZ', 'CORREO')

UPDATE Customers
SET FirstName= 'MANUEL',
	LastName= 'PEREZ',
	Email= 'CORREO'
WHERE CustomerID=5;
