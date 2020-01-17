INSERT INTO Towns (Name) VALUES
('Sofia'),
('Plovdiv'),
('Ruse'),
('Pleven'),
('Varna')

SELECT * FROM Towns

INSERT INTO Departments (Name) VALUES
('C#'),
('JAVA'),
('JS'),
('SQL'),
('PYTHON')

SELECT * FROM Departments

INSERT INTO Adressess(AddressText,TownId) VALUES
('Ruse, Mutkuruva 25',3),
('Varna, Dobrovnik 3',5),
('Sofia, Vitoshka 13',1),
('Plovdiv, Plovdivska 1',2),
('Pleven, Plevenska 1',4)

SELECT * FROM Adressess

INSERT INTO Employees (FirstName,MiddleName,LastName,JobTitle,DepartmentId,HireDate,Salary,AdressId)VALUES

('Ivan', 'Ivanov','Ivanov','J-dev', 1,12/12/1999, 3333.39,5),
('Dragan','Draganov','Draganov','S-dev', 3,01/04/2019, 123.23,1),
('Stamat','Stamatov','Stamatov','J-QA',2,23/03/2000,1233,4),
('Borivoi','Borivoev','Borivoev','S-QA',5,11/04/2012,1,2),
('Ую', 'Мъдев', 'Ташкин', 'ШЕФ', 4, 01/01/2001,9999.99,3)


SELECT * FROM Employees
TRUNCATE TABLE Employees
ALTER TABLE Employees
DROP COLUMN HireDate
ALTER TABLE Employees
ADD HireDate DATE NOT NULL

INSERT INTO Employees (FirstName,MiddleName,LastName,JobTitle,DepartmentId,Salary,AdressId,HireDate)VALUES

('Petar', 'Petrov', 'Petrov', 'Sen-Eng', 3,  4000.00,4,'2013/02/01'),
('Maria', 'Petrova', 'Ivanova', 'Int-Qual', 4,525.25,3, '2013/02/01'),
('Georgi', 'Teziev', 'Ivanov', 'stuf',5, 3000.00, 2, '2013/02/01'),
('Peter', 'Pan', 'Pan', 'stuff',2, 599.88,5,  '2013/02/01')

SELECT * FROM Employees

SELECT * FROM Adressess
ORDER BY AddressText

update Employees
set Salary = Salary + (Salary * 10.0 / 100.0)

SELECT * FROM Employees

SELECT DISTINCT Salary
  FROM Employees