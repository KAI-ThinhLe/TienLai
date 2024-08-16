using System;

class Program 
{
    static void Main()
    {
        
        Console.Write("Enter the principal amount (amount of loan): ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the monthly interest rate (as a percentage): ");
        double monthlyInterestRate = double.Parse(Console.ReadLine()) / 100;
        
        Console.Write("Enter the number of months: ");
        int months = int.Parse(Console.ReadLine());
        
        double totalAmount = principal;
        
        
        for (int i = 0; i < months; i++)
        {
            double interest = totalAmount * monthlyInterestRate;
            totalAmount += interest;
        }
        
        Console.WriteLine($"The total amount after {months} months is: {totalAmount:C}");
    }
}
