double temperatureInCelsius = double.Parse(Console.ReadLine());

double temperatureInFahrenheit = temperatureInCelsius * 1.8 + 32;

Console.WriteLine($"{temperatureInFahrenheit:F2}");