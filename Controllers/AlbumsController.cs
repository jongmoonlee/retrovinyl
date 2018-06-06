using System.Linq;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAlbums()
        {
            var albums = _context.Albums.ToList();

            return Ok(albums);
        }

        [HttpGet("{id}")]
        public IActionResult GetAlbum(int id)
        {
            var album = _context.Albums.FirstOrDefault(x => x.Id == id);

            return Ok(album);
        }
    }
}