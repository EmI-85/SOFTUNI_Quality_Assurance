int n = int.Parse(Console.ReadLine());

PrintNumber(n);

static void PrintNumber(int number)
{
    if(number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }

}