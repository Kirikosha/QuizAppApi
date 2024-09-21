using Microsoft.EntityFrameworkCore;
using QuizAppApi.Database.Interfaces;
using QuizAppApi.Database.Models;

namespace QuizAppApi.Database.Repo
{
    public class AnswerRepository : IAnswerRepository
    {
        private QuizDbContext _context;
        public AnswerRepository(QuizDbContext quizDbContext)
        {
            _context = quizDbContext;
        }
        public async Task<bool> Add(Answer answer)
        {
            Question? question = await _context.Questions.FindAsync(answer.QuestionId);
            if (question == null)
            {
                return false;
            }
            _context.Answers.Add(answer);
            return true;
        }

        public bool Delete(Answer answer)
        {
            if(answer == null) { return false; }
            _context.Answers.Remove(answer);
            return true;
        }

        public async Task<bool> DeleteById(Guid answerId)
        {
            Answer? answer = await _context.Answers.FirstOrDefaultAsync(a => a.Id == answerId);
            if (answer == null) return false;
            _context.Answers.Remove(answer);
            return true;
        }

        public async Task<Answer> Get(Guid answerId)
        {
            Answer? answer = await _context.Answers.FirstOrDefaultAsync(a => a.Id == answerId);
            if (answer == null) throw new ArgumentException("Answer was not found");
            return answer;
        }

        public async Task<IEnumerable<Answer>> GetAllByQuestionId(Guid questionId)
        {
            List<Answer> answers = await _context.Answers.Where(a => a.QuestionId == questionId).ToListAsync();
            return answers;
        }

        public async Task<IEnumerable<Answer>> GetAllByQuizId(Guid quizId)
        {
            List<Question> questions = await _context.Questions.Where(q => q.QuizId == quizId).ToListAsync();
            List<Answer> answers = new List<Answer>();
            foreach(Question question in questions)
            {
                List<Answer> temmpAnswers = await _context.Answers.Where(a => a.QuestionId == question.Id).ToListAsync();
                answers.AddRange(temmpAnswers);
            }
            return answers;
        }

        public bool Update(Answer answer)
        {
            if (answer == null) return false;
            _context.Answers.Update(answer);
            return true;
        }
    }
}
