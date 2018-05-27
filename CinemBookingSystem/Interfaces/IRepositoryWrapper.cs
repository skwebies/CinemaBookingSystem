using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Interfaces
{
    public interface IRepositoryWrapper
    {
        IMovieRepository Movie { get; }
        IAuditoriumRepository Auditorium { get; }
    }
}
