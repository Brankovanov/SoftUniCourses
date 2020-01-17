CREATE TABLE Manufacturers
(
ManufacturerId INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(20) NOT NULL,
EstablishedOn DATE NOT NULL
)

CREATE TABLE Models
(
ModelId INT PRIMARY KEY,
[Name] NVARCHAR(20) NOT NULL,
ManufacturerId INT NOT NULL,
CONSTRAINT ManufacturerId FOREIGN KEY (ManufacturerId) REFERENCES Manufacturers (ManufacturerId)
)

INSERT INTO Manufacturers VALUES ('BMW','07/03/1916')
INSERT INTO Manufacturers VALUES ('Tesla','01/01/2003')
INSERT INTO Manufacturers VALUES ('Lada','01/05/1966')

INSERT INTO Models VALUES (101,'X1',1)
INSERT INTO Models VALUES (102,'i6',1)
INSERT INTO Models VALUES (103,'Model S',2)
INSERT INTO Models VALUES (104, 'Model X',2)
INSERT INTO Models VALUES (105, 'Model 3',2)
INSERT INTO Models VALUES (106,'Nova',3)

SELECT * FROM Manufacturers
SELECT * FROM Models