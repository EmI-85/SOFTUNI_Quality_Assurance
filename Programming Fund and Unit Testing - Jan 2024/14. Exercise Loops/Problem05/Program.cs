int n = int.Parse(Console.ReadLine());

int countNumDivTwo = 0;
int countNumDivThree = 0;
int countNumDivFour = 0;


for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum % 2 == 0)
    { 
        countNumDivTwo++;
    }
    if (currentNum % 3 == 0)
    {
        countNumDivThree++;
    }
    if (currentNum % 4 == 0)
    {
        countNumDivFour++;
    }
}

double percentageTwo = (double)countNumDivTwo / n * 100;
double percentageThree = (double)countNumDivThree / n * 100;
double percentageFour = (double)countNumDivFour / n * 100;


Console.WriteLine($"{percentageTwo:F2}%");
Console.WriteLine($"{percentageThree:F2}%");
Console.WriteLine($"{percentageFour:F2}%");
