using System.Collections.Generic;
using Project.Core.Domain;

namespace Project.Core.Repositiores
{
    public interface IUserRepositiores
    {
         User Get(string email);
         IEnumerable<User> getAll();
         void Add(User user);
    }
}