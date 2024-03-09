using System;


namespace Lb5.Task3
{
    public static class Class1
    {
        public static void Task()
        {
            Random random = new Random();
            int minRange = 1; 
            int maxRange = 100; 
            int numberToGuess = random.Next(minRange, maxRange + 1);

            Console.WriteLine($"The computer has chosen a number between {minRange} and {maxRange}. Try to guess!");

            int userGuess;
            do
            {
                Console.Write("Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out userGuess))
                {
                    Console.WriteLine("Please enter an integer.");
                    continue;
                }

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                }
            } while (userGuess != numberToGuess);
        }

    }
}
