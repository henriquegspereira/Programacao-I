namespace Model
{
    public class Customer : People
    {
        #region Attributes
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

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
            string phone
        )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
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
