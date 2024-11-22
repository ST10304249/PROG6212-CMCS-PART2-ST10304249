using Prog_P2;
using System.Threading.Tasks;
using Prog_P2.Models;

namespace Prog_P2.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> ValidateUserCredentials(string username, string password)
        {
            // Basic example; You should use a proper hashed password check
            var user = _context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);
            return Task.FromResult(user != null);
        }

        public Task<User?> GetUserByIdAsync(int id)
        {
            return Task.FromResult<User?>(_context.Users.FirstOrDefault(u => u.UserID == id));
        }

        public User Authenticate(string username, string password)
        {
            // Basic example; You should use a proper hashed password check
            var user = _context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);
            return user ?? throw new InvalidOperationException("User not found");
        }
    }


}


