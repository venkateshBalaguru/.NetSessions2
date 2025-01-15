using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGameWithOOP.Models
{
    class Game
    {
        private string _playerName;
        private int _inputNo;
       
        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public int InputNo
        {
            get { return _inputNo; }
            set { _inputNo = value; }
        }

        public bool IsCorrect(int gNo, int userNo) //Checking the number with Actual number and Guessing number
        {
            if (gNo == userNo)
            {
                return true;
            }
            return false;
        }
    }
}
