namespace Composite_Design_Pattern
{
    public class Screen : Component
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }

        public Screen(string brand, string model, string size)
        {
            Brand = brand;
            Model = model;
            Size = size;
        }

        public override void Operation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"[Screen]: Brand: {Brand}, Model: {Model}, Size: {Size}";
        }
    }
}
