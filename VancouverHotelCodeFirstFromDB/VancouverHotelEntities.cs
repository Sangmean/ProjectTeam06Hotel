namespace VancouverHotelCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VancouverHotelEntities : DbContext
    {
        public VancouverHotelEntities()
            : base("name=VancouverHotelConnection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomReservation> RoomReservations { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Room>()
                .HasOptional(e => e.RoomReservation)
                .WithRequired(e => e.Room);
/*
            modelBuilder.Entity<Room>()
                .HasMany(e => e.RoomTypes)
                .WithOptional(e => e.Room)
                .HasForeignKey(e => e.RoomId);*/

            modelBuilder.Entity<RoomType>()
                .Property(e => e.PricePerNight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RoomType>()
                .HasMany(e => e.Rooms)
                .WithOptional(e => e.RoomType)
                .HasForeignKey(e => e.RoomTypeId);
        }
    }
}
