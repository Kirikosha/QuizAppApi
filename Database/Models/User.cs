using Microsoft.AspNetCore.Identity;
using QuizAppApi.Database.Enums;
using QuizAppApi.ServiceModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppApi.Database.Models {
    public class User : IdentityUser<int> {
        public required string Email { get; set; }
        public required Role Role { get; set; }
        public List<Result>? Result { get; set; }
        
    }
}
