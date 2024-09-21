namespace QuizAppApi.Database.Interfaces
{
    public interface IQuizRepository
    {
        Task<bool> Add(Quiz quiz);
        Task<bool> Delete(Quiz quiz);
        Task<bool> DeleteById(Guid quizId);
        Task<Quiz> GetById(Guid quizId);
        Task<IEnumerable<Quiz>> GetAll();
        Task<bool> Update(Quiz quiz);
    }
}
