using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicRegisters.Data.Migrations
{
    public partial class TEst : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Users");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Apelido = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    DataDeCadastro = table.Column<DateTime>(nullable: false),
                    DataDeExclusao = table.Column<DateTime>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    UsuarioDeCadastroId = table.Column<Guid>(nullable: false),
                    UsuarioDeExlusaoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    AccessKey = table.Column<string>(type: "varchar(32)", nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    UserID = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}