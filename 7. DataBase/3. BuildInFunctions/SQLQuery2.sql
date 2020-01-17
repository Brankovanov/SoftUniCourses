SELECT CountryName, IsoCode
FROM Countries
WHERE LEN(CountryName) - LEN(REPLACE(LOWER(CountryName),'a',''))=3
ORDER BY IsoCode

SELECT PeakName,RiverName, PeakName + REPLACE(RiverName,LEFT(LOWER(RiverName),1),'') AS Mix
From Peaks,Rivers
WHERE RIGHT(LOWER(PeakName),1)=LEFT(LOWER(RiverName),1)
ORDER BY Mix
