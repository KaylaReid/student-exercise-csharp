--Cohort
INSERT INTO Cohort (Name)
VALUES ("Day 25")
;
INSERT INTO Cohort (Name)
VALUES ("Day 26")
;
INSERT INTO Cohort (Name)
VALUES ("Day 27")
;

--Exercise
INSERT INTO Exercise (Name, Language)
VALUES ("Loops", "JavaScript")
;
INSERT INTO Exercise (Name, Language)
VALUES ("Array Methods", "JavaScript")
;
INSERT INTO Exercise (Name, Language)
VALUES ("SQL", "Student Exercise")
;

--Instructor
INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId)
VALUES ("Steve", "Brownlee", "Brownlee23", 3)
;
INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId)
VALUES ("Addy", "Coliins", "Collins32", 3)
;
INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId)
VALUES ("Meg", "Ducharme", "Ducharme", 3)
;

--Student
INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId)
VALUES ("Helen", "Chalmers", "helenC", 3),
			("Kayla", "Reid", "reid615", 3),
			("Jen", "Smith", "JenSmith", 2)
;

--StudentExercise
INSERT INTO StudentExercise (StudentId, ExerciseId)
VALUES (1, 2),
			(2, 3),
			(3, 1)
;




