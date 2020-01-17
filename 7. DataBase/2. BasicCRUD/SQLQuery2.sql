SELECT * FROM Departments

SELECT [Name] FROM Departments

SELECT FirstName, LastName, Salary FROM Employees

SELECT FirstName, MiddleName, LastName FROM Employees

SELECT FirstName +'.'+LastName + '@softuni.bg'
AS 'Full Email Address'
FROM Employees

SELECT DISTINCT Salary FROM Employees

SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

SELECT FirstName, LastName, JobTitle FROM Employees
WHERE  Salary BETWEEN 20000 AND  30000

SELECT FirstName + ' ' + MiddleName + ' ' + LastName 
AS 'Full Name'
From Employees 
WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600

SELECT FirstName, LastName 
FROM Employees
WHERE ManagerID IS NULL

SET ROWCOUNT 1000000
SELECT  FirstName, LastName, Salary 
FROM Employees 
WHERE Salary >50000
ORDER BY Salary DESC

SELECT FirstName,LastName
FROM Employees
WHERE DepartmentID != 4

SELECT * 
FROM Employees
ORDER BY Salary DESC,
FirstName ASC,
LastName DESC,
MiddleName ASC


CREATE VIEW V_EmployeesSalaries AS 
SELECT FirstName, LastName, Salary
FROM Employees

CREATE VIEW V_EmployeeNameJobTitle AS 
SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS FullName,
JobTitle AS Job
FROM Employees

SELECT DISTINCT JobTitle FROM EMPLOYEES

SELECT FirstName, LastName, HireDate 
FROM Employees
ORDER BY HireDate DESC

UPDATE Employees 
SET Salary = Salary + (Salary*0.12)
WHERE DepartmentID = 1 
OR DepartmentID = 2 
OR  DepartmentID = 4 
OR  DepartmentID = 11