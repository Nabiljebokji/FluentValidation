namespace Validating.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Address Address { get; set; }
    }
    public class Order
    {
        public double Total { get; set; }

    }
    public class Address
    {
        public string Line1 { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }
}
