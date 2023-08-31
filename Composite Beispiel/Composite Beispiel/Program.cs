using Composite_Design_Pattern;
using System.Net;
using System.Xml.Linq;

// Class for customers
class Customer2
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Customer2(string name, string address)
    {
        Name = name;
        Address = address;
    }
}

// Class for screens
class Screen2
{
    public string Manufcaturer { get; set; }
    public string Model { get; set; }
    public string Size { get; set; }

    public Screen2(string manufacturer, string model, string size)
    {
        Manufcaturer = manufacturer;
        Model = model;
        Size = size;
    }
}

// Class for keyboards
class Keyboard2
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Layout { get; set; }
    public string Size { get; set; }

    public Keyboard2(string hersteller, string modell, string layout, string groesse)
    {
        Manufacturer = hersteller;
        Model = modell;
        Layout = layout;
        Size = groesse;
    }
}

class OrderWithoutComposite
{
    //Difference:
    public List<Screen2> Screens { get; set; }
    public List<Keyboard2> Keyboards { get; set; }

    public Customer2 Customer;
    public string ID;

    public OrderWithoutComposite()
    {
        var nmbrs = "0123456789";
        var id = "";

        for (int i = 0; i < nmbrs.Length; i++)
        {
            id += nmbrs[Random.Shared.Next(0, nmbrs.Length)];
        }
        ID = id;
        Screens = new List<Screen2>();
        Keyboards = new List<Keyboard2>();
    }

    //Difference
    public void Operation()
    {
        Console.WriteLine($"Order {ID}");
        Console.WriteLine($"[Customer]: Name: {Customer.Name}, Adresse: {Customer.Address}");
        Console.WriteLine("Screens:");
        foreach (var screens in Screens)
        {
            Console.WriteLine(screens.Manufcaturer + " " + screens.Model + " " + screens.Size);
        }
        Console.WriteLine("Keyboards:");
        foreach (var tastatur in Keyboards)
        {
            Console.WriteLine(tastatur.Manufacturer + " " + tastatur.Model + " " + tastatur.Layout + " " + tastatur.Size);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Composite example
        var bestellung = new Order();

        bestellung.AddComponent(new Customer("Deniss Cutie", "Under the bridge 13"));

        bestellung.AddComponent(new Screen("Acer", "QG240YH3", "23,8 inches"));
        bestellung.AddComponent(new Screen("Acer", "QG240YH3", "23,8 inches"));
        bestellung.AddComponent(new Screen("Hp", "P34hc ", "34 inches"));

        bestellung.AddComponent(new Keyboard("Sharkoon", "SKILLER SGK5", "DE", "100%"));
        bestellung.AddComponent(new Keyboard("Logitech", "MK270", "US", "100%"));
        bestellung.AddComponent(new Keyboard("HyperX", "Alloy", "US", "60%"));

        bestellung.Operation();

        Console.WriteLine("");

        //negative example
        var bestellung2 = new OrderWithoutComposite();
        bestellung2.Customer = new Customer2("Deniss Cutie", "Under the bridge 13");

        bestellung2.Screens.Add(new Screen2("Acer", "QG240YH3", "23,8 inches"));
        bestellung2.Screens.Add(new Screen2("Acer", "QG240YH3", "23,8 inches"));
        bestellung2.Screens.Add(new Screen2("Hp", "P34hc ", "34 inches"));

        bestellung2.Keyboards.Add(new Keyboard2("Sharkoon", "SKILLER SGK5", "DE", "100%"));
        bestellung2.Keyboards.Add(new Keyboard2("Logitech", "MK270", "US", "100%"));
        bestellung2.Keyboards.Add(new Keyboard2("HyperX", "Alloy", "US", "60%"));

        bestellung2.Operation();
    }
}