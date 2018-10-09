using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }

        // public string FullName {
        //     get {
        //         return $"{FirstName} {LastName}";
        //     }
        // }
        public Student (string firstName, string lastName, string slackHandle, Cohort cohort) {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

        // representing FK joiner table
        public Cohort Cohort { get; set; }
        public List<Exercise> ExerciseList = new List<Exercise>();
        
    }
}