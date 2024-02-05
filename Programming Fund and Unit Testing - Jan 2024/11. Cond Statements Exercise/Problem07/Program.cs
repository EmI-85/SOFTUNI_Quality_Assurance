int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

string status = "";

if (day == "Sunday")
{
    status = "closed";
}
else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
{
    if (hour >= 10 && hour <= 18)
    {
        status = "open";
    }
    else
    {
        status = "closed";
    }
}
Console.WriteLine(status);