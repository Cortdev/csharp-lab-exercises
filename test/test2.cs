using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, result;
            string choice, confirm;
            int x = 0;

            do
            {
                Console.WriteLine("Enter the first number:");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the third number:");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the fourth number:");
                num4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the fifth number:");
                num5 = Convert.ToInt32(Console.ReadLine());

                result = num1 + num2 + num3 + num4 + num5;
                double average = result / 5.0;

                Console.WriteLine("The average is: " + average);

                Console.WriteLine("Do u want to continue (yes or no?): ");
                choice = Console.ReadLine().ToLower();

                if (choice == "yes")
                {
                continue;
                }
                else if (choice == "no")
                {
                  Console.WriteLine("are u sure u dont want to continue? (yes or no?): ");
                    confirm = Console.ReadLine().ToLower();

                    if (confirm == "yes")
                    {
                     break;
                    }
                    else if (confirm == "no")
                    {
                    continue;
                    }
               }
        } while (x == 0);
     }
    }
}
