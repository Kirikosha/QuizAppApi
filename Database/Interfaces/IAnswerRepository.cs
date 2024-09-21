using QuizAppApi.Database.Models;

namespace QuizAppApi.Database.Interfaces
{
    public interface IAnswerRepository
    {
        Task<bool> Add(Answer answer);
        Task<Answer> Get(Guid answerId);
        Task<IEnumerable<Answer>> GetAllByQuizId(Guid quizId);
        Task<IEnumerable<Answer>> GetAllByQuestionId(Guid questionId);
        bool Update(Answer answer);
        Task<bool> DeleteById(Guid answerId);
        bool Delete(Answer answer);
    }
}
