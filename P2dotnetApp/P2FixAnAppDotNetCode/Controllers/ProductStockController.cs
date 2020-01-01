using Microsoft.AspNetCore.Mvc;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Models.Services;
using System.Collections.Generic;

namespace P2FixAnAppDotNetCode.Controllers
{
    public class ProductStockController: Controller
    {
        private readonly IProductServiceTest _productServicesTest;
        public ProductStockController(IProductServiceTest productServicesTest)
        {
            _productServicesTest = productServicesTest;
        }

        public IActionResult ProductStock()
        {
            var result = _productServicesTest.GetProducts();
            return View(result);
        }
    }
}
