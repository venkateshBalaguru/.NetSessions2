class HelloWorld2
{
    static void Main()
    {
        Console.Write("Enter the Number How many times you want print: ");
        var number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < number; i++)    
            Console.WriteLine("Hello, World!");
    }
}
