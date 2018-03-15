using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaBookingData.Models
{
    public class ReservationType
    {
        public int Id { get; set; }

        public string ReservationTypeName { get; set; }

        [NotMapped]
        public virtual ICollection<Reservation> Reservations { get; set; }


    }
}
