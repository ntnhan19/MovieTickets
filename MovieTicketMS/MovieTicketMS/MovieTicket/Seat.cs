namespace MovieTicketMS.MovieTicket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seat()
        {
            Bookings = new HashSet<Booking>();
        }

        [StringLength(10)]
        public string SeatID { get; set; }

        public int SeatNumber { get; set; }

        [Required]
        [StringLength(1)]
        public string RowLetter { get; set; }

        [Required]
        [StringLength(50)]
        public string SeatType { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
