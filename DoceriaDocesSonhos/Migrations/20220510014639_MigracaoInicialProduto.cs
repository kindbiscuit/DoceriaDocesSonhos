using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoceriaDocesSonhos.Migrations
{
    public partial class MigracaoInicialProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    PRECO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QUANTIDADE_DISPONIVEL = table.Column<int>(type: "int", nullable: false),
                    TIPO_DE_DOCE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");
        }
    }
}
