int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

int n = int.Parse(Console.ReadLine());

int minNum = int.MaxValue;
int maxNum = int.MinValue;


for (int i = 0; i < n; i++)
{
    if (numbers[i] > maxNum)
    {
        maxNum = numbers[i];
    }
    if (numbers[i] < minNum)
    {
        minNum = numbers[i];
    }
}
Console.WriteLine(maxNum);
Console.WriteLine(minNum);