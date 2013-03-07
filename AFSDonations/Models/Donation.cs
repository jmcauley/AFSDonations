using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFSDonations.Models
{
    public partial class Donation
    {
        public System.Guid DonationId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.Guid> StudentWidget_StudentWidgetId { get; set; }
        public string TransactionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Zip { get; set; }
        public System.DateTime DateOfTransaction { get; set; }
        public virtual StudentWidget StudentWidget { get; set; }

        [NotMapped]
        public string CardName { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public string CardNumber { get; set; }
        [NotMapped]
        public string ExpMonth { get; set; }
        [NotMapped]
        public string ExpYear { get; set; }
        [NotMapped]
        public string CVV2 { get; set; }
    }
}
