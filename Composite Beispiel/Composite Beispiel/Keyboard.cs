namespace Composite_Design_Pattern
{
    public class Keyboard : Component
    {
        private string Brand { get; set; }
        private string Name { get; set; }
        private string Layout { get; set; }
        private string Size { get; set; }

        public Keyboard(string brand, string name, string layout, string size)
        {
            Brand = brand;
            Name = name;
            Layout = layout;
            Size = size;
        }

        public override void Operation()
        {
            Console.WriteLine(this.ToString());
            foreach(Component component in this.Components)
            {
                component.Operation();
            }
        }

        public override string ToString()
        {
            return $"[Keyboard]: Brand: {Brand}, Name: {Name}, Layout: {Layout}, Size: {Size}";
        }
    }
}
