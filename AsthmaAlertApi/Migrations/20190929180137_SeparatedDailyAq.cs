using Microsoft.EntityFrameworkCore.Migrations;

namespace AsthmaAlertApi.Migrations
{
    public partial class SeparatedDailyAq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AsthmaCategory",
                table: "DailyAqs");

            migrationBuilder.DropColumn(
                name: "AsthmaValue",
                table: "DailyAqs");

            migrationBuilder.DropColumn(
                name: "DustDanderCategory",
                table: "DailyAqs");

            migrationBuilder.DropColumn(
                name: "DustDanderValue",
                table: "DailyAqs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AsthmaCategory",
                table: "DailyAqs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AsthmaValue",
                table: "DailyAqs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DustDanderCategory",
                table: "DailyAqs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DustDanderValue",
                table: "DailyAqs",
                nullable: false,
                defaultValue: 0);
        }
    }
}
