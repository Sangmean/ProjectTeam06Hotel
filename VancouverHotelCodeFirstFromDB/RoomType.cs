namespace VancouverHotelCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomType")]
    public partial class RoomType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomTypeId { get; set; }

        public int? RoomId { get; set; }

        [Column("RoomType")]
        [StringLength(50)]
        public string RoomType1 { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? Capacity { get; set; }

        public decimal? PricePerNight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }

        public virtual Room Room { get; set; }
    }
}
