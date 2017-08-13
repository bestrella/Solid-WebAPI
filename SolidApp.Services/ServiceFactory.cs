using System;
using System.Collections.Generic;
using System.Text;

namespace SolidApp.Services
{
    public static class ServiceFactory
    {
        public static IProductService CreateProductService()
        {
            return new ProductService();
        }
    }
}
