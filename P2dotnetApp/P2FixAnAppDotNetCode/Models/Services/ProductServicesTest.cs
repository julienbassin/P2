using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2FixAnAppDotNetCode.Models.Services
{    

    public class ProductServicesTest : IProductServiceTest
    {
        private List<Product> productTemp ;

        public List<Product> SaveTempProduct(Product item)
        {
            //bool isEmpty = !productTemp.Any();
            if(item == null)
            {                
                throw new Exception("Item is null");
            }
            else
            {

                productTemp.Add(item);
            }

            return productTemp;
        }
        

        public List<Product> RestoreProductValue()
        {
            var test = productTemp;
            return productTemp;
        }
    }
}
