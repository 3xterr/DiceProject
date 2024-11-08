using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace DiceProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of dice you want to throw: ");
            int NumberOfDice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many sides should your dice have: ");
            int diceSides = Convert.ToInt32(Console.ReadLine());
            if (NumberOfDice > 0)
            {
                List<int> diceResults = new List<int>();//Creates a list to store dice result values
                Random random = new Random(); //Creates a variable that will be later asigned a value of a random number.

                for (int i = 0; i < NumberOfDice; i++)//Creates an object called random of class Random that allows to assign a random number to a variable later on.
                {
                    int roll = random.Next(1, (diceSides + 1));
                    diceResults.Add(roll);
                    Console.WriteLine($"Dice {i + 1}: {roll}");
                }
                
                int sum = diceResults.Sum();

                Console.WriteLine("\nSum of dice: " + sum);

                diceResults.Sort();//Sorts values in ascending order

                Console.WriteLine("\nSorted Results: ");
                foreach (int result in diceResults) 
                {
                    Console.WriteLine(result);
                }



            } else { Console.WriteLine("Invalid input. Please enter a positive integer."); }
            
        }
    }
}
