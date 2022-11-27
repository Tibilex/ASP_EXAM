using ASP_EXAM.Roles.Admin;

namespace ASP_EXAM.Settings
{
    public class ProductWork : IDisposable
    {

        private DatabaseContext _dataContext;
        private ProductRepository _productRepository;

        public ProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_dataContext);
                return _productRepository;
            }
            set { _productRepository = value; }
        }

        public ProductWork()
        {
            _dataContext = new();
        }
        public void Dispose() => GC.SuppressFinalize(this);
        
    }
}
