int[] arrayOne = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
int[] arrayTwo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

List<int> mergedList = new List<int>();

int longerArrayLength = Math.Max(arrayOne.Length, arrayTwo.Length);

for  (int i = 0; i < longerArrayLength; i++)
{
    if(i < arrayOne.Length)

    {
        mergedList.Add(arrayOne[i]);
    }
    if(i < arrayTwo.Length)
    {
        mergedList.Add(arrayTwo[i]);
    }
}
Console.WriteLine(string.Join(" ", mergedList));