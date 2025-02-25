namespace ControllersAndActionAss.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string City { get; set; } = "";
        public List<string> Address { get; set; } = new List<string>();

    }
}