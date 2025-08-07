using System;

namespace HighestLowestFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
           Console.Write($"Enter number {i + 1}: ");
              numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
          int highest = numbers[0];
            int lowest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
            if (numbers[i] > highest)
             highest = numbers[i];

             if (numbers[i] < lowest)
                    lowest = numbers[i];
            }

            Console.WriteLine("\nNumbers entered:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}: {numbers[i]}");
            }
            Console.WriteLine($"\nHighest number: {highest}");
            Console.WriteLine($"Lowest number: {lowest}");
        }
    }
}
