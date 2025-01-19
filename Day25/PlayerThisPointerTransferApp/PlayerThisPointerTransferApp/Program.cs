using System;
using PlayerThisPointerTransferApp.Models;

namespace PlayerThisPointerTransferApp
{
    class Program
    {
        static void Main()
        {
            var playerVenkat = new Player("Venkatesh", 25, 10571, 100000);
            PrintDetails(playerVenkat);
            Console.WriteLine(playerVenkat.Deposit(5000));
            Console.WriteLine(playerVenkat.Withdraw(110000));

            var playerSachin  = new Player("Sachin", 30, 10572);
            PrintDetails(playerSachin);
            Console.WriteLine(playerSachin.Deposit(2000));
            Console.WriteLine(playerSachin.Withdraw(1000));

            Player transferAmount = playerVenkat.Transfer(playerSachin, 500000);
            PrintDetails(transferAmount);
            
            //PrintDetails(playerVenkat);
            //PrintDetails(playerSachin);
        }

        public static void PrintDetails(Player player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Age: {player.Age}");
            Console.WriteLine($"Account Number: {player.AccountNumber}");
            Console.WriteLine($"Balance: {player.Balance}");
            Console.WriteLine();
        }
    }
}
