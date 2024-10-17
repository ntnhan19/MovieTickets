using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MovieTicketMS.MovieTicket
{
    public partial class DBMovieTicket : DbContext
    {
        public DBMovieTicket()
            : base("name=DBMovieTicket")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Movy> Movies { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<ShowTime> ShowTimes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.SeatID)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.ShowTimes)
                .WithRequired(e => e.Cinema)
                .HasForeignKey(e => e.CinemaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.ShowTimes1)
                .WithRequired(e => e.Cinema1)
                .HasForeignKey(e => e.CinemaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.ShowTimes)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.ShowTimes)
                .WithRequired(e => e.Movy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Seat>()
                .Property(e => e.SeatID)
                .IsUnicode(false);

            modelBuilder.Entity<Seat>()
                .Property(e => e.RowLetter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Seat>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Seat>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Seat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShowTime>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.ShowTime)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
