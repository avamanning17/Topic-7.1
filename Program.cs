using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace Topic_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Hello, World!");

            while (true)
            {
                Console.WriteLine("Are we there yet?");

            }


            int pin = 12345;
            int entry;

            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            Console.WriteLine("ENTER YOUR PIN: ");

            int.TryParse(Console.ReadLine(), out entry);

            Console.WriteLine(entry);

            while (entry != pin)
            {
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.WriteLine("ENTER YOUR PIN: ");
                int.TryParse(Console.ReadLine(), out entry);
                Console.WriteLine();
            }
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");

            int secretNumber = generator.Next(1, 11);
            int guess = 0, guesses = 0;

            Console.WriteLine("I have picked a number between 1, 10.");

            while (guess != secretNumber && guesses < 5)
            {
                Console.WriteLine("Guess the number im thinking of: ");
                int.TryParse(Console.ReadLine(), out guess);

                if (guess == secretNumber)
                {
                    Console.WriteLine("You are correct!");

                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Your guess is to low");
                    guesses++;
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Your guess is to high");
                    guesses++;
                }
                if (guesses == 5)
                {
                    Console.WriteLine("You have used up all of your guesses! you have failed.");
                }


                int diceOne, diceTwo;
            bool done;
            done = false;
            diceOne = generator.Next(1, 7);
            diceTwo = generator.Next(1, 7);
            Console.WriteLine("Roll both of the dice");
            Console.WriteLine("The first die: " + diceOne);
            Console.WriteLine("The second die: " + diceTwo);
            while (!done)
            { 
                Console.WriteLine("You did not role doubles.");
                diceOne = generator.Next(1, 7);
                diceTwo = generator.Next(1, 7);
                Console.WriteLine("Roll both of the dice");
                Console.WriteLine("The first die: " + diceOne);
                Console.WriteLine("The second die: " + diceTwo);
                if (diceOne == diceTwo)
                {
                    done = true;
                }

            }

            Console.WriteLine("Congradulations you rolled doubles.");
        }  
    }
}