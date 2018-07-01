using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetroVynyl.API.Data;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Controllers
{
    [Route("api/[controller]")]
    public class CartsController : Controller
    {
        private readonly IRetroVynylRepository _repo;
        public CartsController(IRetroVynylRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCartsAsync()
        {
            var carts = await _repo.Carts;
            return Ok(carts);  
            
        }

        [Route("api/[controller]/{id}")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartAsync(int id)
        {
            var cart = await _repo.GetCart(id);
           

            return Ok(cart);
        }


       
        [HttpPost]
        public async void AddCartAsync(Carts cart)
        {    
             

            _repo.Add(cart);
            await _repo.saveAll();
        }
    }
}