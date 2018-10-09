using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Instructor {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

         // this is a constructor, a constructor is used to construct a new object
        public Instructor (string fistName, string lastName, string slackhandle, Cohort cohort) {
            FistName = fistName;
            LastName = lastName;
            SlackHandle = slackhandle;
            Cohort = cohort;
        }

        // this ia a method, a method to assign an exercise to a student
        public void AssignExercises(Exercise exercise, Student student){
            student.ExerciseList.Add(exercise);
        }
    }
}