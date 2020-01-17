SELECT Id 
FROM WizzardDeposits

SELECT 
	COUNT (DISTINCT c.Id) AS [Count]
FROM WizzardDeposits AS c

SELECT
	MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits

SELECT DepositGroup,
	MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits
	GROUP BY DepositGroup

SELECT DepositGroup
FROM WizzardDeposits
 GROUP BY DepositGroup
 HAVING AVG(MagicWandSize) = (
    SELECT TOP (1) AVG(MagicWandSize)
    FROM WizzardDeposits
    GROUP BY DepositGroup
    ORDER BY AVG(MagicWandSize)
 );

SELECT DepositGroup, SUM(DepositAmount)
 FROM WizzardDeposits
 GROUP BY DepositGroup

 SELECT DepositGroup, SUM(DepositAmount) AS Total
 FROM WizzardDeposits
 WHERE MagicWandCreator = 'Ollivander family' 
 GROUP BY DepositGroup 
 HAVING SUM(DepositAmount)< 150000
 ORDER BY SUM(DepositAmount) DESC
 
SELECT DepositGroup,MagicWandCreator,MIN(DepositCharge) AS MinimalCharge 
FROM WizzardDeposits
GROUP BY DepositGroup,MagicWandCreator
Order By MagicWandCreator, DepositGroup


