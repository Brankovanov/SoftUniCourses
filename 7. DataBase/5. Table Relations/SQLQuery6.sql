CREATE DATABASE University

CREATE TABLE Majors
(
	MajorId INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL 
)

CREATE TABLE Students
(
	StudentId INT PRIMARY KEY IDENTITY,
	StudentNumber INT NOT NULL UNIQUE, 
	StudentName VARCHAR(50) NOT NULL,
	MajorId INT NOT NULL 
	CONSTRAINT FK_Student FOREIGN KEY(MajorId) REFERENCES Majors(MajorId)
)

CREATE TABLE Payments
(
	PaymentId INT PRIMARY KEY IDENTITY,
	PaymentDate DATE NOT NULL ,
	PaymentAmount DECIMAL(8,2) NOT NULL,
	StudentId INT NOT NULL
	CONSTRAINT FK_Payments FOREIGN KEY(StudentId) REFERENCES Students(StudentId)
)

CREATE TABLE Subjects
(
	SubjectId INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Agenda
(
	StudentId INT,
	SubjectId INT
	CONSTRAINT PK_Agenda PRIMARY KEY(StudentId, SubjectId),
	CONSTRAINT FK_Agenda_Student FOREIGN KEY(StudentId) REFERENCES Students(StudentId),
	CONSTRAINT FK_Agenga_Subject FOREIGN KEY(SubjectId) REFERENCES Subjects(SubjectId)
)