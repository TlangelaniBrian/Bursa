using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class PaymentConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Payment>
    {
        private readonly EntityTypeBuilder<Payment> _builder = modelBuilder.Entity<Payment>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new PaymentId(v));

            builder.Property(x => x.PocketId)
                .HasConversion(
                    v => v.Value,
                    v => new PocketId(v));

            builder.Property(x => x.PaymentTypeId)
                .HasConversion(
                    v => v.Value,
                    v => new AllowanceId(v));

            builder.Property(x => x.BeneficiaryId)
                .HasConversion(
                    v => v.Value,
                    v => new UserId(v));

            builder.Property(x => x.PaymentOfficerId)
                .HasConversion(
                    v => v.Value,
                    v => new UserId(v));

            builder.HasOne<User>("PaymentOfficer")
                .WithMany()
                .HasForeignKey(x => x.PaymentOfficerId)
                .OnDelete(DeleteBehavior.Restrict);

            //Seed Payment
            foreach (var payment in PaymentData.PaymentList)
            {
                builder.HasData(payment);
            }
        }
    }
}
