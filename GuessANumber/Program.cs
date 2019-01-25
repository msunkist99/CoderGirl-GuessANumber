using System;

namespace GuessANumber
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number between 1 and 10: ");
            int number = int.Parse(Console.ReadLine());

            // If they enter 8, output “You Win!”. Otherwise, output “You Lose.”. Do this using an inline if statement.
            string outputLine;

            outputLine = (number == 8) ? "You Win!" : "You Lose.";

            Console.WriteLine(outputLine);

            Console.ReadLine();
        }
    }
}
