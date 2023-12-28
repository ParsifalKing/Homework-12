public class Product
{
    string Name;
    int Price;

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Product: {Name}\n Price: ${Price}");
    }
}