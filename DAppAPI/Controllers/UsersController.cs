using DAppAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DAppAPI.Controllers
{
    [ApiController]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
