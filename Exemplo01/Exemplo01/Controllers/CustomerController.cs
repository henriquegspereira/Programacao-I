using Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo01.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            int id = 1;

            Customer cu = new Customer();
            cu.CustomerId = id;
            cu.EmailAdress = "fulano@mail.com.br";
            cu.FirtsName = "Fulano";
            cu.LastName = "De Tal";

            Customer cu1 = new Customer
            {
                CustomerId = ++id,
                EmailAdress = "cicliano@mai.com.br",
                FirtsName = "Ciclano",
                LastName = "De Tal"
            };

            var cu2 = new Customer
            {
                CustomerId = ++id,
                EmailAdress = "beltrano@mail.com.br",
                FirtsName = "Beltrano",
                LastName = "De Tal"
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(cu);
            customers.Add(cu1);
            customers.Add(cu2);

            return View(customers);
        }
    }
}
