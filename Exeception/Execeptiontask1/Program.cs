using System;
namespace Execeptiontask1
{
     public class Program
    {
        // Method to validate age
        public static void ValidateAge(int age)
        {
            if (age < 18 || age > 60)
            {
                throw new InvalidAgeException("Age must be between 18 and 60.");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();

                Console.Write("Enter employee age: ");
                int age = int.Parse(Console.ReadLine());

                // Validate age before proceeding
                ValidateAge(age);

                Console.Write("Enter employee department: ");
                string department = Console.ReadLine();

                // Create employee object
                Employee emp = new Employee(name, age, department);
                emp.DisplayEmployeeInfo();
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }
    }
}