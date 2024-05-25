using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bursaDAL.Migrations
{
    /// <inheritdoc />
    public partial class intiateCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllowanceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowanceTypes", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "FinancingInstitutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancingInstitutions", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneContactDetails = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmailContactDetails = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Bursaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinancingInstitutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bursaries", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Bursaries_FinancingInstitutions_FinancingInstitutionId",
                        column: x => x.FinancingInstitutionId,
                        principalTable: "FinancingInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicYears",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    InstitutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicYears", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_AcademicYears_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Access = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Features_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonnelId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HashIdNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SaltIdNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ActivityLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BursaryBeneficiaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BursaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BeneficiaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BursaryBeneficiaries", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_BursaryBeneficiaries_Bursaries_BursaryId",
                        column: x => x.BursaryId,
                        principalTable: "Bursaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BursaryBeneficiaries_Users_BeneficiaryId",
                        column: x => x.BeneficiaryId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BursaryOfficers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BursaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OfficerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BursaryOfficers", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_BursaryOfficers_Bursaries_BursaryId",
                        column: x => x.BursaryId,
                        principalTable: "Bursaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BursaryOfficers_Users_OfficerId",
                        column: x => x.OfficerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pockets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BeneficiaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LivingArrangement = table.Column<int>(type: "int", nullable: false),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pockets", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Pockets_Users_BeneficiaryId",
                        column: x => x.BeneficiaryId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Residences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LivingArrangement = table.Column<int>(type: "int", nullable: false),
                    LeaseUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ResidenceVerificationStatus = table.Column<int>(type: "int", nullable: false),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccredited = table.Column<bool>(type: "bit", nullable: true),
                    LandLordName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    LandLordPhone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LandLordEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EndTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residences", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Residences_Users_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allowances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalNumberPayments = table.Column<int>(type: "int", nullable: false),
                    TotalNumberPaymentsMade = table.Column<int>(type: "int", nullable: false),
                    StartTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PaymentCycle = table.Column<int>(type: "int", nullable: false),
                    AllowanceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BursaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PocketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowances", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Allowances_AllowanceTypes_AllowanceTypeId",
                        column: x => x.AllowanceTypeId,
                        principalTable: "AllowanceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Allowances_Bursaries_BursaryId",
                        column: x => x.BursaryId,
                        principalTable: "Bursaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Allowances_Pockets_PocketId",
                        column: x => x.PocketId,
                        principalTable: "Pockets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BeneficiaryIdNumber = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    OfficerPersonnelId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AllowanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentRef = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PaymentDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    PaymentTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistories", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PaymentHistories_Allowances_AllowanceId",
                        column: x => x.AllowanceId,
                        principalTable: "Allowances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfPeriodPaid = table.Column<int>(type: "int", nullable: false),
                    BeneficiaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentOfficerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CreateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PocketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Payments_Allowances_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "Allowances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Users_BeneficiaryId",
                        column: x => x.BeneficiaryId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Users_PaymentOfficerId",
                        column: x => x.PaymentOfficerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AllowanceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22180315-f107-4737-983a-99f8eb2a48a9"), "Book Allowance" },
                    { new Guid("9ab195d3-0373-4284-a341-f094ad2bff94"), "Residence Allowance" },
                    { new Guid("a5aa0a8e-6988-486a-9975-ca16d99b4149"), "Travel Allowance" },
                    { new Guid("c445390f-e829-4d56-9bd7-d51de39dd718"), "Food Allowance" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Access", "IsActive", "Name", "RoleId" },
                values: new object[,]
                {
                    { new Guid("211eb55a-13bf-4f84-8f8e-bcbf9ce6564a"), "R-W-D", true, "user", null },
                    { new Guid("3d27613b-37ac-49e3-b143-dbe193975974"), "R-W-D", true, "Bursary", null },
                    { new Guid("65fa4c90-600a-4cb6-9961-60fe359c71b4"), "R-W-D", true, "allowance", null },
                    { new Guid("6b7eb258-cdf1-40c7-a457-7fd93abcdd56"), "R-W-D", true, "residency", null },
                    { new Guid("8d22686a-2b92-481a-9e21-064211b7c949"), "R-W-D", true, "all", null }
                });

            migrationBuilder.InsertData(
                table: "FinancingInstitutions",
                columns: new[] { "Id", "Category", "CreateTimestamp", "Description", "Image", "Name", "UpdatedTimestamp" },
                values: new object[] { new Guid("4b53bd2d-0e83-4117-9274-03197a7f2473"), 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The National Student Financial Aid Scheme (NSFAS) is a South African government student financial aid scheme which provides financial aid to undergraduate students who need financial assistance to assist them to pay for the cost of their tertiary education.", "https://www.nsfas.org.za/content/images/logo.png", "National Student Financial Aid Scheme", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "CreateTimestamp", "Description", "EmailContactDetails", "Image", "Name", "PhoneContactDetails", "UpdatedTimestamp" },
                values: new object[] { new Guid("0d018d4b-9b97-437d-8f33-f47ebbdd0aa3"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Stellenbosch is a public research university situated in Stellenbosch, a town in the Western Cape province of South Africa. Stellenbosch is jointly the oldest university in South Africa and the oldest extant university in Sub-Saharan Africa alongside the University of Cape Town which received full university status on the same day in 1918.", null, "https://www.sun.ac.za/english/corporate-identity/PublishingImages/Downloads/Su%20Logo/US%20korporatiewe%20logo%20stack%20vertikaal_CMYK.jpg", "Univerity of Stellenbosch", null, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6620edbe-d4da-4b52-8068-9fc35abd0fee"), "Student", "Student" },
                    { new Guid("7a3a9989-fa57-4186-ae1e-feb53d641d17"), "Admin", "Admin" },
                    { new Guid("a8b05ec0-9a82-4b7a-9d41-9829b16e2cf0"), "Officer", "Officer" },
                    { new Guid("dd7ee8cf-9075-403a-82dd-67100a57115e"), "SuperAdmin", "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "Id", "CreatedTimestamp", "InstitutionId", "Period", "Year" },
                values: new object[,]
                {
                    { new Guid("13dce65b-e2a5-4abe-b62c-7799ba88402e"), new DateTime(2024, 5, 25, 13, 5, 59, 473, DateTimeKind.Local).AddTicks(4959), new Guid("0d018d4b-9b97-437d-8f33-f47ebbdd0aa3"), 11, 2024 },
                    { new Guid("b24b5369-01c2-47c8-999c-38d861721bdd"), new DateTime(2024, 5, 25, 13, 5, 59, 473, DateTimeKind.Local).AddTicks(4466), new Guid("0d018d4b-9b97-437d-8f33-f47ebbdd0aa3"), 12, 2024 }
                });

            migrationBuilder.InsertData(
                table: "Bursaries",
                columns: new[] { "Id", "CreateTimestamp", "Description", "FinancingInstitutionId", "Image", "IsActive", "Name", "Notes", "StatusCode", "TotalAmount", "Type", "UpdatedTimestamp" },
                values: new object[] { new Guid("b1da32d9-858b-4e42-9470-d04cab92940f"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The National Student Financial Aid Scheme (NSFAS) is a South African government student financial aid scheme which provides financial aid to undergraduate students who need financial assistance to assist them to pay for the cost of their tertiary education.", new Guid("4b53bd2d-0e83-4117-9274-03197a7f2473"), "https://www.nsfas.org.za/content/images/logo.png", true, "NSFAS - PrivateResidence", "", 1, 75000m, 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "HashIdNumber", "IdNumber", "IsActive", "Name", "PersonnelId", "PhoneNumber", "RoleId", "SaltIdNumber", "Surname" },
                values: new object[,]
                {
                    { new Guid("122716c8-522b-4d6e-af92-04dd7208b862"), new DateTime(1983, 12, 7, 10, 0, 30, 0, DateTimeKind.Unspecified), "mrbtmkhabela+3@gmail.com", null, "2106098795089", true, "Student", "100000004", "081000002", new Guid("6620edbe-d4da-4b52-8068-9fc35abd0fee"), "102", "Student" },
                    { new Guid("35996b95-cce1-4bf0-88c8-a26a99032e30"), new DateTime(1983, 12, 7, 10, 0, 30, 0, DateTimeKind.Unspecified), "mrbtmkhabela+3@gmail.com", null, "2106098795089", true, "Officer", "100000003", "081000002", new Guid("a8b05ec0-9a82-4b7a-9d41-9829b16e2cf0"), "102", "Officer" },
                    { new Guid("5d76cbcf-b3de-426d-b105-faa16b8536a4"), new DateTime(1993, 2, 27, 10, 0, 30, 0, DateTimeKind.Unspecified), "mrbtmkhabela+1@gmail.com", null, "9008122255089", true, "Super Admin", "100000001", "0810000000", new Guid("dd7ee8cf-9075-403a-82dd-67100a57115e"), null, "Super Admin" },
                    { new Guid("e9446c7d-8328-490d-8a1f-3c180bb95cfd"), new DateTime(1983, 12, 7, 10, 0, 30, 0, DateTimeKind.Unspecified), "mrbtmkhabela+2@gmail.com", null, "9202018795089", true, "Admin", "100000002", "081000001", new Guid("7a3a9989-fa57-4186-ae1e-feb53d641d17"), null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AllowanceTypeId", "Amount", "BursaryId", "EndTimestamp", "IsActive", "Name", "PaymentCycle", "PocketId", "StartTimestamp", "TotalNumberPayments", "TotalNumberPaymentsMade" },
                values: new object[,]
                {
                    { new Guid("2aa8bf15-e2c4-499c-9097-7c5f196f2641"), new Guid("a5aa0a8e-6988-486a-9975-ca16d99b4149"), 12000.00m, new Guid("b1da32d9-858b-4e42-9470-d04cab92940f"), new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Travel Allowance", 3, null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0 },
                    { new Guid("39a725c3-1605-47f9-8554-e376da69e1b3"), new Guid("9ab195d3-0373-4284-a341-f094ad2bff94"), 45000.00m, new Guid("b1da32d9-858b-4e42-9470-d04cab92940f"), new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Residence Allowance", 3, null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0 },
                    { new Guid("c803c4d5-abe7-45ef-83f5-235cea13deb5"), new Guid("c445390f-e829-4d56-9bd7-d51de39dd718"), 13000.00m, new Guid("b1da32d9-858b-4e42-9470-d04cab92940f"), new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Food Allowance", 3, null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0 },
                    { new Guid("dc3d722a-a9fb-42d1-8b6b-38052fb4db53"), new Guid("22180315-f107-4737-983a-99f8eb2a48a9"), 5000.00m, new Guid("b1da32d9-858b-4e42-9470-d04cab92940f"), new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Book Allowance", 2, null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "BursaryOfficers",
                columns: new[] { "Id", "BursaryId", "CreateTimestamp", "OfficerId" },
                values: new object[] { new Guid("29d86a7d-f193-4132-aaa7-ff9a2780da7a"), new Guid("b1da32d9-858b-4e42-9470-d04cab92940f"), new DateTime(2024, 5, 25, 13, 5, 59, 480, DateTimeKind.Local).AddTicks(4254), new Guid("35996b95-cce1-4bf0-88c8-a26a99032e30") });

            migrationBuilder.InsertData(
                table: "Pockets",
                columns: new[] { "Id", "BeneficiaryId", "CreateTimestamp", "IsActive", "LivingArrangement", "Name", "UpdateTimestamp" },
                values: new object[] { new Guid("6909a8f7-58d3-4430-8ced-b57628c46235"), new Guid("122716c8-522b-4d6e-af92-04dd7208b862"), new DateTime(2024, 5, 25, 13, 5, 59, 493, DateTimeKind.Local).AddTicks(9437), true, 1, "Student - [Residence] Pocket", new DateTime(2024, 5, 25, 13, 5, 59, 493, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.InsertData(
                table: "Residences",
                columns: new[] { "Id", "Address", "CreateTimestamp", "EndTimestamp", "IsAccredited", "IsActive", "LandLordEmail", "LandLordName", "LandLordPhone", "LeaseUrl", "LivingArrangement", "ResidenceVerificationStatus", "ResidentId", "StartTimestamp", "TotalCost", "UpdatedTimestamp" },
                values: new object[] { new Guid("f4e13f22-8fc4-4dc8-a598-ccc6c8b3377c"), "4 Beech Close, Macassar, Cape Town, 7130", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "mrjd@gmail.com", "Mr. John Doe", "0810000000", "https://drive.google.com/file/d/1g8Q-_eWb9o9n02Tgo2dYlyrnZKsoRBiT/view?usp=drive_link", 1, 1, new Guid("122716c8-522b-4d6e-af92-04dd7208b862"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45000.00m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "BeneficiaryId", "CreateTimestamp", "NumberOfPeriodPaid", "PaymentDescription", "PaymentOfficerId", "PaymentStatus", "PaymentTimestamp", "PaymentTypeId", "PocketId", "UpdatedTimestamp" },
                values: new object[] { new Guid("be049cdd-8eba-40b3-a465-dadd1fc70bf6"), 1200.00m, new Guid("122716c8-522b-4d6e-af92-04dd7208b862"), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Travel Allowance Payment", new Guid("35996b95-cce1-4bf0-88c8-a26a99032e30"), 1, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2aa8bf15-e2c4-499c-9097-7c5f196f2641"), new Guid("6909a8f7-58d3-4430-8ced-b57628c46235"), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicYears_InstitutionId",
                table: "AcademicYears",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLogs_UserId",
                table: "ActivityLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Allowances_AllowanceTypeId",
                table: "Allowances",
                column: "AllowanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Allowances_BursaryId",
                table: "Allowances",
                column: "BursaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Allowances_PocketId",
                table: "Allowances",
                column: "PocketId");

            migrationBuilder.CreateIndex(
                name: "IX_Bursaries_FinancingInstitutionId",
                table: "Bursaries",
                column: "FinancingInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_BursaryBeneficiaries_BeneficiaryId",
                table: "BursaryBeneficiaries",
                column: "BeneficiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_BursaryBeneficiaries_BursaryId",
                table: "BursaryBeneficiaries",
                column: "BursaryId");

            migrationBuilder.CreateIndex(
                name: "IX_BursaryOfficers_BursaryId",
                table: "BursaryOfficers",
                column: "BursaryId");

            migrationBuilder.CreateIndex(
                name: "IX_BursaryOfficers_OfficerId",
                table: "BursaryOfficers",
                column: "OfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_RoleId",
                table: "Features",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistories_AllowanceId",
                table: "PaymentHistories",
                column: "AllowanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BeneficiaryId",
                table: "Payments",
                column: "BeneficiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentOfficerId",
                table: "Payments",
                column: "PaymentOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypeId",
                table: "Payments",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pockets_BeneficiaryId",
                table: "Pockets",
                column: "BeneficiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_ResidentId",
                table: "Residences",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicYears");

            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "BursaryBeneficiaries");

            migrationBuilder.DropTable(
                name: "BursaryOfficers");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "PaymentHistories");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Residences");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "Allowances");

            migrationBuilder.DropTable(
                name: "AllowanceTypes");

            migrationBuilder.DropTable(
                name: "Bursaries");

            migrationBuilder.DropTable(
                name: "Pockets");

            migrationBuilder.DropTable(
                name: "FinancingInstitutions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
