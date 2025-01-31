using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBMICommonLib.Models
{
    public class HumanBeing
    {
        private string _name;
        private int _age;
        private GenderOption _gender;
        //private string _gender;
        private double _weight;
        private double _height;
        private double _bmi;
        private double _inchToMeterHeight;


        public HumanBeing(string name, int age, GenderOption gender, double weight, double height)
        {
            _name = name;
            _age = age;
            //_gender = (Gender)Enum.Parse(typeof(Gender), gender);
            _gender = gender;
            _weight = weight;
            _height = height;
            
        }

        public string Name { get { return _name; } }

        public int Age { get { return _age; } }
       // public Gender Gender {  get { return _gender; } }
       public GenderOption Gender 
        { 
            get
            { 
                return _gender; 
            }
        }

        public double Height { get { return _height; } }
        public double Weight { get { return _weight; } }

        public void Eat()
        {
            if (_gender == GenderOption.Male)
            {
                _weight = _weight + _weight * .20;
            }
            else
                _weight = _weight + _weight * .10;

        }

        public void WorkOut()
        {
            if (_gender == GenderOption.Male)
            {

                _weight = _weight + _weight * .05;
                _height = _height + _height * .02;
            }
            else
            {
                _weight = _weight + _weight * .10;
                _height = _height + _height * .04;
            }
        }

        public double BMI()
        {
            if (_height > 8 || _height < 0 )
            {
                throw new NotARightHeightException(this);
            }
            else
            {
                _inchToMeterHeight = _height / 3.281;
                _bmi = _weight / (_inchToMeterHeight * _inchToMeterHeight);
                return Math.Round(_bmi);
            }
        }

        public string GetBodyStructure()
        {
            if (_bmi <= 18.5) { return "Under Weight"; }
            else if (_bmi > 18.5 && _bmi <= 24.9) { return "Normal Weight"; }
            else if (_bmi > 24.9 && _bmi <= 29.9) { return "Over Weight"; }
            else { return "Very Fat"; }
        }

            
    }
}
