using Model;
using Repository.VirtualDataBase;

namespace Repository
{
    public class CustomerRepository
    {

        public void Create(Customer customer)
        {
            MyData.Customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            MyData.Customers.Remove(customer);
        }

        public void Update(Customer customer)
        {
            var _customer = GetById(customer.Id);
            
            _customer.FirstName = customer.FirstName;
            _customer.LastName = customer.LastName;
            _customer.Email = customer.Email;
            _customer.Phone = customer.Phone;
            _customer.HomeAdress = customer.HomeAdress;
            _customer.ShippingAdress = customer.ShippingAdress;
        }
        public Customer GetById(int id)
        {
            var customer = 
                MyData.Customers.
                    FirstOrDefault(x => x.Id == id);

            if(customer is null) return null;

            return customer;
        }

        public List<Customer> GetByName(string name)
        {
            var customers = MyData.Customers
                .Where(x => x.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return customers;
        }
    }
}
