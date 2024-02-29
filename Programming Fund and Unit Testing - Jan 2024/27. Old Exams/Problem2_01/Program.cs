int numCount = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < numCount; i++)
{
    int currentnum = int.Parse(Console.ReadLine()); 

    if(isPrime(currentnum))
    {
        sum += currentnum;
    }
}
Console.WriteLine(sum);

static bool isPrime(int number)
{
    bool isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }

        }
    }
    return isPrime;
}