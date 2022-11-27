using ASP_EXAM.Models;
using ASP_EXAM.Settings;
using System.Net;

namespace ASP_EXAM.Roles.Admin
{
    public class AdminRepository : IAdminRepository<User>
    {
        private DatabaseContext _context;

        public AdminRepository(DatabaseContext context)
        {
            this._context = context;
        }

        public IEnumerable<User> GetAll() => _context.Users;

        public User? GetUserByMail(string mail) => (User?)_context.Users.FirstOrDefault(x => x.Email == mail);

        public bool AddUser(User user)
        {
            DatabaseContext context = new();
            var temp = context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (temp == null)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
