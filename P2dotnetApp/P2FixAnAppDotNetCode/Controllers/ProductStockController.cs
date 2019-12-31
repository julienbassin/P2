using Microsoft.AspNetCore.Mvc;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Models.Services;
using System.Collections.Generic;

namespace P2FixAnAppDotNetCode.Controllers
{
    public class ProductStockController: Controller
    {
        private readonly IProductStocks _productstocks;
        private readonly Product _product = new Product(55, 25, 100.00, "Casque Bose", "casque de grandes qualité");

        public ProductStockController(IProductStocks productStocks)
        {
            _productstocks = productStocks;
        }

        public IActionResult ProductStock()
        {
            var result = _productstocks.GetProductTest(_product);
            return View(result);
        }
        
    }
}
