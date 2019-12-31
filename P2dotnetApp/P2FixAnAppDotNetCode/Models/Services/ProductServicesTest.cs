using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2FixAnAppDotNetCode.Models.Services
{
    public class ProductServicesTest : IProductStocks
    {
        public void GetProductTemp()
        {
            Console.WriteLine($"Dependency Injection for products, Name: {item.Name}, Price: {item.Price}, Stock: {item.Stock}");
        }
    }
}
