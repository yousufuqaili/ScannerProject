using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerProject.src
{
    internal class Grade
    {
        public int GradeAsNumber;

        public List<Course> CoursesInGrade;

        public Grade(int grade)
        {
            CoursesInGrade = new List<Course>();
            GradeAsNumber = grade;
        }
    }
}
