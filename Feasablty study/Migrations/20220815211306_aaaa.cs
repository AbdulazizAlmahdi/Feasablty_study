using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationalCycle",
                table: "Technical_Study",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalOperatingExpensese",
                table: "Technical_Study",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalOperatingExpenseseOneYear",
                table: "Feasibility_studies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WorkingCapital",
                table: "Feasibility_studies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationalCycle",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalOperatingExpensese",
                table: "Technical_Study");

            migrationBuilder.DropColumn(
                name: "TotalOperatingExpenseseOneYear",
                table: "Feasibility_studies");

            migrationBuilder.DropColumn(
                name: "WorkingCapital",
                table: "Feasibility_studies");
        }
    }
}
