using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class ResidenceConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Residence>
    {
        private readonly EntityTypeBuilder<Residence> _builder = modelBuilder.Entity<Residence>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Residence> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new ResidenceId(v));

            foreach (var residence in ResidenceData.ResidenceList)
            {
                builder.HasData(residence);
            }
        }
    }
}
