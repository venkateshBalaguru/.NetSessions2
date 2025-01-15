using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithEnumColour.Models
{
    class Rectangle
    {
        //fields
        private int _width;
        private int _height;
        private Colours _colour;
        private const int MAX_VALUE = 100;
        private const int MIN_VALUE = 1;

        //properties for Area of Rectangle
        public int Area
        {
            get
            {
                return _width * _height;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = IsValidate(value);
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = IsValidate(value);
            }
        }

        public Colours Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }

        //Method for Area of Rectangle
        public int CalculatedArea()
        {
            return _width * _height;
        }

        private int IsValidate(int value)
        {
            if (value < MIN_VALUE)
            {
               return value = MIN_VALUE;
            }
            if (value > MAX_VALUE)
            {
                return value = MAX_VALUE;
            }
            return value;
        }
    }
}
