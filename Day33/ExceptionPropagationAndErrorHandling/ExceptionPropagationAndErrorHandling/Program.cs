namespace ExceptionPropagationAndErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Main");
            try  //if we use the try catch in Main we can easily get the code excuted if we use in F2(). at the time F1() has error means we can't get the exception error
            {
                F1();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error"); //we can our own error msg in catch
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine(ex.ToString()); //if we need the info of the error from the exception we need the Exception class 
                //Console.ResetColor();

                //we can split the our Error msg and Exception msg:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR MSG: {ex.Message}\n"); //if we need the info of the error from the exception we need the Exception class 
                Console.WriteLine($"Stack trace is : {ex.StackTrace}");
                Console.ResetColor();

                //Console.WriteLine(ex);//This is the Exception ToString() method will call
            }
            Console.WriteLine("End of Main");
            
        }
        static void F1() 
        { 
            Console.WriteLine("Inside the F1");
            F2();
            Console.WriteLine("End of F1");
        }
        static void F2()
        {
            Console.WriteLine("Inside the F2");
            F3();
            //try  //if we use the try catch in Main we can easily get the code excuted if we use in F2(). at the time F1() has error means we can't get the exception error
            //{
            //    F3();
            //}
            //catch (Exception ex)
            //{
            //    //Console.WriteLine("Error"); //we can our own error msg in catch
            //    //Console.ForegroundColor = ConsoleColor.Red;
            //    //Console.WriteLine(ex.ToString()); //if we need the info of the error from the exception we need the Exception class 
            //    //Console.ResetColor();

            //    //we can split the our Error msg and Exception msg:
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"ERROR MSG: {ex.Message}\n"); //if we need the info of the error from the exception we need the Exception class 
            //    Console.WriteLine($"Stack trace is : {ex.StackTrace}");
            //    Console.ResetColor();

            //    //Console.WriteLine(ex);//This is the Exception ToString() method will call
            //}
            //Console.WriteLine("End of F2");
        }
        static void F3()
        {
            Console.WriteLine("Inside the F3");
            throw new Exception(" we found the error"); //if we throw the error next of the lines are not executed.
            //Console.WriteLine("End of F3");//This will not Execute//This is called unreachable code
        }


    }
}
