using Microsoft.EntityFrameworkCore;

namespace API_Authentication
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User? GetEmailAndPassword(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user is null) return null;

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, user.Password);
            return isPasswordValid ? user : null;

        }
    }
}
