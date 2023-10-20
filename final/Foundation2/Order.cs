using System.ComponentModel;
using System.Runtime.InteropServices;

public class Order 
{
    List<Product> _products = new List<Product>();

    private Customer _customer;

    int costToShip = 5;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void SetProductsList(List<Product> products)
    {
        _products = products;
    }
//Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
//The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
    public double TotalOrderPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
            {
                totalPrice += product.TotalPrice();
            }
        
        totalPrice += ShippingCost();

        return totalPrice;
    }
//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    public int ShippingCost()
    {
        if (_customer.InternationalShipping() == false)
        {
            costToShip = 5;
        }

        else{
            costToShip = 35;
        }

        return costToShip;
    }
//A packing label should list the name and product id of each product in the order.
    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetName()} Product ID: {product.GetID()}");
        }
    }
//A shipping label should list the name and address of the customer
    public void ShippingLabel()
    {
        Address customerAddress = _customer.GetAddress();
        Console.WriteLine($"{_customer.GetCustomerName()} \n{customerAddress.Display()}");
    }
}

