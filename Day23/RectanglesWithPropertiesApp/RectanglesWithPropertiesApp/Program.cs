using RectanglesWithPropertiesApp.Models;
using System;

namespace RectanglesWithPropertiesApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle r4 = new Rectangle();
            r4.Width = 10;
            r4.Height = 20;
            //r4.BorderStyle = "RRD"; //This is a BorderStyle Property in string type, the user can enter any value, but we have only three predefined values
                                      //This is not a valid border style, because we have predefined border styles in properties if user enters any other
                                      //value it is changed to default value. the user can't understand why the value is changing
            r4.BorderStyle = BorderOptions.Single; //This is a BorderStyle Property in enum type, the user can enter only predefined values in the enum it will display 
            //Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}, Area: {rectangle.Area}, Border Style: {rectangle.BorderStyle}");
            //PrintDetails("r4 rectangel", r4);//We printing the details of r4 rectangle only by calling the PrintDetails method

            Rectangle r1 = new Rectangle();
            r1.Width = 20;
            r1.Height = 20;
            r1.BorderStyle = BorderOptions.Dotted;
            //PrintDetails("r1 rectangel", r1);

            Rectangle r2 = new Rectangle();
            r2.Width = 30;
            r2.Height = 20;
            r2.BorderStyle = BorderOptions.Single;
            //PrintDetails("r2 rectangel", r2);


            Rectangle r3 = new Rectangle();
            r3.Width = 40;
            r3.Height = 20;
            r3.BorderStyle = BorderOptions.Double;
            //PrintDetails("r3 rectangel", r3);
            Console.WriteLine("count"+ Rectangle.count); //To find the count of objects in a class we have create a default constructor with count field in a static


            Rectangle[] manyRectangles = new Rectangle[4];
            manyRectangles[0] = r1;
            manyRectangles[1] = r2;
            manyRectangles[2] = r3;
            manyRectangles[3] = r4;

            PrintDetails(manyRectangles);//We printing the details of all rectangles by calling the PrintDetails method
            Console.WriteLine("Checking the Foreground and Background color reset");
        }

        private static void PrintDetails(Rectangle[] manyRectangles) //This method is used to print the details of all rectangles
        {
            for (int i = 0; i < manyRectangles.Length; i++)
            {
                PrintDetails("r" + (i+1) + "", manyRectangles[i]);
            }
        }
             private static void PrintDetails(string details, Rectangle rectangle)//This method is used to print the details of a rectangle by passing the rectangle object one by one
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; //This will change the foreground color to DarkGreen
            //Console.BackgroundColor = ConsoleColor.White; //This will change the background color to White
            Console.WriteLine("printing details of :" + details);
            Console.WriteLine($"Width {rectangle.Width} , Height is {rectangle.Height}, Area is {rectangle.Area} ,Border_Style is {rectangle.BorderStyle}");
            Console.WriteLine("Foreground color is " + Console.ForegroundColor); //This will print the current foreground color
            Console.WriteLine("Background color is " + Console.BackgroundColor); //This will print the current background color
            Console.WriteLine();
            Console.ResetColor(); //This will reset the foreground and background color to default after the printDetails method is executed

        }
    }
    }
