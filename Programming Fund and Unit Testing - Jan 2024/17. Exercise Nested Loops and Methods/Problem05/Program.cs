int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 0; j <= n; j++)
    {
        for (int m = 0; m <= n; m++)
        {
            for (int k = 0; k <= n; k++)
            {
                int leftSum = i + j;
                int rightSum = m + k;

                if (leftSum == rightSum && rightSum == n)
                {
                    Console.Write($"{i}{j}{m}{k} ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

