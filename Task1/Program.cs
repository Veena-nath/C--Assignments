

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to read the age of a candidate and 
            //determine whether it is eligible for casting his/her own 
            //vote

            Console.Write("Enter the age:");
            int age = Convert.ToInt32( Console.ReadLine());
            //int.Parse( Console.ReadLine() );

            if (age >= 18)
            {
                Console.WriteLine("candidate is eligible to vote");

            }
            else
            {
                Console.WriteLine("Candidate is not eligible to vote");
            }
        }
    }
}
