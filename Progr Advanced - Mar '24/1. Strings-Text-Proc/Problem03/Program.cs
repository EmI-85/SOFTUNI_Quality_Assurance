string word = Console.ReadLine();
string text = Console.ReadLine();

while(text.Contains(word))
{
    int wordIndex = text.IndexOf(word);
    string beforeWord = text.Substring(0, wordIndex);
    string afterWord = text.Substring (wordIndex + word.Length);

    text = beforeWord + afterWord;
}

Console.WriteLine(text);