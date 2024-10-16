using Microsoft.EntityFrameworkCore;
using QuizAppApi.Database.Interfaces;
using QuizAppApi.Database.Models;
using System.Linq.Expressions;

namespace QuizAppApi.Database.Repo
{
    public class UserRepository : IUserRepository
    {
        private QuizDbContext _context;
        public UserRepository(QuizDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(User user)
        {
            if (user == null) return false;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(User user)
        {
            if (user == null) return false;
            var isSuccess = await DeleteById(user.Id);
            return isSuccess;
        }

        public async Task<bool> DeleteById(int userId)
        {
            var user = await GetUserById(userId);
            if (user == null) return false;
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        // TODO - swap exceptions to logger and probably change return type to (User?, Exception?)
        public async Task<User> GetUserById(int userId)
        {
            return await GetUserByPredicate(u => u.Id == userId, nameof(userId), userId);
        }

        // TODO - swap exceptions to logger and probably change return type to (User?, Exception?)
        public async Task<User> GetUserByEmail(string email)
        {
            return await GetUserByPredicate(u => u.Email == email, nameof(email), email);
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            return await GetUserByPredicate(u => u.UserName == userName, nameof(userName), userName);
        }
        
        private async Task<User> GetUserByPredicate(
            Expression<Func<User, bool>> predicate,
            string parameterName,
            object parameterValue)
        {
            if (parameterValue is int id && id == default ||
                parameterValue is string str && string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(parameterName, $"{parameterName} was not set");
            }

            var user = await _context.Users.FirstOrDefaultAsync(predicate);

            return user ?? throw new ArgumentException(
                $"User with specific {parameterName} was not found");
        }

        public async Task<bool> Update(User user)
        {
            if (user == null) return false;

            User? checkUser = await _context.Users.FirstOrDefaultAsync(a => a.Id == user.Id);
            if (checkUser == null) return false;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
