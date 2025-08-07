using System;

namespace Test13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ur name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nHi {name}! Welcome to the Guessing Game!");
            Console.WriteLine("Instructions:");
            Console.WriteLine("I have chosen a magic number between 1 and 50.");
            Console.WriteLine("ur goal is to guess it sir!");
            Console.WriteLine("I will tell you if your guess is too high or too low.\n");
        
            Random rand = new Random();
            int magicNumber = rand.Next(1, 51); 
            Console.WriteLine($"[DEBUG] Magic Number is: {magicNumber}");

            int guess = 0; 
            int attempts = 0;

            while (guess != magicNumber)
               {
                Console.Write("Enter your guess: ");

                if (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 50)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 50.\n");
                 continue;
                }

                attempts++;

                if (guess < magicNumber)
                {
                 Console.WriteLine("too low! try again.\n");
                }
                else if (guess > magicNumber)
                {
                 Console.WriteLine("tooo high! try again.\n");
                }
            }
            Console.WriteLine($"\n Congratulations u wonnn, {name}!");
          
            Console.WriteLine($"Ycongrats u guess the correct number  ({magicNumber}) in {attempts} attempt(s).");
     }
    }
 }