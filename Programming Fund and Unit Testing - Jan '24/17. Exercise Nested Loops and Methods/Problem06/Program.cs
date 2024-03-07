string input = Console.ReadLine();

Console.WriteLine(CountOfVowels(input));

static int CountOfVowels(string text)
{
    int counterVowels = 0;

    for(int i = 0; i < text.Length; i++)
    {
        char ch = char.ToLower(text[i]);

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            counterVowels++;
        }
    }
    return counterVowels;
}