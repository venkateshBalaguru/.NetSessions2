using ManBoyInterfaceApp.Models;

namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var boy = new Boy();

            AtTheParty(man);
            AtTheParty(boy);

            //AtTheMovies(man);  //Man is not in the IEmotionable interface
            AtTheMovies(boy);

         
        }
        public static void AtTheParty(IMannerable obj)
            {
            Console.WriteLine("At the Party");
            obj.Wish();
            obj.Depart();
            
            Console.WriteLine("Party over");
        }

        public static void AtTheMovies(IEmotionable obj)
        {
            Console.WriteLine("At the movies");
            obj.Laugh();
            obj.Cry();
        }
    }
}
