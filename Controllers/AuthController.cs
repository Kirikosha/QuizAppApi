using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuizAppApi.Database.Interfaces;
using QuizAppApi.Database.Models;

namespace QuizAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        // Locks out a possibility for future logging in if the try was not successful
        private const bool SHOULD_LOCK_OUT_AFTER_FAILURE = false; 
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;
        private IUserRepository _userRepository;
        public AuthController(SignInManager<User> signInManager,
            IUserRepository userRepository, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userRepository = userRepository;
            _userManager = userManager;
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
        
        // TODO - make it also to try and get user by its username at the same time
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LogIn([FromBody] string email, [FromBody] string password)
        {
            User? user = null;
            int isSuccess = await TryGetUser(user, email);
            if(user == null)
            {
                return StatusCode(isSuccess);
            }
            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, password, SHOULD_LOCK_OUT_AFTER_FAILURE );
            if (signInResult.Succeeded)
            {
                return Ok();
            }
            return StatusCode(StatusCodes.Status401Unauthorized);
        }

        private async Task<int> TryGetUser(User? user, string email)
        {
            try
            {
                user = await _userRepository.GetUserByEmail(email);                
            }
            catch (ArgumentNullException)
            {
                return StatusCodes.Status400BadRequest;
            }
            catch (ArgumentException)
            {
                return StatusCodes.Status401Unauthorized;
            }
            // TODO - reconsider the following exception
            catch (Exception)
            {
                return StatusCodes.Status404NotFound;
            }
            return -1;
        }

        [HttpPost]
        [Route("register")]
        // TODO - write tests and check if works
        public async Task<IActionResult> Register([FromBody] string username, [FromBody] string email, [FromBody] string password)
        {
            User user = new User {
                Email = email,
                UserName = username,
                Role = Database.Enums.Role.Admin};
            IdentityResult result = await _userManager.CreateAsync(user, password);
            return Ok(user.Id);
        }
    }
}
