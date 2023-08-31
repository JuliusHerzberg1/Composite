namespace Composite_Design_Pattern
{
    public class Order : Component
    {
        private string ID;
        private List<Component> components = new List<Component>();

        public Order() {
            var nmbrs = "0123456789";
            var id = "";
            
            for(int i = 0; i < nmbrs.Length; i++)
            {
                id+= nmbrs[Random.Shared.Next(0, nmbrs.Length)];
            }
            ID = id;
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }

        public override void Operation()
        {
            Console.WriteLine($"Order {ID}");
            foreach (Component component in components)
            {
                component.Operation();
            }
        }
    }
}
