using ASP_EXAM.Settings;

namespace ASP_EXAM.Roles.Admin
{
    public class AdminWork : IDisposable
    {
        private DatabaseContext _userContext;
        private AdminRepository _adminRepository;

        public AdminRepository AdminRepository
        {
            get
            {
                if (_adminRepository == null)
                    _adminRepository = new AdminRepository(_userContext);
                return _adminRepository;
            }
            set { _adminRepository = value; }
        }

        public AdminWork()
        {
            _userContext = new();
        }
        public void Dispose() => GC.SuppressFinalize(this);
    }
    
}