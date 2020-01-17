CREATE DATABASE TableRelations

CREATE TABLE Passports
(
PassportId INT NOT NULL  PRIMARY KEY,
PassportNumber NVARCHAR(10) NOT NULL UNIQUE
)

INSERT INTO Passports VALUES (101,'N34FG21B')
INSERT INTO Passports VALUES (102,'K65LO4R7')
INSERT INTO Passports VALUES (103,'ZE657QP2')

CREATE TABLE Persons
(
PersonId INT NOT NULL PRIMARY KEY IDENTITY,
FirstName NVARCHAR(20) NOT NULL,
Salary MONEY NOT NULL,
PassportId INT NOT NULL UNIQUE
CONSTRAINT  PassportId FOREIGN KEY (PassportId) REFERENCES Passports (PassportId)
)


INSERT INTO Persons VALUES ('Roberto',43300.00,102)
INSERT INTO Persons VALUES ('Tom',56100.00,103)
INSERT INTO Persons VALUES ('Yana',60200.00,101)
