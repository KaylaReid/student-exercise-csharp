using System;

namespace StudentExercises
{
    public class Exercise {
        public string Name { get; set; }
        public string Language { get; set; }

        // 
        //  public string ExerciseName { get; set; }
        // public string Name { get{return ExerciseName;} set{ExerciseName = value;}}

        public Exercise (string exerciseName, string language) {
            Name = exerciseName;
            Language = language;
        }
        public Exercise () {
            
        }
    }
   
}
