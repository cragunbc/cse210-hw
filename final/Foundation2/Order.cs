public class Order
{
    private List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    private float TotalCost()
    {
        float price = 0;
        float shipping;
        foreach(Product product in _products)
        {
            price += product.Price(); 
        }
        if(_customer.Address.GetInUS())
            shipping = 5;
        else
            shipping = 35;
        return price + shipping;
    }

    public void PackingLabel()
    {
        Console.WriteLine($"Cost: ${string.Format("{0:F2}", Math.Round(TotalCost(), 2))}");
        foreach(Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.Name}, Product ID: {product.ProductID}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"Name: {_customer.Name}\nAddress: {_customer.Address.GetAddressString()}");
    }

    public void AddProduct()
    {
        Console.WriteLine("Please enter the following info:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Product ID: ");
        string productID = Console.ReadLine();
        Console.Write("Price: ");
        float price = float.Parse(Console.ReadLine());
        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        Product product = new(name, productID, price, quantity);

        _products.Add(product);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

}