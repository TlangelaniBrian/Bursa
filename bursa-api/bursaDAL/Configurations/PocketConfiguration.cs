using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class PocketConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Pocket>
    {
        private readonly EntityTypeBuilder<Pocket> _builder = modelBuilder.Entity<Pocket>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Pocket> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);


            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new PocketId(v));

            builder
                .HasOne(p => p.Beneficiary)
                .WithMany()
                .HasForeignKey(p => p.BeneficiaryId)
                .OnDelete(DeleteBehavior.Restrict);

            foreach (var pocket in PocketData.PocketList)
            {
                builder.HasData(pocket);
            }
        }
    }
}
