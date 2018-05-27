using CinemaBookingSystem.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MovieController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }


        public IActionResult Index()
        {
            var movies = _repositoryWrapper.Movie.GetAll();

            return View(movies);
        }
    }
}
