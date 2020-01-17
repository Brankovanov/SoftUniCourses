/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[PersonName]
      ,[Picture]
      ,[Height]
      ,[Weight]
      ,[Gender]
      ,[BirthDate]
      ,[Biography]
  FROM [Minions].[dbo].[People]

  INSERT INTO People (PersonName,Picture,Height,Weight,Gender,BirthDate,Biography) VALUES
  ('Ivan',Null,Null, Null,'M','0001-01-01','Текст.'),
  ('Stamat', Null,Null, Null,'M','0001-01-01', 'Текст.Текст.'),
  ('Ivanka', Null,Null, Null,'F','0001-01-01', 'Текст.Текст.Текст.Текст.'),
  ('Didka',Null,Null, Null,'F','0001-01-01', 'Текст.Текст.Текст.Текст.Текст.Текст.'),
  ('Borivoi',Null,Null, Null,'M','0001-01-01','Текст.Текст.Текст.Текст.Текст.Текст.Текст.')

  SELECT* FROM People
  
  TRUNCATE TABLE People

  ALTER TABLE PEOPLE
  ALTER COLUMN Gender Varchar(1) NOT NULL

  CREATE TABLE USERS(
  Id INT NOT NUll PRIMARY KEY IDENTITY,
  UserName VARCHAR(30) NOT NULL UNIQUE, 
  Pass VARCHAR(26) NOT NULL,
  ProfilePicture VARBINARY(900),
  LastLoginTime TIMESTAMP,
  IsDeleted VARCHAR(1) NOT NULL CHECK (IsDeleted IN ('T','F'))
  )

  INSERT INTO USERS(UserName, Pass, ProfilePicture,LastLoginTime,IsDeleted) VALUES
  ('User1','12390',NULL,CURRENT_TIMESTAMP,'T'),
  ('User2','123490',NULL,CURRENT_TIMESTAMP,'F'),
  ('User3','12345',NULL,CURRENT_TIMESTAMP,'F'),
  ('User4','123456',NULL,CURRENT_TIMESTAMP,'T'),
  ('User5','1234567',NULL,CURRENT_TIMESTAMP,'F')

  SELECT * FROM USERS

   TRUNCATE TABLE USERS

   ALTER TABLE USERS
 DROP COLUMN LastLoginTime

  ALTER TABLE USERS
 ADD LastLoginTime DATETIME

 ALTER TABLE USERS
 ADD CONSTRAINT PassLenght 
 CHECK (LEN(Pass)>=5)
 
 ALTER TABLE USERS
 DROP CONSTRAINT PassLenght 
 
 ALTER TABLE USERS
 ADD CONSTRAINT NameLenght 
 CHECK (LEN(UserName)>=3)
