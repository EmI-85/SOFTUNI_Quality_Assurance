namespace P04.TrapezoidArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = (a+b)/2 * height;
            Console.WriteLine(area);
        }
    }
}
