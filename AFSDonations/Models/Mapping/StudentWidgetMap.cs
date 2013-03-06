using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AFSDonations.Models.Mapping
{
    public class StudentWidgetMap : EntityTypeConfiguration<StudentWidget>
    {
        public StudentWidgetMap()
        {
            // Primary Key
            this.HasKey(t => t.StudentWidgetId);

            // Properties
            // Table & Column Mappings
            this.ToTable("StudentWidgets");
            this.Property(t => t.StudentWidgetId).HasColumnName("StudentWidgetId");
            this.Property(t => t.Srn).HasColumnName("Srn");
            this.Property(t => t.ProgramRefCode).HasColumnName("ProgramRefCode");
            this.Property(t => t.DestinationCountry).HasColumnName("DestinationCountry");
            this.Property(t => t.FundraisingAmount).HasColumnName("FundraisingAmount");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.BlogUrl).HasColumnName("BlogUrl");
            this.Property(t => t.AmountRaised).HasColumnName("AmountRaised");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.EnabledStatus).HasColumnName("EnabledStatus");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.AreaTeam).HasColumnName("AreaTeam");
        }
    }
}
