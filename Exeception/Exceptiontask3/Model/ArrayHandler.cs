using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiontask3.Model
{
    internal class ArrayHandler
    {
        // Array with 10 elements
        private int[] numbers = new int[10];

        public ArrayHandler()
        {
            // Initialize array with values 1 to 10
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
        }
    }
}
