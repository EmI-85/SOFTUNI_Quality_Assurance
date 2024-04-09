namespace Problem03
{
    internal class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while(input!= "end")
            {
                string[] inputParams = input.Split();

                string serialNumber = inputParams[0];
                string itemName = inputParams[1];
                int itemQuantity= int.Parse(inputParams[2]);
                double itemPrice = double.Parse(inputParams[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemObject = item,
                    ItemQuantity = itemQuantity,
                    PriceBox = itemPrice * itemQuantity
                };
                boxes.Add(box);

                input = Console.ReadLine();
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(b => b.PriceBox).ToList();

            foreach(Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemObject.Name} - ${box.ItemObject.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }    
        public double Price { get; set; }    
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item ItemObject { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceBox { get; set; }
    }
}
