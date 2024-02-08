int number = int.Parse(Console.ReadLine());
int startNumber = number;

while (startNumber > 0)
{
    int lastDigit = startNumber % 10;
    startNumber = startNumber / 10;
    if (number % lastDigit != 0)
    {
        Console.WriteLine($"{number} is not special");
        break;
    }
    if (startNumber == 0)
    {
        Console.WriteLine($"{number} is special");
        break;
    }

}