namespace RectangleAbstractionApp.Models
{
    class Rectangle
    {
        public int height; //if we use public we can use the fields out of the class
        public int width;
        public int CalculatedArea()
        {
            return height * width;
        }
    }
}