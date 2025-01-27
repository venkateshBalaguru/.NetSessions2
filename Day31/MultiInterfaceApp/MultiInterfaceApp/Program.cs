using System.Net.Http.Headers;
using MultiInterfaceApp.Models;

namespace MultiInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var boy = new Boy();

           // AtTheMovies(man);
            AtTheMovies(boy);
            AtThePark(boy);
            AtThePark(man);


            
        }

        static void AtThePark(IMannerable obj)
        {
            Console.WriteLine("In the Park");
            obj.Wish();
            obj.Depart();
            Console.WriteLine();
        }

        static void AtTheMovies(IEmotionable obj)
        {
            Console.WriteLine("In the Movie");
            obj.Cry();
            obj.Laugh();
            Console.WriteLine();
        }
    }
}
