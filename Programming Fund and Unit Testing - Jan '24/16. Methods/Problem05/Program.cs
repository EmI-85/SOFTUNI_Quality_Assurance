string input = Console.ReadLine();
int num = int.Parse(Console.ReadLine());


Console.WriteLine(RepeatText(input, num));

static string RepeatText(string text, int count)
{
    string newText = text;

    for(int i = 1; i < count; i++)
    {
        newText += text;
    }
    return newText;
}