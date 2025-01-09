using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationRectangleREfactorApp.Models
{
     class Rectangle
    {
        private int _height; //for private fields, use underscore before the variable name
        private int _width;
        private const int MIN_DIMENSION = 1; //for constants, use all caps and underscore between words
        private const int MAX_DIMENSION = 100;

        public int CalculateArea()
        {
            return _height * _width;
        }

        public void SetWidth(int pwidth) //setter or writer
        {

            _width = CorrectTheDimension(pwidth);
        }


        public int GetWidth()//getter or reader
        {
            return _width;
        }

        public void SetHeight(int pheight)
        {
            _height = CorrectTheDimension(pheight);
        }
        public int GetHeight()
        {
            return _height;
        }

        private int CorrectTheDimension(int dimension) //check if the dimension is within the range
        {
            if (dimension < MIN_DIMENSION)
            {
                return MIN_DIMENSION;
            }

            if (dimension > MAX_DIMENSION)
            {
                return MAX_DIMENSION;
            }

            return dimension;

        }



    }
}