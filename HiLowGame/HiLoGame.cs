using System;
using System.Collections.Generic;
using System.Text;

namespace HiLowGame
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;  // we are specifying the maximum range value 
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);  // we have to say MAX + 1 because random doesnt include last number
        private static int pot = 10;  // amount of money we have in the pot to gamble with

        public static int GetPot() { return pot; }  // we just want to return the current value of the pot

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            // figure out if the user's guess is greater than or less than current number
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;  // because the user guess correctly then we add 1 to the pot
            }
            else
            {
                // the user guess incorrectly
                Console.WriteLine("Bad luck, you guessed wrong...");
                pot--;  // we have to deduct 1 because the user guessed incorrectly
            }
            currentNumber = nextNumber;  // the new current number will be the next number
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
                Console.WriteLine($"The number is atleast {half}");
            else Console.WriteLine($"The number is at most {half}");
            pot--;  // because we used a hint we have to deduct 1 from the pot
        }
    }
}
