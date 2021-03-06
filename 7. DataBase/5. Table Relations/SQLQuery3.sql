CREATE TABLE Students
(
	StudentId INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR (20) NOT NULL
)

CREATE TABLE Exams
(
	ExamId INT PRIMARY KEY,
	[Name] NVARCHAR (20) NOT NULL
)

CREATE TABLE StudentExams
(
	StudentId INT NOT NULL,
	ExamId INT NOT NULL
	CONSTRAINT PK_StudentExams PRIMARY KEY (StudentId,ExamId),
	CONSTRAINT StudentId FOREIGN KEY (StudentId) REFERENCES Students (StudentId),
	CONSTRAINT ExamId FOREIGN KEY (ExamId) REFERENCES Exams (ExamId)
)
INSERT INTO Students VALUES ('Mila')
INSERT INTO Students VALUES ('Toni')
INSERT INTO Students VALUES ('Ron')

INSERT INTO Exams VALUES (101, 'SpringMVC')
INSERT INTO Exams VALUES (102, 'Neo4J')
INSERT INTO Exams VALUES (103, 'Oracle 11j')

INSERT INTO StudentExams VALUES (1, 101)
INSERT INTO StudentExams VALUES (1, 102)
INSERT INTO StudentExams VALUES (2, 101)
INSERT INTO StudentExams VALUES (3, 103)
INSERT INTO StudentExams VALUES (2, 102)
INSERT INTO StudentExams VALUES (2, 103)

SELECT * FROM Students
SELECT * FROM Exams 
SELECT * FROM StudentExams