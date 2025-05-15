namespace data_type1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter the distance:");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the time:");
            int time = Convert.ToInt32(Console.ReadLine());
            int speed = distance / time;
            Console.WriteLine($"The speed in killometer per hour is:{speed}");
            Console.WriteLine($"The speed in miles per hour is{speed}");
        }
    }
}
