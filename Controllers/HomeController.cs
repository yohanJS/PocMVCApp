using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PocMVCApp.Data;
using PocMVCApp.Models;
using System.Diagnostics;

namespace PocMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                // Check if TwoFactorEnabled is true for the current user
                bool isTwoFactorEnabled = await _userManager.GetTwoFactorEnabledAsync(currentUser);

                if (!isTwoFactorEnabled)
                {
                    // Pass the result to the view
                    ViewBag.IsTwoFactorEnabled = false;
                }
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UserCardsPartial() {
            return PartialView("_UsersCard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}