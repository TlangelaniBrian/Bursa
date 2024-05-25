using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class FeatureConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Feature>
    {
        private readonly EntityTypeBuilder<Feature> _builder = modelBuilder.Entity<Feature>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new FeatureId(v));

            foreach (var feature in FeatureData.FeatureList)
            {
                builder.HasData(feature);
            }
        }
    }
}
