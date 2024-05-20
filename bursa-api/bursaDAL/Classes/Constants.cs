using bursaDAL.Modals;
using System.Collections.ObjectModel;
using System.Globalization;

namespace bursaDAL.Classes
{
    public static class Constants
    {
        private static readonly AcademicYearId januaryToDecemberYearId = AcademicYearId.ParseAcademicYearId("b24b536901c247c8999c38d861721bdd");
        private static readonly AcademicYearId februaryToDecemberYearId = AcademicYearId.ParseAcademicYearId("13dce65be2a54abeb62c7799ba88402e");

        private static readonly AllowanceId travelAllowanceId = AllowanceId.ParseAllowanceId("2aa8bf15e2c4499c90977c5f196f2641");
        private static readonly AllowanceId foodAllowanceId = AllowanceId.ParseAllowanceId("c803c4d5abe745ef83f5235cea13deb5");
        private static readonly AllowanceId bookAllowanceId = AllowanceId.ParseAllowanceId("dc3d722aa9fb42d18b6b38052fb4db53");
        private static readonly AllowanceId residenceAllowanceId = AllowanceId.ParseAllowanceId("39a725c3160547f98554e376da69e1b3");

        private static readonly AllowanceTypeId travelAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("a5aa0a8e6988486a9975ca16d99b4149");
        private static readonly AllowanceTypeId foodAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("c445390fe8294d569bd7d51de39dd718");
        private static readonly AllowanceTypeId bookAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("22180315f1074737983a99f8eb2a48a9");
        private static readonly AllowanceTypeId residenceAllowanceTypeId = AllowanceTypeId.ParseAllowanceTypeId("9ab195d303734284a341f094ad2bff94");

        private static readonly BursaryId nsfasBursaryId = BursaryId.ParseBursaryId("b1da32d9858b4e429470d04cab92940f");
        private static readonly BursaryOfficerId nsfasHomeBursaryOfficerId = BursaryOfficerId.ParseBursaryOfficerId("29d86a7df1934132aaa7ff9a2780da7a");
        private static readonly PocketId nsfasStudentPocketId = PocketId.ParsePocketId("4039a933d5ad4d21af2d7657e6ba7a84");
        private static readonly PaymentId paymentId = PaymentId.ParsePaymentId("be049cdd8eba40b3a465dadd1fc70bf6");
        private static readonly InstitutionId institutionId = InstitutionId.ParseInstitutionId("0d018d4b9b97437d8f33f47ebbdd0aa3");
        private static readonly FinancingInstitutionId financingInstitutionId = FinancingInstitutionId.ParseFinancingInstitutionId("4b53bd2d0e834117927403197a7f2473");
        
        private static readonly FeatureId superAdminFeatureId = FeatureId.ParseFeatureId("8d22686a2b92481a9e21064211b7c949");
        private static readonly FeatureId userFeatureId = FeatureId.ParseFeatureId("211eb55a13bf4f848f8ebcbf9ce6564a");
        private static readonly FeatureId BursaryFeatureId = FeatureId.ParseFeatureId("3d27613b37ac49e3b143dbe193975974");
        private static readonly FeatureId allowanceFeatureId = FeatureId.ParseFeatureId("65fa4c90600a4cb6996160fe359c71b4");
        private static readonly FeatureId residencyFeatureId = FeatureId.ParseFeatureId("6b7eb258cdf140c7a4577fd93abcdd56");

        private static readonly UserId superAdminUserId = UserId.ParseUserId("5d76cbcfb3de426db105faa16b8536a4");
        private static readonly UserId adminUserId = UserId.ParseUserId("e9446c7d8328490d8a1f3c180bb95cfd");
        private static readonly UserId officerUserId = UserId.ParseUserId("35996b95cce14bf088c8a26a99032e30");
        private static readonly UserId studentUserId = UserId.ParseUserId("122716c8522b4d6eaf9204dd7208b862");

        private static readonly RoleId superAdminRoleId = RoleId.ParseRoleId("dd7ee8cf9075403a82dd67100a57115e");
        private static readonly RoleId adminRoleId = RoleId.ParseRoleId("7a3a9989fa574186ae1efeb53d641d17");
        private static readonly RoleId officerRoleId = RoleId.ParseRoleId("a8b05ec09a824b7a9d419829b16e2cf0");
        private static readonly RoleId studentRoleId = RoleId.ParseRoleId("6620edbed4da4b5280689fc35abd0fee");

        public enum VarificationStatus
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
        public enum LivingArrangment
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

        internal static class AcademicYearData
        {
            public static ReadOnlyCollection<AcademicYear> AcademicYearList { get; } = new ReadOnlyCollection<AcademicYear>(
            [
                new AcademicYear
                {
                    Id = januaryToDecemberYearId,
                    Period = AcademicPeriod.JanuaryToDecember,
                    Year = 2024,
                    InstitutionId = institutionId,
                },
                new AcademicYear
                {
                    Id = februaryToDecemberYearId,
                    Period = AcademicPeriod.FebruaryToDecember,
                    Year = 2024,
                    InstitutionId = institutionId,
                }
            ]
            );
        }
        internal static class AllowanceData
        {
            public static ReadOnlyCollection<Allowance> AllowanceList { get; } = new ReadOnlyCollection<Allowance>(
            [
                new Allowance
                {
                    Id = travelAllowanceId,
                    AllowanceTypeId = travelAllowanceTypeId,
                    Name = AllowanceTypeData.travelAllowance,
                    Amount = 12000.00m,
                    BursaryId = nsfasBursaryId,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Monthly,
                    TotalNumberPayments = 10,
                    TotalNumberPaymentsMade = 0,
                    StartTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                },
                new Allowance
                {
                    Id = foodAllowanceId,
                    Name = AllowanceTypeData.foodAllowance,
                    AllowanceTypeId = foodAllowanceTypeId,
                    Amount = 13000.00m,
                    BursaryId = nsfasBursaryId,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Monthly,
                    TotalNumberPayments = 12,
                    TotalNumberPaymentsMade = 0,
                    StartTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                },
                new Allowance
                {
                    Id = bookAllowanceId,
                    Name = AllowanceTypeData.bookAllowance,
                    AllowanceTypeId = bookAllowanceTypeId,
                    Amount = 5000.00m,
                    BursaryId = nsfasBursaryId,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.BiAnnually,
                    TotalNumberPayments = 2,
                    TotalNumberPaymentsMade = 0,
                    StartTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    EndTimestamp = DateTime.ParseExact("2024-12-16 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                },
                new Allowance
                {
                    Id = residenceAllowanceId,
                    Name = AllowanceTypeData.residenceAllowance,
                    AllowanceTypeId = residenceAllowanceTypeId,
                    Amount = 45000.00m,
                    BursaryId = nsfasBursaryId,
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
            public const string travelAllowance = "Travel Allowance";
            public const string foodAllowance = "Food Allowance";
            public const string bookAllowance = "Book Allowance";
            public const string residenceAllowance = "Residence Allowance";

            public static ReadOnlyCollection<AllowanceType> AllowanceTypeList { get; } = new ReadOnlyCollection<AllowanceType>(
            [
                new AllowanceType
                {
                    Id = travelAllowanceTypeId,
                    Name = travelAllowance
                },
                new AllowanceType
                {
                    Id = foodAllowanceTypeId,
                    Name = foodAllowance
                },
                new AllowanceType
                {
                    Id = bookAllowanceTypeId,
                    Name = bookAllowance
                },
                new AllowanceType
                {
                    Id = residenceAllowanceTypeId,
                    Name = residenceAllowance
                }
            ]);
        }
        internal static class BursaryData
        {
            public static ReadOnlyCollection<Bursary> BursaryList { get; } = new ReadOnlyCollection<Bursary>(
               [
                new Bursary
                {
                    Id = nsfasBursaryId,
                    Name = "NSFAS - PrivateResidence",
                    TotalAmount = 75000,
                    IsActive = true,
                    Type = BursaryType.FullCost,
                    CreateTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    UpdatedTimestamp = DateTime.ParseExact("2024-02-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    StatusCode = VarificationStatus.Approved,
                    FinancingInstitutionId = financingInstitutionId,
                    Description = "The National Student Financial Aid Scheme (NSFAS) is a South African government student financial aid scheme which provides financial aid to undergraduate students who need financial assistance to assist them to pay for the cost of their tertiary education.",
                    Image = "https://www.nsfas.org.za/content/images/logo.png",
                    UpdatedBy = officerUserId
                },
            ]);
        }
        internal static class BursaryOfficerData
        {
            public static ReadOnlyCollection<BursaryOfficer> BursaryOfficerList { get; } = new ReadOnlyCollection<BursaryOfficer>(
                [
                    new BursaryOfficer
                    {
                        Id = nsfasHomeBursaryOfficerId,
                        OfficerId = officerUserId,
                        BursaryId = nsfasBursaryId
                    }
                ]);
        }
        internal static class FeatureData
        {
            public const string readWriteDeleteAction = "R-W-D";
            public const string readWriteAction = "R-W";
            public const string readDeleteAction = "R-D";
            public const string readAction = "R";

            public const string superAdminFeature = "all";
            public const string userFeature = "user";
            public const string BursaryFeature = "Bursary";
            public const string allowanceFeature = "allowance";
            public const string residencyFeature = "residency";

            public static ReadOnlyCollection<Feature> FeatureList { get; } = new ReadOnlyCollection<Feature>(
            [
                new Feature
                {
                    Id = superAdminFeatureId,
                    Name = superAdminFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = userFeatureId,
                    Name = userFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = BursaryFeatureId,
                    Name = BursaryFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = allowanceFeatureId,
                    Name = allowanceFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = residencyFeatureId,
                    Name = residencyFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                }
            ]);
        }
        internal static class FinancingInstitutionData
        {
            public static ReadOnlyCollection<FinancingInstitution> FinancingInstitutionList { get; } = new ReadOnlyCollection<FinancingInstitution>(
                                  [
                new FinancingInstitution
                {
                    Id = financingInstitutionId,
                    Name = "National Student Financial Aid Scheme",
                    CreateTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    UpdatedTimestamp = DateTime.ParseExact("2024-02-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Description = "The National Student Financial Aid Scheme (NSFAS) is a South African government student financial aid scheme which provides financial aid to undergraduate students who need financial assistance to assist them to pay for the cost of their tertiary education.",
                    Image = "https://www.nsfas.org.za/content/images/logo.png",
                    UpdatedBy = officerUserId,
                    Bursaries = BursaryData.BursaryList
                },
            ]);
        }
        internal static class InstitutionData
        {
            public static ReadOnlyCollection<Institution> InstitutionList { get; } = new ReadOnlyCollection<Institution>(
            [
                new Institution
                {
                    Id = institutionId,
                    Name = "Univerity of Stellenbosch",
                    CreateTimestamp = DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    UpdatedTimestamp = DateTime.ParseExact("2024-02-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Description = "University of Stellenbosch is a public research university situated in Stellenbosch," +
                                  " a town in the Western Cape province of South Africa. " +
                                  "Stellenbosch is jointly the oldest university in South Africa and the oldest extant university" +
                                  " in Sub-Saharan Africa alongside the University of Cape Town which received full university status on the same day in 1918.",
                    Image = "https://www.sun.ac.za/english/corporate-identity/PublishingImages/Downloads/Su%20Logo/US%20korporatiewe%20logo%20stack%20vertikaal_CMYK.jpg",
                    UpdatedById = officerUserId
                }
            ]);
        }
        internal static class PaymentData {
            public static ReadOnlyCollection<Payment> PaymentList { get; } = new ReadOnlyCollection<Payment>(
                [
                    new Payment
                    {
                        Id = paymentId,
                        AllowanceId = travelAllowanceId,
                        PaymentTypeId = travelAllowanceId,
                        PocketId = nsfasStudentPocketId,
                        PaymentMadeById = officerUserId,
                        Amount = 1200.00m,
                        PaymentStatus = PaymentStatusCode.Paid,
                        PaymentTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                        BeneficiaryId = studentUserId,
                        NumberOfPeriodPaid = 1,
                        PaymentDescription = "Travel Allowance Payment",
                        CreateTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                        UpdatedTimestamp = DateTime.ParseExact("2024-05-01 00:00:00", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture)
                    }
                ]);  
        }
        internal static class PocketData
        {
            public static ReadOnlyCollection<Pocket> PocketList { get; } = new ReadOnlyCollection<Pocket>(
                           [
                new Pocket
                {
                    Id = nsfasStudentPocketId,
                    Name = "Student - [Residence] Pocket",
                    IsActive = true,
                    BeneficiaryId = studentUserId,
                    ResidenceId = ResidenceId.NewResidenceId(),
                    Bursaries = BursaryData.BursaryList
                }
            ]);
        }
        internal static class ResidenceData
        {
            private static readonly ResidenceId residenceId = ResidenceId.ParseResidenceId("f4e13f228fc44dc8a598ccc6c8b3377c");
            public static ReadOnlyCollection<Residence> ResidenceList { get; } = new ReadOnlyCollection<Residence>(
            [
                new Residence
                {
                    Id = residenceId,
                    UserId = studentUserId,
                    UpdatedBy = officerUserId,
                    LivingArrangment = LivingArrangment.PrivateResidence,
                    TotalCost = 45000.00m,
                    LeaseUrl = new Uri("https://drive.google.com/file/d/1g8Q-_eWb9o9n02Tgo2dYlyrnZKsoRBiT/view?usp=drive_link"),
                    Address = "4 Beech Close, Macassar, Cape Town, 7130",
                    ResidenceVarificationStatus = VarificationStatus.Approved,
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
            public const string superAdminRole = "SuperAdmin";
            public const string adminRole = "Admin";
            public const string officerRole = "Officer";
            public const string studentRole = "Student";

            public static ReadOnlyCollection<Role> RoleList { get; } = new ReadOnlyCollection<Role>(new[]
               {
                new Role
                {
                    Id = superAdminRoleId,
                    Name = superAdminRole,
                    Features = [
                        new Feature
                        {
                            Id = superAdminFeatureId,
                            Name = FeatureData.superAdminFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        }
                    ]
                },
                new Role
                {
                    Id = adminRoleId,
                    Name = adminRole,
                    Features =
                    [
                        new()
                        {
                            Id = userFeatureId,
                            Name = FeatureData.userFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        },
                        new()
                        {
                            Id = BursaryFeatureId,
                            Name = FeatureData.BursaryFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        },
                        new() {
                            Id = allowanceFeatureId,
                            Name = FeatureData.allowanceFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        },
                        new() {
                            Id = residencyFeatureId,
                            Name = FeatureData.residencyFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        }
                    ]
                },
                new Role
                {
                    Id = officerRoleId,
                    Name = officerRole,
                    Features =
                    [
                        new()
                        {
                            Id = userFeatureId,
                            Name = FeatureData.userFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        },
                        new()
                        {
                            Id = BursaryFeatureId,
                            Name = FeatureData.BursaryFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        },
                        new() {
                            Id = allowanceFeatureId,
                            Name = FeatureData.allowanceFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        },
                        new() {
                            Id = residencyFeatureId,
                            Name = FeatureData.residencyFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        }
                    ]
                },
                new Role
                {
                    Id = studentRoleId,
                    Name = studentRole,
                    Features =
                    [
                        new()
                        {
                            Id = userFeatureId,
                            Name = FeatureData.userFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteAction
                        },
                        new()
                        {
                            Id = BursaryFeatureId,
                            Name = FeatureData.BursaryFeature,
                            IsActive = true,
                            Access = FeatureData.readAction
                        },
                        new() {
                            Id = allowanceFeatureId,
                            Name = FeatureData.allowanceFeature,
                            IsActive = true,
                            Access = FeatureData.readAction
                        },
                        new() {
                            Id = residencyFeatureId,
                            Name = FeatureData.residencyFeature,
                            IsActive = true,
                            Access = FeatureData.readWriteDeleteAction
                        }
                    ]
                }
            });
        }
        internal static class UserData
        {
            public static ReadOnlyCollection<User> UserList { get; } = new ReadOnlyCollection<User>(new[]
            {
                new User
                {
                    Id = superAdminUserId,
                    RoleId = superAdminRoleId,
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
                    Id = adminUserId,
                    RoleId = adminRoleId,
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
                    Id = officerUserId,
                    RoleId = officerRoleId,
                    IsActive = true,
                    SaltIDNumber = "102",
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
                    Id = studentUserId,
                    RoleId = studentRoleId,
                    IsActive = true,
                    SaltIDNumber = "102",
                    IdNumber ="2106098795089",
                    Name = "Student",
                    Surname = "Student",
                    PhoneNumber = "081000002",
                    DateOfBirth = DateTime.ParseExact("1983-12-07 10:00:30", "yyyy-MM-dd hh:mm:ss",CultureInfo.CurrentCulture),
                    Email = "mrbtmkhabela+3@gmail.com",
                    PersonnelId = "100000004"
                },
            });
        }
    }
}
