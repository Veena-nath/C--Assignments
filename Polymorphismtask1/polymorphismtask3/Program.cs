using polymorphismtask3.Model;

namespace polymorphismtask3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            Console.WriteLine("Choose a shape (cube, sphere, cylinder, cone):");
            string inputShape = Console.ReadLine().ToLower();

            double volume = 0;

            // Handle shape logic
            switch (inputShape)
            {
                case "cube":
                    Console.Write("Enter side length (press enter to use default): ");
                    string cubeInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(cubeInput))
                    {
                        volume = shape.Volume(); // No argument — default cube
                    }
                    else if (double.TryParse(cubeInput, out double side))
                    {
                        volume = shape.Volume("cube", side);
                    }
                    break;

                case "sphere":
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    volume = shape.Volume("sphere", radius);
                    break;

                case "cylinder":
                case "cone":
                    Console.Write("Enter radius: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    volume = shape.Volume(inputShape, r, h);
                    break;

                default:
                    Console.WriteLine("Invalid shape selected.");
                    break;
            }

            if (volume >= 0)
            {
                Console.WriteLine($"\n✅ Volume of {inputShape} = {volume:F2}");
            }
        }
    }
}
