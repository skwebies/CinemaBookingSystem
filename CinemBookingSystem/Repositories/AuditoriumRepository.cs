using CinemaBookingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaBookingData.Models;
using CinemaBookingData;
using Microsoft.EntityFrameworkCore;

namespace CinemaBookingSystem.Repositories
{
    public class AuditoriumRepository : IAuditoriumRepository
    {
        private CinemaContext _context;

        public AuditoriumRepository(CinemaContext context)
        {
            _context = context;
        }

        //Get auditorium, seats and screenings by auditorium id
        public Auditorium GetAllAuditorium(int auditoriumId)
        {
            var auditorium = _context.Auditoriums.Include(a => a.Seats).Include(a => a.Screenings).Where(a => a.Id == auditoriumId).FirstOrDefault();

            return auditorium;
        }

        //Get All Auditoriums, seats and screenings
        public IEnumerable<Auditorium> GetAllAuditoriums()
        {
            var auditoriums = _context.Auditoriums.Include(a => a.Seats).Include(a => a.Seats).ToList();

            return auditoriums;
        }
    }
}
