string[] days = new string[8];
days[0] = "Invalid day!";
days[1] = "Monday";
days[2] = "Tuesday";
days[3] = "Wednesday";
days[4] = "Thursday";
days[5] = "Friday";
days[6] = "Saturday";
days[7] = "Sunday";

int currentDay = int.Parse(Console.ReadLine());

if (currentDay >= 1 && currentDay <= 7)
{
    Console.WriteLine(days[currentDay]);
}
else
{
    Console.WriteLine(days[0]);
}