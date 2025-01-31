using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBMICommonLib.Models
{
    public class NotARightHeightException : Exception
    {
        private HumanBeing _human;

        public NotARightHeightException(HumanBeing human)
        {
            _human = human;
        }

        public override string Message
        {
            get { return $"Name : {_human.Name} : Your Height is not in Correct Number {_human.Height} give right format (1 to 8)."; }
        }

    }
}
   