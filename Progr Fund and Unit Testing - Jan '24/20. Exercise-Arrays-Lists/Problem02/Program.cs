List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


while (input.Count > 1)
{
    List<int> output = new List<int>();

    for (int i = 0; i < input.Count - 1; i++)
    {
        int sum = input[i] + input[i + 1];
        output.Add(sum);
    }
    input = output;

}
Console.WriteLine(string.Join(" ", input));