namespace Exemplo01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? EmailAdress { get; set; }

        public string? FirtsName { get; set; }

        public string? LastName { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(EmailAdress)
             || string.IsNullOrEmpty(FirtsName)
             || string.IsNullOrEmpty(LastName)
            )
                return false;

            return true;
        }


    }
}
