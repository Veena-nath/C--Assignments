using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismtask1.Model
{
        public class Rectangle
        {
            private int x_coordinate;
            private int y_coordinate;

            // Default constructor
            public Rectangle()
            {
                x_coordinate = 0;
                y_coordinate = 0;
            }

            // Parameterized constructor
            public Rectangle(int x, int y)
            {
                x_coordinate = x;
                y_coordinate = y;
            }

            // Setter for x_coordinate
            public void SetX(int x)
            {
                x_coordinate = x;
            }

            // Getter for x_coordinate
            public int GetX()
            {
                return x_coordinate;
            }

            // Setter for y_coordinate
            public void SetY(int y)
            {
                y_coordinate = y;
            }

            // Getter for y_coordinate
            public int GetY()
            {
                return y_coordinate;
            }

            // Method to compute area
            public int GetArea()
            {
                return x_coordinate * y_coordinate;
            }
        }
}
