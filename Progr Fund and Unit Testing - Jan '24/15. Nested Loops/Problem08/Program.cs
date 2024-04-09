int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

for  (int number = startNum; number <= endNum; number++)
{
    bool isPrime = true;

    for(int i = 2; i < number; i++)
    {
        if(number % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write(number + " ");
    }
}