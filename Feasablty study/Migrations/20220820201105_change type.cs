using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class changetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_regions_regionId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_regions",
                table: "regions");

            migrationBuilder.RenameTable(
                name: "regions",
                newName: "Regions");

            migrationBuilder.RenameColumn(
                name: "roleId",
                table: "AspNetUsers",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "regionId",
                table: "AspNetUsers",
                newName: "RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_regionId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_RegionId");

            migrationBuilder.AlterColumn<int>(
                name: "ProfitRate",
                table: "Feasibility_studies",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Regions_RegionId",
                table: "AspNetUsers",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Regions_RegionId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            migrationBuilder.RenameTable(
                name: "Regions",
                newName: "regions");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "AspNetUsers",
                newName: "roleId");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "AspNetUsers",
                newName: "regionId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_RegionId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_regionId");

            migrationBuilder.AlterColumn<double>(
                name: "ProfitRate",
                table: "Feasibility_studies",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_regions",
                table: "regions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_regions_regionId",
                table: "AspNetUsers",
                column: "regionId",
                principalTable: "regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
