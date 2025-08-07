// using System;

// namespace Test16
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double num1, num2;

//             Console.Write("Enter first number: ");
//             string input1 = Console.ReadLine();
//             if (!double.TryParse(input1, out num1))
//             {
//                 Console.WriteLine("mali,  Invalid input for first number.");
//                 return;
//             }

//             Console.Write("Enter second number: ");
//             string input2 = Console.ReadLine();
//             if (!double.TryParse(input2, out num2))
//             {
//              Console.WriteLine("malii, Invalid input for second number.");
//              return;
//             }

//             Console.WriteLine();

//             if (num2 == 0)
//             {
//              Console.WriteLine(" u cant divide in to zero");
//             }
//             else
//             {
//             double division = num1 / num2;
//             Console.WriteLine($"ratio: {num1} ÷ {num2} = {division}");
//             }

//             double power = Math.Pow(num1, num2);
//             Console.WriteLine($"Exponentiation: {num1} ^ {num2} = {power}");
//         }
//     }
// }
        