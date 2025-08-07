 using System;      
namespace Test3
{
    class Program
    {
    static void Main(string[] args)
    {
      Console.WriteLine("i type ang nakuhang pera ");
      double amount = Convert.ToDouble(Console.ReadLine());   

      Console.WriteLine("enter the Interest rate %:");
      double interest = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("enter the time (years): ");
      double time = Convert.ToDouble(Console.ReadLine());

     interest = (amount * interest * time) / 100;
     Console.WriteLine(interest);
     
     Console.WriteLine($"Borrowed Amount: {amount:C}" );
     Console.WriteLine($"Interest Rate: {interest:C}"  );
     Console.WriteLine($"time period: {time:C} years");
     Console.WriteLine($"Total Interest: {interest:C}");
     
    // double kasi ang interest ay hindi lagi buo
    // :C currency value format para malinis at mag mukhang pera

    } 
  }
}