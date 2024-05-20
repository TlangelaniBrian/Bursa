using bursaDAL.Modals;
using Microsoft.EntityFrameworkCore;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Configurations
{
    public partial class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void ConfigureTableKeys()
        {
            _modelBuilder.Entity<AcademicYear>()
             .HasKey(x => x.Id) 
             .IsClustered(false);
            
            _modelBuilder.Entity<Allowance>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<AllowanceType>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<Bursary>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<BursaryOfficer>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<FinancingInstitution>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<Feature>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<Institution>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<Payment>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<PaymentHistroy>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<Pocket>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<Residence>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<Role>()
             .HasKey(x => x.Id)
             .IsClustered(false);

            _modelBuilder.Entity<User>()
             .HasKey(x => x.Id)
             .IsClustered(false);
        }
        public void SeedData()
        {
            //Seed Institution
            foreach (var institution in InstitutionData.InstitutionList)
            {
                _modelBuilder.Entity<Institution>().HasData(institution);
            }

            //Seed Academic Year
            foreach (var academicYear in AcademicYearData.AcademicYearList)
            {
                _modelBuilder.Entity<AcademicYear>().HasData(academicYear);
            }

            //Seed Allowance Type
            foreach (var allowanceType in AllowanceTypeData.AllowanceTypeList)
            {
                _modelBuilder.Entity<AllowanceType>().HasData(allowanceType);
            }

            foreach (var feature in FeatureData.FeatureList)
            {
                _modelBuilder.Entity<Feature>().HasData(feature);
            }

            foreach (var role in RoleData.RoleList)
            {
                _modelBuilder.Entity<Role>().HasData(role);
            }

            foreach (var user in UserData.UserList)
            {
                _modelBuilder.Entity<User>().HasData(user);
            }

            //Seed Allowance
            foreach (var allowance in AllowanceData.AllowanceList)
            {
                _modelBuilder.Entity<Allowance>().HasData(allowance);
            }

            foreach (var bursary in BursaryData.BursaryList)
            {
                _modelBuilder.Entity<Bursary>().HasData(bursary);
            }
            foreach (var finInstitution in FinancingInstitutionData.FinancingInstitutionList)
            {
                _modelBuilder.Entity<FinancingInstitution>().HasData(finInstitution);
            }
            foreach (var residence in ResidenceData.ResidenceList)
            {
                _modelBuilder.Entity<Residence>().HasData(residence);
            }

            foreach (var pocket in PocketData.PocketList)
            {
                _modelBuilder.Entity<Pocket>().HasData(pocket);
            }

        }
    }
}
