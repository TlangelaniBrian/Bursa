using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class AllowanceTypeConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<AllowanceType>
    {
        private readonly EntityTypeBuilder<AllowanceType> _builder = modelBuilder.Entity<AllowanceType>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<AllowanceType> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new AllowanceTypeId(v));

            foreach (var allowanceType in AllowanceTypeData.AllowanceTypeList)
            {
                builder.HasData(allowanceType);
            }
        }

    }
}
