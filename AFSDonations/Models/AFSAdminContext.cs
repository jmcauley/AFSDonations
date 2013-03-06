using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AFSDonations.Models.Mapping;

namespace AFSDonations.Models
{
    public partial class AFSAdminContext : DbContext
    {
        static AFSAdminContext()
        {
            Database.SetInitializer<AFSAdminContext>(null);
        }

        public AFSAdminContext()
            : base("Name=AFSAdminContext")
        {
        }

        public DbSet<Donation> Donations { get; set; }
        public DbSet<StudentWidget> StudentWidgets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DonationMap());
            modelBuilder.Configurations.Add(new StudentWidgetMap());
        }
    }
}
