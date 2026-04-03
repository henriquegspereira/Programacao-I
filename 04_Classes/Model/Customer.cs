namespace Model
{
    public class Customer
    {
        #region Attributes
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Adress? HomeAdress { get; set; }
        public Adress ShippingAdress { get; set; } = null!;

        #endregion

        #region Constructors
        public Customer()
        {
        }
        public Customer(
            int id, 
            string firstName, 
            string lastName, 
            string email, 
            string phone, 
            Adress? homeAdress, 
            Adress shippingAdress
        )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            HomeAdress = homeAdress;
            ShippingAdress = shippingAdress;
        }

        #endregion

        #region Validations
        public bool Validate()
        {
            if(string.IsNullOrWhiteSpace(FirstName)) return false;
            if(string.IsNullOrWhiteSpace(LastName)) return false;
            if(string.IsNullOrWhiteSpace(Email)) return false;
            if(string.IsNullOrWhiteSpace(Phone)) return false;
            return true;
        }
        #endregion
    }
}
