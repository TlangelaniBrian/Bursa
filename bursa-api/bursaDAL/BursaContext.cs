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

        public DbSet<Feature> Features { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<AllowanceType> AllowanceTypes { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Bursary> Bursaries { get; set; }
        public DbSet<BursaryOfficer> BursaryOfficers { get; set; }
        public DbSet<BursaryBeneficiary> BursaryBeneficiaries { get; set; }
        public DbSet<FinancingInstitution> FinancingInstitutions { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentHistory> PaymentHistories { get; set; }
        public DbSet<Pocket> Pockets { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new FeatureConfiguration(modelBuilder).Setup();
            new RoleConfiguration(modelBuilder).Setup();
            new UserConfiguration(modelBuilder).Setup();
            new InstitutionConfiguration(modelBuilder).Setup();
            new AcademicYearConfiguration(modelBuilder).Setup();
            new AllowanceConfiguration(modelBuilder).Setup();
            new AllowanceTypeConfiguration(modelBuilder).Setup();
            new BursaryConfiguration(modelBuilder).Setup();
            new BursaryOfficerConfiguration(modelBuilder).Setup();
            new FinancingInstitutionConfiguration(modelBuilder).Setup();
            new PaymentHistroyConfigurations(modelBuilder).Setup();
            new ResidenceConfiguration(modelBuilder).Setup();
            new PaymentConfiguration(modelBuilder).Setup();
            new PocketConfiguration(modelBuilder).Setup();
            new BursaryBeneficiaryConfiguration(modelBuilder).Setup();
            new ActivityLogConfiguration(modelBuilder).Setup();
        }
    }
}
