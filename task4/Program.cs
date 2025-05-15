namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Marks in Maths, Physics, and Chemistry
            Console.Write("Enter marks in Mathematics: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter mark in physics : ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            // Check subject criteria
            bool isMathsEligible = maths >= 65;
            bool isPhysicsEligible = physics >= 55;
            bool isChemistryEligible = chemistry >= 50;

            // Calculate total marks
            int total = maths + physics + chemistry;
            int total1 = maths + physics;

            // Eligibility condition 
            bool isEligible = isMathsEligible && isPhysicsEligible && isChemistryEligible &&
                              (total >= 180 || total1 >= 140);

            // Display result based on eligibility
            if (isEligible)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is NOT eligible for admission.");
            }
        }
    }
}
