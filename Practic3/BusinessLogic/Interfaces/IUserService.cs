using Internet_Shop__practice_5_.Models;

namespace BusinessLogic.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
        Task Create(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}