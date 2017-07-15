using System;
using Project.Core.Repositiores;
using Project.Infrastructure.DTO;


namespace Project.Infrastructure.Services
{
    public class ProductService : IProductServices
    {
        private readonly IProductRepositiores _productRepositiory;
        public ProductService(IProductRepositiores productRepository)
        {
            _productRepositiory = productRepository;
        }
        // public ProductDTO Get(int id)
        // {
        //     var product = _productRepositiory.Get(id);

        //      return new ProductDTO{

        //          name = product.name
                 
        //      };
             
        // }
        public string Get(int id){
            var text = _productRepositiory.Get(id);
            return text;
        }
    }
}