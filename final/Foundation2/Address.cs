using System;

public class Address 
{
    private string _streetAdress = "";
    private string _city = "";
    private string _stateOrProvince = "";
    private string _country = "";

    public Address() { }
    public Address(string street, string city, string stateOrProvince, string country) 
    {
        _streetAdress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string CountryValidation (string country) //This method reciebe the country of the customer as an argument  
    {                                                //to validate the cosuntry is USA or not.
        String info = "";
        if (_country == "USA" || _country == "EE.UU")
        {
            info = "The customer is inside the United States";
        } else {
            info = "The customer is outside the United States";
        }
        return info;
    }

    public string AddressInformation() //This method returns a  string of the address information of the customer.
    {
        string adressInfo = "";
        adressInfo = $"Street: {_streetAdress} \nCity: {_city} \nState/Province: {_stateOrProvince} \nCountry: {_country} \n{CountryValidation(_country)}";
        return adressInfo;
    }
}