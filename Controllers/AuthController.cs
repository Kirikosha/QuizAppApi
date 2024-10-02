using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuizAppApi.Database.Models;

namespace QuizAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        SignInManager<User> _signInManager;
        public AuthController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        [Route("isLoggedIn")]
        public IActionResult IsLoggedIn()
        {
            Console.WriteLine("I am working!");
            if(User.Identity == null)
            {
                return Ok(false);
            }
            return Ok(User.Identity.IsAuthenticated);
        }
    }
}
