using System.Runtime.CompilerServices;

namespace Composite_Design_Pattern
{
    public class Bildschirm : IComponent
    {
        private string Marke { get; set; }
        private string Model { get; set; }
        private string Size { get; set; }

        public Bildschirm(string marke, string model, string size)
        {
            Marke = marke;
            Model = model;
            Size = size;
        }

        public void Operation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"[Bildschirm]: Marke: {Marke}, Model: {Model}, Size: {Size}";
        }
    }
}
