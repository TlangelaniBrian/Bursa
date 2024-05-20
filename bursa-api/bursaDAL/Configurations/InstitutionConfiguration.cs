using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
        public class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
        {
            public void Configure(EntityTypeBuilder<Institution> builder)
            {
                ConfigureInstitutionKeys(builder);
            }

            private void ConfigureInstitutionKeys(EntityTypeBuilder<Institution> builder)
            {
                builder.ToTable("Institution");
                builder.HasKey(x => x.Id)
                       .IsClustered(false);

                builder.Property(x => x.Id)
                       .ValueGeneratedNever()
                       .HasConversion(id => id.Value, 
                                      value => InstitutionId.CreateInstitutionId(value));

            }

          
        }
    
}
