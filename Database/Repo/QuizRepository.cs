using Microsoft.EntityFrameworkCore;
using QuizAppApi.Database.Interfaces;
using System.Linq.Expressions;

namespace QuizAppApi.Database.Repo
{
    public class QuizRepository : IQuizRepository
    {
        private QuizDbContext _context;
        public QuizRepository(QuizDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(Quiz quiz)
        {
            if (quiz == null) return false;
            await _context.Quizes.AddAsync(quiz);
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> Delete(Quiz quiz)
        {
            if (quiz == null) return false;
            bool doesExists = await _context.Quizes.AnyAsync(a => a.Id == quiz.Id);
            if (!doesExists) return false;
            _context.Quizes.Remove(quiz);
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteById(int quizId)
        {
            Quiz? quiz = await _context.Quizes.FirstOrDefaultAsync(a => a.Id == quizId);
            if (quiz == null) return false;
            _context.Quizes.Remove(quiz);
            _context.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Quiz>> GetAll()
        {
            IEnumerable<Quiz> quizes = await _context.Quizes.ToListAsync();
            return quizes;
        }

        public async Task<Quiz> GetById(int quizId)
        {
            Quiz? quiz = await _context.Quizes.FirstOrDefaultAsync(a => a.Id == quizId);
            if (quiz == null) throw new ArgumentNullException($"A quiz with an id of {quizId} was not found", nameof(quiz));
            return quiz;
        }

        public async Task<bool> Update(Quiz quiz)
        {
            bool doesExist = await _context.Quizes.AnyAsync(a => a.Id == quiz.Id);
            if (!doesExist) return false;
            _context.Quizes.Update(quiz);
            _context.SaveChanges();
            return true;
        }
    }
}
