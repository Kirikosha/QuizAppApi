using QuizAppApi.Database.Models;

namespace QuizAppApi.Database.Interfaces
{
    public interface IAnswerRepository
    {
        Task<bool> Add(Answer answer);
        Task<Answer> Get(int answerId);
        Task<IEnumerable<Answer>> GetAllByQuizId(int quizId);
        Task<IEnumerable<Answer>> GetAllByQuestionId(int questionId);
        bool Update(Answer answer);
        Task<bool> DeleteById(int answerId);
        bool Delete(Answer answer);
    }
}
