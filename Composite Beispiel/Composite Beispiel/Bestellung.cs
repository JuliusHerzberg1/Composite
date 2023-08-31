namespace Composite_Design_Pattern
{
    public class Bestellung : IComponent
    {
        private string ID;
        private List<IComponent> components = new List<IComponent>();

        public Bestellung() {
            var nmbrs = "0123456789";
            var id = "";
            
            for(int i = 0; i < nmbrs.Length; i++)
            {
                id+= nmbrs[Random.Shared.Next(0, nmbrs.Length)];
            }
            ID = id;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void Operation()
        {
            Console.WriteLine($"Bestellung {ID}");
            foreach (IComponent component in components)
            {
                component.Operation();
            }
        }
    }
}
