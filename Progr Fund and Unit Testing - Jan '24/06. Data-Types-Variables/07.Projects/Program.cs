using System.Runtime.InteropServices;

string architectsName = Console.ReadLine();
int projectsCount = int.Parse(Console.ReadLine());

double projectTime = projectsCount * 3;

Console.WriteLine($"The architect {architectsName} will need {projectTime} hours to complete {projectsCount} project/s.");