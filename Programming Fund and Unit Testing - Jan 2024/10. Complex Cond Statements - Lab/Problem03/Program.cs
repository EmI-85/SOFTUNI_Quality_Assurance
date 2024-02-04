int points = int.Parse(Console.ReadLine());

int finalPoints = 0;

if (points >= 0 && points <= 3)
{
    finalPoints = points + 5;
}
else if (points >= 4 && points <= 6)
{
    finalPoints = points + 15;
}
else if (points >= 7 && points <= 9)
{
    finalPoints = points + 20;
}
else
{
    finalPoints = points;
}

Console.WriteLine(finalPoints);
