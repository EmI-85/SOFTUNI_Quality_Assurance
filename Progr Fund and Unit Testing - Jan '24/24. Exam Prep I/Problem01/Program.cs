int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number != 0)
{
    int digit = number % 10;

    if (digit % 2 == 0)
    {
        int resultFactorial = CalculateFactorial(digit);
        sum += resultFactorial;
    }

    number = number / 10;
}

Console.WriteLine(sum);

static int CalculateFactorial(int num)
{
    int result = 1;

    while(num > 0)
    {
            result = result * num;
            num -= 1;
    }
    return result;
}