using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2FixAnAppDotNetCode.Models.Services
{    

    public class ProductServicesTest : IProductServiceTest
    {
        public List<Product> productTemp = new List<Product>();

        public List<Product> UpdatedTempProduct(Product UpdatedProduct)
        {
            if(UpdatedProduct != null)
            {
                productTemp.Add(UpdatedProduct);
            }
            return productTemp;
        }
        

        public List<Product> RestoreProductValue()
        {
            return productTemp;
        }
    }
}
