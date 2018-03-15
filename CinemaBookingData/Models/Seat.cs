using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaBookingData.Models
{
    public class Seat
    {
        public int SeatId { get; set; }

        public int SeatRow { get; set; }

        public int SeatNumber { get; set; }

        public int AuditoriumId { get; set; }

        [NotMapped]
        public virtual ICollection<SeatReserved> SeatsReserved { get; set; }


    }
}
