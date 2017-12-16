using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingData.Models
{
   public class Screening
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int AuditoriumId { get; set; }

        public DateTime ScreeningStart { get; set; }        

        public virtual ICollection<Auditorium> Auditoriums { get; set; }

    }
}
