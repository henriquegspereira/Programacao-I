using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository.VirtualDataBase;

namespace Repository.Seeds
{
    public static class CustomerSeeds
    {
        public static void Seed()
        {

            if (MyData.Customers.Count < 1)
            {

                Customer c1 = new Customer();
                c1.Id = 1;
                c1.FirstName = "Jão";
                c1.LastName = "Oliveira";
                c1.Email = "jao.oliveira@bol.com";
                c1.Phone = "123-456-7890";

                Address c1Adress = new Address();
                c1Adress.Id = 1;
                c1Adress.FederalState = "SC";
                c1Adress.Street = "Rua dos Cachorros";
                c1Adress.Number = "24";
                c1Adress.City = "Videira";
                c1Adress.PostalCode = "89558-000";
                c1Adress.Country = "Brasil";
                c1Adress.AddressType = AddressType.Residential;

                c1.Addresses.Add(c1Adress);

                Customer c2 = new Customer();
                c2.Id = 2;
                c2.FirstName = "Maria";
                c2.LastName = "Silva";
                c2.Email = "maria.silva@bol.com";
                c2.Phone = "123-456-7890";

                Address c2Adress = new Address();
                c2Adress.Id = 2;
                c2Adress.FederalState = "SC";
                c2Adress.Street = "Rua dos Gatos";
                c2Adress.Number = "48";
                c2Adress.City = "Iomerê";
                c2Adress.PostalCode = "89558-000";
                c2Adress.Country = "Brasil";
                c2Adress.AddressType = AddressType.Residential;

                c2.Addresses.Add(c2Adress);

                MyData.Customers.Add(c1);
                MyData.Customers.Add(c2);
            }
        }
    }
}
