namespace Problem01_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            try
            {
                number = NotNegativeNum(number);
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Goodbye.");
            }
        }

         static double NotNegativeNum(double input)
         {
            if(input < 0)
            {
                throw new ArgumentException("Invalid number.");
            }


            return input;
         }
    }
}
