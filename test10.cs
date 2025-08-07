// using System;

// namespace Test10    
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//              int[] value = {1000, 500, 200, 100, 50, 20, 10, 5, 1};
         

//             Console.WriteLine("enter a amount in peso");
//             int amount = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("\nBreakdown of currency:");

//             for (int i = 0; i < value.Length; i++)
//             { 
//                 int count= amount / value [i]; 
//                 if (count > 0)
//            {
//                 Console.WriteLine($"{value[i]} peso bill/coin: {count}");
//                 amount = amount % value[i];
//            }
//         }
//     }
// }
// }
