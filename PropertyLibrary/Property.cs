using System.Globalization;

namespace PropertyLibrary
{
    public class Property
    {
        public int Id { get; set; }
        public PropertyType Type { get; set; }
        public ContractType Contract { get; set; }

        public enum PropertyType
        {
            none = 0,
            House,
            Apartment
        }

        public enum ContractType
        {
            none = 0,
            Rent,
            Sale
        }

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Area { get; set; }
        public int Bedrooms { get; set; }

    }
}
