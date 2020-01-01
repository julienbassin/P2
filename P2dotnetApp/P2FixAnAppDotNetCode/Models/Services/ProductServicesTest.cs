using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2FixAnAppDotNetCode.Models.Services
{
    public class productTest
    {
        public string Title { get; set; }
    }

    public class ProductServicesTest : IProductServiceTest
    {
        private readonly List<productTest> productsTest = new List<productTest>
        {
          new productTest { Title= "DVD player" },
          new productTest { Title= "TV" },
          new productTest { Title= "Projector" }
        };

        public IEnumerable<productTest> GetProducts()
        {
            return productsTest.AsEnumerable();
        }
    }
}
