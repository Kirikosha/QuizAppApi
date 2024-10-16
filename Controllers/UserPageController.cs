using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace QuizAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserPageController : Controller
    {
        [Authorize]
        [HttpGet]
        [Route("profile")]
        public IActionResult GetUserProfile()
        {
            string token = Request.Cookies["token"] ?? string.Empty;
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest(new { message = "JWT token was not received" });
            }

            var jwtToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;
             return Ok();
        }
    }
}
