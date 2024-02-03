int side1 = int.Parse(Console.ReadLine());
int side2 = int.Parse(Console.ReadLine());
int side3 = int.Parse(Console.ReadLine());

if  (side1 < side2 + side3 & side2 < side1 + side3 & side3 < side2 + side1)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}
