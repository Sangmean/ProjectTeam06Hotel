namespace VancouverHotelCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomReservation")]
    public partial class RoomReservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }

        public int? ReservationId { get; set; }

        public virtual Reservation Reservation { get; set; }

        public virtual Room Room { get; set; }
    }
}
