using Microsoft.EntityFrameworkCore.Migrations;

namespace AsthmaAlertApi.Migrations
{
    public partial class AddingTrackingTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrackingTitle",
                table: "TrackingItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrackingTitle",
                table: "TrackingItems");
        }
    }
}
