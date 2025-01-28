namespace ExceptionGenerateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding the Errors in Compile time or run time error(syntax error are called compile time error it don't build we didn't
            //get exe if we get compile error..
            //If we get runtime error is called exception errors. it compiled and get error in runtime it will build the exe file.
            int firstNo = int.Parse(args[0]); // "10"
            int second = int.Parse(args[1]);  // "5"
            int divResult = firstNo / second;

            Console.WriteLine($"{firstNo} / {second} = {divResult}");

            Console.WriteLine("end of the program!!");

            //Main(args); //we can recursive the main function also but the first time it run from the main only
            // Type of Exception errors
            //1.System.IndexOutOfRangeException
            //2.System.DivideByeZeroException
            //3.System.FormatException
            //4.System.OverflowException
            //5.System.FormatException


        }
    }
}
