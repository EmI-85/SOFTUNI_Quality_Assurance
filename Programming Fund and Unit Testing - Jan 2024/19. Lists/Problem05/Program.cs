List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandElements = command.Split().ToArray();

    if (commandElements[0] == "Contains")
    {
        int number = int.Parse(commandElements[1]);
        
        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commandElements[0] == "PrintEven")
    {
        foreach (int number in numbers)
        {

            if(number % 2 == 0)
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine();
    }
    else if (commandElements[0] == "PrintOdd")
    {
        foreach (int number in numbers)
        {

            if (number % 2 != 0)
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine();
    }
    else if (commandElements[0] == "GetSum")
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine(sum);
    }
    else if (commandElements[0] == "Filter")
    {
        string condition = commandElements[1];
        int inputNumber = int.Parse(commandElements[2]);

        List<int> filteredNumbers = new List<int>();
       
        foreach(int number in numbers)
        {
            if(condition == ">" && number > inputNumber)
            {
                filteredNumbers.Add(number);
            }
            else if (condition == ">=" && number >= inputNumber)
            {
                filteredNumbers.Add(number);
            }
            else if (condition == "<" && number < inputNumber)
            {
                filteredNumbers.Add(number);
            }
            else if (condition == "<=" && number <= inputNumber)
            {
                filteredNumbers.Add(number);
            }
        }
        numbers = filteredNumbers;
    }

    command = Console.ReadLine();
}
  

Console.WriteLine(string.Join(" ", numbers));
