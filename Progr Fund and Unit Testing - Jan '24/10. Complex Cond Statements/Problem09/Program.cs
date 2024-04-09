string ticketType = Console.ReadLine(); 
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());


double price = 0;

if(ticketType == "Premiere")
{
    price = 12.00;
}
else if (ticketType == "Normal")
{
    price = 7.50;
}
else if (ticketType == "Discount")
{
    price = 5.00;
}

double totalPrice = rows * columns * price;

Console.WriteLine($"{totalPrice:F2}");