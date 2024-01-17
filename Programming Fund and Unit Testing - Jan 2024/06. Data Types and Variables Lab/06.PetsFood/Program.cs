int dogFoodCount = int.Parse(Console.ReadLine());
int catFoodCount = int.Parse(Console.ReadLine());

double sumDogFood = dogFoodCount * 2.50;
double sumCatFood = catFoodCount * 4.00;
double sumTotal = sumDogFood + sumCatFood;

Console.WriteLine($"{sumTotal:F2} lv.");
