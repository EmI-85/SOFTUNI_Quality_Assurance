int numberPens = int.Parse(Console.ReadLine());
int numberMarkers = int.Parse(Console.ReadLine());
int litersCleaner = int.Parse(Console.ReadLine()); 
int discountPerc = int.Parse(Console.ReadLine()); 


double totalSum = numberPens * 5.80 + numberMarkers *  7.20 + litersCleaner * 1.20;
double totalCost = totalSum - totalSum * discountPerc/100;

Console.WriteLine(totalCost);
