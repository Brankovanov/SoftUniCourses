CREATE DATABASE Movies

 CREATE TABLE Directors(
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 DirectorName VARCHAR(30) NOT NULL,
 Notes TEXT
 )

 INSERT INTO Directors(DirectorName,Notes) VALUES
 ('Director1',Null),
 ('Director1','Text.'),
 ('Director2',Null),
 ('Director2','Text.'),
 ('Director2222','Text.Text.Text.Text.')
 
 SELECT* FROM Directors

 CREATE TABLE Genres(
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 GenreName VARCHAR(30) NOT NULL,
 Notes TEXT
 )

 INSERT INTO Genres(GenreName,Notes) VALUES
 ('Genre1',Null),
 ('Genre1','Text.'),
 ('Genre2',Null),
 ('Genre2','Text.'),
 ('Genre2222','Text.Text.Text.Text.')

  SELECT* FROM Genres

   CREATE TABLE Categories(
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 CategoryName VARCHAR(30) NOT NULL,
 Notes TEXT
 )

 INSERT INTO Categories(CategoryName,Notes) VALUES
 ('Category1',Null),
 ('Category1','Text.'),
 ('Category2',Null),
 ('Category2','Text.'),
 ('Category2222','Text.Text.Text.Text.')

  SELECT* FROM Categories

   CREATE TABLE Movies(
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 Title VARCHAR(30) NOT NULL,
 DirectorId INT NOT NULL FOREIGN KEY REFERENCES Directors(Id),
 CopyRightYear INT CONSTRAINT YearRange CHECK ( CopyRightYear>=1850 and CopyRightYear<=2019),
 Lenght INT NOT Null,
 GenreId INT NOT NULL FOREIGN KEY REFERENCES Genres(Id),
 CategiryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
 Rating INT CONSTRAINT Rating CHECK ( Rating>=0 and Rating<=10),
 Notes TEXT
 )

 INSERT INTO Movies(Title, DirectorId,CopyRightYear,Lenght,GenreId, CategiryId,Rating,Notes) VALUES
 ('Movie1',1,1999,129,1,5,0,Null),
 ('Movie11',2,2000,123,2,4,3,'Text.'),
 ('Movie111',3,1933,34,3,3,7,Null),
 ('Movie1111',1,2003,123,3,4,10,'Text.'),
 ('Movie1222',4,1888,123,5,5,3,'Text.Text.Text.Text.')

 SELECT * FROM Movies