using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Instructor {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        // build a constructor
        public Instructor (string fistName, string lastName, string slackhandle, Cohort cohort) {
            FistName = fistName;
            LastName = lastName;
            SlackHandle = slackhandle;
            Cohort = cohort;
        }


        // a method to assign an exercise to a student
        public void AssignExercises(Exercise exercise, Student student){
            student.ExerciseList.Add(exercise);
        }
    }
}