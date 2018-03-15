using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CinemBookingSystem.Models;
using CinemaBookingSystem.Interfaces;

namespace CinemBookingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;    
        }

        public IActionResult Index()
        {
            var movies = _movieRepository.GetAllMovies();
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
