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

        [HttpGet]
        public IActionResult Create()
        {
            var product = new Product();

            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product == null)
                return View(nameof(Index));

            _productRepository.Create(product);

            return RedirectToAction(nameof(Index));

        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var product = _productRepository.GetById(id);
            if (product is null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var product = _productRepository.GetById(id);
            if (product is null)
                return NotFound();

            _productRepository.Delete(product);

            return RedirectToAction(nameof(Index));
        }
    }
}
