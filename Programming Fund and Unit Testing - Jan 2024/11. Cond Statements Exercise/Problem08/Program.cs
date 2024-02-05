string productName = Console.ReadLine();


if(productName == "banana" ||productName == "apple" ||productName == "kiwi" ||productName == "cherry" ||productName == "lemon")
{
    Console.WriteLine("fruit");
}
else if (productName == "cucumber" || productName == "pepper" || productName == "carrot")
{
    Console.WriteLine("vegetable");
}
else
{
    Console.WriteLine("unknown");
}