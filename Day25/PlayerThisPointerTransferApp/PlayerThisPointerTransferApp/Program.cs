using System;
using PlayerThisPointerTransferApp.Models;

namespace PlayerThisPointerTransferApp
{
    class Program
    {
        static void Main()
        {
            var playerVenkat = new Player("Venkatesh", 25, 10571, 100000);
            playerVenkat.Deposit(5000);
            playerVenkat.Withdraw(1000);
            PrintDetails(playerVenkat);

            var playerSachin  = new Player("Sachin", 30, 10572);
            playerSachin.Deposit(5000);
            PrintDetails(playerSachin);

            playerVenkat.Transfer(playerSachin, 5000);
            Player transferAmount = playerVenkat.Transfer(playerSachin, 5000);
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
