using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execeptiontask1.Model
{
        public class EmployeeApp
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }

            public EmployeeApp(string name, int age, string department)
            {
                Name = name;
                Age = age;
                Department = department;
            }

            public void DisplayEmployeeInfo()
            {
                Console.WriteLine("\nEmployee Information:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Department: {Department}");
            }
        }
    }


