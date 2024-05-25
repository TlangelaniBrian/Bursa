using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class BursaryOfficerConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<BursaryOfficer>
    {

        private readonly EntityTypeBuilder<BursaryOfficer> _builder = modelBuilder.Entity<BursaryOfficer>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<BursaryOfficer> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new BursaryOfficerId(v));

            builder.Property(x => x.BursaryId)
                .HasConversion(
                    v => v.Value,
                    v => new BursaryId(v));

            foreach (var bursaryOfficer in BursaryOfficerData.BursaryOfficerList)
            {
                builder.HasData(bursaryOfficer);
            }
        }
    }
}
