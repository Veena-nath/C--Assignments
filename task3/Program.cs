namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to read roll no, name and marks of 
            //three subjects and calculate the total, percentage and
            //division
            //get user input
            Console.Write("Enter the Roll.no: ");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the Name:");
            string name = Console.ReadLine();
            Console.Write("Enter the mark of English:");
            float English = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the mark of maths:");
            float maths = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the mark of science:");
            float science = Convert.ToSingle(Console.ReadLine());
            

            float total = English + maths + science;
            float percentage = total / 300 * 100;
            string Grade;
            if (percentage >=90)
            {
                Grade = "A Grade";
            }else if(percentage>=80)
            {
                Grade = "B Grade";

            }else if(percentage>=75)
            {
                Grade = "C Grade";


            } else if(percentage>=45)
            {
                Grade = " D Grade";

            }else
            {
                Grade = "Fail";
            }

            Console.WriteLine("----Student Report-----\n");
            Console.WriteLine("Roll no" + rollno);
            Console.WriteLine("name" + name);
            Console.WriteLine("Total" + total);
            Console.WriteLine("Percentage" +percentage.ToString("f2") + "%");
            Console.WriteLine("Grade" + Grade);



        }
    }
}
