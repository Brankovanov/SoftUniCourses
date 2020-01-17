SELECT PeakName FROM Peaks
ORDER BY PeakName

SELECT CountryName, Population 
FROM Countries 
WHERE ContinentCode  = 'EU'
ORDER BY Population DESC, CountryName ASC

Find all countries along with information about their currency. Display the country name, country code and
information about its currency: either &quot;Euro&quot; or &quot;Not Euro&quot;. Sort the results by country name alphabetically.

SELECT CountryName, CountryCode, 
CASE
    WHEN CurrencyCode='EUR'  THEN 'Euro'
    WHEN CurrencyCode!='EUR'  THEN 'Not Euro'   
END AS 'Currency'
FROM Countries
ORDER BY CountryName