using Microsoft.AspNetCore.Mvc;
using Repository;
using Model;
namespace ClassesMetodos.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        public IActionResult Index()
        {
            Object objeto = new Object();
            //var Product = _ProductRepository.GetById(1);
            //var Products = _ProductRepository.GetByName("Jão");

            var Products = _productRepository.GetAll();
            //Products.Add(Product);
            //Products.Add((Product)objeto);

            return View(Products);
        }
    }
}
