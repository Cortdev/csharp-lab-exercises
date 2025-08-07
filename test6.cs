using System;      
namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
                int [] a = new int[3]; 

            for (int i = 0; i < 3; i++)
            {
            Console.WriteLine("enter a number {0}:", i + 1);
            a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Sort(a);
            
            Console.WriteLine("\n ascending number");
            for (int i = 0; i < 3; i++)
            { 
                Console.Write(a[i] + " ");
            }   
            Array.Reverse(a);
            Console.WriteLine("\n descending number");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(a[i] + " ");
            }
          
             }
            }
        }   