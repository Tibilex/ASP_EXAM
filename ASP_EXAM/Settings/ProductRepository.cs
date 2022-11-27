using ASP_EXAM.Models;

namespace ASP_EXAM.Settings
{
    public class ProductRepository
    {
        private DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            this._context = context;
        }

        public IEnumerable<Product> GetAll() => _context.Products;
    }
}
