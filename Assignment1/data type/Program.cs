namespace data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get the base of triangle
            Console.WriteLine("Enter the base of triangle:");
            int Base = Convert.ToInt32(Console.ReadLine());
            // get the height of triangle
            Console.WriteLine("Enter the height of triangle:");
            int Height = Convert.ToInt32(Console.ReadLine());
            // get the slope of triangle
            Console.WriteLine("Enter the slope of the triangle:");
            int slope = Convert.ToInt32(Console.ReadLine());
            //Calclucate the area of the triangle
            double area = (Base * Height) / 2;
            //Calclucate the perimeter of th etriangle
            int perimeter = Base + Height + slope;
            //Display the result
            Console.WriteLine($"Area of the triangle is:{area}");
            Console.WriteLine($"Perimeter of the triangle is:{perimeter}");

        }
    }
}
