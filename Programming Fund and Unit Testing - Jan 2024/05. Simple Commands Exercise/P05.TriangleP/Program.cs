namespace P05.TrianglePerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int perimeter = a + b + c;
            Console.WriteLine(perimeter);
        }
    }
}
