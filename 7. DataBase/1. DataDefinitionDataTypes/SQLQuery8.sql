CREATE TABLE Minions(
 Id INT PRIMARY KEY IDENTITY,
 MinionName NVARCHAR(50) NOT NULL,
 Age INT NOT NULL
 )

 CREATE TABLE Towns(
  Id INT PRIMARY KEY IDENTITY,
  TownName NVARCHAR(50) NOT NULL
  )

  ALTER TABLE Minions
  ADD TownId INT FOREIGN KEY REFERENCES Towns(id)

  INSERT INTO Towns(TownName) VALUES
  ('Sofia'),
  ('Plovdiv'),
  ('Varna')

  SELECT * FROM Towns

  INSERT INTO Minions(MinionName,Age,TownId) VALUES
  ('Kevin',22,1),
  ('Bob',15,3),
  ('Steward',33,2)

  SELECT* FROM Minions

  TRUNCATE TABLE Minions

  DROP TABLE Minions

  DROP TABLE Towns

  CREATE TABLE People(
   Id INT PRIMARY KEY IDENTITY,
   PersonName NVARCHAR(200) NOT NULL,
   Picture IMAGE,
   Height DECIMAL (1,1),
   Weight DECIMAL (1,1),
   Gender Binary NOT NULL,
   BirthDate DATE NOT NUll,
   Biography TEXT
   )

