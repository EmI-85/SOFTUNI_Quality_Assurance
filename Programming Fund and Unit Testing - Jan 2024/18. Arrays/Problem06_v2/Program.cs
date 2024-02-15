int[] numbers1 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
int[] numbers2 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();


foreach (int num1 in numbers1)
{
    foreach (int num2 in numbers2)
    {
        if (num1 == num2)
        {
            Console.Write($"{num1} ");
        }
    }
}
