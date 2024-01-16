namespace P06._InchesToCentimetersConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengthInInches = double.Parse(Console.ReadLine());
            double sentimeters= lengthInInches * 2.54;
            Console.WriteLine(sentimeters);
         }
    }
}
