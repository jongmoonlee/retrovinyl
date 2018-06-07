using System.Threading.Tasks;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);  
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);  
    }
}