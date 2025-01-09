using EncapsulationRectangleApp.Models;
using System;

class RectangleTest
{
    static void Main()
    {
        Rectangle rectangle1 = new Rectangle();
        rectangle1.SetWidth(120);  //setting the value of width and checking the condition in the setter method the value is greater than 100
        Console.WriteLine($"widht is {rectangle1.GetWidth()}");


        rectangle1.SetHeight(-10); //setting the value of height and checking the condition in the setter method the value is less than 0
        Console.WriteLine($"height is {rectangle1.GetHeight()}");
        Console.WriteLine("Area is " + rectangle1.CalculatedArea());


        Rectangle rectangle2 = new Rectangle();
        rectangle2.SetHeight(10);
        rectangle2.SetWidth(20);
        rectangle2.CalculatedArea();
        Console.WriteLine("Area of Rectangle is: " + rectangle2.CalculatedArea()+"==> width is " + rectangle2.GetWidth() + " Height is " + rectangle2.GetHeight());

    }
}