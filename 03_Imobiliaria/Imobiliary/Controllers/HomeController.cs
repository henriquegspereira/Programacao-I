using Imobiliary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PropertyLibrary;
using System.Diagnostics.Contracts;
using Core.Enums;

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

                new House
                {
                    Id = 1,
                    Name = "Beach House",
                    Description = "A beautiful beach house with an ocean view.",
                    Address = "123 Waves St, Sun Beach",
                    Type = PropertyEnums.PropertyType.House,
                    Contract = PropertyEnums.ContractType.Sale,
                    Price = 450000.00m,
                    Area = 120,
                    Bedrooms = 3,
                    Floors = 4,
                    HasGarage = true
                },

                new Apartment
                {
                    Id = 2,
                    Name = "Downtown Apartment",
                    Description = "Modern apartment in the heart of the city.",
                    Address = "456 Main Avenue, Downtown",
                    Type = PropertyEnums.PropertyType.Apartment,
                    Contract = PropertyEnums.ContractType.Rent,
                    Price = 2500.00m,
                    Area = 75,
                    Bedrooms = 2,
                    Floor = 5,
                    HasElevator = true
                },

                new House
                {
                    Id = 3,
                    Name = "Country House",
                    Description = "Cozy country house, ideal for relaxing.",
                    Address = "789 Rural Road, Green Field",
                    Type = PropertyEnums.PropertyType.House,
                    Contract = PropertyEnums.ContractType.Sale,
                    Price = 320000.00m,
                    Area = 200,
                    Bedrooms = 4,
                    Floors = 2,
                    HasGarage= true
                },

                new Apartment
                {
                    Id = 4,
                    Name = "Luxury Apartment",
                    Description = "Luxury apartment with panoramic city views.",
                    Address = "321 High St, Noble District",
                    Type = PropertyEnums.PropertyType.Apartment,
                    Contract = PropertyEnums.ContractType.Rent,
                    Price = 8500.00m,
                    Area = 150,
                    Bedrooms = 3,
                    Floor = 2,
                    HasElevator = true
                },

                new House
                {
                    Id = 5,
                    Name = "Mountain House",
                    Description = "Charming mountain house, perfect for weekend getaways.",
                    Address = "654 Mountain Trail, Blue Ridge",
                    Type = PropertyEnums.PropertyType.House,
                    Contract = PropertyEnums.ContractType.Sale,
                    Price = 280000.00m,
                    Area = 90,
                    Bedrooms = 2,
                    Floors = 1,
                    HasGarage = false
                },

                new Apartment
                {
                    Id = 6,
                    Name = "Modern Apartment",
                    Description = "Modern apartment with contemporary design and prime location.",
                    Address = "987 Artists Ave, Cultural Center",
                    Type = PropertyEnums.PropertyType.Apartment,
                    Contract = PropertyEnums.ContractType.Rent,
                    Price = 3200.00m,
                    Area = 85,
                    Bedrooms = 2,
                    Floor = 8,
                    HasElevator= true
                },

                new House
                {
                    Id = 7,
                    Name = "Luxury Mansion",
                    Description = "Luxury house with a pool, garden, and gourmet area.",
                    Address = "555 Palm St, Exclusive Condominium",
                    Type = PropertyEnums.PropertyType.House,
                    Contract = PropertyEnums.ContractType.Sale,
                    Price = 1250000.00m,
                    Area = 450,
                    Bedrooms = 5,
                    Floors = 3,
                    HasGarage= true
                },

                new Apartment
                {
                    Id = 8,
                    Name = "Compact Apartment",
                    Description = "Compact and functional apartment, ideal for singles or couples.",
                    Address = "222 Sun St, Central District",
                    Type = PropertyEnums.PropertyType.Apartment,
                    Contract = PropertyEnums.ContractType.Rent,
                    Price = 1800.00m,
                    Area = 45,
                    Bedrooms = 1,
                    Floor = 1,
                    HasElevator = false
                },

                new House
                {
                    Id = 9,
                    Name = "Farmhouse",
                    Description = "Farmhouse with a large plot of land and nature views.",
                    Address = "789 Green Road, Rural Area",
                    Type = PropertyEnums.PropertyType.House,
                    Contract = PropertyEnums.ContractType.Sale,
                    Price = 550000.00m,
                    Area = 1000,
                    Bedrooms = 3,
                    Floors = 3,
                    HasGarage = true
                },

                new Apartment
                {
                    Id = 10,
                    Name = "Cozy Apartment",
                    Description = "Cozy apartment with charming decor and convenient location.",
                    Address = "333 Leisure St, Residential District",
                    Type = PropertyEnums.PropertyType.Apartment,
                    Contract = PropertyEnums.ContractType.Rent,
                    Price = 2100.00m,
                    Area = 65,
                    Bedrooms = 2,
                    Floor = 4,
                    HasElevator = false,
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
