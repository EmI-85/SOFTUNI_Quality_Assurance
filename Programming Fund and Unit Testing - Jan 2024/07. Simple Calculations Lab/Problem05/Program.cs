double depositedAmount = double.Parse(Console.ReadLine());
int termInMonths = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double monthlyRate = annualInterestRate / 100 / 12;
double amount = depositedAmount * (1 + monthlyRate * termInMonths);

Console.WriteLine($"{amount:F2}");