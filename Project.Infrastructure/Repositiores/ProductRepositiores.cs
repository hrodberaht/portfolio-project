using System;
using Project.Core.Domain;
using Project.Core.Repositiores;

namespace Project.Infrastructure.Repositiores
{
    public class ProductRepositiores : IProductRepositiores
    {
        string[] Array = new string[2]{"first","second"};

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public string Get(int id)
        {
            return id.ToString();
        }

        public Product Get(string name)
        {
            throw new NotImplementedException();
        }
    }
}