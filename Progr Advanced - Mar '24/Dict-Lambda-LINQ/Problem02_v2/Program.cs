int count = int.Parse(Console.ReadLine());

var wordsWithSynonyms = new Dictionary<string, List<string>>();

for (int i = 0; i < count; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (wordsWithSynonyms.ContainsKey(word))
    {
        wordsWithSynonyms[word].Add(synonym);

    }
    else
    {
        wordsWithSynonyms.Add(word, new() { synonym });
    }
}

foreach (var wordPair in wordsWithSynonyms)
{
    string synonyms = string.Join(", ", wordPair.Value);
    Console.WriteLine($"{wordPair.Key} - {synonyms}");
}