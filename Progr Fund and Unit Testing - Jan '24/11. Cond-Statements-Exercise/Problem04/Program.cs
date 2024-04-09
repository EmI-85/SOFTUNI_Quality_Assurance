int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();

double result = 0;

if(mathOperator == "+")
{
    result = num1 + num2;
}
else if (mathOperator == "-")
{
    result = num1 - num2;
}
else if (mathOperator == "*")
{
    result = num1 * num2;
}
else if (mathOperator == "/")
{
    result = num1 / num2;
}

Console.WriteLine($"{num1} {mathOperator} {num2} = {result:F2}");