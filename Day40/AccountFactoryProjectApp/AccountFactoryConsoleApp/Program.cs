using AccountFactoryCommonLib.Services;

namespace AccountFactoryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountFactory factory = new AccountFactory();

            IAccount savingsaccount = factory.CreateAccount(AccountType.Saving);
            savingsaccount.AccountType();

            IAccount currentaccount = factory.CreateAccount(AccountType.Current);
            currentaccount.AccountType();

        }
    }
}