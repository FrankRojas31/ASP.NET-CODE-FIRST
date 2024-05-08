using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistemawebcf.Migrations
{
    public partial class TablaCategoriaUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Categoria",
                unicode: false,
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Categoria");
        }
    }
}
