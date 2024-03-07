int w = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

Console.WriteLine(GetRectangleArea(w, l));

static int GetRectangleArea(int width, int length)
{
    int area = width * length;
    return area;
}