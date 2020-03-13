using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
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

            userForRegisterDto.Username = userForRegisterDto.ToLower();


            if (await _repo.UserExists(userForRegisterDto))
                return BadRequest("Please note username already exists");

            var userToCreate = new User
            {
                username = userForRegisterDto.Username
            };


            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201)
        }

    }
}