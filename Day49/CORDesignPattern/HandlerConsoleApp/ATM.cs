using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using CORCommonLib.Models;

namespace HandlerConsoleApp
{
    // This class managed the sequence in which all the handlers are going to be chained together
    // This class initiates the request to a ConcreteHandler object on the chain
    public class ATM
    {
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();
        public ATM()
        {
            // Prepare the chain of Handlers
            // Here, we need to set the next handler of each handler
            fiveHundredHandler.SetNextHandler(twoHundredHandler);
            twoHundredHandler.SetNextHandler(hundredHandler);
        }
        //The following method handle the request and passes it to the first handler in the chain of responsibility.
        public void Withdraw(long requestedAmount)
        {
            //First check whether the amount is Divisible by 100 or not
            if (requestedAmount % 100 == 0)
            {
                Console.WriteLine(fiveHundredHandler.DispatchNote(requestedAmount));
            }
            else
            {
                Console.WriteLine($"You Enter Invalid Amount(Amount should be Multiply of Hundred): {requestedAmount}");
            }
        }
    }
}