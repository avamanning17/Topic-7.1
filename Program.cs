using System.Net.NetworkInformation;

namespace Topic_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //while (true)
            //{
            //    Console.WriteLine("Are we there yet?");

            //}


            //int pin = 12345;
            //int entry;

            //Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            //Console.WriteLine("ENTER YOUR PIN: ");

            //int.TryParse(Console.ReadLine(), out entry);

            //Console.WriteLine(entry);

            //while (entry != pin)
            //{
            //    Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
            //    Console.WriteLine("ENTER YOUR PIN: ");
            //    int.TryParse(Console.ReadLine(), out entry);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");

            int secretNumber = 7;
            int randNum;

            Console.WriteLine("I have picked a number between 1, 10.");
            Console.WriteLine("Guess the number im thinking of: ");
            int.TryParse(Console.ReadLine(), out randNum);
            while (randNum != secretNumber)
            {
              
                    Console.WriteLine("Incorrect number! Try agin!");
                    Console.WriteLine("Enter the number: ");
                    if (secretNumber >= 10)
                    {
                        Console.WriteLine("That number is a bit too high!");
                    }
                    if (secretNumber == 1)
                    {
                        Console.WriteLine("That number is a bit too low!");
                    }
                    int.TryParse(Console.ReadLine(), out randNum);
                    Console.WriteLine();

                    Console.WriteLine("Correct!");
                }
               
           
            }








        }
    }
}
