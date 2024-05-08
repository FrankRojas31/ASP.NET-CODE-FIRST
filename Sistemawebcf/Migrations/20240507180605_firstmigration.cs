using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistemawebcf.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idcategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    estado = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.idcategoria);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idproducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idcategoria = table.Column<int>(nullable: false),
                    codigo = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    precio_venta = table.Column<decimal>(type: "decimal(11, 2)", nullable: false),
                    stock = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    estado = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idproducto);
                    table.ForeignKey(
                        name: "FK_producto_categoria",
                        column: x => x.idcategoria,
                        principalTable: "Categoria",
                        principalColumn: "idcategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_idcategoria",
                table: "Producto",
                column: "idcategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_nombre",
                table: "Producto",
                column: "nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
