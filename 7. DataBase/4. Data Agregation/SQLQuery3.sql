SELECT DepartmentId, SUM(Salary) AS [Total Salary]
FROM Employees
GROUP BY DepartmentID

SELECT DepartmentID, MIN(Salary) AS [MinimumSalary]
FROM Employees
WHERE 
HireDate>Convert(datetime, '01/01/2000' )
GROUP BY DepartmentID
HAVING DepartmentID = 2 OR DepartmentID = 5 OR DepartmentID =7

SELECT * INTO [EmployeesAS] FROM Employees
WHERE [Salary] >= 30000
DELETE FROM EmployeesAS
WHERE [ManagerID] = 42
UPDATE EmployeesAS
SET [Salary] += 5000
WHERE [DepartmentID] = 1
SELECT [DepartmentID],
    AVG([Salary]) as [AverageSalary]
FROM EmployeesAS
GROUP BY [DepartmentID]

SELECT DepartmentID,MAX(Salary) AS [MaxSalary]
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000