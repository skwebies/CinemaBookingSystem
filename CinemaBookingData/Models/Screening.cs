using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaBookingData.Models
{
   public class Screening
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int AuditoriumId { get; set; }

        public DateTime ScreeningStart { get; set; }

        [NotMapped]
        public virtual ICollection<Auditorium> Auditoriums { get; set; }

        [NotMapped]
        public virtual ICollection<SeatReserved> SeatsReserved { get; set; }

        [NotMapped]
        public virtual ICollection<Reservation> Reservations { get; set; }




    }
}
