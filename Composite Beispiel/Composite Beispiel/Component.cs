namespace Composite_Design_Pattern
{
    public abstract class Component
    {
        public abstract void Operation();

        public List<Component> Components { get; set; } = new List<Component>();
    }
}
