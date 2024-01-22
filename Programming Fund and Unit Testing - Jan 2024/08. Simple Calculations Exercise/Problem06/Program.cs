int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm = int.Parse(Console.ReadLine());
int heightInCm = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double aquariumVolume = lengthInCm * widthInCm * heightInCm;
double volumeLiters = aquariumVolume * 0.001;
double occupiedSpace = percentage / 100 * volumeLiters;
double waterLiters = volumeLiters - occupiedSpace;


Console.WriteLine($"{waterLiters:F2}");