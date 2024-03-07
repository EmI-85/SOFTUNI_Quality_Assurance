int studentsCount = int.Parse(Console.ReadLine());

double sumGrades = 0;

for  (int i = 1; i <= studentsCount; i++)
{
    double grade = double.Parse(Console.ReadLine());
    sumGrades += grade;
}

double averageGrade = sumGrades/studentsCount;

Console.WriteLine($"{averageGrade:F2}");