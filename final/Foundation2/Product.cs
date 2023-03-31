using System;

public class Products 
{
    private string _prodName = "";
    private string _prodId = "";
    private int _quantity = 0;
    private double _price = 0;
       
    public Products() {}
    public Products(string name, string Id, int quantity,double price) 
    {
        _prodName = name;
        _prodId = Id;
        _quantity = quantity;
        _price = price;
    }

    
}