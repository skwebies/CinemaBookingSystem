﻿// <auto-generated />
using CinemaBookingData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CinemaBookingData.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaBookingData.Models.Auditorium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("SeatsNumber");

                    b.HasKey("Id");

                    b.ToTable("Auditoriums");
                });

            modelBuilder.Entity("CinemaBookingData.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CinemaBookingData.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cast");

                    b.Property<string>("Description");

                    b.Property<string>("DirectorName");

                    b.Property<string>("MovieName");

                    b.Property<string>("MovieType");

                    b.Property<string>("Reviews");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinemaBookingData.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeePaidId");

                    b.Property<int>("EmployeeReservedId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsPaid");

                    b.Property<bool>("IsReserved");

                    b.Property<int>("ReservationContact");

                    b.Property<int>("ReservationTypeId");

                    b.Property<int>("ScreeningId");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CinemaBookingData.Models.ReservationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ReservationTypeName");

                    b.HasKey("Id");

                    b.ToTable("ReservationTypes");
                });

            modelBuilder.Entity("CinemaBookingData.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuditoriumId");

                    b.Property<int>("MovieId");

                    b.Property<DateTime>("ScreeningStart");

                    b.HasKey("Id");

                    b.ToTable("Screenings");
                });

            modelBuilder.Entity("CinemaBookingData.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuditoriumId");

                    b.Property<int>("SeatNumber");

                    b.Property<int>("SeatRow");

                    b.HasKey("SeatId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("CinemaBookingData.Models.SeatReserved", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ReservationId");

                    b.Property<int>("ScreeningId");

                    b.Property<int>("SeatId");

                    b.HasKey("Id");

                    b.ToTable("SeatsReserved");
                });
#pragma warning restore 612, 618
        }
    }
}
