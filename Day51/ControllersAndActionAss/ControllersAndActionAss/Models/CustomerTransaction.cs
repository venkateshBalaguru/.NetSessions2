namespace ControllersAndActionAss.Models
{
    public class CustomerTransaction
    {
        public int AccountId { get; set; }
        public string Name { get; set; } = "";
        //public string Address { get; set; }
       // public List<string> TransactionType { get; set; } = new List<string>();
        public string City { get; set; } = "";
        public double Balance { get; set; }

        public CustomerTransaction(int accountId, string name, string city,double balance)
        {
            AccountId = accountId;
            Name = name;
            //TransactionType = transactionType;
            City = city;
            Balance = balance;
        }

    }
}
