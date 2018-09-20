using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicRegisters.Admin.Migrations
{
    public partial class AdicionadoAsContasNoAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conta",
                columns: table => new
                {
                    ApelidoDaConta = table.Column<string>(maxLength: 20, nullable: false),
                    Ativa = table.Column<bool>(nullable: false),
                    CNPJ = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    EmailParaUsuarioAdministrador = table.Column<string>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 80, nullable: true),
                    NomeDaConta = table.Column<string>(maxLength: 80, nullable: false),
                    SenhaParaUsuarioAdministrador = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conta");
        }
    }
}
