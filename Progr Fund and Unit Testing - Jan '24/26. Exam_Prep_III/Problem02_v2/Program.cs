int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = input.Length - 1; i >= input.Length - n; i--)
{
    sum += input[i];
}

double average = sum / n;
Console.WriteLine($"{average:F2}");