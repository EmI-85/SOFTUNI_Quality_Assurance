int baseNum = int.Parse(Console.ReadLine());
int powNum = int.Parse(Console.ReadLine());

Console.WriteLine(PowerResult(baseNum, powNum));

static int PowerResult(int baseNumber, int powerNumber)
{
    int result = baseNumber; 
    for(int i = 2; i <= powerNumber; i++)
    {
        result *= baseNumber;
    }

    return result;
}