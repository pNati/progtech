using System.Linq;
using WpfBurgerApp.Data;
using WpfBurgerApp.Data_management;
using System.Windows;

namespace WpfBurgerApp.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepo;
        public AuthService(UserRepository repo) => _userRepo = repo;

        public bool Authenticate(string username, string password)
        {
            var user = _userRepo.GetByUsername(username);
            try
            {
                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash)) {
                    AppState.User = user;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                //MessageBox teszteléshez. Hogy ne fagyjon ki, a hibát kiíratjuk (catch-el).
                MessageBox.Show(ex.Message);
                
                return false;
            }
        }
    }
}
