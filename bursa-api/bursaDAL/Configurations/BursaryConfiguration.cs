using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class BursaryConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Bursary>
    {
        private readonly EntityTypeBuilder<Bursary> _builder = modelBuilder.Entity<Bursary>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Bursary> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new BursaryId(v));

            foreach (var bursary in BursaryData.BursaryList)
            {
                builder.HasData(bursary);
            }
        }
    }
}
