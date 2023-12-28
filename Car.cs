namespace task_1;

public class Car : Product
{
    string color;
    string dateOfManufacture;

    public Car(string name, int price, string color, string dateOfManufacture)
    : base(name, price)
    {
        this.color = color;
        this.dateOfManufacture = dateOfManufacture;
    }

    public string AboutCar()
    {
        return $"Color : {color}\n Car was crearted in {dateOfManufacture}";
    }
}
