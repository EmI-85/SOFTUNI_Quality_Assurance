string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double finalPrice = GetFinalPrice(product, quantity);
Console.WriteLine($"{finalPrice:F2}");

static double GetFinalPrice(string p, int q)
{
    double itemPrice = 0;

    if(p == "coffee")
    {
        itemPrice = 1.50;
    }
    else if (p == "water")
    {
        itemPrice = 1.00;
    }
    else if (p == "coke")
    {
        itemPrice = 1.40;
    }
    else if (p == "snacks")
    {
        itemPrice = 2.00;
    }
    return itemPrice * q;
}
