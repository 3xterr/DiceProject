using System;
using System.Collections.Generic;

namespace DiceProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of dice you want to throw: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfDice) && numberOfDice > 0)//Converts users input to data type "int", checks if the number of dice is greater than zero and creates a variable that stores the value of amount of dice that user wnats to throw
            {
                List<int> diceResults = new List<int>();//Creates a list to store dice result values
                Random random = new Random(); //Creates a variable that will be later asigned a value of a random number.

                for (int i = 0; i < numberOfDice; i++)//creates a random number between 1 and 7 set amount of times, stores it into a list and prints it into console.
                {
                    int roll = random.Next(1, 7);
                    diceResults.Add(roll);
                    Console.WriteLine($"Dice {i + 1}: {roll}");
                }

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