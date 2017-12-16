using CinemaBookingData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingData
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; } 
    }
}
