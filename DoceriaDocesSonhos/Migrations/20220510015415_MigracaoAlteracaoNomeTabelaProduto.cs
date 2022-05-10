using Microsoft.EntityFrameworkCore.Migrations;

namespace DoceriaDocesSonhos.Migrations
{
    public partial class MigracaoAlteracaoNomeTabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_produtos",
                table: "produtos");

            migrationBuilder.RenameTable(
                name: "produtos",
                newName: "PRODUTOS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUTOS",
                table: "PRODUTOS",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUTOS",
                table: "PRODUTOS");

            migrationBuilder.RenameTable(
                name: "PRODUTOS",
                newName: "produtos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtos",
                table: "produtos",
                column: "Id");
        }
    }
}
