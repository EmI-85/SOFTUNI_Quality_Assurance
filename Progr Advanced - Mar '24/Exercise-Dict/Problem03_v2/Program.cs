string input = Console.ReadLine();

var productPrice = new Dictionary<string,double>();
var productQuantity = new Dictionary<string,int>();

while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    double price = double.Parse(inputArray[1]);
    int quantity = int.Parse(inputArray[2]);

    if (!productPrice.ContainsKey(product))
    {
        productPrice.Add(product, price);
        productQuantity.Add(product, quantity);
    }
    else
    {
        productPrice[product] = price;
        productQuantity[product] += quantity;
    }
    input = Console.ReadLine();
}
foreach (var product in productPrice.Keys)
{
    double amount = productPrice[product] * productQuantity[product];

    Console.WriteLine($"{product} -> {amount:F2}");
}