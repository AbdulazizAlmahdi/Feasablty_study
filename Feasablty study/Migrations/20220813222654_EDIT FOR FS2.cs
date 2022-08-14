using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class EDITFORFS2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalPriceQuantityMonthly",
                table: "Raw_materials",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalPriceQuantityYearly",
                table: "Raw_materials",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "YearlyCost",
                table: "Public_benefit",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalMonthlySalary",
                table: "Manpower_workforce",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalYearlySalary",
                table: "Manpower_workforce",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "Machinery_Equipment",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalMonthlyPrice",
                table: "Expected_revenue",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalYearlyPrice",
                table: "Expected_revenue",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalPriceArea",
                table: "Construction_and_buliding",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPriceQuantityMonthly",
                table: "Raw_materials");

            migrationBuilder.DropColumn(
                name: "TotalPriceQuantityYearly",
                table: "Raw_materials");

            migrationBuilder.DropColumn(
                name: "YearlyCost",
                table: "Public_benefit");

            migrationBuilder.DropColumn(
                name: "TotalMonthlySalary",
                table: "Manpower_workforce");

            migrationBuilder.DropColumn(
                name: "TotalYearlySalary",
                table: "Manpower_workforce");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Machinery_Equipment");

            migrationBuilder.DropColumn(
                name: "TotalMonthlyPrice",
                table: "Expected_revenue");

            migrationBuilder.DropColumn(
                name: "TotalYearlyPrice",
                table: "Expected_revenue");

            migrationBuilder.DropColumn(
                name: "TotalPriceArea",
                table: "Construction_and_buliding");
        }
    }
}
