using System;

namespace Inheritancetask1.Model
{
    // Base class representing an Employee
    public class Employee
    {
        protected int EmpNo;
        protected string Name;
        protected string Designation;
        protected double BasicPay;

        // Constructor to initialize employee details
        public Employee(int empNo, string name, string designation, double basicPay)
        {
            EmpNo = empNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        // Method to display employee details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee No: " + EmpNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Basic Pay: " + BasicPay);
        }
    }
}
