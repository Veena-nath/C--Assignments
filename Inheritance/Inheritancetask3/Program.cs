namespace Inheritancetask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input for Course
            Console.Write("Enter Course Title: ");
            string courseTitle = Console.ReadLine();
            Console.Write("Enter Course Duration (in hours): ");
            int courseDuration = Convert.ToInt32(Console.ReadLine());
            //course obj creation
            Course course = new Course(courseTitle, courseDuration);
            course.DisplayCourse();

            // Input for Student
            Console.Write("\nEnter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Major (Graduate/Post Graduate): ");
            string studentMajor = Console.ReadLine();

            //student obj creation
            Student student = new Student(studentName, studentId, studentMajor);
            student.Study();

            // Input for Professor
            Console.Write("\nEnter Professor Name: ");
            string professorName = Console.ReadLine();
            Console.Write("Enter Professor Employee ID: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Professor's Major: ");
            string professorMajor = Console.ReadLine();

            //professor object creation
            Professor professor = new Professor(professorName, empId, professorMajor);
            professor.Teach();

            Console.WriteLine("\nAll data recorded successfully.");
        }


    }
    }
[9:19 pm, 21/5/2025] Nadiya: using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancetask3.Model
{
    public class Student
    {
        public string Name;
        public int StudentID;
        public string Major; // "Graduate" or "Post Graduate"

        public Student(string name, int studentId, string major)
        {
            Name = name;
            StudentID = studentId;
            Major = major;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} (ID: {StudentID}) is studying. Program: {Major}");
        }
        }
    }
}
