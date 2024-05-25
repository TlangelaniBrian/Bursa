using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class AllowanceConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Allowance>
    {
        private readonly EntityTypeBuilder<Allowance> _builder = modelBuilder.Entity<Allowance>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Allowance> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new AllowanceId(v));

            //Seed Allowance
            foreach (var allowance in AllowanceData.AllowanceList)
            {
                builder.HasData(allowance);
            }
        }
    }
}
