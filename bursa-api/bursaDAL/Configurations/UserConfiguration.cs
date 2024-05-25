using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public class UserConfiguration(ModelBuilder modelBuilder) : IEntityTypeConfiguration<User>
    {
        private readonly EntityTypeBuilder<User> _builder = modelBuilder.Entity<User>();

        public void Setup()
        {
            Configure(_builder);
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id)
            .IsClustered(false);


            builder.Property(x => x.Id)
                .HasConversion(
                    v => v.Value,
                    v => new UserId(v));

            foreach (var user in UserData.UserList)
            {
                builder.HasData(user);
            }
        }
    }
}
