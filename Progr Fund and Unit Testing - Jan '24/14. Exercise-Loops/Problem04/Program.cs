int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= n; i++)
{
   char vowel = char.Parse(Console.ReadLine());  

    if(vowel=='a')
    {
        sum += 1;
    }
    else if(vowel == 'e')
    {
        sum += 2;
    }
    else if (vowel == 'i')
    {
        sum += 3;
    }
    else if (vowel == 'o')
    {
        sum += 4;
    }
    else if (vowel == 'u')
    {
        sum += 5;
    }
}

Console.WriteLine(sum);