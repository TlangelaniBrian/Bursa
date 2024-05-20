using bursaDAL.Configurations;
using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;

namespace bursaDAL
{
    public class BursaContext : DbContext
    {
        public BursaContext(DbContextOptions<BursaContext> options) : base(options)
        {
        }

        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<AllowanceType> AllowanceTypes { get; set; }
        public DbSet<Bursary> Bursaries { get; set; }
        public DbSet<BursaryOfficer> BursaryOfficers { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FinancingInstitution> FinancingInstitutions { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentHistroy> PaymentHistroies { get; set; }
        public DbSet<Pocket> Pockets { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var configDb = new DbInitializer(modelBuilder);
            configDb.ConfigureTableKeys();
            configDb.SeedData();

        }


    }
}
