using Microsoft.EntityFrameworkCore.Migrations;

namespace Feasablty_study.Migrations
{
    public partial class lastEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WatermarkMarketd",
                table: "Market_study",
                newName: "TargetMarket");

            migrationBuilder.RenameColumn(
                name: "Logography",
                table: "Market_study",
                newName: "StrengthPoints");

            migrationBuilder.RenameColumn(
                name: "CompetitiveAdavantages",
                table: "Market_study",
                newName: "MarketGap");

            migrationBuilder.AddColumn<string>(
                name: "MessageOfTheProject",
                table: "Preliminary_study",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageOfTheProject",
                table: "Preliminary_study");

            migrationBuilder.RenameColumn(
                name: "TargetMarket",
                table: "Market_study",
                newName: "WatermarkMarketd");

            migrationBuilder.RenameColumn(
                name: "StrengthPoints",
                table: "Market_study",
                newName: "Logography");

            migrationBuilder.RenameColumn(
                name: "MarketGap",
                table: "Market_study",
                newName: "CompetitiveAdavantages");
        }
    }
}
