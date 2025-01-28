using MovableInterface.Models;

namespace MovableInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables = new IMovable[3];
            movables[0] = new Car("KIA", "XY1235");
            movables[1] = new Bike("YAMAHA", "X123");
            movables[2] = new Bike("RE", "A321");
            Race(movables);
        }

        static void Race(IMovable[] movable)
        {
            Console.WriteLine("Start Racing.....");
            foreach (IMovable x in movable)
            {
                x.Move();

            }

            Console.WriteLine("Race Ending....");
        }
    }
}
