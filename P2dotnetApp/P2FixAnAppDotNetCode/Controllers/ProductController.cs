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

        public ProductController(IProductService productService, ILanguageService languageService, IProductServiceTest productServiceTest)
        {
            _productService = productService;
            _languageService = languageService;
            _productServiceTest = productServiceTest;
        }

        public IActionResult Index()
        {
            IEnumerable<productTest> products = _productServiceTest.GetProducts();
            return View(products);
        }
    }
}