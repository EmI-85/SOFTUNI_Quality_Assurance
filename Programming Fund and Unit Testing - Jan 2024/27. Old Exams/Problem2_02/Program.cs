int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > n)
    {
        Console.Write(numbers[i] + " ");
    }
}