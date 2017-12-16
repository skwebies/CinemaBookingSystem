using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingData.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public string DirectorName { get; set; }

        public string Cast { get; set; }

        public string Reviews { get; set; }

        public string Description { get; set; }

        public string MovieType { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }



    }
}
