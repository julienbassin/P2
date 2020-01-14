using Microsoft.AspNetCore.Mvc;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Models.Services;
using System.Collections.Generic;

namespace P2FixAnAppDotNetCode.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;
        private readonly IProductServiceTest _productServiceTest;

        public ProductController(IProductService productService, ILanguageService languageService , IProductServiceTest productServiceTest)
        {
            _productService = productService;
            _languageService = languageService;
            _productServiceTest = productServiceTest;
        }

        public IActionResult Index()
        {
          
            if (_productServiceTest.RestoreProductValue().Count != 0)
            {                
                List<Product> products = _productServiceTest.RestoreProductValue();
                return View(products);
            }
            else
            {
                IEnumerable<Product> products = _productService.GetAllProducts();
                return View(products);
            }           

        }
    }
}