using Microsoft.EntityFrameworkCore.Migrations;

namespace Melee_percent_app.Migrations
{
    public partial class MeleeStages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeleeCharacters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeleeCharacters", x => x.CharacterID);
                });

            migrationBuilder.CreateTable(
                name: "MeleeStages",
                columns: table => new
                {
                    StageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StageName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeleeStages", x => x.StageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeleeCharacters");

            migrationBuilder.DropTable(
                name: "MeleeStages");
        }
    }
}
