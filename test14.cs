using System;

namespace Test14
{
    class Program
    {
        static void Main(string[] args)
        {

              Console.WriteLine("Enter mo name mo: ");
            String name = Console.ReadLine();
             
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            while (number > 0)

            {
             Console.WriteLine(name);           
             number--;
            }
                   Console.WriteLine("Done na print na yung name!!");
                    
        }
    }
}
