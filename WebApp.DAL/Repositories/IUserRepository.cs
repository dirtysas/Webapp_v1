using WebApp.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.DAL.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}