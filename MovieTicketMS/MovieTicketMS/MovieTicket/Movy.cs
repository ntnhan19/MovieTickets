namespace MovieTicketMS.MovieTicket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movy()
        {
            ShowTimes = new HashSet<ShowTime>();
        }

        [Key]
        [StringLength(50)]
        public string MovieID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public int Duration { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
