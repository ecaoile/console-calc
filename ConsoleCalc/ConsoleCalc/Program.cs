using System;
using System.Collections.Generic;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = false;
            List<string> pastEqs = new List<string> {};
            int eqCounter = 0;
            double firstNumDbl = 0;
            double secondNumDbl = 0;

            do
            {
                Console.WriteLine("What would you like to do? Choose a number between 1 and 4.");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                string opChoice = Console.ReadLine();

                while (opChoice != "1" && opChoice != "2" && opChoice != "3" && opChoice != "4")
                {
                    Console.WriteLine("You did not choose a valid option. Please choose a number between 1 and 4");
                    opChoice = Console.ReadLine();
                }

                Console.WriteLine("\nPlease enter the first number.");
                string firstNumStr = Console.ReadLine();
               
                while (!double.TryParse(firstNumStr, out firstNumDbl))
                {
                    Console.WriteLine($"{firstNumStr} is not a valid number. Please try again.");
                    firstNumStr = Console.ReadLine();
                }

                Console.WriteLine("\nPlease enter the second number.");
                string secondNumStr = Console.ReadLine();

                while (opChoice == "4" && secondNumStr == "0")
                {
                    Console.WriteLine("\nError: cannot divide by zero. Please enter a different number.");
                    secondNumStr = Console.ReadLine();
                }

                while (!double.TryParse(secondNumStr, out secondNumDbl))
                {
                    Console.WriteLine($"{secondNumStr} is not a valid number. Please try again.");
                    secondNumStr = Console.ReadLine();
                }

                double resultDbl = 0;
                string eqString = "";

                switch (opChoice)
                {
                    case "1":
                        resultDbl = firstNumDbl + secondNumDbl;
                        eqString = $"{firstNumStr} + {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    case "2":
                        resultDbl = firstNumDbl - secondNumDbl;
                        eqString = $"{firstNumStr} - {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    case "3":
                        resultDbl = firstNumDbl * secondNumDbl;
                        eqString = $"{firstNumStr} * {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    case "4":
                        resultDbl = firstNumDbl / secondNumDbl;
                        eqString = $"{firstNumStr} ÷ {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    default:
                        break;
                }

                if (eqCounter < 5)
                {
                    pastEqs.Add(eqString);
                    eqCounter++;
                }

                if (eqCounter == 1)
                    Console.WriteLine("\nYour equation:");
                else
                    Console.WriteLine($"\nYour past {eqCounter} equations:");
                
                if (eqCounter == 5)
                {
                    pastEqs.RemoveAt(0);
                    pastEqs.Add(eqString);
                }

                for (int i = 0; i < eqCounter; i++)
                {
                    Console.WriteLine(pastEqs[i]);
                }

                Console.WriteLine("\nWould you like to enter another equation?");
                string playAgainAns = Console.ReadLine();

                if (playAgainAns.ToUpper() == "Y" || playAgainAns.ToUpper() == "YES")
                    playAgain = true;
                else
                    playAgain = false;

            } while (playAgain == true);

            Console.WriteLine("\nThanks for playing! Press any button to close this app.");
            Console.ReadLine();
        }
    }
}
