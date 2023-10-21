using System.Dynamic;

public class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;

    public Product(string _name, string _productID, float _price, int _quantity)
    {
        this._name = _name;
        this._productID = _productID;
        this._price = _price;
        this._quantity = _quantity;
    }

    public string Name
    {
        get {return _name;}
    }

    public string ProductID
    {
        get {return _productID;}
    }
    
    
    public float Price()
    {
        return _price * _quantity;
    }
}