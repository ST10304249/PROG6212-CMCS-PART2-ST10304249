using Prog_P2;
using Microsoft.AspNetCore.Mvc;
using Prog_P2.Models;

namespace Prog_P2.Services
{
    public interface IUserService
    {
        Task<bool> ValidateUserCredentials(string username, string password);
        Task<User?> GetUserByIdAsync(int id);
        User Authenticate(string username, string password);
    }
}

