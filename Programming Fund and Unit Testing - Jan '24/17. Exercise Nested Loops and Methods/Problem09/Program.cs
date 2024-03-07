string pass = Console.ReadLine();

bool isValidLenght = pass.Length >= 6 && pass.Length <= 10;
bool isValidContent = CheckContent(pass);
bool isValidCountDigits = CheckCountDigits(pass);

if (isValidLenght == true && isValidContent == true && isValidCountDigits == true)
{
    Console.WriteLine("Password is valid");
}
else
{
    if (isValidLenght == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    if (isValidContent == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    if (isValidCountDigits == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}

static bool CheckContent(string pass)
{
    for (int position = 0; position < pass.Length; position++)
    {
        char symbol = pass[position];
        if (char.IsLetterOrDigit(symbol) == false)
        {
            return false;
        }
    }
    return true;
}

static bool CheckCountDigits(string pass)
{
    int count = 0;
    for (int position = 0; position < pass.Length; position++)
    {
        char symbol = pass[position];
        if (char.IsDigit(symbol) == true)
        {
            count++;
        }
    }
    return count >= 2;
}