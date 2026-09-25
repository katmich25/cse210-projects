public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
        // una forma mas corta de escribirlo es return _country == "USA";
    }

    public string GetAddress()
    {
        return _streetAddress + "\n" + _city + "\n" + _stateProvince + "\n" + _country;
    }
}