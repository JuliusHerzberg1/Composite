namespace Composite_Design_Pattern
{
    public class Kunde : IComponent
    {
        private string Name;
        private string Adresse;

        public Kunde(string name, string adresse)
        {
            Name = name;
            Adresse = adresse;
        }

        public void Operation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"[Kunde]: Name: {Name}, Adresse: {Adresse}";
        }
    }
}
