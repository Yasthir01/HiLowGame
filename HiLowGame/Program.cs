using System;

namespace HiLowGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // initial message on the screen that the user sees
            Console.WriteLine("Welcome to HiLo");
            Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}");
            HiLoGame.Hint();
            while (HiLoGame.GetPot() > 0)  // while we still have money in the pot (Cant play if we have no money)
            {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint");
                Console.WriteLine($"Or any other key to quit with {HiLoGame.GetPot()}");
                // look out for the key being entered
                char key = Console.ReadKey(true).KeyChar;
                // decisions for the key that the user entered
                if (key == 'h') HiLoGame.Guess(true);  // if it is true that the next number is greater than the current number
                else if (key == 'l') HiLoGame.Guess(false);  // if number is less than current number
                else if (key == 'q') HiLoGame.Hint();
                else return;
            }
            // if we escape the while loop then it means we ran out of money
            Console.WriteLine("The pot is empty... Byyeeeee");
        }
    }
}
