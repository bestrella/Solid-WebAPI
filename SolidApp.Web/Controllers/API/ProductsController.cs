using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolidApp.Services.Models;
using SolidApp.Services;

namespace SolidApp.Web.Controllers
{
    [Route("api/v1/[controller]/[action]/{id?}")]
    public class ProductsController : Controller
    {
        IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [ProducesResponseType(200,Type =typeof(List<Product>))] //FOR MULTI MODEL RESPONSE TYPE DEPENDING ON RESPONSE STATUS.
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = productService.GetAll();
            return Ok(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = productService.GetById(id);
            return Ok(model);
        }
    }
}
