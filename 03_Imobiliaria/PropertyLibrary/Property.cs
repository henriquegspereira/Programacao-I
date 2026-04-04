using System.Globalization;
using Core.Enums;

namespace PropertyLibrary
{
    public class Property
    {
        #region Attributes
        public int Id { get; set; }
        public PropertyEnums.PropertyType Type { get; set; }
        public PropertyEnums.ContractType Contract { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Area { get; set; }
        public int Bedrooms { get; set; }

        #endregion

        #region Constructors
        public Property() { }

        public Property(
            int id,
            PropertyEnums.PropertyType type,
            PropertyEnums.ContractType contract, 
            string name, 
            string address, 
            string description, 
            decimal price, 
            int area, 
            int bedrooms
        )

        {
            Id = id;
            Type = type;
            Contract = contract;
            Name = name;
            Address = address;
            Description = description;
            Price = price;
            Area = area;
            Bedrooms = bedrooms;
        }
        #endregion

        #region Validations
        public virtual bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Name)) return false;
            if (string.IsNullOrWhiteSpace(Address)) return false;
            if (Price <= 0) return false;
            if (Area <= 0) return false;
            if (Type == PropertyEnums.PropertyType.None) return false;
            return true;
        }
        #endregion
    }
}
