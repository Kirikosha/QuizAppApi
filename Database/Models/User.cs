using Microsoft.AspNetCore.Identity;
using QuizAppApi.Database.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppApi.Database.Models {
    public class User : IdentityUser {
        public required Guid Id { get; set; }
        public required string Email { get; set; }
        public required Role Role { get; set; }
        public List<Result>? Result { get; set; }

    }
}
