int stopNum = int.Parse(Console.ReadLine());

int prevNum = 0;

while (true)
{
    int currentNum = int.Parse(Console.ReadLine());
 
    if (currentNum == stopNum)
    {
        Console.WriteLine(prevNum * 1.20);
        break;
    }
    prevNum = currentNum;
}

