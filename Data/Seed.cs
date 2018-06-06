using System.Collections.Generic;
using Newtonsoft.Json;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedAlbums()
        {
            //seed albums
            var albumData = System.IO.File.ReadAllText("Data/RetroVynyl.json");
            var albums = JsonConvert.DeserializeObject<List<Albums>>(albumData);

            foreach (var album in albums)
            {
                _context.Albums.Add(album);
            }

            _context.SaveChanges();
        }
    }
}