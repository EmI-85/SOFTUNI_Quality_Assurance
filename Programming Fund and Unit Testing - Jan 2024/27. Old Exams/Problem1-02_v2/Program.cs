List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    input.Insert(0, input[input.Count - 1]);
    input.RemoveAt(input.Count - 1);
}
Console.WriteLine(string.Join(", ", input));