﻿namespace AbstractAndInterfacetask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose an animal:\n1. Cat\n2. Dog");
                Console.Write("Enter your choice (1 or 2): ");
                string animalChoice = Console.ReadLine();

                switch (animalChoice)
                {
                    case "1":
                        Animals catanimal = new Cat();
                        catanimal.SaySomething();
                        break;
                    case "2":
                        Animals doganimal = new Dog();
                        doganimal.SaySomething();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Exiting...");
                        continue;
                }


                Console.Write("Enter the body temperature of the mammal (°F): ");
                string tempInput = Console.ReadLine();


                MyAnimals mammal = new MyAnimals();
                Console.WriteLine();
                mammal.SaySomething(); // from Animals
                int resultTemp = mammal.GetBodyTemp(tempInput);
                // from Imammals

                Console.WriteLine("Do you want to continue?y/n");
                string option = Console.ReadLine();

                if (option == "n")
                {
                    Console.WriteLine("Thank you");
                    break;

                }

            }
        }


    }
}