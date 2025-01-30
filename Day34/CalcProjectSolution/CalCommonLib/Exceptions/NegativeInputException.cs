namespace CalCommonLib.Exceptions
{
    [Serializable]
    public class NegativeInputException : Exception
    {
        private int firstNo;
        private int secondNo;
        public NegativeInputException(int firstNo, int secondNo)
        {
            this.firstNo = firstNo;
            this.secondNo = secondNo;
        }

        public override string Message
        {
            get
            {
                if (firstNo < 0 && secondNo < 0)
                    return $"The given both number is {firstNo} , {secondNo} in negative we support only positive number";
                else if (firstNo < 0)
                    return $"The given number is {firstNo} in negative we support only positive number";
                else if (secondNo < 0)
                    return $"The given number is {secondNo} in negative we support only positive number";
                else
                    return base.Message;
            }
        }
    }
}