namespace MovieTicketMS.MovieTicket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentID { get; set; }

        public int BookingID { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
