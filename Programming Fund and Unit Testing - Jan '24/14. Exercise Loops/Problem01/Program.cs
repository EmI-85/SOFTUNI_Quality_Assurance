int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int multiplicationResult = 1;

for(int i = 0; i < power; i++)
{
    multiplicationResult = multiplicationResult * number;
}

Console.WriteLine(multiplicationResult);