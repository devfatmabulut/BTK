// Classes

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();
        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();
    }
}
class CustomerManager  // PASCAL KEY örnekleri ise camel key 
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }
}
class ProductManager  // PASCAL KEY örnekleri ise camel key 
{
    public void Add()
    {
        Console.WriteLine("Product Added");
    }

    public void Update()
    {
        Console.WriteLine("Product Updated");
    }
}

