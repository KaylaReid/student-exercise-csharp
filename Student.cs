using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }
        
        // representing FK joiner table
        public Cohort Cohort { get; set; }
        public List<Exercise> ExerciseList = new List<Exercise>();
        
    }
}