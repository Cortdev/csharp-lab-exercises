using System;

namespace Test12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binaryInput = Console.ReadLine();

            
            if (!IsBinary(binaryInput))
            {
             Console.WriteLine("Invalid binary number. Please use only 0 and 1.");
            return;
            }

            int decimalValue = Convert.ToInt32(binaryInput, 2); // convert binary to decimal

            Console.WriteLine("\nChoose conversion type:");
            Console.WriteLine("1. Decimal");
            Console.WriteLine("2. Octal");
            Console.WriteLine("3. Hexadecimal");
            Console.Write("Enter ur choice in list (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nBinary Input: {binaryInput}");

            switch (choice)
            {
            case 1:
                  Console.WriteLine($"Decimal: {decimalValue}");
                    break;
                case 2:
                    string octalValue = Convert.ToString(decimalValue, 8);
                    Console.WriteLine($"Octal: {octalValue}");
                    break;
                case 3:
                    string hexValue = Convert.ToString(decimalValue, 16).ToUpper();
                    Console.WriteLine($"Hexadecimal: {hexValue}");
                   break;
              default:
            Console.WriteLine("Invalid choice.");
              break;
            }
        }

        static bool IsBinary(string input)
        {
           foreach (char c in input)
        {
        
            if (c != '0' && c != '1')
                    return false;
            }
            return true;
     }
    }
}
