string command = Console.ReadLine();

double accountBalance = 0;

while(command != "End")
{
    double money = double.Parse(command); 
    if (money >= 0)
    {
        accountBalance += money;
        Console.WriteLine($"Increase: {money:F2}");
    }
    else if (money < 0)
    {
        accountBalance -= Math.Abs(money);
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }
    command = Console.ReadLine();
}

Console.WriteLine($"Balance: {accountBalance:F2}");