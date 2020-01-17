SELECT '0-10'  AS [Age groups], 
(SELECT COUNT(Age) FROM WizzardDeposits WHERE Age BETWEEN 0 AND 10)
AS [Number of wizards]
UNION
SELECT '11-20',(SELECT COUNT(Age) FROM WizzardDeposits WHERE Age BETWEEN 11 AND 20)
UNION		 
SELECT '21-30',(SELECT COUNT(Age) FROM WizzardDeposits WHERE Age BETWEEN 21 AND 30)
UNION		 
SELECT '31-40',(SELECT COUNT(Age) FROM WizzardDeposits WHERE Age BETWEEN 31 AND 40)
UNION		 
SELECT '41-50',(SELECT COUNT(Age) FROM WizzardDeposits WHERE Age BETWEEN 41 AND 50)
UNION		  
SELECT '51-60',(SELECT COUNT(Age) FROM WizzardDeposits WHERE Age BETWEEN 51 AND 60)
UNION		  
SELECT '61+',(SELECT COUNT(Age) FROM WizzardDeposits WHERE Age>61)

SELECT DISTINCT LEFT(FirstName,1) AS [FirstLetter]
FROM WizzardDeposits
WHERE DepositGroup ='Troll Chest'

SELECT 
DepositGroup,
IsDepositExpired,
AVG(DepositInterest) AS [Average deposit intrerest]
FROM 
WizzardDeposits
WHERE 
DepositStartDate>Convert(datetime, '01/01/1985' )
GROUP BY
DepositGroup,IsDepositExpired
ORDER BY
DepositGroup DESC, IsDepositExpired ASC

SELECT 
FirstName AS [HostName],
DepositAmount AS [Host Wizard Deposit],
LEAD(FirstName) OVER ( ORDER BY ID ) AS [Guest Wizard],
LEAD(DepositAmount) OVER ( ORDER BY ID ) AS [Guest Wizard Deposit],
(DepositAmount - LEAD(DepositAmount) OVER ( ORDER BY ID )) AS [Difference]
FROM WizzardDeposits

SELECT 
SUM(h.Diff) AS [SumDifference]
FROM
(SELECT DepositAmount - LEAD(DepositAmount) OVER ( ORDER BY ID ) AS Diff
FROM WizzardDeposits) AS h






