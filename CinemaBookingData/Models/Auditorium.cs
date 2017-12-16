using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingData.Models
{
    public class Auditorium
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SeatsNumber { get; set; }

        public ICollection<Seat> Seats { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }
    }
}
