using System;

public class Order 
{
    private string _prodName = "";
    private string _prodId = "";
    private int _quantity = 0;
    private double _price = 0;
    private double _subTotal = 0;
    private double _total = 0;
    public List<Products> _products = new List<Products>(); //This list will contain the products name, id, price and quantity
    public List<Customer> _customer = new List<Customer>();
    public List<Order> _orders = new List<Order>(); 
    public Order() {}
    public Order(string name, string Id, int quantity,double price) 
    {
        _prodName = name;
        _prodId = Id;
        _quantity = quantity;
        _price = price;
    }

//The ShippingCost method reciebe as an argument the country of the customer and detects if the address inside 
//the USA or not. If the address is in the USA will be added as a default $5 of ship, but if the country is not the 
//USA then the ship to add will be $35.
    public string ShippingCost (string country)
    {   
        int ship = 5;
        String totalInfo ="";
        if (country == "USA" || country == "EE.UU") 
        {
          ship = 35;
        } else { }

        foreach (Order p in _orders)
        {
        _subTotal += p._quantity * p._price; 
        }
        Console.WriteLine($"The subtotal is: ${((decimal)_subTotal)}");
        _total = _subTotal + ship; 
        totalInfo = $"The total cost is: ${_total}\n";
        return totalInfo;
    }
//The PackingLabel method is used to display each product of the list and their id products.
    public void PackingLabel() {
        Console.WriteLine($"Product aquaired:");
        Console.WriteLine("Products                 ID N°");
        foreach (Order p in _orders) 
        {
            Console.WriteLine($"{p._prodName} ---------- {p._prodId}");
        }
        Console.WriteLine("\n--------------------------------------");
    }    

}