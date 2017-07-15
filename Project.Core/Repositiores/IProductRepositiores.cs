using Project.Core.Domain;

namespace Project.Core.Repositiores
{
    public interface IProductRepositiores
    {
        
         string Get(int id);

         Product Get(string name);

         void Add(Product product);
    }
}