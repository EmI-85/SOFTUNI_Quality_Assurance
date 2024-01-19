double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());

double addition = number1 + number2;
double subtraction = number1 - number2;
double multiplication = number1 * number2;
double division = number1 / number2;

Console.WriteLine($"{number1:F2} + {number2:F2} = {addition:F2}");
Console.WriteLine($"{number1:F2} - {number2:F2} = {subtraction:F2}");
Console.WriteLine($"{number1:F2} * {number2:F2} = {multiplication:F2}");
Console.WriteLine($"{number1:F2} / {number2:F2} = {division:F2}");

