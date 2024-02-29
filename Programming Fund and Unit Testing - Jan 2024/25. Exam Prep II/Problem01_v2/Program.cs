int n = int.Parse(Console.ReadLine());
bool isNoMagicNum = true;

for (int i = 1; i <= n; i++)
{
    int currentNum = i;
    int sumDigits = 0;
    bool isAllDigitsPrime = true;

    while (currentNum > 0)
    {
        int digit = currentNum % 10;
        currentNum /= 10;

        sumDigits += digit;

        if (!isPrime(digit))
        {
            isAllDigitsPrime = false;
        }
    }
    if (isAllDigitsPrime && sumDigits % 2 == 0)
    {
        Console.Write(i + " ");
        isNoMagicNum = false;
    }
}

if (isNoMagicNum)
{
    Console.WriteLine("no");
}

static bool isPrime(int number)
{
    bool isPrime = true;

    if(number <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i < number; i++) 
        { 
            if(number % i == 0)
            {
                isPrime = false;
            }

        }
    }
    return isPrime;
}