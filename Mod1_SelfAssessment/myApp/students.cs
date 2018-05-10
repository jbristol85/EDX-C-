using System;

namespace myApp
{
    public class Student
    {
        public string StudentName { get; set; }
        public double StudentGPA { get; set; }
        public string StudentMajor { get; set; }
    

        public Student(string studentName)
        {
            this.StudentName = studentName;
            StudentCount++;
        }
        public Student(string studentName, string major, double grade)
        {
            this.StudentName = studentName;
            this.StudentMajor = major;
            this.StudentGPA = grade;
            StudentCount++;
        }
          public Student(string studentName, string major)
        {
            this.StudentName = studentName;
            this.StudentMajor = major;
            StudentCount++;
        }

        private static int StudentCount = 0;

        public Student()
        {
            StudentCount++;
        }
        public static int CountStudents()
        {
            return StudentCount++;
        }

    }
}