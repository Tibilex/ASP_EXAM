using ASP_EXAM.Models;
using ASP_EXAM.Roles.Admin;
using ASP_EXAM.Settings;
using Microsoft.AspNetCore.Mvc;

namespace ASP_EXAM.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ProductController : Controller
    {
        private ProductWork m_work = new();

        [HttpGet("AllProducts")]
        public IEnumerable<Product> GetAll() => m_work.ProductRepository.GetAll();

    }
}
