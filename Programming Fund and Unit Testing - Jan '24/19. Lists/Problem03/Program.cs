List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();  

for (int i = 0; i < numbers.Count; i++)
{
    int currentNumber = numbers[i];

    if(currentNumber < 0)
    {
        numbers.Remove(currentNumber);
        i--;
    }
}

if  (numbers.Count > 0)
{
    numbers.Reverse();
    Console.WriteLine(string.Join(" ", numbers));
}
else
{
    Console.WriteLine("empty");
}