using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaBookingData.Models
{
   public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        [NotMapped]
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
