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
    public class AuditoriumRepository : Repository<Auditorium>, IAuditoriumRepository
    {

        public AuditoriumRepository(CinemaContext context) : base(context)
        {

        }

        
    }
}
