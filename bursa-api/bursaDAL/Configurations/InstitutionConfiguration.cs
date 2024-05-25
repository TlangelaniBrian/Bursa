using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class InstitutionConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Institution>
    {
        private readonly EntityTypeBuilder<Institution> _builder = modelBuilder.Entity<Institution>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Institution> builder)
        {
            builder.HasKey(x => x.Id)
                   .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new InstitutionId(v));

            //Seed Institution
            foreach (var institution in InstitutionData.InstitutionList)
            {
                builder.HasData(institution);
            }
        }
    }

}
