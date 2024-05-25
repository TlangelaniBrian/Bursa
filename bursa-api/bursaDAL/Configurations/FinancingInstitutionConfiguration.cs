using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class FinancingInstitutionConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<FinancingInstitution>
    {
        private readonly EntityTypeBuilder<FinancingInstitution> _builder = modelBuilder.Entity<FinancingInstitution>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<FinancingInstitution> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new FinancingInstitutionId(v));

            foreach (var financingInstitution in FinancingInstitutionData.FinancingInstitutionList)
            {
                builder.HasData(financingInstitution);
            }
        }
    }
}
