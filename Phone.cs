namespace task_1;

public class Phone : Product
{
    string color;
    string brand;

    public Phone(string name, int price, string color, string brand)
    : base(name, price)
    {
        this.color = color;
        this.brand = brand;
    }

    public string AboutPhone()
    {
        return $"Color : {color}\n Brand : {brand}";
    }
}
