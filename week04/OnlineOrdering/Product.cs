using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

      public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }