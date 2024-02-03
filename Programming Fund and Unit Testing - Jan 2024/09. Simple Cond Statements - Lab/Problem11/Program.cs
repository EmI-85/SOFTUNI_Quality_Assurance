string drinkName = Console.ReadLine();  
string extra = Console.ReadLine();
double price = 0;

if (drinkName == "coffee")
{
    price = 1;
}

else if (drinkName == "tea")
{
    price = 0.60;
}

if (extra == "sugar")
{
    price += 0.40;
}


Console.WriteLine($"Final price: ${price:F2}");
