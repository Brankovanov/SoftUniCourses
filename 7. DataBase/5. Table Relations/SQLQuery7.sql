SELECT Mountains.MountainRange,Peaks.PeakName, Peaks.Elevation 
FROM Peaks
INNER JOIN Mountains ON Peaks.MountainId = Mountains.Id
WHERE MountainId = 17
ORDER BY Elevation DESC