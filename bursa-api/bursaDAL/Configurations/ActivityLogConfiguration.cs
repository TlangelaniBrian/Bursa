using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bursaDAL.Configurations
{
    public class ActivityLogConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<ActivityLog>
    {
        private readonly EntityTypeBuilder<ActivityLog> _builder = modelBuilder.Entity<ActivityLog>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<ActivityLog> builder)
        {
            builder.HasKey(x => x.Id)
                .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new ActivityLogId(v));

        }
    }
}
