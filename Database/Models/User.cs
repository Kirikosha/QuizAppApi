using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppApi.Database.Models {
    public class User : IdentityUser {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("username")]
        public required string Username { get; set; }
        [Column("password")]
        public required string Password { get; set; }
        [Column("email")]
        public required string Email { get; set; }
        public List<Result>? Result { get; set; }

    }
}
