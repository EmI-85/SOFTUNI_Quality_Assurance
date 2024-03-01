int num = int.Parse(Console.ReadLine());

while (num > 0)
{
    int currentElement = num % 10;

    if (currentElement == 1)
    {
        Console.WriteLine("one");
    }
    else if (currentElement == 2)
    {
        Console.WriteLine("two");
    }
    else if (currentElement == 3)
    {
        Console.WriteLine("three");
    }
    else if (currentElement == 4)
    {
        Console.WriteLine("four");
    }
    else if (currentElement == 5)
    {
        Console.WriteLine("five");
    }
    else if (currentElement == 6)
    {
        Console.WriteLine("six");
    }
    else if (currentElement == 7)
    {
        Console.WriteLine("seven");
    }
    else if (currentElement == 8)
    {
        Console.WriteLine("eight");
    }
    else if (currentElement == 9)
    {
        Console.WriteLine("nine");
    }
    num /= 10;
}
