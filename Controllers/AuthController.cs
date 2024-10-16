using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QuizAppApi.Database.Interfaces;
using QuizAppApi.Database.Models;
using QuizAppApi.ServiceModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QuizAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        // Locks out a possibility for future logging in if the try was not successful
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;
        private IUserRepository _userRepository;
        private IConfiguration _config;
        public AuthController(SignInManager<User> signInManager,
            IUserRepository userRepository, UserManager<User> userManager,
            IConfiguration config)
        {
            _signInManager = signInManager;
            _userRepository = userRepository;
            _userManager = userManager;
            _config = config;
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

        #region LoginImplementation
        // TODO - make it also to try and get user by its username at the same time
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel model)
        {
            var response = await TryGetUser(model.EmailOrUsername, model.IsEmail);
            Exception? exceptionObj = response.Item1;
            if(exceptionObj != null)
            {
                return BadRequest( new { error = exceptionObj.Message });
            }
            else if(response.Item2 == null)
            {
                return Problem(detail: "Retreiving user object from database was not successful");
            }

            User user = response.Item2;
            UserClaimModel claimModel = new UserClaimModel(user);
            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (signInResult.Succeeded)
            {
                string token = GenerateJWT(claimModel);

                var cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = DateTime.UtcNow.AddHours(2)
                };
                Response.Cookies.Append("token", token, cookieOptions);

                return Ok(new {message = "Logged in successfully"});
            }
            else
            {
                return Unauthorized(new { error = "Signing in wasn't successful"});
            }
        }

        private async Task<(Exception?, User?)> TryGetUser(string email, bool isEmail)
        {
            User? user;
            try
            {
                if (isEmail)
                {
                    user = await _userRepository.GetUserByEmail(email);                
                }
                else
                {
                    user = await _userRepository.GetUserByUserName(email);
                }
            }
            catch (ArgumentNullException exc)
            {
                return (exc, null);
            }
            catch (ArgumentException exc)
            {
                return (exc, null);
            }
            // TODO - reconsider the following exception
            catch (Exception exc)
            {
                return (exc, null);
            }
            return (null, user);
        }
        #endregion

        [HttpPost]
        [Route("register")]
        // TODO - write tests and check if works
        public async Task<IActionResult> Register([FromBody] UserRegistrationModel model)
        {
            User user = new User()
            {
                Email = model.Email,
                Role = Database.Enums.Role.Member,
                UserName = model.UserName
            };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                UserClaimModel userClaim = new UserClaimModel(user);
                string token = GenerateJWT(userClaim);

                var cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = DateTime.UtcNow.AddHours(2)
                };
                Response.Cookies.Append("token", token, cookieOptions);

                return Ok(new {message = "Logged in successfully"});
            }
            return BadRequest(new { message = "Registration wasn't successful" });
        }

        private string GenerateJWT(UserClaimModel model)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, model.Email),
                new Claim(JwtRegisteredClaimNames.Sub, model.UserName),
                new Claim("PhoneNumber", model.PhoneNumber ?? string.Empty),
                new Claim("UserRole", nameof(model.Role)),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["JWT:ValidIssuer"],
                _config["JWT:ValidAudience"], claims, expires: DateTime.Now.AddHours(3),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
