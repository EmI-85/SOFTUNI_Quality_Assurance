double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomHeight * bathroomWidth;
double areaPlusSurplus = bathroomArea * 1.1;
double tileArea = tileHeight * tileWidth;
double tilesNeeded = areaPlusSurplus / tileArea;

Console.WriteLine(Math.Round(tilesNeeded)); 