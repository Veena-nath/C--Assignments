using System;
using Inheritancetask1.Model;

namespace Inheritancetask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of executives: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter details for Executive {i + 1}:");

                Console.Write("Employee Number: ");
                int empNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Designation: ");
                string designation = Console.ReadLine();

                Console.Write("Basic Pay: ");
                double basicPay = Convert.ToDouble(Console.ReadLine());

                // Basic validation before creating Executive
                if (basicPay > 10000)
                {
                    Executive executive = new Executive(empNo, name, designation, basicPay);
                    Console.WriteLine("\nExecutive Details:");
                    executive.DisplayDetails();
                }
                else
                {
                    Console.WriteLine("Basic Pay must be more than Rs. 10,000 for Executive.");
                }
            }

            Console.WriteLine("\nProgram completed.");
        }
    }
}
