
public class Shop : Product
{
    public Shop(string name, int price)
    : base(name, price)
    {

    }

    public List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }

    public void PrintProductList()
    {
        foreach (var item in products)
        {
            System.Console.WriteLine(item);
        }
    }


}