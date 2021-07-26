﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 50;
            product1.UnitsInStock = 5;

            Product product2 = new Product { Id = 2,CategoryId=5, ProductName="Kitap", 
                UnitPrice=20, UnitsInStock=150};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
