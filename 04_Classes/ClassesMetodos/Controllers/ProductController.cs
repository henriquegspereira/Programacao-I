using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using Repository;
using System.Globalization;
using System.Text;
namespace ClassesMetodos.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
        }
        public IActionResult Index()
        {
            Object objeto = new Object();
            var Products = _productRepository.GetAll();
            return View(Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadViewData();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Create(product);
                return RedirectToAction("Index");
            }
            LoadViewData();

            return View();
        }
        private void LoadViewData() 
        {
            var categories = _categoryRepository.GetAll();
            ViewData["CategoryId"] = 
                new SelectList(categories, "Id", "Name");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id <= 0)
                return BadRequest();

            var product = _productRepository.GetById(id);

            if (product is null)
                return NotFound();

            LoadViewData();
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(int id, Product product)
        {
            if (id <= 0 || product is null)
                return BadRequest();

            if (id != product.Id)
                return BadRequest();

            _productRepository.Update(product);
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
        /*

        [HttpGet]
        public IActionResult ExportTxt()
        {
            var products = _productRepository.GetAll();
            var categories = _categoryRepository.GetAll();

            var sb = new StringBuilder();

            //Cabeçalho
            sb.AppendLine("Id;Name;Price;CategoryId;CategoryName");

            string Escape(string s) =>
                s?.Replace("\"", "\"\"") ?? string.Empty;

            foreach (var p in products)

            {

                var categoryName = categories
                .FirstOrDefault(c => c.Id == p.CategoryId)?.Name
                ?? string.Empty;

                // Campos textuais entre aspas e com duplas aspas 
                var nameField = $"\"{Escape(p.Name)}\"";
                var categoryField = $"\"{Escape(categoryName)}\"";

                var priceField = p.Price.ToString("F2",
                CultureInfo.InvariantCulture);

            }
        */
    }
}
