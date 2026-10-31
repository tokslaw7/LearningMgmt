using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace LearningMgmt
{
    enum Grade
    {
        A = 4,
        B = 3,
        C = 2,
        D = 1,
        F = 0
    }
    internal class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public double GPA { get; set; }
        public string Major { get; set; } = string.Empty;
        public Grade grade { get; set; }
    }
}
