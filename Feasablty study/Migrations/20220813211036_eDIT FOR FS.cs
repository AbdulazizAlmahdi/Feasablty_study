using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class eDITFORFS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitors_Market_study_market_StudyId",
                table: "Competitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Construction_and_buliding_Technical_Study_technical_StudyId",
                table: "Construction_and_buliding");

            migrationBuilder.DropForeignKey(
                name: "FK_Establishment_expenses_Technical_Study_technical_StudyId",
                table: "Establishment_expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Expected_revenue_Market_study_market_StudyId",
                table: "Expected_revenue");

            migrationBuilder.DropForeignKey(
                name: "FK_Government_fees_Technical_Study_technical_StudyId",
                table: "Government_fees");

            migrationBuilder.DropForeignKey(
                name: "FK_License_Preliminary_study_preliminary_StudyId",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_Machinery_Equipment_Technical_Study_technical_StudyId",
                table: "Machinery_Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Manpower_workforce_Technical_Study_technical_StudyId",
                table: "Manpower_workforce");

            migrationBuilder.DropForeignKey(
                name: "FK_Marketing_Activity_Market_study_market_StudyId",
                table: "Marketing_Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Public_benefit_Technical_Study_technical_StudyId",
                table: "Public_benefit");

            migrationBuilder.DropForeignKey(
                name: "FK_Raw_materials_Technical_Study_technical_StudyId",
                table: "Raw_materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Technical_Study_technical_StudyId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Risk_Market_study_market_StudyId",
                table: "Risk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technical_Study",
                table: "Technical_Study");

            migrationBuilder.DropIndex(
                name: "IX_Technical_Study_FeasibilityStudyId",
                table: "Technical_Study");

            migrationBuilder.DropIndex(
                name: "IX_Risk_market_StudyId",
                table: "Risk");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_technical_StudyId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Raw_materials_technical_StudyId",
                table: "Raw_materials");

            migrationBuilder.DropIndex(
                name: "IX_Public_benefit_technical_StudyId",
                table: "Public_benefit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preliminary_study",
                table: "Preliminary_study");

            migrationBuilder.DropIndex(
                name: "IX_Preliminary_study_FeasibilityStudyId",
                table: "Preliminary_study");

            migrationBuilder.DropIndex(
                name: "IX_Marketing_Activity_market_StudyId",
                table: "Marketing_Activity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Market_study",
                table: "Market_study");

            migrationBuilder.DropIndex(
                name: "IX_Market_study_FeasibilityStudyId",
                table: "Market_study");

            migrationBuilder.DropIndex(
                name: "IX_Manpower_workforce_technical_StudyId",
                table: "Manpower_workforce");

            migrationBuilder.DropIndex(
                name: "IX_Machinery_Equipment_technical_StudyId",
                table: "Machinery_Equipment");

            migrationBuilder.DropIndex(
                name: "IX_License_preliminary_StudyId",
                table: "License");

            migrationBuilder.DropIndex(
                name: "IX_Government_fees_technical_StudyId",
                table: "Government_fees");

            migrationBuilder.DropIndex(
                name: "IX_Expected_revenue_market_StudyId",
                table: "Expected_revenue");

            migrationBuilder.DropIndex(
                name: "IX_Establishment_expenses_technical_StudyId",
                table: "Establishment_expenses");

            migrationBuilder.DropIndex(
                name: "IX_Construction_and_buliding_technical_StudyId",
                table: "Construction_and_buliding");

            migrationBuilder.DropIndex(
                name: "IX_Competitors_market_StudyId",
                table: "Competitors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "market_StudyId",
                table: "Risk");

            migrationBuilder.DropColumn(
                name: "LeaseType",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Raw_materials");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Public_benefit");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Preliminary_study");

            migrationBuilder.DropColumn(
                name: "market_StudyId",
                table: "Marketing_Activity");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Market_study");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Manpower_workforce");

            migrationBuilder.DropColumn(
                name: "TotleAll",
                table: "Machinery_Equipment");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Machinery_Equipment");

            migrationBuilder.DropColumn(
                name: "preliminary_StudyId",
                table: "License");

            migrationBuilder.DropColumn(
                name: "DrawingDomestic",
                table: "Government_fees");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Government_fees");

            migrationBuilder.DropColumn(
                name: "market_StudyId",
                table: "Expected_revenue");

            migrationBuilder.DropColumn(
                name: "PriceOfExpens",
                table: "Establishment_expenses");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Establishment_expenses");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Construction_and_buliding");

            migrationBuilder.DropColumn(
                name: "SendPrivateSender",
                table: "Construction_and_buliding");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Construction_and_buliding");

            migrationBuilder.DropColumn(
                name: "technical_StudyId",
                table: "Construction_and_buliding");

            migrationBuilder.DropColumn(
                name: "market_StudyId",
                table: "Competitors");

            migrationBuilder.RenameColumn(
                name: "MarketStudyId",
                table: "Risk",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Rentals",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "RentQuantity",
                table: "Rentals",
                newName: "RentalType");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Raw_materials",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Raw_materials",
                newName: "Material");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Public_benefit",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "MarketStudyId",
                table: "Marketing_Activity",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Manpower_workforce",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Machinery_Equipment",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "NameEquipment",
                table: "Machinery_Equipment",
                newName: "NameSupplier");

            migrationBuilder.RenameColumn(
                name: "PreliminaryStudyId",
                table: "License",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Government_fees",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "NameFees",
                table: "Government_fees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MarketStudyId",
                table: "Expected_revenue",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "TypeOfExpense",
                table: "Establishment_expenses",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Establishment_expenses",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "TechnicalStudyId",
                table: "Construction_and_buliding",
                newName: "Feasibility_StudyId");

            migrationBuilder.RenameColumn(
                name: "MarketStudyId",
                table: "Competitors",
                newName: "Feasibility_StudyId");

            migrationBuilder.AddColumn<float>(
                name: "RentalYearly",
                table: "Rentals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<float>(
                name: "PriceOfUnity",
                table: "Raw_materials",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "MonthlyCost",
                table: "Public_benefit",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "Marketing_Activity",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "MonthlySalary",
                table: "Manpower_workforce",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Machinery_Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Government_fees",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Establishment_expenses",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PricePerMeter",
                table: "Construction_and_buliding",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalArea",
                table: "Construction_and_buliding",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technical_Study",
                table: "Technical_Study",
                column: "FeasibilityStudyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preliminary_study",
                table: "Preliminary_study",
                column: "FeasibilityStudyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Market_study",
                table: "Market_study",
                column: "FeasibilityStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Risk_Feasibility_StudyId",
                table: "Risk",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_Feasibility_StudyId",
                table: "Rentals",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Raw_materials_Feasibility_StudyId",
                table: "Raw_materials",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Public_benefit_Feasibility_StudyId",
                table: "Public_benefit",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Marketing_Activity_Feasibility_StudyId",
                table: "Marketing_Activity",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Manpower_workforce_Feasibility_StudyId",
                table: "Manpower_workforce",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Machinery_Equipment_Feasibility_StudyId",
                table: "Machinery_Equipment",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_License_Feasibility_StudyId",
                table: "License",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Government_fees_Feasibility_StudyId",
                table: "Government_fees",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Expected_revenue_Feasibility_StudyId",
                table: "Expected_revenue",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Establishment_expenses_Feasibility_StudyId",
                table: "Establishment_expenses",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Construction_and_buliding_Feasibility_StudyId",
                table: "Construction_and_buliding",
                column: "Feasibility_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_Feasibility_StudyId",
                table: "Competitors",
                column: "Feasibility_StudyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitors_Feasibility_studies_Feasibility_StudyId",
                table: "Competitors",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Construction_and_buliding_Feasibility_studies_Feasibility_StudyId",
                table: "Construction_and_buliding",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Establishment_expenses_Feasibility_studies_Feasibility_StudyId",
                table: "Establishment_expenses",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expected_revenue_Feasibility_studies_Feasibility_StudyId",
                table: "Expected_revenue",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Government_fees_Feasibility_studies_Feasibility_StudyId",
                table: "Government_fees",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_License_Feasibility_studies_Feasibility_StudyId",
                table: "License",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machinery_Equipment_Feasibility_studies_Feasibility_StudyId",
                table: "Machinery_Equipment",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manpower_workforce_Feasibility_studies_Feasibility_StudyId",
                table: "Manpower_workforce",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marketing_Activity_Feasibility_studies_Feasibility_StudyId",
                table: "Marketing_Activity",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Public_benefit_Feasibility_studies_Feasibility_StudyId",
                table: "Public_benefit",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Raw_materials_Feasibility_studies_Feasibility_StudyId",
                table: "Raw_materials",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Feasibility_studies_Feasibility_StudyId",
                table: "Rentals",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Risk_Feasibility_studies_Feasibility_StudyId",
                table: "Risk",
                column: "Feasibility_StudyId",
                principalTable: "Feasibility_studies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitors_Feasibility_studies_Feasibility_StudyId",
                table: "Competitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Construction_and_buliding_Feasibility_studies_Feasibility_StudyId",
                table: "Construction_and_buliding");

            migrationBuilder.DropForeignKey(
                name: "FK_Establishment_expenses_Feasibility_studies_Feasibility_StudyId",
                table: "Establishment_expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Expected_revenue_Feasibility_studies_Feasibility_StudyId",
                table: "Expected_revenue");

            migrationBuilder.DropForeignKey(
                name: "FK_Government_fees_Feasibility_studies_Feasibility_StudyId",
                table: "Government_fees");

            migrationBuilder.DropForeignKey(
                name: "FK_License_Feasibility_studies_Feasibility_StudyId",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_Machinery_Equipment_Feasibility_studies_Feasibility_StudyId",
                table: "Machinery_Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Manpower_workforce_Feasibility_studies_Feasibility_StudyId",
                table: "Manpower_workforce");

            migrationBuilder.DropForeignKey(
                name: "FK_Marketing_Activity_Feasibility_studies_Feasibility_StudyId",
                table: "Marketing_Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Public_benefit_Feasibility_studies_Feasibility_StudyId",
                table: "Public_benefit");

            migrationBuilder.DropForeignKey(
                name: "FK_Raw_materials_Feasibility_studies_Feasibility_StudyId",
                table: "Raw_materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Feasibility_studies_Feasibility_StudyId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Risk_Feasibility_studies_Feasibility_StudyId",
                table: "Risk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technical_Study",
                table: "Technical_Study");

            migrationBuilder.DropIndex(
                name: "IX_Risk_Feasibility_StudyId",
                table: "Risk");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_Feasibility_StudyId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Raw_materials_Feasibility_StudyId",
                table: "Raw_materials");

            migrationBuilder.DropIndex(
                name: "IX_Public_benefit_Feasibility_StudyId",
                table: "Public_benefit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preliminary_study",
                table: "Preliminary_study");

            migrationBuilder.DropIndex(
                name: "IX_Marketing_Activity_Feasibility_StudyId",
                table: "Marketing_Activity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Market_study",
                table: "Market_study");

            migrationBuilder.DropIndex(
                name: "IX_Manpower_workforce_Feasibility_StudyId",
                table: "Manpower_workforce");

            migrationBuilder.DropIndex(
                name: "IX_Machinery_Equipment_Feasibility_StudyId",
                table: "Machinery_Equipment");

            migrationBuilder.DropIndex(
                name: "IX_License_Feasibility_StudyId",
                table: "License");

            migrationBuilder.DropIndex(
                name: "IX_Government_fees_Feasibility_StudyId",
                table: "Government_fees");

            migrationBuilder.DropIndex(
                name: "IX_Expected_revenue_Feasibility_StudyId",
                table: "Expected_revenue");

            migrationBuilder.DropIndex(
                name: "IX_Establishment_expenses_Feasibility_StudyId",
                table: "Establishment_expenses");

            migrationBuilder.DropIndex(
                name: "IX_Construction_and_buliding_Feasibility_StudyId",
                table: "Construction_and_buliding");

            migrationBuilder.DropIndex(
                name: "IX_Competitors_Feasibility_StudyId",
                table: "Competitors");

            migrationBuilder.DropColumn(
                name: "RentalYearly",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Machinery_Equipment");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Government_fees");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Establishment_expenses");

            migrationBuilder.DropColumn(
                name: "PricePerMeter",
                table: "Construction_and_buliding");

            migrationBuilder.DropColumn(
                name: "TotalArea",
                table: "Construction_and_buliding");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Risk",
                newName: "MarketStudyId");

            migrationBuilder.RenameColumn(
                name: "RentalType",
                table: "Rentals",
                newName: "RentQuantity");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Rentals",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "Material",
                table: "Raw_materials",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Raw_materials",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Public_benefit",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Marketing_Activity",
                newName: "MarketStudyId");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Manpower_workforce",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "NameSupplier",
                table: "Machinery_Equipment",
                newName: "NameEquipment");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Machinery_Equipment",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "License",
                newName: "PreliminaryStudyId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Government_fees",
                newName: "NameFees");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Government_fees",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Expected_revenue",
                newName: "MarketStudyId");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Establishment_expenses",
                newName: "TypeOfExpense");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Establishment_expenses",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Construction_and_buliding",
                newName: "TechnicalStudyId");

            migrationBuilder.RenameColumn(
                name: "Feasibility_StudyId",
                table: "Competitors",
                newName: "MarketStudyId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Technical_Study",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "market_StudyId",
                table: "Risk",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaseType",
                table: "Rentals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Rentals",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceOfUnity",
                table: "Raw_materials",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Raw_materials",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MonthlyCost",
                table: "Public_benefit",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Public_benefit",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Preliminary_study",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Marketing_Activity",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "market_StudyId",
                table: "Marketing_Activity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Market_study",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<decimal>(
                name: "MonthlySalary",
                table: "Manpower_workforce",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Manpower_workforce",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotleAll",
                table: "Machinery_Equipment",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Machinery_Equipment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "preliminary_StudyId",
                table: "License",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrawingDomestic",
                table: "Government_fees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Government_fees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "market_StudyId",
                table: "Expected_revenue",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceOfExpens",
                table: "Establishment_expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Establishment_expenses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Construction_and_buliding",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SendPrivateSender",
                table: "Construction_and_buliding",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Construction_and_buliding",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "technical_StudyId",
                table: "Construction_and_buliding",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "market_StudyId",
                table: "Competitors",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technical_Study",
                table: "Technical_Study",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preliminary_study",
                table: "Preliminary_study",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Market_study",
                table: "Market_study",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Technical_Study_FeasibilityStudyId",
                table: "Technical_Study",
                column: "FeasibilityStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Risk_market_StudyId",
                table: "Risk",
                column: "market_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_technical_StudyId",
                table: "Rentals",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Raw_materials_technical_StudyId",
                table: "Raw_materials",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Public_benefit_technical_StudyId",
                table: "Public_benefit",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Preliminary_study_FeasibilityStudyId",
                table: "Preliminary_study",
                column: "FeasibilityStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marketing_Activity_market_StudyId",
                table: "Marketing_Activity",
                column: "market_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Market_study_FeasibilityStudyId",
                table: "Market_study",
                column: "FeasibilityStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manpower_workforce_technical_StudyId",
                table: "Manpower_workforce",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Machinery_Equipment_technical_StudyId",
                table: "Machinery_Equipment",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_License_preliminary_StudyId",
                table: "License",
                column: "preliminary_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Government_fees_technical_StudyId",
                table: "Government_fees",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Expected_revenue_market_StudyId",
                table: "Expected_revenue",
                column: "market_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Establishment_expenses_technical_StudyId",
                table: "Establishment_expenses",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Construction_and_buliding_technical_StudyId",
                table: "Construction_and_buliding",
                column: "technical_StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_market_StudyId",
                table: "Competitors",
                column: "market_StudyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitors_Market_study_market_StudyId",
                table: "Competitors",
                column: "market_StudyId",
                principalTable: "Market_study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Construction_and_buliding_Technical_Study_technical_StudyId",
                table: "Construction_and_buliding",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establishment_expenses_Technical_Study_technical_StudyId",
                table: "Establishment_expenses",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Expected_revenue_Market_study_market_StudyId",
                table: "Expected_revenue",
                column: "market_StudyId",
                principalTable: "Market_study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Government_fees_Technical_Study_technical_StudyId",
                table: "Government_fees",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_Preliminary_study_preliminary_StudyId",
                table: "License",
                column: "preliminary_StudyId",
                principalTable: "Preliminary_study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machinery_Equipment_Technical_Study_technical_StudyId",
                table: "Machinery_Equipment",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manpower_workforce_Technical_Study_technical_StudyId",
                table: "Manpower_workforce",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Marketing_Activity_Market_study_market_StudyId",
                table: "Marketing_Activity",
                column: "market_StudyId",
                principalTable: "Market_study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Public_benefit_Technical_Study_technical_StudyId",
                table: "Public_benefit",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Raw_materials_Technical_Study_technical_StudyId",
                table: "Raw_materials",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Technical_Study_technical_StudyId",
                table: "Rentals",
                column: "technical_StudyId",
                principalTable: "Technical_Study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Risk_Market_study_market_StudyId",
                table: "Risk",
                column: "market_StudyId",
                principalTable: "Market_study",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
