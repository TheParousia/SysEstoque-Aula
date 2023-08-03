using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysEstoque.Migrations
{
    /// <inheritdoc />
    public partial class v101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedorCNPJ",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FornecedorCNPJ",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FornecedorCNPJ",
                table: "Produtos");

            migrationBuilder.CreateTable(
                name: "FornecedorProduto",
                columns: table => new
                {
                    fornecedoresCNPJ = table.Column<string>(type: "varchar(255)", nullable: false),
                    produtosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorProduto", x => new { x.fornecedoresCNPJ, x.produtosId });
                    table.ForeignKey(
                        name: "FK_FornecedorProduto_Fornecedor_fornecedoresCNPJ",
                        column: x => x.fornecedoresCNPJ,
                        principalTable: "Fornecedor",
                        principalColumn: "CNPJ",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FornecedorProduto_Produtos_produtosId",
                        column: x => x.produtosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorProduto_produtosId",
                table: "FornecedorProduto",
                column: "produtosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FornecedorProduto");

            migrationBuilder.AddColumn<string>(
                name: "FornecedorCNPJ",
                table: "Produtos",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedorCNPJ",
                table: "Produtos",
                column: "FornecedorCNPJ");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedorCNPJ",
                table: "Produtos",
                column: "FornecedorCNPJ",
                principalTable: "Fornecedor",
                principalColumn: "CNPJ");
        }
    }
}
