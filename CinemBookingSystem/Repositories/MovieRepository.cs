using CinemaBookingData;
using CinemaBookingData.Models;
using CinemaBookingSystem.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {

        public MovieRepository(CinemaContext context) : base(context)
        {

        }
     
        
    }
}
