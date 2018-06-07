using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetroVynyl.API.Data;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController: Controller
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }
        
        public async Task<IActionResult> Register(string username, string password)
        {
            //validate request

            //convert username to lowercase
            username = username.ToLower();

            if (await _repo.UserExists(username))
                return BadRequest("Username is already taken");
            
            var userToCreate = new User
            {
                Username = username
            };

            var createUser = await _repo.Register(userToCreate, password);

            return StatusCode(201);
        }
    }
}