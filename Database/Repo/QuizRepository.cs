using QuizAppApi.Database.Interfaces;

namespace QuizAppApi.Database.Repo
{
    public class QuizRepository : IQuizRepository
    {
        public Task<bool> Add(Quiz quiz)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Quiz quiz)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(Guid quizId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Quiz>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Quiz> GetById(Guid quizId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Quiz quiz)
        {
            throw new NotImplementedException();
        }
    }
}
