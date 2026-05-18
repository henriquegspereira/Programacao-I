using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository.VirtualDataBase;

namespace Repository.Seeds
{
    public static class ProductSeeds
    {
        public static void Seed()
        {

            if (MyData.Products.Count < 1)
            {

                Product p1 = new Product();
                p1.Id = 1;
                p1.Name = "Maconha";
                p1.Price = 100;

                Product p2 = new Product();
                p2.Id = 2;
                p2.Name = "Coca";
                p2.Price = 50;

                MyData.Products.Add(p1);
                MyData.Products.Add(p2);
            }
        }
    }
}