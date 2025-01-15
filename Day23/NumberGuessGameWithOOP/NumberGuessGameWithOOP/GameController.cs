using System;
using NumberGuessGameWithOOP.Models;
namespace NumberGuessGameWithOOP
{
     class GameController
    {
        static void Main()
        {
            NumberGame();

        }
        static void NumberGame()  //From the user input we start or End the game
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to Number Guess Game");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Exit Game");
            Console.Write("Enter Your Choice : ");
            Game game = new Game();
            game.InputNo = Convert.ToInt32(Console.ReadLine());
            
            if (game.InputNo == 1)
            {
                Console.Write("\nEnter the Player Name : "); //From the user input starting the game
                game.PlayerName = Console.ReadLine();
                Console.WriteLine($"\nHi {(game.PlayerName).ToUpper()}! welcome to game you have three chance to win\n");
                StartGame(game.PlayerName);
                return;
            }
            if (game.InputNo == 2)  //End the game
            {
                Console.WriteLine("\nYou Exit the Game..Have a good Day");
                return;
            }
            Console.WriteLine("\nEnter the correct Input"); //Wrong input
            NumberGame();

        }
        
        static void StartGame(string playerName) //Number Guess game with 3 Attempts
        {
            Game game = new Game(); 
            Random guessnumber = new Random();
            int gNo = guessnumber.Next(1, 50);
            int attempt = 3;
            //Console.WriteLine(gNo);
            for (int i = 1; i <= attempt; i++) //Three attempts
            {
                Console.Write($"\nEnter Your Number between 1 to 50 ==>{i}st Attempt : ");
                int no = Convert.ToInt32(Console.ReadLine());
                if (game.IsCorrect(gNo, no)) //Checking the number and if win
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hi {playerName.ToUpper()}! You Guessed the Correct Number! The Number is {gNo} and You Win");
                    Console.ResetColor();
                    Restart(playerName);
                    return;
                }
                if (!(game.IsCorrect(gNo, no))) //checking the number and if lose we give clue
                {
                    string result = (gNo < no) ? "\nYour Guessing Number is greater than Actual Number" : "\nYour Guessing Number is Smaller than Actual Number";
                    Console.WriteLine(result);
                }

            }
            Console.WriteLine("\nSorry! You missed your all chances, Try Again Later\n");  //Restarting the game
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The Correct Number is {gNo}");
            Console.ResetColor();
            Restart(playerName);

            static void Restart(string playername) //Restarting game from the user input with same user
            {
                Game game1 = new Game();
                game1.PlayerName = playername;

                Console.Write("\nIf you want to continue the Game press! 1 : ");
                int replyNo = Convert.ToInt32(Console.ReadLine());
                if (replyNo != 1)
                {
                    Console.WriteLine("\nThe Game is End! Thank you");
                    return;
                }
                Console.WriteLine("\nThe Game Restarted!\n");
                Console.WriteLine($"\nHi {game1.PlayerName} Welcome Back to Game!");
                StartGame(playername);
            }

        }
    }
}
