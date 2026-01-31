using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessLogic;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductBL _productBL;

        public ProductController(ProductBL productBL)
        {
            _productBL = productBL;
        }

        public IActionResult ShowAll()
        {
            var products = _productBL.GetAllProducts();
            return View(products);
        }

        public IActionResult ShowById(int id)
        {
            var product = _productBL.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
