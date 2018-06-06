using Microsoft.EntityFrameworkCore;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Albums> Albums {get; set;}

        
    }
}