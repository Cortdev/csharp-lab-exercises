     using System;      
    namespace Test1
    {
        class Program
        {
        static void Main(string[] args)
        {
            
        int num1, num2, result; 
        Console.WriteLine("Enter a first number:");
        num1 = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter a second number:");
        num2 = Convert.ToInt32(Console.ReadLine()); 
    
        result = num1 + num2;

        Console.WriteLine("{0} + {1} + = {2}", num1, num2, result);
    
        Console.WriteLine("press any key to exit");
        Console.ReadKey();

            
        }
      }
    }