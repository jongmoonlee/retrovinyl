using System.Collections.Generic;
using System.Threading.Tasks;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Data
{
    public interface IRetroVynylRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> saveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}