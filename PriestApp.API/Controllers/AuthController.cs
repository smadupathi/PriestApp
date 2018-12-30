using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriestApp.API.Data;
using PriestApp.API.Dtos;
using PriestApp.API.Models;

namespace PriestApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthRepository _repo;
        public AuthController(AuthRepository repo)
        {
            _repo = repo;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Username= userForRegisterDto.Username.ToLower();

            if(await _repo.UserExists(userForRegisterDto.Username))
            return BadRequest("Username already Exists");

            var userToCreate=new User
            {
                Username=userForRegisterDto.Username
            };

            var createdUser=await _repo.Register(userToCreate,userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}