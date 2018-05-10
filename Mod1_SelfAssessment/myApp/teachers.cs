using System;

namespace myApp
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public string TeacherSubject { get; set; }
        public int TeacherTenure{ get; set; }
    

        public Teacher(string TeachName)
        {
            this.TeacherName = TeachName;
            TeacherCount++;
        }
        public Teacher(string TeachName, string TeachSubject, int TeachTenure)
        {
            this.TeacherName = TeachName;
            this.TeacherSubject = TeachSubject;
            this.TeacherTenure = TeachTenure;
            TeacherCount++;
        }
          public Teacher(string TeachName, string TeachSubject)
        {
            this.TeacherName = TeachName;
            this.TeacherSubject = TeachSubject;
            TeacherCount++;
        }

        private static int TeacherCount = 0;

        public Teacher()
        {
            TeacherCount++;
        }
        public static int CountTeachers()
        {
            return TeacherCount++;
        }

    }
}