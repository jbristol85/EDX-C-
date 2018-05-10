using System;

namespace myApp
{
    public class Course
    {
        public string CourseName { get; set; }
    

        public Course(string course)
        {
            this.CourseName = course;
        }
    }
}