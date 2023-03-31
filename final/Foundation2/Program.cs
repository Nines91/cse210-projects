using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Order System\n");
        Customer c = new Customer("Nicolas Ines");
        Address c_a = new Address ("235th Flinders Street", "Cansas City", "Texas", "EE.UU");
        Console.WriteLine(c.FullCustomerInfo(c_a.AddressInformation()));
        
        Order c_p = new Order("Glass Bottle", "OG04573", 6, 2.6);
        Order c_p1 = new Order("Coke ", "COK524", 4, 5);
        Order c_p2 = new Order("Pasta", "MLE562", 1, 2);

        Order order = new Order();
        order._orders.Add(c_p);
        order._orders.Add(c_p1);
        order._orders.Add(c_p2);
        Console.WriteLine();
        order.PackingLabel();
        Console.WriteLine(order.ShippingCost(c_a.AddressInformation()));
        
/*------------------------------------Setting the info fot the 2nd customer------------------------*/
        Customer cust2 = new Customer("Lionel Messi");
        Address address2 = new Address("1856th Chicago Streer", "Rosario","Santa Fe", "Argentina");
        Console.WriteLine(cust2.FullCustomerInfo(address2.AddressInformation()));
        
        Order or_cust2 = new Order("Shoes", "756922", 2, 2.500);
        Order or_cust2a = new Order("T-shirt", "884422", 4, 253);
        Order or_cust2b = new Order("Socks", "751122", 8, 55);
        Order or_cust2c = new Order("Jacket", "100052", 3, 87);
        
        Order messiOrder= new Order();
        messiOrder._orders.Add(or_cust2);
        messiOrder._orders.Add(or_cust2a);
        messiOrder._orders.Add(or_cust2b);
        messiOrder._orders.Add(or_cust2c);

        Console.WriteLine();
        order.PackingLabel();
        Console.WriteLine(messiOrder.ShippingCost(address2.AddressInformation()));
    }
}