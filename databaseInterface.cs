using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using Dapper;
using StudentExercises;

namespace StudentExercises
{
    public class DatabaseInterface
    {
        // you have to have a connection in order to do a query this is a connection to the database
        public static SqliteConnection Connection
        {
            get
            {
                string connectionString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection(connectionString);
            }
        }


        public static void CheckExercisesTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;

            try
            {
                List<Exercise> exercises = db.Query<Exercise>
                    ("SELECT Id FROM Exerises").ToList();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    db.Execute(@"CREATE TABLE `Exercise` (
                        `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
                        `Name` TEXT NOT NULL,
                        `Language`  TEXT NOT NULL
                    )");

                    db.Execute(@"
                    INSERT INTO Exercise (Name, Language) VALUES ('Loops', 'JavaScript');
                    INSERT INTO Exercise (Name, Language) VALUES ('Classes', 'CSharp');
                    INSERT INTO Exercise (Name, Language) VALUES ('Array Methods', 'JavaScript');
                    INSERT INTO Exercise (Name, Language) VALUES ('Objects', 'JavaScript');
                    INSERT INTO Exercise (Name, Language) VALUES ('Terminal', 'Everything');
                    ");
                }
            }
        }
        
         public static void CheckInstructorTable () {
            // will return a new sqlite connection that is stored in db
            SqliteConnection db = DatabaseInterface.Connection;

            try {
                List<Instructor> instructors = db.Query<Instructor>
                    // select = what to do on the database side 
                    ("SELECT Id FROM Instructor").ToList ();
            }
            // if the database table doesn't exist, check the exception and if there is no table, create the table
            catch (System.Exception ex) {
                if (ex.Message.Contains ("no such table")) {
                    // execute statement to make a new table into database
                    db.Execute ($@"CREATE TABLE `Instructor` (
                        `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
                        `FirstName` TEXT NOT NULL,
                        `LastName` TEXT NOT NULL,
                        `SlackHandle` TEXT NOT NULL,
                        `CohortId` INTEGER NOT NULL, 
                            FOREIGN KEY(`CohortId`) REFERENCES `Cohort`(`Id`) 
                    )");

                    db.Execute ($@"
                    INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId) VALUES ('Andy', 'Collins', 'andy', 2);
                    INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId) VALUES ('Jisie', 'David', 'Jisie', 1);
                    INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId) VALUES ('Joe', 'Shepherd', 'joes', 3);
                    ");
                }
            }
        }
    }
}