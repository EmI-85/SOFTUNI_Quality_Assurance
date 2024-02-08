int number = int.Parse(Console.ReadLine());

int tempNum = number;
bool isSpecialNum = true;

while (tempNum > 0)
{
    int currentLastDigit = tempNum % 10;
    
    if (tempNum % currentLastDigit != 0)
    {
        isSpecialNum = false;
        break;
    }
    tempNum = tempNum / 10;

    if (isSpecialNum)
    {
        Console.WriteLine($"{number} is special");
    }
    else
    {
        Console.WriteLine($"{number} is not special");
    }
}

