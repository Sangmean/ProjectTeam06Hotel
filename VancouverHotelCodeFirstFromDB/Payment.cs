namespace VancouverHotelCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentId { get; set; }

        public int? ReservationId { get; set; }

        public int? GuestId { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(50)]
        public string PaymentType { get; set; }

        public virtual Guest Guest { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
