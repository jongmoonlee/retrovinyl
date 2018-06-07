using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetroVynyl.API.Data;

namespace RetroVynyl.API.Controllers
{
    [Route("api/[controller]")]
    public class AlbumsController : Controller
    {
        private readonly DataContext _context;
        public AlbumsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbumsAsync()
        {
            var albums = await _context.Albums.ToListAsync();

            return Ok(albums);
        }
        [Route("api/[controller]/{id}")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlbumAsync(int id)
        {
            var album = await _context.Albums.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(album);
        }
    }
}