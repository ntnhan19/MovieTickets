namespace MovieTicketMS.MovieTicket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hall()
        {
            ShowTimes = new HashSet<ShowTime>();
        }

        [StringLength(50)]
        public string HallID { get; set; }

        [Required]
        [StringLength(100)]
        public string CinemaID { get; set; }

        [Required]
        [StringLength(50)]
        public string HallName { get; set; }

        public int TotalSeats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
