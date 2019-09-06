using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AsthmaAlertApi.Migrations
{
    public partial class AddDailyAqCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyAqs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Date = table.Column<string>(nullable: true),
                    OzoneValue = table.Column<int>(nullable: false),
                    OzoneCategory = table.Column<string>(nullable: true),
                    Grass = table.Column<int>(nullable: false),
                    Mold = table.Column<int>(nullable: false),
                    Ragweed = table.Column<int>(nullable: false),
                    Tree = table.Column<int>(nullable: false),
                    AsthmaValue = table.Column<int>(nullable: false),
                    AsthmaCategory = table.Column<string>(nullable: true),
                    DustDanderValue = table.Column<int>(nullable: false),
                    DustDanderCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyAqs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyAqs");
        }
    }
}
