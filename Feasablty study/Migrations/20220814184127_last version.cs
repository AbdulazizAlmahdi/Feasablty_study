using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class lastversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalConstruction_and_buliding",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalEstablishment_expenses",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalGovernment_fees",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalMachinery_Equipment",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalManpower_workforce",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalPublic_benefit",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalRaw_materials",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalRentals",
                table: "Technical_Study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalExpected_revenue",
                table: "Market_study",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalMarketing_Activity",
                table: "Market_study",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalConstruction_and_buliding",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalEstablishment_expenses",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalGovernment_fees",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalMachinery_Equipment",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalManpower_workforce",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalPublic_benefit",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalRaw_materials",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalRentals",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalExpected_revenue",
                table: "Market_study");

            migrationBuilder.DropColumn(
                name: "TotalMarketing_Activity",
                table: "Market_study");
        }
    }
}
