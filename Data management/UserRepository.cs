using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfBurgerApp.Data;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Data_management
{
    public class UserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context) => _context = context;

        public async Task<bool> RegisterUserAsync(User user)
        {

            bool exists = await _context.Users.AnyAsync(u => u.Username == user.Username);
            if (exists)
            {
                MessageBox.Show("A megadott felhasználónév már létezik. Kérlek adj meg egy másikat.");
                return false;
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }
        public void Remove(User user) { _context.Users.Remove(user); _context.SaveChanges(); }
        public User? GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
