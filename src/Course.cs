using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerProject.src
{
    /// <summary>
    /// This class will store the course code, the list of students in this course and
    /// the time the course starts 
    /// </summary>
    internal class Course
    {
        // This courses course code
        public string CourseCode { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public List<Student> StudentsInCourse;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="courseCode"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// Example: CourseCode = ICS4U1, StartTime = 12:00:00, EndTime = 13:17:00
        public Course(string courseCode, string startTime, string endTime)
        {
            StudentsInCourse = new List<Student>();

            CourseCode = courseCode;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
