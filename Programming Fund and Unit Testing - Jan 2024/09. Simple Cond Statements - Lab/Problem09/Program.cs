string figureType = Console.ReadLine();

double area = 0;

if (figureType == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;
}
else if (figureType == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());
    area = width * length;
}
else if (figureType == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * radius * radius;
}

Console.WriteLine($"{area:F2}");
