namespace MovieTicketMS.MovieTicket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            Payments = new HashSet<Payment>();
        }

        public int BookingID { get; set; }

        [Required]
        [StringLength(10)]
        public string SeatID { get; set; }

        public DateTime BookingTime { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [Required]
        [StringLength(50)]
        public string ShowTimeID { get; set; }

        public int UserID { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual ShowTime ShowTime { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
