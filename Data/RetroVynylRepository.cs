using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Data
{
    public class RetroVynylRepository : IRetroVynylRepository
    {
        private readonly DataContext _context;

        public RetroVynylRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<Carts> GetCart(int id)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(u => u.Id == id);
            return cart;
        }

        public async Task<IEnumerable<Carts>> GetCarts()
        {
            var carts = await _context.Carts.ToListAsync();
            return carts;
        }

        public async Task<bool> saveAll()
        {
           return await _context.SaveChangesAsync() > 0;
        }
    }
}