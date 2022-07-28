using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordConfirm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feasibility_studies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feasibility_studies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportMessages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Market_study",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailbleOpportunity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompetitiveAdavantages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WatermarkMarketd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLocationOnTheMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointsOfEwakness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Threats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeasibilityStudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market_study", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Market_study_Feasibility_studies_FeasibilityStudyId",
                        column: x => x.FeasibilityStudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preliminary_study",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectObjectives = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisionOfTheProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CteristicsOfTheProjectArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactorsRepresentedOnIncreasedDemand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactorsRepresentedOnLowDemand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeasibilityStudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preliminary_study", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preliminary_study_Feasibility_studies_FeasibilityStudyId",
                        column: x => x.FeasibilityStudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Technical_Study",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeasibilityStudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technical_Study", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technical_Study_Feasibility_studies_FeasibilityStudyId",
                        column: x => x.FeasibilityStudyId,
                        principalTable: "Feasibility_studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitorsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Products = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompetitorsPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmounrAdded = table.Column<int>(type: "int", nullable: false),
                    MarketStudyId = table.Column<int>(type: "int", nullable: false),
                    market_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitors_Market_study_market_StudyId",
                        column: x => x.market_StudyId,
                        principalTable: "Market_study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expected_revenue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<float>(type: "real", nullable: false),
                    MonthlyQusntity = table.Column<int>(type: "int", nullable: false),
                    MarketStudyId = table.Column<int>(type: "int", nullable: false),
                    market_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expected_revenue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expected_revenue_Market_study_market_StudyId",
                        column: x => x.market_StudyId,
                        principalTable: "Market_study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marketing_Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketStudyId = table.Column<int>(type: "int", nullable: false),
                    market_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marketing_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marketing_Activity_Market_study_market_StudyId",
                        column: x => x.market_StudyId,
                        principalTable: "Market_study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    MarketStudyId = table.Column<int>(type: "int", nullable: false),
                    market_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Risk_Market_study_market_StudyId",
                        column: x => x.market_StudyId,
                        principalTable: "Market_study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Licenses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreliminaryStudyId = table.Column<int>(type: "int", nullable: false),
                    preliminary_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.Id);
                    table.ForeignKey(
                        name: "FK_License_Preliminary_study_preliminary_StudyId",
                        column: x => x.preliminary_StudyId,
                        principalTable: "Preliminary_study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Construction_and_buliding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendPrivateSender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Construction_and_buliding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Construction_and_buliding_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Establishment_expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfExpense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceOfExpens = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establishment_expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Establishment_expenses_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Government_fees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFees = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrawingDomestic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government_fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Government_fees_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Machinery_Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEquipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TotleAll = table.Column<float>(type: "real", nullable: false),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machinery_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machinery_Equipment_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Manpower_workforce",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manpower_workforce", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Manpower_workforce_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Public_benefit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Benefit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Public_benefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Public_benefit_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Raw_materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceOfUnity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityRequiredMonthly = table.Column<int>(type: "int", nullable: false),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raw_materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Raw_materials_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalStudyId = table.Column<int>(type: "int", nullable: false),
                    technical_StudyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Technical_Study_technical_StudyId",
                        column: x => x.technical_StudyId,
                        principalTable: "Technical_Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_market_StudyId",
                table: "Competitors",
                column: "market_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Construction_and_buliding_technical_StudyId",
                table: "Construction_and_buliding",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Establishment_expenses_technical_StudyId",
                table: "Establishment_expenses",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Expected_revenue_market_StudyId",
                table: "Expected_revenue",
                column: "market_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Feasibility_studies_UserId",
                table: "Feasibility_studies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Government_fees_technical_StudyId",
                table: "Government_fees",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_License_preliminary_StudyId",
                table: "License",
                column: "preliminary_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Machinery_Equipment_technical_StudyId",
                table: "Machinery_Equipment",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Manpower_workforce_technical_StudyId",
                table: "Manpower_workforce",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Market_study_FeasibilityStudyId",
                table: "Market_study",
                column: "FeasibilityStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marketing_Activity_market_StudyId",
                table: "Marketing_Activity",
                column: "market_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Preliminary_study_FeasibilityStudyId",
                table: "Preliminary_study",
                column: "FeasibilityStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Public_benefit_technical_StudyId",
                table: "Public_benefit",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Raw_materials_technical_StudyId",
                table: "Raw_materials",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_technical_StudyId",
                table: "Rentals",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Risk_market_StudyId",
                table: "Risk",
                column: "market_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportMessages_UserId",
                table: "SupportMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Technical_Study_FeasibilityStudyId",
                table: "Technical_Study",
                column: "FeasibilityStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId",
                table: "Users",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Marketing_Activity");

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
                name: "Preliminary_study");

            migrationBuilder.DropTable(
                name: "Technical_Study");

            migrationBuilder.DropTable(
                name: "Market_study");

            migrationBuilder.DropTable(
                name: "Feasibility_studies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
