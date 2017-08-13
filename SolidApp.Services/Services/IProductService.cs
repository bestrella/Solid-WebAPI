using SolidApp.Services.Models;
using System;
using System.Collections.Generic;

namespace SolidApp.Services
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
    }
}
