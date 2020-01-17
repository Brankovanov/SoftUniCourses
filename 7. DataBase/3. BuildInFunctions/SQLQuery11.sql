SELECT FirstName, DepartmentID, HireDate 
FROM Employees
WHERE DepartmentID = 3 OR DepartmentID =10 AND YEAR(HireDate)BETWEEN 1995 AND 2003


SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'

SELECT [Name]
FROM Towns
WHERE LEN(Name)=5 OR LEN(Name)=6
ORDER BY Name

SELECT [Name]
FROM Towns
WHERE Name LIKE 'M%' 
OR Name LIKE'K%'
OR Name LIKE'B%' 
OR Name LIKE'E%'
ORDER BY Name

SELECT [Name]
FROM Towns
WHERE Name  LIKE '[^R,B,D]%' 
ORDER BY Name


CREATE VIEW V_EmployeesHiredAfter2000  AS
SELECT FirstName, LastName
FROM Employees
WHERE YEAR(HireDate)> 2000

SELECT *FROM V_EmployeesHiredAfter2000

SELECT FirstName,LastName
FROM Employees
WHERE LEN(LastName)=5

SELECT EmployeeId,FirstName,LastName,Salary,
DENSE_RANK() OVER
(PARTITION BY Salary ORDER BY EmployeeId) AS [Rank]
FROM Employees
WHERE Salary  BETWEEN 10000 AND 50000
ORDER BY Salary DESC

SELECT* FROM(
SELECT EmployeeId,FirstName,LastName,Salary,
DENSE_RANK() OVER
(PARTITION BY Salary ORDER BY EmployeeId) AS [Rank]
FROM Employees
WHERE Salary  BETWEEN 10000 AND 50000)t
WHERE [Rank]=2
ORDER BY Salary DESC