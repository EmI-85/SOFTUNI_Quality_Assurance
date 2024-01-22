int yearlyFee = int.Parse(Console.ReadLine());

double sneakers = yearlyFee * (1 - 0.40);
double team = sneakers * (1 - 0.20);
double ball = team * 0.25;
double accessories = ball * 0.20;

double totalCost = yearlyFee + sneakers + team + ball +  accessories;

Console.WriteLine(totalCost);