using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class dbcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countryTbls",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countryTbls", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "stateTbls",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fkContryId = table.Column<int>(type: "int", nullable: false),
                    CountryTblCountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stateTbls", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_stateTbls_countryTbls_CountryTblCountryId",
                        column: x => x.CountryTblCountryId,
                        principalTable: "countryTbls",
                        principalColumn: "CountryId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_stateTbls_CountryTblCountryId",
                table: "stateTbls",
                column: "CountryTblCountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stateTbls");

            migrationBuilder.DropTable(
                name: "countryTbls");
        }
    }
}
