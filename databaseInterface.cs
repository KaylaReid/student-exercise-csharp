using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using Dapper;
using StudentExercises;

namespace StudentExercises.Data
{
    public class DatabaseInterface
    {
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
                    INSERT INTO Exercise (Name, Language) VALUES ('Classes', 'JavaScript');
                    INSERT INTO Exercise (Name, Language) VALUES ('Design');
                    ");
                }
            }
        }

    }
}