namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                //display choice
                Console.WriteLine("\n=======Area Calculator=======");
                Console.WriteLine("1.Area of circle");
                Console.WriteLine("2.Area of rectangle");
                Console.WriteLine("3.Area of Triangle");
                Console.WriteLine("4.Area of square");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter the choice(1-5):");

                //get choice

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch(choice)
                {
                    //Area of circle
                    case 1:
                        Console.WriteLine("Enter the radius of cricle:");
                        double radius=Convert.ToDouble(Console.ReadLine());
                        double circleArea = Math.PI * radius * radius;
                        Console.WriteLine("Area of circle=" + circleArea);
                        break;
                    case 2:
                        //Area of rectangle
                        Console.WriteLine("Enter the length of rectangle:");
                        double length=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the width of rectangle:");
                        double width =Convert.ToDouble(Console.ReadLine());
                        double rectangleArea =length * width;
                        Console.WriteLine("Area of rectangle=" +rectangleArea);
                        break; 
                     case 3:
                        //Area of triangle
                        Console.WriteLine("Enter the base of triangle:");
                        double baseT = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the height of triangle:");
                        double height=Convert.ToDouble(Console.ReadLine());
                        double triangleArea= 0.5 * baseT * height;
                        Console.WriteLine("Area of triangle:" + triangleArea);
                        break;
                    case 4:
                        //Area of square
                        Console.WriteLine("Enter the side of square");
                        double side = Convert.ToDouble(Console.ReadLine());
                        double squareArea=side * side;
                        Console.WriteLine("Area of square" + squareArea);
                        break;
                    case 5:
                        //to exit the program
                        Console.WriteLine("Exit.");
                        break;

                    default:
                        //if invalid choice
                        Console.WriteLine("Invalid choice! Please enter a number from 1 to 5.");
                        break;
                }
            } while (choice != 5);




        }



            }

        }
    

