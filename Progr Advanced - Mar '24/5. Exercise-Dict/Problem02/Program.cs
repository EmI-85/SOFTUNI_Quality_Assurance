Dictionary<string, int> resources = new Dictionary<string, int>(); 

string resource = Console.ReadLine();

while(resource !=  "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if(resources.ContainsKey(resource))
    {
        resources[resource] += quantity;
    }
    else
    {
        resources.Add(resource, quantity);
    }

    resource = Console.ReadLine();
}

foreach(var pair in resources)
    {
        Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
