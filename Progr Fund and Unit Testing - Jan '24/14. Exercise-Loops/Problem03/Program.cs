﻿int n = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;

for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if(currentNum > maxNum)
    {
        maxNum = currentNum;
    }
}

Console.WriteLine(maxNum);