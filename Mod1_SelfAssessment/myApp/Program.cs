using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram Major1 = new UProgram("Information Technology");
            Degree Degree1 = new Degree("Bachelors");
            Course Course1 = new Course("Programming with C#");
            Student Student1 = new Student("James");
            Student Student2 = new Student("Kathy", "Marketing");
            Student Student3 = new Student("Brad", "Finance", 3.5);
            Teacher Teacher1 = new Teacher("Tom");
            Teacher Teacher2 = new Teacher("Rachel", "Computer Science", 10);
            // Major1.Field = ;

            Console.WriteLine($"The major is { Major1.Major }.");
            Console.WriteLine($"The degree is { Degree1.DegreeName }.");
            Console.WriteLine($"The course is { Course1.CourseName }.");

            Console.WriteLine($"Student1's name is { Student1.StudentName }.");
            Console.WriteLine($"Student2's name is { Student2.StudentName } and their major is { Student2.StudentMajor }.");
            Console.WriteLine($"Student3's name is { Student3.StudentName } and their major is { Student3.StudentMajor } with a GPA of { Student3.StudentGPA }.");

            Console.WriteLine($"Teacher1's name is { Teacher1.TeacherName }.");
            Console.WriteLine($"Teacher2's name is { Teacher2.TeacherName } and they teach { Teacher2.TeacherSubject } and has taught for { Teacher2.TeacherTenure } years");
        }
    }
   

   
}
