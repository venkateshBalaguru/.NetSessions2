using System;
using System.Security.Cryptography;

namespace RectanglesWithPropertiesApp.Models
{
    class Rectangle
    {
        //fields

        private int _width;
        private int _height;
        private BorderOptions _borderStyle;

        private const int MIN_DIMENSION = 1;
        private const int MAX_DIMENSION = 100;





        //properties

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = CorrectTheDimension(value);  //value is a keyword that represents the value being assigned to the property

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
                _height = CorrectTheDimension(value);
            }

        }

        public int Area
        {

            get
            {
                return _width * _height;
            }
        }

        //Border style in properties (It is in string type the user can enter any value anyway we can set default value the user can't understand why the value is changing)
        //public string BorderStyle
        //{
        //    get
        //    {
        //        return _borderStyle;
        //    }
        //    set
        //    {
        //        if (value == "Single" || value == "Double" || value == "Dotted" || value == "Dashed")
        //        {
        //            _borderStyle = value;
        //        }
        //        else
        //        {

        //            _borderStyle = "Single";
        //        }
        //    }
        //}

        //The properties in enum type (It is in enum type the user can enter only predefined values in the enum it will display)
        public BorderOptions BorderStyle
        {
            get
            {
                return _borderStyle;
            }
            set
            {
                _borderStyle = value;   
            }
    }
        //Methods

        private int CorrectTheDimension(int dimension)
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