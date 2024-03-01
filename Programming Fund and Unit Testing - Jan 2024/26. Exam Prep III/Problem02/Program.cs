int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

double sum = 0;
int arrLen = input.Length;

for (int i = 0; i < n; i++)
{
    int currentnum = input[arrLen - 1 - i];
    sum += currentnum;
}

double average = sum / n;
Console.WriteLine($"{average:F2}");