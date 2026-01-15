using hulisajeDP4;

var factory = new ConcreteMenuFactory();

var hlavniMenu = (SubMenuItem)factory.CreateMenuItem("Hlavní menu");

hlavniMenu.Add(factory.CreateMenuItem("Nový soubor", () => Console.WriteLine("Soubor vytvořen")));
hlavniMenu.Add(factory.CreateMenuItem("Otevřít soubor", () => Console.WriteLine("Soubor otevřen")));

var nastaveni = (SubMenuItem)factory.CreateMenuItem("Nastavení");
nastaveni.Add(factory.CreateMenuItem("Zvuk", () => Console.WriteLine("Zvuk nastaven")));
nastaveni.Add(factory.CreateMenuItem("Obrazovka", () => Console.WriteLine("Obrazovka nastavena")));

hlavniMenu.Add(nastaveni);

var pokrocile = (SubMenuItem)factory.CreateMenuItem("Pokročilé");
var debug = (SubMenuItem)factory.CreateMenuItem("Debug");
debug.Add(factory.CreateMenuItem("Logování", () => Console.WriteLine("Logování aktivováno")));
pokrocile.Add(debug);

hlavniMenu.Add(pokrocile);

hlavniMenu.Show();

Console.ReadLine();