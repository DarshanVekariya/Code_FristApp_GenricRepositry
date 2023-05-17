using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cityTbls_stateTbls_StateTblStateId",
                table: "cityTbls");

            migrationBuilder.RenameColumn(
                name: "StateTblStateId",
                table: "cityTbls",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_cityTbls_StateTblStateId",
                table: "cityTbls",
                newName: "IX_cityTbls_StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_cityTbls_stateTbls_StateId",
                table: "cityTbls",
                column: "StateId",
                principalTable: "stateTbls",
                principalColumn: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cityTbls_stateTbls_StateId",
                table: "cityTbls");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "cityTbls",
                newName: "StateTblStateId");

            migrationBuilder.RenameIndex(
                name: "IX_cityTbls_StateId",
                table: "cityTbls",
                newName: "IX_cityTbls_StateTblStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_cityTbls_stateTbls_StateTblStateId",
                table: "cityTbls",
                column: "StateTblStateId",
                principalTable: "stateTbls",
                principalColumn: "StateId");
        }
    }
}
