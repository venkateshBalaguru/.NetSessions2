
namespace EncapsulationRectangleApp.Models
{
    class Rectangle
    {
        private int height;
        private int width;

        public int CalculatedArea()
        {
            return height * width;
        }

        public void SetHeight(int pHeight)//setting the Value from the object to the private variable using the public method(setter/wirter)
        {
            if (pHeight < 0)
            {
                height = 1;
            }
            else if (pHeight > 100)
            {
                height = 100;
            }
            else
            {
                height = pHeight;
            }
        }

        public void SetWidth(int pWidth)//setting the Value from the object to the private variable using the public method(setter/wirter)
        {
            if (pWidth < 0)
            {
                width = 1;
            }
            else if (pWidth > 100)
            {
                width = 100;
            }
            else
            {
                width = pWidth;
            }
        }

        public int GetWidth() //getting the value from the private variable to the object using the public method(getter/reader)
        {
            return width;
        }
        public int GetHeight() //getting the value from the private variable to the object using the public method(getter/reader)
        {
            return height;
        }
    }
}
