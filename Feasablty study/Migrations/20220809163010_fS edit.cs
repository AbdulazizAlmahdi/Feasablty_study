using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class fSedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Feasibility_studies",
                newName: "ProjectDate");

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Feasibility_studies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectEmail",
                table: "Feasibility_studies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Feasibility_studies");

            migrationBuilder.DropColumn(
                name: "ProjectEmail",
                table: "Feasibility_studies");

            migrationBuilder.RenameColumn(
                name: "ProjectDate",
                table: "Feasibility_studies",
                newName: "DateTime");
        }
    }
}
