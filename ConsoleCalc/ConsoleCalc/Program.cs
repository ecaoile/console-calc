using System;
using System.Collections.Generic;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = false;
            List<string> pastEqs = new List<string> {"","","","",""};
            int eqCounter = 0;

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
                double firstNumDbl = Double.Parse(firstNumStr);

                Console.WriteLine("Please enter the second number.");
                string secondNumStr = Console.ReadLine();
                double secondNumbDbl = Double.Parse(secondNumStr);

                double resultDbl = 0;
                string eqString = "";
                switch (opChoice)
                {
                    case "1":
                        resultDbl = firstNumDbl + secondNumbDbl;
                        eqString = $"{firstNumStr} + {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    case "2":
                        resultDbl = firstNumDbl - secondNumbDbl;
                        eqString = $"{firstNumStr} - {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    case "3":
                        resultDbl = firstNumDbl * secondNumbDbl;
                        eqString = $"{firstNumStr} * {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    case "4":
                        resultDbl = firstNumDbl / secondNumbDbl;
                        eqString = $"{firstNumStr} ÷ {secondNumStr} = {resultDbl.ToString()}";
                        break;
                    default:
                        break;
                }
 
                if (eqCounter == 0)
                {
                    pastEqs[eqCounter] = eqString;
                    eqCounter++;
                    Console.WriteLine("\nYour equation:");
                    Console.WriteLine(eqString);
                }
                else
                {

                    if (eqCounter < 5)
                    {
                        pastEqs[eqCounter] = eqString;
                        eqCounter++;
                    }

                    else if (eqCounter == 5)
                    {
                        Console.WriteLine("This shit is filled up!");
                        pastEqs.RemoveAt(0);
                        pastEqs.Add(eqString);
                    }

                    Console.WriteLine($"\nYour past {eqCounter} equations:");
                    for (int i = 0; i < eqCounter; i++)
                    {
                        Console.WriteLine(pastEqs[i]);
                    }
                }

                Console.WriteLine("\nWould you like to enter another equation?");
                string playAgainAns = Console.ReadLine();

                if (playAgainAns.ToUpper() == "Y" || playAgainAns.ToUpper() == "YES")
                    playAgain = true;
                else
                    playAgain = false;

            } while (playAgain == true);

            Console.WriteLine("Thanks for playing! Press any button to close this app.");
            Console.ReadLine();
        }
    }
}
