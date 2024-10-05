using Microsoft.EntityFrameworkCore;
using QuizAppApi.Database.Interfaces;
using QuizAppApi.Database.Models;

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
            if (userId == default) throw new ArgumentException("User id was not set");
            var user = await _context.Users.FirstOrDefaultAsync(a => a.Id == userId);
            return user == null ? 
                throw new ArgumentNullException(
                    nameof(userId), 
                    "User with specified id was not found") : user;
        }

        // TODO - swap exceptions to logger and probably change return type to (User?, Exception?)
        public async Task<User> GetUserByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException(nameof(email), "Email was null");
            }

            var user = await _context.Users.FirstOrDefaultAsync(a => a.Email == email);
            return user == null ? throw new ArgumentException("User with specific email was not found", email) : user;
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
