int balance = int.Parse(Console.ReadLine());
int withdrawalAmount = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

if (withdrawalAmount > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else
{
    if (withdrawalAmount <= balance)
    {
        Console.WriteLine("The withdraw was successful.");
    }
    else
    {
        Console.WriteLine("Insufficient availability.");
    }
}