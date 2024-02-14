int n = int.Parse(Console.ReadLine());

for (int hundreds = 1; hundreds <= 9; hundreds++)
{
    for (int tens = 0; tens <= 9; tens++)
    {
        for (int ones = 0; ones <= 9; ones++)
        {
            int digitsProduct = hundreds * tens * ones;

            if(digitsProduct == n)
            {
                Console.Write($"{hundreds}{tens}{ones} ");
            }
        }
    }
}