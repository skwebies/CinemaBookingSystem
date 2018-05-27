using CinemaBookingData;
using CinemaBookingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly CinemaContext _cinemaContext;
        private IMovieRepository _movie;
        private IAuditoriumRepository _auditorium;


        public RepositoryWrapper(CinemaContext cinemaContext)
        {
            _cinemaContext = cinemaContext;
        }


        public IMovieRepository Movie
        {
            get
            {
                if(_movie == null)
                {
                    _movie = new MovieRepository(_cinemaContext);
                }

                return _movie;
            }
        }

        public IAuditoriumRepository Auditorium
        {
            get
            {
                if(_auditorium == null)
                {
                    _auditorium = new AuditoriumRepository(_cinemaContext);
                }

                return _auditorium;
            }
        }


        


    }
}
