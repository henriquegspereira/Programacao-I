using Model;
using Repository.VirtualDataBase;

namespace Repository
{
    public class ProductRepository
    {

        public void Create(Product product)
        {
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
        }
        public Product GetById(int id)
        {
            var product =
                MyData.Products.
                    FirstOrDefault(x => x.Id == id);

            if (product is null) return null;

            return product;
        }

        public List<Product> GetByName(string name)
        {
            var products = MyData.Products
                .Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return products;
        }

        public List<Product> GetAll()
        {
            return MyData.Products;
        }
    }
}