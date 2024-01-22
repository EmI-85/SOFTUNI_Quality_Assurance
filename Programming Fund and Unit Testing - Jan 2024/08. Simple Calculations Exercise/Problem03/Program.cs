int nylonSqm = int.Parse(Console.ReadLine());
int paintLiters = int.Parse(Console.ReadLine());
int thinnerLiters = int.Parse(Console.ReadLine());
int workHours = int.Parse(Console.ReadLine());

double materialsCost = (nylonSqm + 2) * 1.50 + (paintLiters * 1.10) * 14.50 + thinnerLiters * 5.00 + 0.40;
double workCost = workHours * (0.30 * materialsCost);
double totalCost = materialsCost + workCost;

Console.WriteLine(totalCost);