List<string> strings = Console.ReadLine()
                        .Split()
                        .Where(s => s.Length % 2 == 0)
                        .ToList();

foreach (string str in strings)
{
    Console.WriteLine(str);
}