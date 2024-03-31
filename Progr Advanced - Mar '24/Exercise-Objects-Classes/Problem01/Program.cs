namespace Problem01
{
    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;

                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(student => student.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }

        }
    }


}

