int[] inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

int outputNumbersLength = inputNumbers.Length / 2;

if(inputNumbers.Length % 2 != 0)
{
    outputNumbersLength++;
}

int[] outputNumbers = new int [outputNumbersLength];

for (int i = 0; i < outputNumbersLength; i++)
{
    if (inputNumbers.Length % 2 != 0 && i == outputNumbersLength - 1)
    {
        outputNumbers[i] = inputNumbers[i];
        break;
    }
    int elementA = inputNumbers[i];
    int elementB = inputNumbers[inputNumbers.Length - 1 - i];
    outputNumbers[i] = elementA + elementB;
}

Console.WriteLine (string.Join (" ", outputNumbers));
