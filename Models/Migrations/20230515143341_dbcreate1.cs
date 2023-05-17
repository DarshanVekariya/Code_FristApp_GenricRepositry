using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class dbcreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cityTbls",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fkStateId = table.Column<int>(type: "int", nullable: false),
                    StateTblStateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityTbls", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_cityTbls_stateTbls_StateTblStateId",
                        column: x => x.StateTblStateId,
                        principalTable: "stateTbls",
                        principalColumn: "StateId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cityTbls_StateTblStateId",
                table: "cityTbls",
                column: "StateTblStateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cityTbls");
        }
    }
}
