string input = Console.ReadLine();


while(input != "End")
{
    int number = int.Parse(input);
    int sumDigits = 0;

    while (number > 0)
    {
        int digit = number % 10;
        sumDigits += digit;
        number /= 10;
    }

    Console.WriteLine($"Sum of digits = {sumDigits}");

    input = Console.ReadLine();
}

if(input == "End")
{
    Console.WriteLine("Goodbye");
}