using System.Collections.Generic;

namespace ScannerProject.src
{
    internal class Student : Person
    {
        private int _numberOfCourses;

        public List<Course> CoursesStudentHas { get; }

        public Student(int id) : base(id)
        {
            CoursesStudentHas = new List<Course>();
        }
    }
}