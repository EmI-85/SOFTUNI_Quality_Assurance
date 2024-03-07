string inputLine = Console.ReadLine();

string[] strings = inputLine.Split(" ");
int[] ints = new int[strings.Length];

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = int.Parse(strings[i]);
}

int sum = 0;

for (int i = 0; i < ints.Length; i++)
{
    sum += ints[i];
}

Console.WriteLine(sum);