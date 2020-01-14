using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2FixAnAppDotNetCode.Models.Services
{    

    public class ProductServicesTest : IProductServiceTest
    {
        public static List<Product> tempLst;

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
            if (tempLst == null)
            {
                tempLst = new List<Product>();
            }
            return tempLst;
        }
    }
}
