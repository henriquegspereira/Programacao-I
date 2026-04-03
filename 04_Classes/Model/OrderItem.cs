namespace Model
{
    public class OrderItem
    {
        #region Attibutes
        public int Id { get; set; }
        public Product Product { get; set; } = null!;
        public float Qty { get; set; }
        public double SalePrice { get; set; }
        public double TotalPrice { get; set; }

        #endregion

        #region Constructors

        public OrderItem()
        {
        }

        public OrderItem(
            int id,
            Product product,
            float qty,
            double saleprice,
            double totalprice   
        )
        {
            Id = id;
            Product = product;
            Qty = qty;
            SalePrice = SalePrice;
            TotalPrice = TotalPrice;
        }
        #endregion

        #region Validations
        public bool Validate()
        {
            if(Qty <= 0)return false; 
            if(SalePrice <= 0) return false;
            if(TotalPrice <=0 ) return false;
            return true;
        }
        #endregion
    }
}
