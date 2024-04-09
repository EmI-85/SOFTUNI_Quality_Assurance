namespace Problem02
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandInfo = Console.ReadLine().Split(": ");
                string command = commandInfo[0];
                string data = commandInfo[1];

                if (command == "Edit")
                {
                    article.Edit(data);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(data);
                }
                else if (command == "Rename")
                {
                    article.Rename(data);
                }
            }
            Console.WriteLine(article);

        }
    }
}
