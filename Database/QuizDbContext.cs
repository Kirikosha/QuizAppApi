using Microsoft.EntityFrameworkCore;
using QuizAppApi.Database.Models;

namespace QuizAppApi.Database
{
    public class QuizDbContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }

        public QuizDbContext(DbContextOptions<QuizDbContext> contextOptions) : base(contextOptions)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=QuizAppApi;Username=postgres;Password=IronSword12");
            base.OnConfiguring(optionsBuilder);
        }

        private bool SaveChanges()
        {
            return this.SaveChanges();
        }
    }
}
