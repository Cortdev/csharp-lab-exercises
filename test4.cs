// using System;      
// namespace Test4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int pagibig = 100; 
//             string name, work, reply;
//             int num1, num2, grossSalary, sss, phil, tax, totalDeductions, netSalary;
//             int x = 0;
//             do 
//           {
//             Console.Write("Enter Employee Name: ");
//             name = Console.ReadLine();

//             Console.Write("Enter Of Your Company Name: ");
//             work = Console.ReadLine();
        
//             Console.Write("Number of days worked: "); 
//             num1 = Convert.ToInt32(Console.ReadLine());

//             Console.Write("Input Your Daily Salary Rate: ");
//             num2 = Convert.ToInt32(Console.ReadLine()); 

//             grossSalary = num1 * num2;

//             sss = (num1 * num2);
//             phil = (num1 * num2);
//             tax = (num1 * num2);

//             totalDeductions = sss + pagibig + phil + tax;
//             netSalary = grossSalary - totalDeductions;

//             Console.WriteLine($"Employee Name: {name}");
//             Console.WriteLine($"Company Name: {work}");
//             Console.WriteLine($"Gross Salary: {grossSalary:C}");
//             Console.WriteLine($"SSS Deduction (15%): {sss:C}");
//             Console.WriteLine($"Pagibig Deduction (Fixed 100): {pagibig:C}");
//             Console.WriteLine($"Philhealth Deduction (5%): {phil:C}");
//             Console.WriteLine($"Tax Deduction (10%): {tax:C}");
//             Console.WriteLine($"Total Deductions: {totalDeductions:C}");
//             Console.WriteLine($"Net Salary: {netSalary:C}");
      
//             Console.Write(" Do You want to continue");
//             Console.Write ("Y/N: ");
//             reply  = Console.ReadLine();
         
//             if (reply == "yes" || reply == "YES")
//           {
//             continue;
//           }
//           else if (reply == "no" || reply == "NO")
//           {
//           Console.Write("Goodbye: ");
//           break;
//           }
// }   while (x == 0);
//      Console.ReadLine();
// }
// }
// }