int countNum = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= countNum; i++)
{
    double number = double.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum); 