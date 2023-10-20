using System.Net.Sockets;

public class Customer
{
//The customer contains a name and an address.
//The name is a string, but the Address is a class.
    private string _customerName;

    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    
//The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

    public bool InternationalShipping()
    {
        if (_address.International() == true)
        {
            return true;
        }

        else
            return false;
    }
}