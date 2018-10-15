using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Exercise Loops = new Exercise ("Loops", "JavaScript");
            Exercise ArrayMothods = new Exercise ("Array Methods", "JavaScript");
            Exercise Objects = new Exercise ("Objects", "JavaScript");
            Exercise Classes = new Exercise ("Classes", "CSharp");
            Exercise Syntax = new Exercise ("Syntax", "JavaScript");
            Exercise Terminal = new Exercise ("Terminal", "Everything");

            Cohort Day26 = new Cohort ("Day Cohort 26");
            Cohort Day27 = new Cohort ("Day Cohort 27");
            Cohort Day28 = new Cohort ("Day Cohort 28");

            Student Ricky = new Student ("Ricky", "Bruner", "rbruner", Day27);
            Student Kayla = new Student ("Kayla", "Reid", "reid615", Day27);
            Student Jen = new Student ("Jen", "Claws", "jenclaws", Day28);
            Student Jessica = new Student ("Jessica", "Barnett", "jbarnett", Day28);
            Student Avett = new Student ("Avett", "Ducharme", "avett", Day27);

            Instructor Steve = new Instructor ("Steve", "Brownlee", "steveBrownlee", Day27);
            Instructor Meg = new Instructor ("Meg", "Ducharme", "mDucharme", Day27);
            Instructor Andy = new Instructor ("Andy", "Collins", "andy", Day27);

            Steve.AssignExercises(Loops, Ricky);
            Steve.AssignExercises(Objects, Ricky);
            Steve.AssignExercises(Classes, Ricky);
            Steve.AssignExercises(Loops, Kayla);
            Steve.AssignExercises(Objects, Kayla);
            Steve.AssignExercises(Loops, Jen);
            Steve.AssignExercises(Objects, Jen);
            Steve.AssignExercises(Loops, Jessica);
            Steve.AssignExercises(Objects, Jessica);

            Andy.AssignExercises(ArrayMothods, Jessica);
            Andy.AssignExercises(Classes, Jessica);
            Andy.AssignExercises(ArrayMothods, Jen);
            Andy.AssignExercises(Classes, Jen);
            Andy.AssignExercises(ArrayMothods, Kayla);
            Andy.AssignExercises(Classes, Kayla);
            Andy.AssignExercises(ArrayMothods, Ricky);
            Andy.AssignExercises(Classes, Ricky);

            Meg.AssignExercises(Syntax, Jessica);
            Meg.AssignExercises(Terminal, Jessica);
            Meg.AssignExercises(Syntax, Jen);
            Meg.AssignExercises(Terminal, Jen);
            Meg.AssignExercises(Syntax, Kayla);
            Meg.AssignExercises(Terminal, Kayla);
            Meg.AssignExercises(Syntax, Ricky);
            Meg.AssignExercises(Terminal, Ricky);



            List<Student> students = new List<Student>() {
                Ricky,
                Kayla,
                Jen,
                Jessica,
                Avett
            };

            List<Exercise> exercises = new List<Exercise>() {
                Loops,
                ArrayMothods,
                Objects,
                Classes,
                Syntax,
                Terminal
            };

            List<Cohort> cohort = new List<Cohort>() {
                Day26,
                Day27,
                Day28
            };

            List<Instructor> instructor = new List<Instructor>() {
                Steve,
                Meg,
                Andy
            };

            // 1. List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> javaScriptexercies = from ex in exercises
            where ex.Language == "JavaScript"
            select ex;

            javaScriptexercies.ToList();
            // foreach(Exercise e in javaScriptexercies)
            // {
            //     Console.WriteLine(e.ExerciseName);
            // }

            // 2. List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> studentsincohort = from s in students
            where s.Cohort == Day27
            select s;
      
            studentsincohort.ToList();
            // foreach(Student s in studentsincohort)
            // {
            //     Console.WriteLine($"{s.FirstName} {s.LastName} Student of cohort 27");
            // }

            // 3. List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> instructorCohort = from inst in instructor
            where inst.Cohort == Day27
            select inst;

            instructorCohort.ToList();
            // foreach(Instructor inst in instructorCohort)
            // {
            //     Console.WriteLine($"{inst.FistName} {inst.LastName} Instructor for cohort 27");
            // }

            // 4. Sort the students by their last name.
            IEnumerable<Student> studentsByLastname = from oStudents in students
            orderby oStudents.LastName
            select oStudents;

            studentsByLastname.ToList();
            // foreach(Student stu in studentsByLastname)
            // {
            //     Console.WriteLine($"{stu.FirstName} {stu.LastName}");
            // }   

            // 5. Display any students that aren't working on any exercises
            IEnumerable<Student> noExStudents = students.Where(s => 
            s.ExerciseList.Count() == 0).ToList();

                foreach(Student noExStu in noExStudents)
                {
                    Console.WriteLine($"this student doesn't have any exercies {noExStu.FirstName} {noExStu.LastName}");
                }

            // 6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.

            var studentwithmostex = (from s in students
            select new{
                FirstName = s.FirstName,
                ExerciseList = s.ExerciseList.Count()
            })
            .OrderByDescending(s => exercises)
            .FirstOrDefault();
            Console.WriteLine($"{studentwithmostex.FirstName} is working on {studentwithmostex.ExerciseList} exercises");

            // 7. How many students in each cohort?
            var numberOfStudentsInCohort = students.GroupBy(c => c.Cohort.Name);
            foreach (var studnetGroup in numberOfStudentsInCohort)
            {
                Console.WriteLine($"{studnetGroup.Key} has {studnetGroup.Count()} students");
            }

        }
    }
}
