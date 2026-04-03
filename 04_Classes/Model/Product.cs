namespace Model
{
    public class Product
    {
        #region Attibutes
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }

        #endregion

        #region Constructors
        public Product()
        {
        }

        public Product(
            int id, 
            string name, 
            double price
        )
        {
            Id = id;
            Name = name;
            Price = price;
        }

        #endregion

        #region Validations
        /// <summary>
        /// Valida se nome é vazio e valor <= 0
        /// </summary>
        /// <returns>booleano</returns>
        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Name)) return false;
            if (Price <= 0) return false;

            return true;
        }

        #endregion
    }
}
