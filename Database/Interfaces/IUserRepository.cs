using QuizAppApi.Database.Models;

namespace QuizAppApi.Database.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> Add(User user);
        Task<User> GetUserById(Guid userId);
        Task<bool> Delete(User user);
        Task<bool> DeleteById (Guid userId);
        Task<bool> Update(User user);
        Task<User> GetUserByEmail(string email);
    }
}
