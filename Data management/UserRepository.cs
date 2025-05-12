using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBurgerApp.Data;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Data_management
{
    public class UserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context) => _context = context;

        public void Add(User user) { _context.Users.Add(user); _context.SaveChanges(); }
        public void Remove(User user) { _context.Users.Remove(user); _context.SaveChanges(); }
        public User? GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
