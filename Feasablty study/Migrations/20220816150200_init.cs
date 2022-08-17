using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feasibility_studies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalOperatingExpenseseOneYear = table.Column<double>(type: "float", nullable: false),
                    WorkingCapital = table.Column<double>(type: "float", nullable: false),
                    NetProfit = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feasibility_studies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feasibility_studies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupportMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportMessages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitorsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Products = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompetitorsPrice = table.Column<double>(type: "float", nullable: false),
                    AmounrAdded = table.Column<int>(type: "int", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitors_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Construction_and_buliding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerMeter = table.Column<float>(type: "real", nullable: false),
                    TotalArea = table.Column<float>(type: "real", nullable: false),
                    TotalPriceArea = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Construction_and_buliding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Construction_and_buliding_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Establishment_expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establishment_expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Establishment_expenses_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expected_revenue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<float>(type: "real", nullable: false),
                    MonthlyQusntity = table.Column<int>(type: "int", nullable: false),
                    TotalMonthlyPrice = table.Column<float>(type: "real", nullable: false),
                    TotalYearlyPrice = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expected_revenue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expected_revenue_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Government_fees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government_fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Government_fees_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Licenses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.Id);
                    table.ForeignKey(
                        name: "FK_License_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Machinery_Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSupplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machinery_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machinery_Equipment_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manpower_workforce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    MonthlySalary = table.Column<float>(type: "real", nullable: false),
                    TotalMonthlySalary = table.Column<float>(type: "real", nullable: false),
                    TotalYearlySalary = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manpower_workforce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manpower_workforce_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Market_study",
                columns: table => new
                {
                    FeasibilityStudyId = table.Column<int>(type: "int", nullable: false),
                    AvailbleOpportunity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrengthPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketGap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetMarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLocationOnTheMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointsOfEwakness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Threats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalExpected_revenue = table.Column<float>(type: "real", nullable: false),
                    TotalMarketing_Activity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market_study", x => x.FeasibilityStudyId);
                    table.ForeignKey(
                        name: "FK_Market_study_Feasibility_studies_FeasibilityStudyId",
                        column: x => x.FeasibilityStudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marketing_Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marketing_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marketing_Activity_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preliminary_study",
                columns: table => new
                {
                    FeasibilityStudyId = table.Column<int>(type: "int", nullable: false),
                    VisionOfTheProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageOfTheProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectObjectives = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CteristicsOfTheProjectArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactorsRepresentedOnIncreasedDemand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactorsRepresentedOnLowDemand = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preliminary_study", x => x.FeasibilityStudyId);
                    table.ForeignKey(
                        name: "FK_Preliminary_study_Feasibility_studies_FeasibilityStudyId",
                        column: x => x.FeasibilityStudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Public_benefit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Benefit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyCost = table.Column<float>(type: "real", nullable: false),
                    YearlyCost = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Public_benefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Public_benefit_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Raw_materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceOfUnity = table.Column<float>(type: "real", nullable: false),
                    QuantityRequiredMonthly = table.Column<int>(type: "int", nullable: false),
                    TotalPriceQuantityMonthly = table.Column<float>(type: "real", nullable: false),
                    TotalPriceQuantityYearly = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raw_materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Raw_materials_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentalYearly = table.Column<float>(type: "real", nullable: false),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Risk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DangerReductionStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionDangerReduece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feasibility_StudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Risk_Feasibility_studies_Feasibility_StudyId",
                        column: x => x.Feasibility_StudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Technical_Study",
                columns: table => new
                {
                    FeasibilityStudyId = table.Column<int>(type: "int", nullable: false),
                    TotalMachinery_Equipment = table.Column<float>(type: "real", nullable: false),
                    TotalManpower_workforce = table.Column<float>(type: "real", nullable: false),
                    TotalConstruction_and_buliding = table.Column<float>(type: "real", nullable: false),
                    TotalRentals = table.Column<float>(type: "real", nullable: false),
                    TotalGovernment_fees = table.Column<float>(type: "real", nullable: false),
                    TotalEstablishment_expenses = table.Column<float>(type: "real", nullable: false),
                    TotalRaw_materials = table.Column<float>(type: "real", nullable: false),
                    TotalPublic_benefit = table.Column<float>(type: "real", nullable: false),
                    AnnualDepreciation = table.Column<double>(type: "float", nullable: false),
                    TotalOperatingExpensese = table.Column<double>(type: "float", nullable: false),
                    AnnualAaintenance = table.Column<double>(type: "float", nullable: false),
                    OperationalCycle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technical_Study", x => x.FeasibilityStudyId);
                    table.ForeignKey(
                        name: "FK_Technical_Study_Feasibility_studies_FeasibilityStudyId",
                        column: x => x.FeasibilityStudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_Feasibility_StudyId",
                table: "Competitors",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Construction_and_buliding_Feasibility_StudyId",
                table: "Construction_and_buliding",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Establishment_expenses_Feasibility_StudyId",
                table: "Establishment_expenses",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Expected_revenue_Feasibility_StudyId",
                table: "Expected_revenue",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Feasibility_studies_UserId",
                table: "Feasibility_studies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Government_fees_Feasibility_StudyId",
                table: "Government_fees",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_License_Feasibility_StudyId",
                table: "License",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Machinery_Equipment_Feasibility_StudyId",
                table: "Machinery_Equipment",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Manpower_workforce_Feasibility_StudyId",
                table: "Manpower_workforce",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Marketing_Activity_Feasibility_StudyId",
                table: "Marketing_Activity",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Public_benefit_Feasibility_StudyId",
                table: "Public_benefit",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Raw_materials_Feasibility_StudyId",
                table: "Raw_materials",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_Feasibility_StudyId",
                table: "Rentals",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Risk_Feasibility_StudyId",
                table: "Risk",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportMessages_UserId",
                table: "SupportMessages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Competitors");

            migrationBuilder.DropTable(
                name: "Construction_and_buliding");

            migrationBuilder.DropTable(
                name: "Establishment_expenses");

            migrationBuilder.DropTable(
                name: "Expected_revenue");

            migrationBuilder.DropTable(
                name: "Government_fees");

            migrationBuilder.DropTable(
                name: "License");

            migrationBuilder.DropTable(
                name: "Machinery_Equipment");

            migrationBuilder.DropTable(
                name: "Manpower_workforce");

            migrationBuilder.DropTable(
                name: "Market_study");

            migrationBuilder.DropTable(
                name: "Marketing_Activity");

            migrationBuilder.DropTable(
                name: "Preliminary_study");

            migrationBuilder.DropTable(
                name: "Public_benefit");

            migrationBuilder.DropTable(
                name: "Raw_materials");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Risk");

            migrationBuilder.DropTable(
                name: "SupportMessages");

            migrationBuilder.DropTable(
                name: "Technical_Study");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Feasibility_studies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
