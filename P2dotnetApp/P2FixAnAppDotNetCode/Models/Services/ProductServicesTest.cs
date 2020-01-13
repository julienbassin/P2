using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2FixAnAppDotNetCode.Models.Services
{    

    public class ProductServicesTest : IProductServiceTest
    {
        public List<Product> tempLst = new List<Product>();

        public List<Product> SaveTempProduct(Product item)
        {
            if(item != null)
            {
                tempLst.Add(item);
            }

            return tempLst;
        }
        

        public List<Product> RestoreProductValue()
        {
            
            return tempLst;
        }
    }
}
