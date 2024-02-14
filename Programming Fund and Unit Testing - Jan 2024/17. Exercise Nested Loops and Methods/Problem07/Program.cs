long n1 = int.Parse(Console.ReadLine());
long n2 = int.Parse(Console.ReadLine());

double factorial1 = Factorial(n1);
double factorial2 = Factorial(n2); 
    
double result = factorial1 / factorial2;


Console.WriteLine(result);

static double Factorial(double n)
{
    int fac = 1;
    for (int i = 1; i <= n; i++)
    {
        fac *= i;
    }
    return fac;
}