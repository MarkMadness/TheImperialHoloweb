using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TheImperialHoloweb.Data;

namespace TheImperialHoloweb.Controllers
{
    public class LawOrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LawOrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> BountyBoard()
        {
            var bounties = await _context.LawBounties.ToListAsync();
            return View(bounties);
        }

        // Other actions (Create, Edit, Delete) can be added here
        public IActionResult Code()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult Rebels()
        {
            return View();
        }
    }
}
