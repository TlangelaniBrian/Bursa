using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class RoleConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<Role>
    {
        private readonly EntityTypeBuilder<Role> _builder = modelBuilder.Entity<Role>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);

            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new RoleId(v));

            foreach (var role in RoleData.RoleList)
            {
                builder.HasData(role);
            }
        }
    }
}
