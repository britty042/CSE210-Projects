public class Address
{
//The address contains a string for the street address, the city, state/province, and country.
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;

    }

//The address should have a method that can return whether it is in the USA or not.
    public bool International()
    {
        if (_country == "USA")
        {
            return false;
        } 
        else
        {
            return true;
        }
    }
//The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    public string Display()
    {
        return $"{_streetAddress} \n{_city}, {_stateOrProvince} \n{_country}";
    }
}