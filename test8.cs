// using System;

// namespace Test8
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] Food_Menu = { "sinigang dragon", "adobong pigeon", "nilagang chick", "sinigang na cow" };
//             double[] Prices = { 1000, 85, 133, 3500 };
//             double Total_bill = 0;
//             double subtotal;
//             string reply = "yes"; 

//             do
//             {
//                 Console.WriteLine("\n***** MENU *****");
//                 for (int i = 0; i < Food_Menu.Length; i++)
//                 {
//                   Console.WriteLine($"{i + 1}. {Food_Menu[i]} - ₱{Prices[i]}");
//                 }

//                 Console.Write("\nAno po order niyo? (1-4): ");
//                 bool validChoice = int.TryParse(Console.ReadLine(), out int choice);

//                 if (!validChoice || choice < 1 || choice > 4)
//                 {
//                     Console.WriteLine("Invalid choice. Please select from 1 to 4.");
//                 continue;
//                 }

//                 Console.Write("Ilan po?: ");
//                 bool validQty = int.TryParse(Console.ReadLine(), out int quantity);

//                 if (!validQty || quantity < 1)
//                 {
//                 Console.WriteLine(" Invalid quantity.");
//                  continue;
//                 }

//                 subtotal = Prices[choice - 1] * quantity;
//                 Total_bill += subtotal;

//                 Console.Write("Mag-aadd ka pa ba ng order? (yes/no): ");
//                 string? input = Console.ReadLine();

//                 if (input == null)
//                 {
//                  reply = "no"; 
//                 }
//                 else
//                 {
//                  reply = input.ToLower();
//                 }

//             } while (reply == "yes");

//             double vatableAmount = Total_bill * 0.88;
//             double VAT = Total_bill * 0.12;

//             Console.WriteLine("\n===== BILLING =====");
//             Console.WriteLine($"Total Bill: ₱{Total_bill:F2}");
//             Console.WriteLine($"Vatable Amount: ₱{vatableAmount:F2}");
//             Console.WriteLine($"VAT (12%): ₱{VAT:F2}");

//             Console.Write("\nBayad po ninyo: ₱");
//             bool validPayment = double.TryParse(Console.ReadLine(), out double amountTendered);

//             if (!validPayment)
//             {
//                 Console.WriteLine(" Invalid input for payment.");
//                 return;
//             }

//             if (amountTendered >= Total_bill)
//             {
//                 double change = amountTendered - Total_bill;
//                 Console.WriteLine($"Sukli: ₱{change:F2}");
//             }
//             else
//             {
//                 Console.WriteLine("Kulang po pera niyo sir/ma'am.");
//         }
//         }
//     }
// }
