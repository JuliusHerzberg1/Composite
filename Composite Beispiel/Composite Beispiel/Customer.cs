namespace Composite_Design_Pattern
{
    public class Customer : Component
    {
        public string Name;
        public string Address;

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override void Operation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"[Customer]: Name: {Name}, Address: {Address}";
        }
    }
}
