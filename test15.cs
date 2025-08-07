using System;

namespace Test15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
            Console.Write($"Enter number #{i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

          Console.WriteLine("\nEven and Odd Classify ");
            foreach (int num in numbers)
            {
             if (num % 2 == 0)
          {
             Console.WriteLine($"{num} Even");
          }
                else
                {
                 Console.WriteLine($"{num} is Odd");
                }
            
      }
       }
 }
}
