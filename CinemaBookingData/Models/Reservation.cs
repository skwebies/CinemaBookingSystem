using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaBookingData.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int ScreeningId { get; set; }

        public int EmployeeReservedId { get; set; }

        public int ReservationTypeId { get; set; }

        public int ReservationContact { get; set; }

        public bool IsReserved { get; set; }

        public int EmployeePaidId { get; set; }

        public bool IsPaid { get; set; }

        public bool IsActive { get; set; }

    }
}
