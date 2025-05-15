namespace data_type2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // get value of y
            Console.Write("enter the value of y:");
            int y = int.Parse(Console.ReadLine());
            //check y value is -5 to 5
            if (y >= -5 && y <= 5)
            {
                // calculate x
                int x = (y * y) + (2 * y) + 1;
                //display the result
                Console.WriteLine(x);


            }
            //invalid y
            else
            {
                Console.WriteLine("Please give a valid input");
            }
        }
    }
}
