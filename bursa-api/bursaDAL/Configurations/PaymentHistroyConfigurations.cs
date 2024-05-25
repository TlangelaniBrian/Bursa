using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bursaDAL.Configurations
{
    public class PaymentHistroyConfigurations(ModelBuilder modelBuilder) : IEntityTypeConfiguration<PaymentHistory>
    {
        private readonly EntityTypeBuilder<PaymentHistory> _builder = modelBuilder.Entity<PaymentHistory>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<PaymentHistory> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new PaymentHistoryId(v));

        }
    }
}
