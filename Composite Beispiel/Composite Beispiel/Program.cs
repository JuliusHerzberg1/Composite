using Composite_Design_Pattern;

var bestellung = new Bestellung();

bestellung.AddComponent(new Kunde("Deniss Cutie", "Unter der Brücke 13"));

bestellung.AddComponent(new Bildschirm("Acer", "QG240YH3", "23,8 Zoll"));
bestellung.AddComponent(new Bildschirm("Acer", "QG240YH3", "23,8 Zoll"));
bestellung.AddComponent(new Bildschirm("Hp", "P34hc ", "34 Zoll"));

bestellung.AddComponent(new Tastatur("Sharkoon", "SKILLER SGK5", "DE", "100%"));
bestellung.AddComponent(new Tastatur("Logitech", "MK270", "US", "100%"));
bestellung.AddComponent(new Tastatur("HyperX", "Alloy", "US", "60%"));

bestellung.Operation();