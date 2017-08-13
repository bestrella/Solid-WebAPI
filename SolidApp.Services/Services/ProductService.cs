using System;
using System.Collections.Generic;
using System.Text;
using SolidApp.Services.Models;
using System.Linq;

namespace SolidApp.Services
{
    internal class ProductService : AbstractService, IProductService
    {
        //TODO: GET DATA FROM EF

        public List<Product> GetAll()
        {
            var model = new List<Product>();

            model.Add(new Product() { Id = 1, Name = "Test" });
            model.Add(new Product() { Id = 2, Name = "Test me" });
            model.Add(new Product() { Id = 3, Name = "Test now" });

            return model;
        }

        public Product GetById(int id)
        {
            var products = new List<Product>();

            products.Add(new Product() { Id = 1, Name = "Test" });
            products.Add(new Product() { Id = 2, Name = "Test me" });
            products.Add(new Product() { Id = 3, Name = "Test now" });

            return products.Where(p => p.Id == id).FirstOrDefault();
             
        }
    }
}
