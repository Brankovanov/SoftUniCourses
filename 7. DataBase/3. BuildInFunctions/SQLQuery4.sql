SELECT TOP (50) [Name], FORMAT([Start],'yyyy-MM-dd') AS StartDate
FROM Games
WHERE YEAR([Start]) BETWEEN 2011 AND 2012
ORDER BY [Start], [Name]

SELECT UserName, STUFF(EMAIL,1,CHARINDEX('@',Email,1),'') AS [Email Provider]
FROM Users
ORDER BY [Email Provider], UserName

SELECT UserName, IpAddress
FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username

SELECT [Name] AS Game,
  CASE
   WHEN DATEPART(HOUR, Start) BETWEEN 0 AND 11
    THEN 'Morning'
   WHEN DATEPART(HOUR, Start) BETWEEN 12 AND 17
    THEN 'Afternoon'
   WHEN DATEPART(HOUR, Start) BETWEEN 18 AND 23
    THEN 'Evening'
   ELSE 'N\A'
    END AS [Part of the Day],
  CASE 
   WHEN Duration<=3 
   THEN 'Extra Short'
   WHEN Duration BETWEEN  4 AND 6 
   THEN 'Short'
   WHEN Duration> 6
   THEN 'Long'
   WHEN Duration IS NUll 
   THEN 'Extra Long'
   END AS Duration
FROM Games
ORDER BY [Name], Duration,[Part of the Day]