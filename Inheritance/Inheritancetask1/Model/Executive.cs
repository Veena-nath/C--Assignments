using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancetask1.Model
{
    public class Executive : Employee
    {
        // Constructor that passes parameters to base class
        public Executive(int empNo, string name, string designation, double basicPay)
            : base(empNo, name, designation, basicPay)
        {
            // No extra properties for now
        }
    }
}

