using Composite_Beispiel;
using Composite_Design_Pattern;

class Keyboard2
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Layout { get; set; }
    public string Size { get; set; }
    public List<Switch> Switches { get; set; }

    public Keyboard2(string manufacturer, string model, string layout, string size)
    {
        Manufacturer = manufacturer;
        Model = model;
        Layout = layout;
        Size = size;
        Switches = new List<Switch>();
    }
}

class OrderWithoutComposite
{
    public string ID;
    public Customer Customer { get; set; }
    public List<Screen> Screens { get; set; }
    public List<Keyboard2> Keyboards { get; set; }

    public OrderWithoutComposite(Customer customer)
    {
        var nmbrs = "0123456789";
        var id = "";

        for (int i = 0; i < nmbrs.Length; i++)
        {
            id += nmbrs[Random.Shared.Next(0, nmbrs.Length)];
        }
        ID = id;
        Customer = customer;
        Screens = new List<Screen>();
        Keyboards = new List<Keyboard2>();
    }

    public void Operation()
    {
        Console.WriteLine($"Order {ID}");
        Console.WriteLine(Customer.ToString());
        foreach (var screen in Screens)
        {
            Console.WriteLine($"[Screen]: Brand: {screen.Brand}, Model: {screen.Model}, Size: {screen.Size}");
        }
        foreach (var keyboard in Keyboards)
        {
            Console.WriteLine($"[Keyboard]: Brand: {keyboard.Manufacturer}, Model: {keyboard.Model}, Layout: {keyboard.Layout}, Size: {keyboard.Size}");
            if(keyboard.Switches.Count > 0)
            {
                foreach (var switchName in keyboard.Switches)
                {
                    Console.WriteLine($"[Switch]: {switchName}");
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Composite example
        var order = new Order();

        order.AddComponent(new Customer("Deniss Cutie", "Under the bridge 13"));

        order.AddComponent(new Screen("Acer", "QG240YH3", "23,8 inches"));
        order.AddComponent(new Screen("Acer", "QG240YH3", "23,8 inches"));
        order.AddComponent(new Screen("Hp", "P34hc ", "34 inches"));

        var keyboard = new Keyboard("Sharkoon", "SKILLER SGK5", "DE", "100%");
        keyboard.Components.Add(new Switch("Red BX", "Cherry"));
        keyboard.Components.Add(new Switch("Purple CX", "Cherry"));

        order.AddComponent(keyboard);
        order.AddComponent(new Keyboard("Logitech", "MK270", "US", "100%"));
        order.AddComponent(new Keyboard("HyperX", "Alloy", "US", "60%"));

        order.Operation();

        Console.WriteLine("");

        //Negative example
        var order2 = new OrderWithoutComposite(new Customer("Deniss Cutie", "Under the bridge 13"));

        order2.Screens.Add(new Screen("Acer", "QG240YH3", "23,8 inches"));
        order2.Screens.Add(new Screen("Acer", "QG240YH3", "23,8 inches"));
        order2.Screens.Add(new Screen("Hp", "P34hc ", "34 inches"));

        var keyboard1 = new Keyboard2("Sharkoon", "SKILLER SGK5", "DE", "100%");
        keyboard1.Switches.Add(new Switch("Red BX", "Cherry"));
        keyboard1.Switches.Add(new Switch("Purple CX", "Cherry"));
        order2.Keyboards.Add(keyboard1);

        order2.Keyboards.Add(new Keyboard2("Logitech", "MK270", "US", "100%"));
        order2.Keyboards.Add(new Keyboard2("HyperX", "Alloy", "US", "60%"));

        order2.Operation();
    }
}