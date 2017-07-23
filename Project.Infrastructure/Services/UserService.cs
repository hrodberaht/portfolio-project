using System;
using Project.Core.Domain;
using Project.Core.Repositiores;
using Project.Infrastructure.DTO;

namespace Project.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositiores _userRepositiores;
        public UserService(IUserRepositiores userRepositiores)
        {
            _userRepositiores = userRepositiores;
        }
        public UserDTO Get(string email)
        {
            var user = _userRepositiores.Get(email);
            return new UserDTO{
                Email = user.Email
            };
        }
    }
}