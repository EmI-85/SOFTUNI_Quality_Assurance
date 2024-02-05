int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3 = int.Parse(Console.ReadLine());

int totalSeconds = time1 + time2 + time3;   
int timeMinutes = totalSeconds / 60;
int timeSeconds = totalSeconds % 60;

Console.WriteLine($"{timeMinutes}:{timeSeconds:D2}");   