using Microsoft.EntityFrameworkCore.Migrations;

namespace JMRLeagueWASM.Server.Migrations
{
    public partial class Players : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    PlayerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PlayerName" },
                values: new object[] { 1, "Chris", "Chris" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PlayerName" },
                values: new object[] { 2, "Dave", "Dave" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PlayerName" },
                values: new object[] { 3, "Jay", "Jay" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PlayerName" },
                values: new object[] { 4, "John", "John" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PlayerName" },
                values: new object[] { 5, "Tom", "Tom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
