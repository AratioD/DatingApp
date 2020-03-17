using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;

        }

        [HttpPost("register")]

        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Your user username exists!! Please check a new one. ");

            var userToCreate = new User
            {
                Username = userForRegisterDto.Username
            };


            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Username);
            return StatusCode(201);

        }

        [HttpPost("login")]

        public async Task<IActionResult> Login(UserForRegisterDto userForRegisterDto)
    }
}
