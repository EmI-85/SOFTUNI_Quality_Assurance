int pagesNumberInBook = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int pagesPerDay = int.Parse(Console.ReadLine());


int bookReadingTime = pagesNumberInBook / pagesPerHour;
int numberOfHoursPerDay = bookReadingTime / pagesPerDay;

Console.WriteLine(numberOfHoursPerDay);