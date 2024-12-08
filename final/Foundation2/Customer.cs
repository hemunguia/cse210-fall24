namespace OnlineOrdering
{
    public class Customer
    {
        public string Name { get; private set; }
        private Address Address { get; set; }

        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public bool LivesInUSA()
        {
            return Address.IsInUSA();
        }

        public Address GetAddress()
        {
            return Address;
        }
    }
}
