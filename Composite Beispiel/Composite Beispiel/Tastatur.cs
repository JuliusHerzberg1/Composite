using System.Runtime.CompilerServices;

namespace Composite_Design_Pattern
{
    public class Tastatur : IComponent
    {
        private string Marke { get; set; }
        private string Name { get; set; }
        private string Layout { get; set; }
        private string Size { get; set; }

        public Tastatur(string marke, string name, string layout, string size)
        {
            Marke = marke;
            Name = name;
            Layout = layout;
            Size = size;
        }

        public void Operation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"[Tastatur]: Marke: {Marke}, Name: {Name}, Layout: {Layout}, Size: {Size}";
        }
    }
}
