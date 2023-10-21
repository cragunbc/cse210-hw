using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        Address a1 = new("1234 North Rd", "Arlington", "Virginia", "USA");
        Customer c1 = new("Dave Smith", a1);
        Order o1 = new(c1);
        Product p1 = new("Bananas", "25", 1.50f, 2);
        Product p2 = new("Computer", "30", 199.99f, 1);
        Product p3 = new("Skateboard", "199", 25.76f, 3);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.PackingLabel();
        o1.ShippingLabel();

        Console.WriteLine("");
        Address a2 = new("5897 South St", "London", "England", "Europe");
        Customer c2 = new("Sara Johnson", a2);
        Order o2 = new(c2);
        Product p4 = new("iPhone", "257", 1199.99f, 1);
        Product p5 = new("Desk", "451", 149.99f, 4);
        Product p6 = new("Cookies", "89", 9.99f, 5);
        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);
        o2.PackingLabel();
        o2.ShippingLabel();
    }
}