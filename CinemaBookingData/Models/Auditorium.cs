using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaBookingData.Models
{
    public class Auditorium
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SeatsNumber { get; set; }

        public ICollection<Seat> Seats { get; set; }

        [NotMapped]
        public virtual ICollection<Screening> Screenings { get; set; }
    }
}
