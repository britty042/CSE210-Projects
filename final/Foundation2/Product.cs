public class Product
{
    private string _productName;
    private int _productID;
    private double _price;
    private int _quantity;

    //int totalPrice = 0;

    //Contains the name, product id, price, and quantity of each product.
    //The price of this product is computed by multiplying the price and the quantity. 
    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetID()
    {
        return _productID;
    }
    public double TotalPrice()
    {
        double totalPrice = _price * _quantity;

        return totalPrice;
    }
}