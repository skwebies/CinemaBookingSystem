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
        private readonly IMovieRepository _movieRepository;
        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;    
        }

        
        public IActionResult Index()
        {

            return View();
            
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
