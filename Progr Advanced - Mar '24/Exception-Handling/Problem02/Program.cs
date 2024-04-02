namespace Problem02
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            int start = 1;
            int end = 100;
            
            while(numbers.Count < 10)
            {
                try
                {
                    int number = ReadNumber(start, end);
                    numbers.Add(number);
                    start = number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            bool isParsed = int.TryParse(input, out int output);

            if (!isParsed)
            {
                throw new FormatException("Invalid Number!");
            }

            if (output <= start || output >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - {end}!");
            }

            return output;
        }
    }
}
