double radiusCircle = double.Parse(Console.ReadLine());

double area = radiusCircle * radiusCircle * Math.PI;
double perimeter= 2 * Math.PI * radiusCircle;

Console.WriteLine($"Area = {area:F2}");
Console.WriteLine($"Perimeter = {perimeter:F2}");
