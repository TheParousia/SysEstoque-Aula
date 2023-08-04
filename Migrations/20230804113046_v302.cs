using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysEstoque.Migrations
{
    /// <inheritdoc />
    public partial class v302 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_UnidadeMedidaId",
                table: "Produtos");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_UnidadesMedida_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_UnidadesMedida_UnidadeMedidaId",
                table: "Produtos");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
