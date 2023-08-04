﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace SysEstoque.Migrations
{
    /// <inheritdoc />
    public partial class v301 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almoxarife",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true),
                    Telefone = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almoxarife", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(type: "longtext", nullable: true),
                    Rua = table.Column<string>(type: "longtext", nullable: true),
                    Bairro = table.Column<string>(type: "longtext", nullable: true),
                    Numero = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotaSaida",
                columns: table => new
                {
                    IdNotaSaida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ValorTotal = table.Column<float>(type: "float", nullable: false),
                    DataEmicao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    almoxarifeResposavelid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaSaida", x => x.IdNotaSaida);
                    table.ForeignKey(
                        name: "FK_NotaSaida_Almoxarife_almoxarifeResposavelid",
                        column: x => x.almoxarifeResposavelid,
                        principalTable: "Almoxarife",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    Preco = table.Column<double>(type: "double", nullable: false),
                    Estoque = table.Column<float>(type: "float", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    UnidadeMedidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_UnidadeMedidaId",
                        column: x => x.UnidadeMedidaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "varchar(255)", nullable: false),
                    NomeFantasia = table.Column<string>(type: "longtext", nullable: true),
                    RazaoSocial = table.Column<string>(type: "longtext", nullable: true),
                    CNAEPrincipal = table.Column<string>(type: "longtext", nullable: true),
                    ResponsavelRegistro = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Telefone = table.Column<string>(type: "longtext", nullable: true),
                    enderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.CNPJ);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Enderecos_enderecoId",
                        column: x => x.enderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemNotaSaida",
                columns: table => new
                {
                    NotaSaidaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemNotaSaida", x => new { x.NotaSaidaId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ItemNotaSaida_NotaSaida_NotaSaidaId",
                        column: x => x.NotaSaidaId,
                        principalTable: "NotaSaida",
                        principalColumn: "IdNotaSaida",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemNotaSaida_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "NotaEntrada",
                columns: table => new
                {
                    IdNotaEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FornecedorCNPJ = table.Column<string>(type: "varchar(255)", nullable: true),
                    Numeracao = table.Column<int>(type: "int", nullable: false),
                    Serie = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<float>(type: "float", nullable: false),
                    DataEmicao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaEntrada", x => x.IdNotaEntrada);
                    table.ForeignKey(
                        name: "FK_NotaEntrada_Fornecedor_FornecedorCNPJ",
                        column: x => x.FornecedorCNPJ,
                        principalTable: "Fornecedor",
                        principalColumn: "CNPJ");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemNotaEntrada",
                columns: table => new
                {
                    NotaEntradaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemNotaEntrada", x => new { x.NotaEntradaId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ItemNotaEntrada_NotaEntrada_NotaEntradaId",
                        column: x => x.NotaEntradaId,
                        principalTable: "NotaEntrada",
                        principalColumn: "IdNotaEntrada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemNotaEntrada_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_enderecoId",
                table: "Fornecedor",
                column: "enderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorProduto_produtosId",
                table: "FornecedorProduto",
                column: "produtosId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemNotaEntrada_ProdutoId",
                table: "ItemNotaEntrada",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemNotaSaida_ProdutoId",
                table: "ItemNotaSaida",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaEntrada_FornecedorCNPJ",
                table: "NotaEntrada",
                column: "FornecedorCNPJ");

            migrationBuilder.CreateIndex(
                name: "IX_NotaSaida_almoxarifeResposavelid",
                table: "NotaSaida",
                column: "almoxarifeResposavelid");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Id_Nome",
                table: "Produtos",
                columns: new[] { "Id", "Nome" });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FornecedorProduto");

            migrationBuilder.DropTable(
                name: "ItemNotaEntrada");

            migrationBuilder.DropTable(
                name: "ItemNotaSaida");

            migrationBuilder.DropTable(
                name: "UnidadesMedida");

            migrationBuilder.DropTable(
                name: "NotaEntrada");

            migrationBuilder.DropTable(
                name: "NotaSaida");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Almoxarife");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
