string input = Console.ReadLine();

Dictionary<char, int> charachters = new Dictionary<char, int>();

foreach(char ch in input)
{
    if (ch != ' ')
    {
        if(charachters.ContainsKey(ch))
        {
            charachters[ch]++;
        }
        else
        {
            charachters.Add(ch, 1);
        }
    }
}

foreach(var pair in charachters)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}