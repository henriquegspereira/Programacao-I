using Imobiliary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PropertyLibrary;
using System.Diagnostics.Contracts;

namespace Imobiliary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Properties()
        {

            var properties = new List<Property>()
            {

                new Property
                {
                    Id = 1,
                    Name = "Beach House",
                    Description = "A beautiful beach house with an ocean view.",
                    Address = "123 Waves St, Sun Beach",
                    Type = Property.PropertyType.House,
                    Contract = Property.ContractType.Sale
                },

                new Property
                {
                    Id = 2,
                    Name = "Downtown Apartment",
                    Description = "Modern apartment in the heart of the city.",
                    Address = "456 Main Avenue, Downtown",
                    Type = Property.PropertyType.Apartment,
                    Contract = Property.ContractType.Rent
                },

                new Property
                {
                    Id = 3,
                    Name = "Country House",
                    Description = "Cozy country house, ideal for relaxing.",
                    Address = "789 Rural Road, Green Field",
                    Type = Property.PropertyType.House,
                    Contract = Property.ContractType.Sale
                },

                new Property
                {
                    Id = 4,
                    Name = "Luxury Apartment",
                    Description = "Luxury apartment with panoramic city views.",
                    Address = "321 High St, Noble District",
                    Type = Property.PropertyType.Apartment,
                    Contract = Property.ContractType.Rent
                },

                new Property
                {
                    Id = 5,
                    Name = "Mountain House",
                    Description = "Charming mountain house, perfect for weekend getaways.",
                    Address = "654 Mountain Trail, Blue Ridge",
                    Type = Property.PropertyType.House,
                    Contract = Property.ContractType.Sale
                },

                new Property
                {
                    Id = 6,
                    Name = "Modern Apartment",
                    Description = "Modern apartment with contemporary design and prime location.",
                    Address = "987 Artists Ave, Cultural Center",
                    Type = Property.PropertyType.Apartment,
                    Contract = Property.ContractType.Rent
                },

                new Property
                {
                    Id = 7,
                    Name = "Luxury Mansion",
                    Description = "Luxury house with a pool, garden, and gourmet area.",
                    Address = "555 Palm St, Exclusive Condominium",
                    Type = Property.PropertyType.House,
                    Contract = Property.ContractType.Sale
                },

                new Property
                {
                    Id = 8,
                    Name = "Compact Apartment",
                    Description = "Compact and functional apartment, ideal for singles or couples.",
                    Address = "222 Sun St, Central District",
                    Type = Property.PropertyType.Apartment,
                    Contract = Property.ContractType.Rent
                },

                new Property
                {
                    Id = 9,
                    Name = "Farmhouse",
                    Description = "Farmhouse with a large plot of land and nature views.",
                    Address = "789 Green Road, Rural Area",
                    Type = Property.PropertyType.House,
                    Contract = Property.ContractType.Sale
                },

                new Property
                {
                    Id = 10,
                    Name = "Cozy Apartment",
                    Description = "Cozy apartment with charming decor and convenient location.",
                    Address = "333 Leisure St, Residential District",
                    Type = Property.PropertyType.Apartment,
                    Contract = Property.ContractType.Rent
                }
             };

            return View(properties);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
