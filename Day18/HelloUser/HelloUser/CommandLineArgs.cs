class CommandLineArgs
{
    static void Main(string[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No Argument passed, Pls pass the Args");
            return;
        }
        //Console.WriteLine($"The size of userName array is: {userNames.Length}");
        //for (int i = 0; i < userNames.Length; i++)
        //{
        //    Console.WriteLine("Hello welcome to .NetSession! " + userNames[i]);
        //}
        //Console.WriteLine();
        foreach (string name in userNames) //forward only we can't do in reverse order
        {
            Console.WriteLine("Hi RRD Folks-->" + name);
        }
    }
}