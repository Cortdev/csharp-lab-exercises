using System;

namespace Test17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter character: ");
            char symbol = Convert.ToChar(Console.ReadLine());
             Console.Write("Enter number: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= rows; i++)
            {
            for (int space = 1; space <= rows - i; space++)
                {
                Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                Console.Write(symbol);
                }
                Console.WriteLine(); 
            }

            for (int i = rows - 1; i >= 1; i--)
            {
            for (int space = 1; space <= rows - i; space++)
                {
                  Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }
 }
}
