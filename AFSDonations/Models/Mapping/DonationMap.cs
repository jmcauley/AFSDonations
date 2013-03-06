using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AFSDonations.Models.Mapping
{
    public class DonationMap : EntityTypeConfiguration<Donation>
    {
        public DonationMap()
        {
            // Primary Key
            this.HasKey(t => t.DonationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Donations");
            this.Property(t => t.DonationId).HasColumnName("DonationId");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.StudentWidget_StudentWidgetId).HasColumnName("StudentWidget_StudentWidgetId");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.DateOfTransaction).HasColumnName("DateOfTransaction");

            // Relationships
            this.HasOptional(t => t.StudentWidget)
                .WithMany(t => t.Donations)
                .HasForeignKey(d => d.StudentWidget_StudentWidgetId);

        }
    }
}
