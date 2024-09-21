using QuizAppApi.Database.Interfaces;
using QuizAppApi.Database.Models;

namespace QuizAppApi.Database.Repo
{
    public class UserRepository : IUserRepository
    {
        public Task<bool> Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
