using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationRectangleArrayApp.Models
{
     class RectangleArray
    {
        private int _height;
        private int _width;
        private string _color;
        private const int MAX_DIMENSION= 100;
        private const int MIN_DIMENSION = 1;

        public int CalculatedAread()
        {
            return _height * _width;
        }

        public void SetHeight(int pheight)
        {
            if (pheight < 0)
            {
                pheight = MIN_DIMENSION;
                _height = pheight;
            }
            

            if (pheight > 100)
            {
                pheight = MAX_DIMENSION;
                _height = pheight;
            }
            _height = pheight;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetWidth(int pwidth)
        {
          _width = CheckDimension(pwidth);
        }

        public int GetWidth()
        {
            return _width;
        }

        public string SetColor(string pcolor)
        {
            if (pcolor == "red" || pcolor == "green" || pcolor == "blue")
            {
               return _color = pcolor;
            }
           return _color = "red"; //default color
         }

        public string GetColor()
        {
            return _color;
        }

        public int CheckDimension(int dimension)
        {
            if (dimension < 0)
            {
                return MIN_DIMENSION;
            }
            if (dimension > 100)
            {
                return MAX_DIMENSION;
            }
            return dimension;
        }

    }
}
