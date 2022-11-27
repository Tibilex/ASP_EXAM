using ASP_EXAM.Models;
using ASP_EXAM.Roles.Admin;
using Microsoft.AspNetCore.Mvc;

namespace ASP_EXAM.Controllers
{
    [ApiController]
    [Route("controller")]
    public class AdminController : Controller
    {
        private AdminWork m_work = new();

        [HttpGet("GetAllUsers")]
        public IEnumerable<object> GetAll() => m_work.AdminRepository.GetAll();

        [HttpGet("GetToMail")]
        public User? GetUserByMail(string mail) => m_work.AdminRepository.GetUserByMail(mail);

        [HttpPost("Add")]
        public string AddUser([FromForm] User user)
        {
            if (!TryValidateModel(user, nameof(User)))
                return "!!! This email is already registered:";
            ModelState.ClearValidationState(nameof(User));

            if (!m_work.AdminRepository.AddUser(user))
            {
                return "!!! This email is already registered:";
            }
            return "Registrarion successful:";
        }
    }
}
