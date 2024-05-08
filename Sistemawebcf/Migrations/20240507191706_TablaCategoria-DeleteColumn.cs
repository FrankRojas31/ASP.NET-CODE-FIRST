using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistemawebcf.Migrations
{
    public partial class TablaCategoriaDeleteColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Categoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Categoria",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);
        }
    }
}
