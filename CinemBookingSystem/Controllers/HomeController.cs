using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CinemBookingSystem.Models;
using CinemaBookingSystem.Interfaces;
using Microsoft.AspNetCore.Authorization;
using CinemaBookingSystem.Repositories;
using CinemaBookingData;

namespace CinemBookingSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public HomeController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;    
        }

        
        public IActionResult Index()
        {
            var movies = _repositoryWrapper.Movie.GetAll();
            return View(movies);
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
