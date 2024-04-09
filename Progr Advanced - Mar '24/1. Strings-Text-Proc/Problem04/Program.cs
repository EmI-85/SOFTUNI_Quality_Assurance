string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
string text = Console.ReadLine();

foreach (string word in bannedWords)
{
    if(text.Contains(word))
    {
        string replacement = new string('*', word.Length);
        text = text.Replace(word, replacement);
    }
}

Console.WriteLine(text);