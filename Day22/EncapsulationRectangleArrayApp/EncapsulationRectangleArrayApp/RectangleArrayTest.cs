using EncapsulationRectangleArrayApp.Models;
using System;
class RectangleArrayTest
{
        static void Main(string[] args)
        {
            RectangleArray[] rectangles = new RectangleArray[3];
            rectangles[0] = new RectangleArray();
            rectangles[0].SetHeight(10);
            rectangles[0].SetWidth(20);
            rectangles[0].SetColor("red");
        Console.WriteLine("Rectangle 1: Height = {0}, Width = {1}, Area = {2}, Color = {3}", rectangles[0].GetHeight(), rectangles[0].GetWidth(), rectangles[0].CalculatedAread(), rectangles[0].GetColor());

        rectangles[1] = new RectangleArray();
        rectangles[1].SetHeight(30);
        rectangles[1].SetWidth(40);
        rectangles[1].SetColor("green");
        Console.WriteLine("Rectangle 2: Height = {0}, Width = {1}, Area = {2}, Color = {3}", rectangles[1].GetHeight(), rectangles[1].GetWidth(), rectangles[1].CalculatedAread(), rectangles[1].GetColor());


        rectangles[2] = new RectangleArray();
        rectangles[2].SetHeight(50);
        rectangles[2].SetWidth(60);
        rectangles[2].SetColor("yellow");
        Console.WriteLine("Rectangle 3: Height = {0}, Width = {1}, Area = {2}, color = {3}", rectangles[2].GetHeight(), rectangles[2].GetWidth(), rectangles[2].CalculatedAread(), rectangles[2].GetColor());

        BiggestRectangle(rectangles);
    }

    static void BiggestRectangle(RectangleArray[] rectangles)
    {
        int maxArea = 0;
        int rectangleIndex = 0;
        for (int i = 0; i < rectangles.Length; i++)
        {
            if (rectangles[i].CalculatedAread() > maxArea)
            {
                maxArea = rectangles[i].CalculatedAread();
                rectangleIndex = i;
            }
        }
       Console.WriteLine("The biggest rectangle is Rectangle {0} with area = {1}", rectangleIndex + 1, maxArea);
    }
}

