string season = Console.ReadLine();
string accommodationType = Console.ReadLine();  
int daysCount = int.Parse(Console.ReadLine());

double pricePernight = 0;
double discount = 0;


if(season == "Spring")
{
    discount = 1 - 0.20;

    if(accommodationType == "Hotel")
    {
        pricePernight = 30;
    }
    else if(accommodationType == "Camping")
    {
        pricePernight = 10;
    }
}
else if (season == "Summer")
{
    discount = 1 - 0.00;

    if (accommodationType == "Hotel")
    {
        pricePernight = 50;
    }
    else if (accommodationType == "Camping")
    {
        pricePernight = 30;
    }
}
else if (season == "Autumn")
{
    discount = 1 - 0.30;

    if (accommodationType == "Hotel")
    {
        pricePernight = 20;
    }
    else if (accommodationType == "Camping")
    {
        pricePernight = 15;
    }
}
else if (season == "Winter")
{
    discount = 1 - 0.10;

    if (accommodationType == "Hotel")
    {
        pricePernight = 40;
    }
    else if (accommodationType == "Camping")
    {
        pricePernight = 10;
    }
}

double totalCost = pricePernight * daysCount * discount;

Console.WriteLine($"{totalCost:F2}");
