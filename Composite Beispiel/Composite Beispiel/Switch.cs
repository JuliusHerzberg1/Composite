using Composite_Design_Pattern;

namespace Composite_Beispiel
{
    public class Switch : Component
    {
        private string Name { get; set; }
        private string Brand { get; set; }

        public Switch(string name, string brand) {
            Name = name;
            Brand = brand;
        }

        public override void Operation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"[Switch]: Name: {Name}, Brand: {Brand}";
        }
    }
}
