using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public class AuthRepository : IAuthRepository
    { 
        private readonly DataContext _context;
        
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public Task<Users> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<Users> Register(Users user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}