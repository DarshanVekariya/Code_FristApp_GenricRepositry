using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cityTbls_stateTbls_StateTblStateId",
                table: "cityTbls");

            migrationBuilder.DropForeignKey(
                name: "FK_stateTbls_countryTbls_CountryTblCountryId",
                table: "stateTbls");

            migrationBuilder.DropIndex(
                name: "IX_cityTbls_StateTblStateId",
                table: "cityTbls");

            migrationBuilder.DropColumn(
                name: "StateTblStateId",
                table: "cityTbls");

            migrationBuilder.RenameColumn(
                name: "CountryTblCountryId",
                table: "stateTbls",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_stateTbls_CountryTblCountryId",
                table: "stateTbls",
                newName: "IX_stateTbls_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_stateTbls_countryTbls_CountryId",
                table: "stateTbls",
                column: "CountryId",
                principalTable: "countryTbls",
                principalColumn: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stateTbls_countryTbls_CountryId",
                table: "stateTbls");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "stateTbls",
                newName: "CountryTblCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_stateTbls_CountryId",
                table: "stateTbls",
                newName: "IX_stateTbls_CountryTblCountryId");

            migrationBuilder.AddColumn<int>(
                name: "StateTblStateId",
                table: "cityTbls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cityTbls_StateTblStateId",
                table: "cityTbls",
                column: "StateTblStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_cityTbls_stateTbls_StateTblStateId",
                table: "cityTbls",
                column: "StateTblStateId",
                principalTable: "stateTbls",
                principalColumn: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_stateTbls_countryTbls_CountryTblCountryId",
                table: "stateTbls",
                column: "CountryTblCountryId",
                principalTable: "countryTbls",
                principalColumn: "CountryId");
        }
    }
}
