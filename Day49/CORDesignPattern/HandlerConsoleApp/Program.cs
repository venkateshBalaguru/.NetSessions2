// See https://aka.ms/new-console-template for more information
using HandlerConsoleApp;

ATM atm = new ATM();
Console.Write("Enter the Amount(Multiply of 100) : ");
long amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Requested Amount ==> "+amount);
atm.Withdraw(amount);

        
    
