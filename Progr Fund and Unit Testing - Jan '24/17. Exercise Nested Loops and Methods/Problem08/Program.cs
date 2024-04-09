int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine(GetMultiplicationSign(n1, n2, n3));

static string GetMultiplicationSign(int num1, int num2, int num3)
{
    string sign = "";
    int product = num1 * num2 * num3;   

    if(product == 0)
    {
        sign = "zero";
    }
    else if (product < 0)
    {
        sign = "negative";
    }
    else
    {
        sign = "positive";
    }

    return sign;
}
