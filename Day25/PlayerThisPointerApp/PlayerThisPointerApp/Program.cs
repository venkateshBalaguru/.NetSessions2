//Player playerVenkat = new Player("Rahul", 25, 101); //We using regular way to create object of Player class
//var playerVenkat = new Player("Venkatesh", 25, 101); //Here the var is special keyword in C# which is used to declare a variable of a particular type and it is implicitly typed variable.(its a compile time variable)
using PlayerThisPointerApp.Models;
using System;

class Program
{

    static void Main()
    {

        var playerMinu = new Player(1, "Minu",28);
        PrintDetails(playerMinu);

        //PrintDetails(new Player(3, "VenkatBala", 25)); //anonymous object

        var playerVenkat = new Player(2, "Venkat");
        PrintDetails(playerVenkat);

        Player elder = playerVenkat.WhoIsElder(playerMinu);
        PrintDetails(elder);



    }

    private static void PrintDetails(Player player)
    {
        Console.WriteLine($"Player ID: {player.Id}");
        Console.WriteLine($"Player Name: {(player.Name == null ? "Null" : player.Name)}");
        Console.WriteLine($"Player Age: {player.Age}");
        Console.WriteLine($"has code is {player.GetHashCode()}");
        Console.WriteLine();

    }
}
