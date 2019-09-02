using Microsoft.EntityFrameworkCore.Migrations;

namespace AsthmaAlertApi.Migrations
{
    public partial class AddDateToTrackingItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "TrackingItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "TrackingItems");
        }
    }
}
