using System.Linq;
using WpfBurgerApp.Data;
using BCrypt.Net;

namespace WpfBurgerApp.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepo;
        public AuthService(UserRepository repo) => _userRepo = repo;

        public bool Authenticate(string username, string password)
        {
            var user = _userRepo.GetByUsername(username);
            return user != null && BCrypt.Verify(password, user.PasswordHash);
        }
    }
}
