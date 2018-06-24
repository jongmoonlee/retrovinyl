using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetroVynyl.API.Data;

namespace RetroVynyl.API.Controllers
{
    [Route("api/[controller]")]
    public class CartsController : Controller
    {
        private readonly DataContext _context;
        public CartsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCartsAsync()
        {
            var carts = await _context.Carts.ToListAsync();
            

            return Ok(carts);
        }
        [Route("api/[controller]/{id}")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartAsync(int id)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.Id == id);
           

            return Ok(cart);
        }
    }
}