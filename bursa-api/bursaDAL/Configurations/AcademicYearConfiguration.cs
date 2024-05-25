using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class AcademicYearConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<AcademicYear>
    {
        private readonly EntityTypeBuilder<AcademicYear> _builder = modelBuilder.Entity<AcademicYear>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<AcademicYear> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new AcademicYearId(v));

            foreach (var academicYear in AcademicYearData.AcademicYearList)
            {
                builder.HasData(academicYear);
            }
        }
    }
}
