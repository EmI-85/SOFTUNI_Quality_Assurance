int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegetarianMenus = int.Parse(Console.ReadLine());

double menusPrice = chickenMenus * 10.35 + fishMenus * 12.40 + vegetarianMenus * 8.15;
double dessertPrice = menusPrice * 0.20;
double deliveryPrice = 2.50;

double totalAmount = menusPrice + dessertPrice + deliveryPrice;

Console.WriteLine(totalAmount);

