using WebApp.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.BLL.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}