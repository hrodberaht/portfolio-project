using Project.Infrastructure.DTO;

namespace Project.Infrastructure.Services
{
    public interface IUserService
    {
         UserDTO Get(string email);
    }
}