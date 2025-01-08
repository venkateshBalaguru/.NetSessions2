namespace AbstractionCircleApp.shapes
{
    class CircleShape
    {
        static void Main()
        {
            Circle circle1 = new Circle();
            circle1.radius = 5;
            circle1.calculateArea();
            Console.WriteLine("The radius is " + circle1.radius + " Area of circle1: " + circle1.calculateArea());

            Circle circle2 = new Circle();
            circle2.radius = 50;
            circle2.calculateArea();
            Console.WriteLine("The radius is " + circle2.radius + " Area of circle1: " + circle2.calculateArea());

        }
    }

}