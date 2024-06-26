using bursaDAL.Modals;
using System.Collections.ObjectModel;
using System.Globalization;

namespace bursaDAL.Classes
{
    public static class Constants
    {
        public static readonly AcademicYearId JanuaryToDecemberYearId = AcademicYearId.ParseAcademicYearId("b24b536901c247c8999c38d861721bdd");
        public static readonly AcademicYearId FebruaryToDecemberYearId = AcademicYearId.ParseAcademicYearId("13dce65be2a54abeb62c7799ba88402e");

        public static readonly AllowanceId TravelAllowanceId = AllowanceId.ParseAllowanceId("2aa8bf15e2c4499c90977c5f196f2641");
        public static readonly AllowanceId FoodAllowanceId = AllowanceId.ParseAllowanceId("c803c4d5abe745ef83f5235cea13deb5");
        public static readonly AllowanceId BookAllowanceId = AllowanceId.ParseAllowanceId("dc3d722aa9fb42d18b6b38052fb4db53");
        public static readonly AllowanceId ResidenceAllowanceId = AllowanceId.ParseAllowanceId("39a725c3160547f98554e376da69e1b3");

        public static readonly AllowanceTypeId TravelAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("a5aa0a8e6988486a9975ca16d99b4149");
        public static readonly AllowanceTypeId FoodAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("c445390fe8294d569bd7d51de39dd718");
        public static readonly AllowanceTypeId BookAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("22180315f1074737983a99f8eb2a48a9");
        public static readonly AllowanceTypeId ResidenceAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("9ab195d303734284a341f094ad2bff94");

        public static readonly BursaryId NsfasBursaryId = BursaryId.ParseBursaryId("b1da32d9858b4e429470d04cab92940f");
        public static readonly BursaryOfficerId NsfasHomeBursaryOfficerId = BursaryOfficerId.ParseBursaryOfficerId("29d86a7df1934132aaa7ff9a2780da7a");
        public static readonly PocketId NsfasStudentPocketId = PocketId.ParsePocketId("6909a8f758d344308cedb57628c46235");
        public static readonly PaymentId PaymentId = PaymentId.ParsePaymentId("be049cdd8eba40b3a465dadd1fc70bf6");
        public static readonly InstitutionId InstitutionId = InstitutionId.ParseInstitutionId("0d018d4b9b97437d8f33f47ebbdd0aa3");
        public static readonly FinancingInstitutionId FinancingInstitutionId = FinancingInstitutionId.ParseFinancingInstitutionId("4b53bd2d0e834117927403197a7f2473");
        public static readonly ResidenceId ResidenceId = ResidenceId.ParseResidenceId("f4e13f228fc44dc8a598ccc6c8b3377c");
        public static readonly FeatureId SuperAdminFeatureId = FeatureId.ParseFeatureId("8d22686a2b92481a9e21064211b7c949");
        public static readonly FeatureId UserFeatureId = FeatureId.ParseFeatureId("211eb55a13bf4f848f8ebcbf9ce6564a");
        public static readonly FeatureId BursaryFeatureId = FeatureId.ParseFeatureId("3d27613b37ac49e3b143dbe193975974");
        public static readonly FeatureId AllowanceFeatureId = FeatureId.ParseFeatureId("65fa4c90600a4cb6996160fe359c71b4");
        public static readonly FeatureId ResidencyFeatureId = FeatureId.ParseFeatureId("6b7eb258cdf140c7a4577fd93abcdd56");

        public static readonly UserId SuperAdminUserId = UserId.ParseUserId("5d76cbcfb3de426db105faa16b8536a4");
        public static readonly UserId AdminUserId = UserId.ParseUserId("e9446c7d8328490d8a1f3c180bb95cfd");
        public static readonly UserId OfficerUserId = UserId.ParseUserId("35996b95cce14bf088c8a26a99032e30");
        public static readonly UserId StudentUserId = UserId.ParseUserId("122716c8522b4d6eaf9204dd7208b862");

        public static readonly RoleId SuperAdminRoleId = RoleId.ParseRoleId("dd7ee8cf9075403a82dd67100a57115e");
        public static readonly RoleId AdminRoleId = RoleId.ParseRoleId("7a3a9989fa574186ae1efeb53d641d17");
        public static readonly RoleId OfficerRoleId = RoleId.ParseRoleId("a8b05ec09a824b7a9d419829b16e2cf0");
        public static readonly RoleId StudentRoleId = RoleId.ParseRoleId("6620edbed4da4b5280689fc35abd0fee");

        public enum VerificationStatus
        {
            Pending = 0,
            Approved = 1,
            Rejected = 2,
            Cancelled = 3
        }
        public enum PaymentCycle
        {
            None = 0,
            Annually = 1,
            BiAnnually = 2,
            Monthly = 3
        }
        public enum AcademicPeriod
        {
            Discontinued = 0,
            FebruaryToNovember = 10,
            FebruaryToDecember = 11,
            JanuaryToDecember = 12
        }
        public enum BursaryType
        {
            Other = 0,
            FullCost = 1,
            Capped = 2,
            Partial = 3
        }
        public enum LivingArrangement
        {
            Home = 0,
            PrivateResidence = 1,
            ResCatered = 2,
            ResSelfCatered = 3
        }
        public enum PaymentStatusCode
        {
            Pending = 0,
            Paid = 1,
            Rejected = 2,
            Cancelled = 3
        }
        public enum InstitutionCategory
        {
            Other = 0,
            Corporate = 1,
            Family = 2,
            Government = 3,
            Individual = 4
        }
        internal static class AcademicYearData
        {
            public static ReadOnlyCollection<AcademicYear> AcademicYearList { get; } = new(
            [
                new AcademicYear
                {
                    Id = JanuaryToDecemberYearId,
                    Period = AcademicPeriod.JanuaryToDecember,
                    Year = 2024,
                    InstitutionId = InstitutionId,
                },
                new AcademicYear
                {
                    Id = FebruaryToDecemberYearId,
                    Period = AcademicPeriod.FebruaryToDecember,
                    Year = 2024,
                    InstitutionId = InstitutionId,
                }
            ]
            );
        }
        internal static class AllowanceData
        {
            public static ReadOnlyCollection<Allowance> AllowanceList { get; } = new(
            [
                new Allowance
                {
                    Id = TravelAllowanceId,
                    AllowanceTypeId = TravelAllowanceTypeId,
                    Name = AllowanceTypeData.TravelAllowance,
                    Amount = 12000.00m,
                    BursaryId = NsfasBursaryId,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Monthly,
                    TotalNumberPayments = 10,
                    TotalNumberPaymentsMade = 0,
                    StartTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                },
                new Allowance
                {
                    Id = FoodAllowanceId,
                    Name = AllowanceTypeData.FoodAllowance,
                    AllowanceTypeId = FoodAllowanceTypeId,
                    Amount = 13000.00m,
                    BursaryId = NsfasBursaryId,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Monthly,
                    TotalNumberPayments = 12,
                    TotalNumberPaymentsMade = 0,
                    StartTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                },
                new Allowance
                {
                    Id = BookAllowanceId,
                    Name = AllowanceTypeData.BookAllowance,
                    AllowanceTypeId = BookAllowanceTypeId,
                    Amount = 5000.00m,
                    BursaryId = NsfasBursaryId,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.BiAnnually,
                    TotalNumberPayments = 2,
                    TotalNumberPaymentsMade = 0,
                    StartTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                },
                new Allowance
                {
                    Id = ResidenceAllowanceId,
                    Name = AllowanceTypeData.ResidenceAllowance,
                    AllowanceTypeId = ResidenceAllowanceTypeId,
                    Amount = 45000.00m,
                    BursaryId = NsfasBursaryId,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Monthly,
                    TotalNumberPayments = 12,
                    TotalNumberPaymentsMade = 0,
                    StartTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                }
            ]);
        }
        internal static class AllowanceTypeData
        {
            public const string TravelAllowance = "Travel Allowance";
            public const string FoodAllowance = "Food Allowance";
            public const string BookAllowance = "Book Allowance";
            public const string ResidenceAllowance = "Residence Allowance";

            public static ReadOnlyCollection<AllowanceType> AllowanceTypeList { get; } = new(
            [
                new AllowanceType
                {
                    Id = TravelAllowanceTypeId,
                    Name = TravelAllowance
                },
                new AllowanceType
                {
                    Id = FoodAllowanceTypeId,
                    Name = FoodAllowance
                },
                new AllowanceType
                {
                    Id = BookAllowanceTypeId,
                    Name = BookAllowance
                },
                new AllowanceType
                {
                    Id = ResidenceAllowanceTypeId,
                    Name = ResidenceAllowance
                }
            ]);
        }
        internal static class BursaryData
        {
            public static ReadOnlyCollection<Bursary> BursaryList { get; } = new(
               [
                new Bursary
                {
                    Id = NsfasBursaryId,
                    Name = "NSFAS - PrivateResidence",
                    TotalAmount = 75000,
                    IsActive = true,
                    Type = BursaryType.FullCost,
                    CreateTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    UpdatedTimestamp = DateTime.ParseExact("2024-02-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    StatusCode = VerificationStatus.Approved,
                    FinancingInstitutionId = FinancingInstitutionId,
                    Description = "The National Student Financial Aid Scheme (NSFAS) is a South African government student financial aid scheme which provides financial aid to undergraduate students who need financial assistance to assist them to pay for the cost of their tertiary education.",
                    Image = "https://www.nsfas.org.za/content/images/logo.png",

                },
            ]);
        }
        internal static class BursaryOfficerData
        {
            public static ReadOnlyCollection<BursaryOfficer> BursaryOfficerList { get; } = new(
                [
                    new BursaryOfficer
                    {
                        Id = NsfasHomeBursaryOfficerId,
                        OfficerId = OfficerUserId,
                        BursaryId = NsfasBursaryId
                    }
                ]);
        }
        internal static class FeatureData
        {
            public const string ReadWriteDeleteAction = "R-W-D";
            public const string ReadWriteAction = "R-W";
            public const string ReadDeleteAction = "R-D";
            public const string ReadAction = "R";

            public const string SuperAdminFeature = "all";
            public const string UserFeature = "user";
            public const string BursaryFeature = "Bursary";
            public const string AllowanceFeature = "allowance";
            public const string ResidencyFeature = "residency";

            public static ReadOnlyCollection<Feature> FeatureList { get; } = new(
            [
                new Feature
                {
                    Id = SuperAdminFeatureId,
                    Name = SuperAdminFeature,
                    IsActive = true,
                    Access = ReadWriteDeleteAction
                },
                new Feature
                {
                    Id = UserFeatureId,
                    Name = UserFeature,
                    IsActive = true,
                    Access = ReadWriteDeleteAction
                },
                new Feature
                {
                    Id = BursaryFeatureId,
                    Name = BursaryFeature,
                    IsActive = true,
                    Access = ReadWriteDeleteAction
                },
                new Feature
                {
                    Id = AllowanceFeatureId,
                    Name = AllowanceFeature,
                    IsActive = true,
                    Access = ReadWriteDeleteAction
                },
                new Feature
                {
                    Id = ResidencyFeatureId,
                    Name = ResidencyFeature,
                    IsActive = true,
                    Access = ReadWriteDeleteAction
                }
            ]);
        }
        internal static class FinancingInstitutionData
        {
            public static ReadOnlyCollection<FinancingInstitution> FinancingInstitutionList { get; } = new(
                                  [
                new FinancingInstitution
                {
                    Id = FinancingInstitutionId,
                    Name = "National Student Financial Aid Scheme",
                    CreateTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    UpdatedTimestamp = DateTime.ParseExact("2024-02-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Description = "The National Student Financial Aid Scheme (NSFAS) is a South African government student financial aid scheme which provides financial aid to undergraduate students who need financial assistance to assist them to pay for the cost of their tertiary education.",
                    Image = "https://www.nsfas.org.za/content/images/logo.png",

                    Category = InstitutionCategory.Government
                },
            ]);
        }
        internal static class InstitutionData
        {
            public static ReadOnlyCollection<Institution> InstitutionList { get; } = new(
            [
                new Institution
                {
                    Id = InstitutionId,
                    Name = "Univerity of Stellenbosch",
                    CreateTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    UpdatedTimestamp = DateTime.ParseExact("2024-02-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Description = "University of Stellenbosch is a public research university situated in Stellenbosch," +
                                  " a town in the Western Cape province of South Africa. " +
                                  "Stellenbosch is jointly the oldest university in South Africa and the oldest extant university" +
                                  " in Sub-Saharan Africa alongside the University of Cape Town which received full university status on the same day in 1918.",
                    Image = "https://www.sun.ac.za/english/corporate-identity/PublishingImages/Downloads/Su%20Logo/US%20korporatiewe%20logo%20stack%20vertikaal_CMYK.jpg",

                }
            ]);
        }
        internal static class PaymentData
        {
            public static ReadOnlyCollection<Payment> PaymentList { get; } = new(
                [
                    new Payment
                    {
                        Id = PaymentId,
                        PaymentTypeId = TravelAllowanceId,
                        PocketId = NsfasStudentPocketId,
                        PaymentOfficerId = OfficerUserId,
                        Amount = 1200.00m,
                        PaymentStatus = PaymentStatusCode.Paid,
                        PaymentTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                        BeneficiaryId = StudentUserId,
                        NumberOfPeriodPaid = 1,
                        PaymentDescription = "Travel Allowance Payment",
                        CreateTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                        UpdatedTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                    }
            ]);
        }
        internal static class PocketData
        {
            public static ReadOnlyCollection<Pocket> PocketList { get; } = new(
            [
                new Pocket
                {
                    Id = NsfasStudentPocketId,
                    Name = "Student - [Residence] Pocket",
                    IsActive = true,
                    BeneficiaryId = StudentUserId,
                    LivingArrangement = LivingArrangement.PrivateResidence
                }
            ]);
        }
        internal static class ResidenceData
        {
            public static ReadOnlyCollection<Residence> ResidenceList { get; } = new(
            [
                new Residence
                {
                    Id = ResidenceId,
                    ResidentId = StudentUserId,
                    LivingArrangement = LivingArrangement.PrivateResidence,
                    TotalCost = 45000.00m,
                    LeaseUrl = new Uri("https://drive.google.com/file/d/1g8Q-_eWb9o9n02Tgo2dYlyrnZKsoRBiT/view?usp=drive_link"),
                    Address = "4 Beech Close, Macassar, Cape Town, 7130",
                    ResidenceVerificationStatus = VerificationStatus.Approved,
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    StartTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    IsAccredited = true,
                    LandLordName = "Mr. John Doe",
                    LandLordPhone = "0810000000",
                    LandLordEmail = "mrjd@gmail.com",
                    IsActive = true,
                    CreateTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    UpdatedTimestamp = DateTime.ParseExact("2024-02-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                }
            ]);
        }
        internal static class RoleData
        {
            public const string SuperAdminRole = "SuperAdmin";
            public const string AdminRole = "Admin";
            public const string OfficerRole = "Officer";
            public const string StudentRole = "Student";

            public static ReadOnlyCollection<Role> RoleList { get; } = new([

                new Role
                {
                    Id = SuperAdminRoleId,
                    Name = SuperAdminRole,
                    Description = SuperAdminRole
                },
                new Role
                {
                    Id = AdminRoleId,
                    Name = AdminRole,
                    Description = AdminRole
                },
                new Role
                {
                    Id = OfficerRoleId,
                    Name = OfficerRole,
                    Description = OfficerRole
                },
                new Role
                {
                    Id = StudentRoleId,
                    Name = StudentRole,
                    Description = StudentRole
                }
            ]);
        }
        internal static class UserData
        {
            public static ReadOnlyCollection<User> UserList { get; } = new(
            [
                new User
                {
                    Id = SuperAdminUserId,
                    RoleId = SuperAdminRoleId,
                    IsActive=true,
                    IdNumber ="9008122255089",
                    Name = "Super Admin",
                    Surname = "Super Admin",
                    PhoneNumber = "0810000000",
                    DateOfBirth =  DateTime.ParseExact("1993-02-27 10:00:30", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Email = "mrbtmkhabela+1@gmail.com",
                    PersonnelId = "100000001"
                },
                new User
                {
                    Id = AdminUserId,
                    RoleId = AdminRoleId,
                    IsActive=true,
                    IdNumber ="9202018795089",
                    Name = "Admin",
                    Surname = "Admin",
                    PhoneNumber = "081000001",
                    DateOfBirth = DateTime.ParseExact("1983-12-07 10:00:30", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Email = "mrbtmkhabela+2@gmail.com",
                    PersonnelId = "100000002"
                },
                new User
                {
                    Id = OfficerUserId,
                    RoleId = OfficerRoleId,
                    IsActive = true,
                    SaltIdNumber = "102",
                    IdNumber ="2106098795089",
                    Name = "Officer",
                    Surname = "Officer",
                    PhoneNumber = "081000002",
                    DateOfBirth = DateTime.ParseExact("1983-12-07 10:00:30", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Email = "mrbtmkhabela+3@gmail.com",
                    PersonnelId = "100000003"
                },
                new User
                {
                    Id = StudentUserId,
                    RoleId = StudentRoleId,
                    IsActive = true,
                    SaltIdNumber = "102",
                    IdNumber ="2106098795089",
                    Name = "Student",
                    Surname = "Student",
                    PhoneNumber = "081000002",
                    DateOfBirth = DateTime.ParseExact("1983-12-07 10:00:30", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Email = "mrbtmkhabela+3@gmail.com",
                    PersonnelId = "100000004"
                },
            ]);
        }
    }
}
