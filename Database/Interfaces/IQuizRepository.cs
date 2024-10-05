namespace QuizAppApi.Database.Interfaces
{
    public interface IQuizRepository
    {
        Task<bool> Add(Quiz quiz);
        Task<bool> Delete(Quiz quiz);
        Task<bool> DeleteById(int quizId);
        Task<Quiz> GetById(int quizId);
        Task<IEnumerable<Quiz>> GetAll();
        Task<bool> Update(Quiz quiz);
    }
}
