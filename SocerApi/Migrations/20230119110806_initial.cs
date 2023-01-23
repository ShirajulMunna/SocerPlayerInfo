using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocerApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "postPlayerInfos",
                columns: table => new
                {
                    playerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    countryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    playingPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfplayeingWorldCup = table.Column<int>(type: "int", nullable: false),
                    numberOfPlayingMatchInWorldCup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postPlayerInfos", x => x.playerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postPlayerInfos");
        }
    }
}
