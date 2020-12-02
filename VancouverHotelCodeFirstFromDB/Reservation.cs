namespace VancouverHotelCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            Payments = new HashSet<Payment>();
            RoomReservations = new HashSet<RoomReservation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }

        public int? GuestId { get; set; }

        public int? RoomId { get; set; }

        public String ReservationDate { get; set; }

       // [Column(TypeName = "date")]
        public String CheckInDate { get; set; }

       // [Column(TypeName = "date")]
        public String CheckOutDate { get; set; }

        public int? NumberOfGuest { get; set; }

        public int NumberOfNight { get; set; }

        public virtual Guest Guest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual Room Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomReservation> RoomReservations { get; set; }

       
    }
}