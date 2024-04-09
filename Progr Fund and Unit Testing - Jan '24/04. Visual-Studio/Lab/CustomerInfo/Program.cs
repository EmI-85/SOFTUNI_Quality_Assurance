namespace PersonInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            string country = Console.ReadLine();
            string town = Console.ReadLine();
            Console.WriteLine($"{first_name} {last_name} from {country} - {town}!");
        }
    }
    }

