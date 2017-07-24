using System;
using System.Collections.Generic;
using System.Linq;
using Project.Core.Domain;
using Project.Core.Repositiores;

namespace Project.Infrastructure.Repositiores
{
    public class UserRepositiores : IUserRepositiores
    {
        private static ISet<User> UserList = new HashSet<User>{
            new User("user1@email.com", "user1"),
            new User("user2@email.com", "user2"),
        };
        public void Add(User user)
        {
            UserList.Add(user);
        }

        public User Get(string email)
        {
            return UserList.Single(x => x.Email == email.ToLowerInvariant()); 
        }

        public IEnumerable<User> getAll()
        {
            return UserList;
        }
    }
}