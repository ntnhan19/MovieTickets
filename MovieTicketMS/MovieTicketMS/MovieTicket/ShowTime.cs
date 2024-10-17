namespace MovieTicketMS.MovieTicket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShowTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShowTime()
        {
            Bookings = new HashSet<Booking>();
        }

        [StringLength(50)]
        public string ShowTimeID { get; set; }

        [Required]
        [StringLength(50)]
        public string MovieID { get; set; }

        [Column(TypeName = "date")]
        public DateTime ShowDate { get; set; }

        public TimeSpan StartTime { get; set; }

        [Required]
        [StringLength(100)]
        public string CinemaID { get; set; }

        [Required]
        [StringLength(50)]
        public string HallID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual Cinema Cinema1 { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Movy Movy { get; set; }
    }
}
