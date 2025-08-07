// using System;

// namespace Test9
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] Inventory = new int[10];

//             for (int i = 0; i < Inventory.Length; i++)   
//             {
//            Console.Write($"Enter inventory for warehouse #{i + 1}: ");
//            Inventory[i] = Convert.ToInt32(Console.ReadLine());
//             }


//             Console.WriteLine("\nList of Summary Report:");
//             for (int i = 0; i < Inventory.Length; i++)
//             {
//                Console.WriteLine($"Warehouse #{i + 1}: {Inventory[i]} units");
//             }

//             Console.WriteLine("\nList of Inventory Bar Chart:");
//             for (int i = 0; i < Inventory.Length; i++) 
//             {
//               Console.Write($"Warehouse #{i + 1}: ");
//                 for (int j = 0; j < Inventory[i]; j += 10)
//                 {
//                  Console.Write("*");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }