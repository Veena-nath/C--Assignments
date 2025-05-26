using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask3.Model
{
    internal class Course
    {
        public static int EnrolledCount = 0;
        public static int MAX_AVAILABILITY = 3;

        public string CourseName { get; set; }

        public Course(string courseName)
        {
            CourseName = courseName;
        }
    }
}
