using System.Formats.Asn1;

namespace P02.SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int area = side * side;
            Console.WriteLine(area);
        }
    }
}
