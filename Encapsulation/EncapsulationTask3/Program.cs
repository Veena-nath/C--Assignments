using EncapsulationTask3.Model;

namespace EncapsulationTask3
{
    public class Program
    {
        static void Main(string[] args)
        { 
            //get input
            Console.WriteLine("Enter course name :");
            string courseName = Console.ReadLine();
            Course course = new Course(courseName);

            Console.WriteLine("\nHow many students do you want to  enrolling?");
            int studentCount;
            //validation
            while (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
            {
                Console.WriteLine("Please enter a valid number greater than 0:");
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");

                Console.Write("ID: ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("Invalid ID. Please enter a numeric value: ");
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Student student = new Student(id, name);
                student.EnrollCourse(course);
            }

            Console.WriteLine($"\nFinal Enrollment Count: {Course.EnrolledCount}/{Course.MAX_AVAILABILITY}");
        }
    }
}