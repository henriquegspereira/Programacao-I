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
            MyData.Products.AddRange(
                new List<Product> 
                { 
                    new Product() {
                        Id = 1,
                        Name = "Maconha",
                        Price = 100,
                        CategoryId = 1
                    },
                    new Product() {
                        Id = 2,
                        Name = "Coca",
                        Price = 50,
                        CategoryId = 2
                    },
                    new Product()
                    {
                        Id = 3,
                        Name = "LOLÓ",
                        Price = 50,
                        CategoryId = 3
                    }
                }
            );
        }
    }
}