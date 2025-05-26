using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask3.Model
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Course EnrolledCourse { get; private set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void EnrollCourse(Course course)
        {
            if (EnrolledCourse != null)
            {
                Console.WriteLine($"Student {Name} is already enrolled in {EnrolledCourse.CourseName}.");
                return;
            }

            if (Course.EnrolledCount >= Course.MAX_AVAILABILITY)
            {
                Console.WriteLine($"Enrollment failed for {Name}. Course '{course.CourseName}' has reached its maximum capacity of {Course.MAX_AVAILABILITY} students.");
            }
            else
            {
                EnrolledCourse = course;
                Course.EnrolledCount++;
                Console.WriteLine($"Student {Name} successfully enrolled in {course.CourseName}. Total enrolled: {Course.EnrolledCount}");
            }
        }
    }
}
