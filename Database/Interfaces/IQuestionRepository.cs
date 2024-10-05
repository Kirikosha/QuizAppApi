using QuizAppApi.Database.Models;

namespace QuizAppApi.Database.Interfaces
{
    public interface IQuestionRepository
    {
        Task<bool> Add(Question question);
        Task<Question> GetByQuestionId(int questionId);
        Task<IEnumerable<Question>> GetAllByQuizId(int quizId);
        Task<bool> Update(Question question);
        bool Delete(Question question);
        Task<bool> DeleteById(int questionId);
    }
}
