using Model;
using Repository.VirtualDataBase;

namespace Repository
{
    public class ProductRepository 
        : BaseRepository<Product>
    {

        public void Create(Product product)
        {
            product.Id = GetNextId();
            MyData.Products.Add(product);
        }

        public void Delete(Product product)
        {
            MyData.Products.Remove(product);
        }

        public void Update(Product product)
        {
            var _product = GetById(product.Id);

            _product.Name = product.Name;
            _product.Price = product.Price;
            _product.CategoryId = product.CategoryId;
        }
        public Product GetById(int id)
        {
            var product =
                MyData.Products.
                    FirstOrDefault(x => x.Id == id);

            if (product is null) return null!;

            return product;
        }

        public List<Product> GetByName(string name)
        {
            var products = MyData.Products
                .Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return products;
        }

        public List<Product> GetByCategoryId(int categoryid)
        {
            List<Product> products = [];
            foreach (var p in MyData.Products)
            {
                if (p.CategoryId == categoryid)
                {
                    products.Add(p);
                }
            }
            return products;
        }
        public List<Product> GetAll()
        {
            return MyData.Products;
        }
    }
}