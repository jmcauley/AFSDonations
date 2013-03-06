using System;
using System.Collections.Generic;

namespace AFSDonations.Models
{
    public partial class StudentWidget
    {
        public StudentWidget()
        {
            this.Donations = new List<Donation>();
        }

        public System.Guid StudentWidgetId { get; set; }
        public string Srn { get; set; }
        public string ProgramRefCode { get; set; }
        public string DestinationCountry { get; set; }
        public decimal FundraisingAmount { get; set; }
        public System.DateTime EndDate { get; set; }
        public string DisplayName { get; set; }
        public string BlogUrl { get; set; }
        public decimal AmountRaised { get; set; }
        public string State { get; set; }
        public int EnabledStatus { get; set; }
        public System.Guid ServiceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string AreaTeam { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
    }
}
