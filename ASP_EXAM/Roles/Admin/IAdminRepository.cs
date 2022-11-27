using System.Net;

namespace ASP_EXAM.Roles.Admin
{
    public interface IAdminRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        public T? GetUserByMail(string T);
        bool AddUser(T T);
    }
}
