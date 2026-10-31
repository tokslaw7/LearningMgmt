using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LearningMgmt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Data.StudentList.Add(new Student() { StudentID = 1, StudentName = "John Doe", grade = Grade.A, GPA = 4.0, Major = "Computer Science" });
            Data.StudentList.Add(new Student() { StudentID = 2, StudentName = "Jane Smith", grade = Grade.B, GPA = 3.0, Major = "Mathematics" });
            Data.StudentList.Add(new Student() { StudentID = 3, StudentName = "Bob Johnson", grade = Grade.A, GPA = 4.0, Major = "Physics" });
            Data.StudentList.Add(new Student() { StudentID = 4, StudentName = "Alice Brown", grade = Grade.A, GPA = 4.0, Major = "Artificial Intelligence" });

            var highestGradeStudent = Data.StudentList.Max(student => student.grade);
            var studentWithHighestGrade = Data.StudentList.Where(student => student.grade == highestGradeStudent).ToList();
            
            const string path = @"C:\MSSA\20483\Assignments\LearningMgmt";
            string FileName = path + Console.ReadLine() + "HighestStudentGrade.txt";

            try
            {
                Directory.CreateDirectory(path);

                using (StreamWriter writer = new StreamWriter(FileName, false))
                {
                    writer.WriteLine("Student with the Highest Grade:");
                    writer.WriteLine("--------------------------------");
                    writer.WriteLine($"Student with Highest Grade: {highestGradeStudent}");
                    writer.WriteLine($"Date Saved: {DateTime.Now}");
                    writer.WriteLine();

                    foreach (var student in studentWithHighestGrade)
                    {
                        writer.WriteLine($"Student ID: {student.StudentID}");
                        writer.WriteLine($"Student Name: {student.StudentName}");
                        writer.WriteLine($"Student Grade: {student.grade}");
                        writer.WriteLine($"Student Major: {student.Major}");
                        writer.WriteLine("-------------------------------");

                    }
                }

                Console.WriteLine($"Highest Grade Students saved successfully: {FileName}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
            
            Application.Run(new LoginForm());
        }
    }
}
