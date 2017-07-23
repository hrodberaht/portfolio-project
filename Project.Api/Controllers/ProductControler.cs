using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Infrastructure;
using Project.Infrastructure.DTO;
using Project.Infrastructure.Services;

namespace Project.Api.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        // public ProductDTO Get(int id)
        //     => _productService.Get(id);
        // public string Get(){
        //     return "Hello";
        // }
        public string Get(int id){
           return "id:" + _productService.Get(id);
        }
    }
    
}
