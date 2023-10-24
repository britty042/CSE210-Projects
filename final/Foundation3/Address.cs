public class Address
{
//The address contains a string for the street address, the city, and state.
    private string _streetAddress;
    private string _city;
    private string _state;
    

    public Address(string streetAddress, string city, string state)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    

    }


//The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    public string Display()
    {
        return $"{_streetAddress} \n{_city}, {_state}";
    }
}
