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
            if(tempLst == null)
            {
                tempLst = new List<Product>();
            }

            bool contains = tempLst.Any(i => i.Id == item.Id);

            if (contains)
            {
                
                tempLst.Select(i => { i.Stock = item.Stock; return i; });
            }
            else
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
