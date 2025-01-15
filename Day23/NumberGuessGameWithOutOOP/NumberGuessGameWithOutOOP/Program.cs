using System;
class Program
{
    static void Main()
    {
        NumberGame();

    }
    static void NumberGame()  //From the user input we start or End the game
    {
        Console.WriteLine("Welcome to Number Guess Game");
        Console.WriteLine("1. Play Game");
        Console.WriteLine("2. Exit Game");
        int replyNo = Convert.ToInt32(Console.ReadLine());
        if (replyNo == 1)
        {
            Console.WriteLine("Enter the Player Name :"); //From the user input starting the game
            string playerName = Console.ReadLine();
            Console.WriteLine($"Hi {playerName} welcome to game you have three chance to win");
            StartGame(playerName);
            return;
        }
        if (replyNo == 2)  //End the game
        {
            Console.WriteLine("You Exit the Game..Have a good Day");
            return;
        }
        Console.WriteLine("Enter the correct Input"); //Wrong input
        NumberGame();

    }
    static void StartGame(string playerName) //Number Guess game with 3 Attempts
    {
        Random guessnumber = new Random();
        int gNo = guessnumber.Next(1, 50);
        int attempt = 3;
        //Console.WriteLine(gNo);
        for (int i = 1; i <= attempt; i++) //Three attempts
        {
            Console.WriteLine($"Enter Your Number between 1 to 50 ==>{i}st Attempt :");
            int no = Convert.ToInt32(Console.ReadLine());
            if (IsCorrect(gNo, no)) //Checking the number and if win
            {
                Console.WriteLine($"Hi {playerName} You Guessed the Correct Number is {gNo} and You Win");
                Restart(playerName);
                return;
            }
            if (!(IsCorrect(gNo, no))) //checking the number and if lose we give clue
            {
                string result = (gNo < no) ? "Your Guessing Number is greater than Actual Number" : "Your Guessing Number is Smaller than Actual Number";
                Console.WriteLine(result);
            }

        }
        Console.WriteLine("Sorry! You missed your all chances, Try Again Later\n");  //Restarting the game
        Console.WriteLine($"The Correct Number is {gNo}");
        Restart(playerName);

        static void Restart(string playername) //Restarting game from the user input with same user
        {
            Console.WriteLine("\nIf you want to continue the Game press! 1");
            int replyNo = Convert.ToInt32(Console.ReadLine());
            if (replyNo != 1)
            {
                Console.WriteLine("\nThe Game is End! Thank you");
                return;
            }
            StartGame(playername);
        }

        static bool IsCorrect(int gNo, int userNo) //Checking the number with Actual number and Guessing number
        {
            if (gNo == userNo)
            {
                return true;
            }
            return false;
        }

    }
}