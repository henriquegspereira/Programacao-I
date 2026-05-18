namespace Model
{
    public class Address
    {
        #region Attibutes
        public int Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string FederalState { get; set; } = string.Empty;
        public AddressType AddressType { get; set; } 
        #endregion

        #region Constructors
        public Address()
        {
        }

        public Address(
            int id,
            string street,
            string number,
            string city,
            string postalCode,
            string country,
            string federalState,
            AddressType adressType
        )
        {
            Id = id;
            Street = street;
            Number = number;
            City = city;
            PostalCode = postalCode;
            Country = country;
            FederalState = federalState;
            AddressType = adressType;
        }


        #endregion

        #region Validations
        public bool Validate()
        {
            if(string.IsNullOrEmpty(Street)) return false;
            if(string.IsNullOrEmpty(Number)) return false;
            if (string.IsNullOrEmpty(City)) return false;
            if(string.IsNullOrWhiteSpace(Country)) return false;
            if(string.IsNullOrWhiteSpace(FederalState)) return false;

            return true;
        }
        #endregion
    }

    public enum AddressType
    {
        Residential,
        Comercial,
        Other
    }
}
