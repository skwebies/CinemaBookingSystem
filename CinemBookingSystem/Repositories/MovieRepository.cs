using CinemaBookingData;
using CinemaBookingData.Models;
using CinemaBookingSystem.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _context;

        public MovieRepository(CinemaContext context)
        {
            _context = context; 
        }

        //Get all movies with screenings
        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = _context.Movies.ToList();

            return movies;
        }

        //Get movie and screenings by movie id
        public Movie GetMovieById(int movieId)
        {
            var movie = _context.Movies.Where(m => m.MovieId == movieId).Include(s => s.Screenings).FirstOrDefault();

            return movie;
        }
                       
    }
}
