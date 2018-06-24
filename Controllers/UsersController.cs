using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetroVynyl.API.Data;
using AutoMapper;
using RetroVynyl.API.Dtos;
using System.Collections.Generic;

namespace RetroVynyl.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IRetroVynylRepository _repo;
        private readonly IMapper _mapper;

        public UsersController(IRetroVynylRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _repo.GetUsers();
            var usersToReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);

            return Ok(usersToReturn);
        }

        [Route("api/[controller]/{id}")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);

            return Ok(user);
        }
    }
}