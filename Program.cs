using System;

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

            Instructor Steve = new Instructor ("Steve", "Brownlee", "steveBrownlee", Day27);
            Instructor Meg = new Instructor ("Meg", "Ducharme", "mDucharme", Day27);
            Instructor Andy = new Instructor ("Andy", "Collins", "andy", Day27);

            Steve.AssignExercises(Loops, Ricky);
            Steve.AssignExercises(Objects, Ricky);
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

        }
    }
}
