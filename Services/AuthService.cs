public class AuthService
{
    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context = context;
    }

    public bool Authenticate(string username, string password)
    {
        var user = _context.Users.SingleOrDefault(u => u.Username == username);
        return user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
    }
}