using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cityTbls_stateTbls_StateTblStateId",
                table: "cityTbls");

            migrationBuilder.DropIndex(
                name: "IX_cityTbls_StateTblStateId",
                table: "cityTbls");

            migrationBuilder.DropColumn(
                name: "StateTblStateId",
                table: "cityTbls");
        }
    }
}
