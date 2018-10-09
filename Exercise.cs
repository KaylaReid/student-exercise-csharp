using System;

namespace StudentExercises
{
    public class Exercise {
        public string ExerciseName { get; set; }
        public string Language { get; set; }

        public Exercise (string exerciseName, string language) {
            ExerciseName = exerciseName;
            Language = language;
        }
    }
   
}
