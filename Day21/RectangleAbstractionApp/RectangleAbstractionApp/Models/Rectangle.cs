namespace RectangleAbstractionApp.Models
{
    class Rectangle
    {
        public int height;
        public int width;
        public int CalculatedArea()
        {
            return height * width;
        }
    }
}