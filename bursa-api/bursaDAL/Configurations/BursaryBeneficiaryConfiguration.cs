using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bursaDAL.Configurations
{
    public class BursaryBeneficiaryConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<BursaryBeneficiary>
    {

        private readonly EntityTypeBuilder<BursaryBeneficiary> _builder = modelBuilder.Entity<BursaryBeneficiary>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<BursaryBeneficiary> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new BursaryBeneficiaryId(v));

            builder.Property(x => x.BursaryId)
                .HasConversion(
                    v => v.Value,
                    v => new BursaryId(v));

        }
    }
}
