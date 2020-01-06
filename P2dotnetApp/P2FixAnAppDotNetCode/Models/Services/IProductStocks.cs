using System;
using System.Collections.Generic;


namespace P2FixAnAppDotNetCode.Models.Services
{
    public interface IProductServiceTest
    {
        List<Product> RestoreProductValue();
        List<Product> SaveTempProduct(Product item);
    }
}
