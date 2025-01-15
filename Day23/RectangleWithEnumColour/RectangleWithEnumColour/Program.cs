using RectangleWithEnumColour.Models;
using System;

namespace RectangleWithEnumColour

{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Width = 10;
            rect1.Height = 20;
            rect1.Colour = Colours.Red;

            Rectangle rect2 = new Rectangle();
            rect2.Width = 10;
            rect2.Height = 220;
            rect2.Colour = Colours.Blue;

            Rectangle rect3 = new Rectangle();
            rect3.Width = 110;
            rect3.Height = 20;
            rect3.Colour = Colours.Green;

            Rectangle[] rects = new Rectangle[3] { rect1, rect2, rect3 };

            PrintDetails(rects);
            //Console.WriteLine("Checking the Foreground color isChanging?");//We reset the foreground color to the default color in the printdetails method
            BiggestRectangle(rects);
        }
        public static void PrintDetails(Rectangle[] rects)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < rects.Length; i++)
            {
                Console.WriteLine($"Rectangle {i + 1}");
                Console.WriteLine($"Width: {rects[i].Width}");
                Console.WriteLine($"Height: {rects[i].Height}");
                Console.WriteLine($"Area: {rects[i].Area}");
                Console.WriteLine($"Colour: {rects[i].Colour}");
                Console.WriteLine();
                
            }
            Console.ResetColor();
        }
        static void BiggestRectangle(Rectangle[] rectangles)
        {
            int maxArea = 0;
            int rectangleIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Area > maxArea)
                {
                    maxArea = rectangles[i].Area;
                    rectangleIndex = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("The biggest rectangle is Rectangle {0} with area = {1}", rectangleIndex + 1, maxArea);
            Console.ResetColor();
        }
    }
}
