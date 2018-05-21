using System;

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            string opChoice = Console.ReadLine();
            switch (opChoice)
            {
                case "1":
                    Console.WriteLine("You want to add two numbers.");
                    break;
                case "2":
                    Console.WriteLine("You want to subtract two numbers.");
                    break;
                case "3":
                    Console.WriteLine("You want to multiply two lines");
                    break;
                case "4":
                    Console.WriteLine("You want to divide two numbers");
                    break;
                default:
                    Console.WriteLine("You did not choose a valid option. Please type choose a number between 1 and 4");
                    opChoice = Console.ReadLine();
                    break;
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the first number.");
            string firstNumStr = Console.ReadLine();
            double firstNumDbl = Double.Parse(firstNumStr);
        
            Console.WriteLine("Please enter the second number.");
            string secondNumStr = Console.ReadLine();
            double secondNumbDbl = Double.Parse(secondNumStr);

            switch (opChoice)
            {
                case "1":
                    double resultDbl = firstNumDbl + secondNumbDbl;
                    Console.WriteLine("Your equation:");
                    Console.WriteLine($"{firstNumStr} + {secondNumStr} = {resultDbl.ToString()}");
                    break;
                case "2":
                    Console.WriteLine("You want to subtract two numbers.");
                    break;
                case "3":
                    Console.WriteLine("You want to multiply two lines");
                    break;
                case "4":
                    Console.WriteLine("You want to divide two numbers");
                    break;
                default:
                    Console.WriteLine("You did not choose a valid option. Please type choose a number between 1 and 4");
                    opChoice = Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
