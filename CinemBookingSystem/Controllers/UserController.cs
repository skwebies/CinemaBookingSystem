using CinemaBookingData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppIdentityUser> userManager;

        public UserController(
            UserManager<AppIdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var viewModel = this.userManager.Users.ToList();
            return View(viewModel);
        }
    }
}
