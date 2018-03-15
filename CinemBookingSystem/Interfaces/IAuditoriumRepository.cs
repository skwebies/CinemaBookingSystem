using CinemaBookingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Interfaces
{
    public interface IAuditoriumRepository
    {
        IEnumerable<Auditorium> GetAllAuditoriums();

        Auditorium GetAllAuditorium(int auditoriumId);
    }
}
