using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicRegisters.Admin.Migrations
{
    public partial class AlteradoNoMeDaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_conta",
                table: "conta");

            migrationBuilder.RenameTable(
                name: "conta",
                newName: "Conta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conta",
                table: "Conta",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Conta",
                table: "Conta");

            migrationBuilder.RenameTable(
                name: "Conta",
                newName: "conta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_conta",
                table: "conta",
                column: "Id");
        }
    }
}
