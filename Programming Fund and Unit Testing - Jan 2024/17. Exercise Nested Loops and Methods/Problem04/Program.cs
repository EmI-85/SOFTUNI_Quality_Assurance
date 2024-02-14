char s = char.Parse(Console.ReadLine());
char e = char.Parse(Console.ReadLine());
char x = char.Parse(Console.ReadLine());

int count = 0;

for (char i = s; i <= e; i++)
{
    for (char j = s; j <= e; j++)
    {
            for (char m = s; m <= e; m++)
            {
            if (i == x || j == x || m == x)
            {
                continue;
            }
            else 
            {
                Console.Write($"{i}{j}{m} ");
                count++;
            }
            }
    }
}
Console.WriteLine();
Console.WriteLine(count);




