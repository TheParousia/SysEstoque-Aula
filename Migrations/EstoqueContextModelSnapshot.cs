﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SysEstoque.Models;

#nullable disable

namespace SysEstoque.Migrations
{
    [DbContext(typeof(EstoqueContext))]
    partial class EstoqueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FornecedorProduto", b =>
                {
                    b.Property<string>("fornecedoresCNPJ")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("produtosId")
                        .HasColumnType("int");

                    b.HasKey("fornecedoresCNPJ", "produtosId");

                    b.HasIndex("produtosId");

                    b.ToTable("FornecedorProduto");
                });

            modelBuilder.Entity("SysEstoque.Models.Almoxarife", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Almoxarife");
                });

            modelBuilder.Entity("SysEstoque.Models.Categoria", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SysEstoque.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("SysEstoque.Models.Fornecedor", b =>
                {
                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CNAEPrincipal")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("longtext");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("longtext");

                    b.Property<string>("ResponsavelRegistro")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.Property<int>("enderecoId")
                        .HasColumnType("int");

                    b.HasKey("CNPJ");

                    b.HasIndex("enderecoId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("SysEstoque.Models.ItemNotaEntrada", b =>
                {
                    b.Property<int>("NotaEntradaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("NotaEntradaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemNotaEntrada");
                });

            modelBuilder.Entity("SysEstoque.Models.ItemNotaSaida", b =>
                {
                    b.Property<int>("NotaSaidaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("NotaSaidaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemNotaSaida");
                });

            modelBuilder.Entity("SysEstoque.Models.NotaEntrada", b =>
                {
                    b.Property<int>("IdNotaEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmicao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FornecedorCNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Numeracao")
                        .HasColumnType("int");

                    b.Property<int>("Serie")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("float");

                    b.HasKey("IdNotaEntrada");

                    b.HasIndex("FornecedorCNPJ");

                    b.ToTable("NotaEntrada");
                });

            modelBuilder.Entity("SysEstoque.Models.NotaSaida", b =>
                {
                    b.Property<int>("IdNotaSaida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmicao")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("float");

                    b.Property<int>("almoxarifeResposavelid")
                        .HasColumnType("int");

                    b.HasKey("IdNotaSaida");

                    b.HasIndex("almoxarifeResposavelid");

                    b.ToTable("NotaSaida");
                });

            modelBuilder.Entity("SysEstoque.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<float>("Estoque")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("UnidadeMedidaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("UnidadeMedidaId");

                    b.HasIndex("Id", "Nome");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SysEstoque.Models.UnidadeMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UnidadesMedida");
                });

            modelBuilder.Entity("SysEstoque.Models.Usuario", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HashSenha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Login");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("FornecedorProduto", b =>
                {
                    b.HasOne("SysEstoque.Models.Fornecedor", null)
                        .WithMany()
                        .HasForeignKey("fornecedoresCNPJ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SysEstoque.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("produtosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SysEstoque.Models.Fornecedor", b =>
                {
                    b.HasOne("SysEstoque.Models.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("endereco");
                });

            modelBuilder.Entity("SysEstoque.Models.ItemNotaEntrada", b =>
                {
                    b.HasOne("SysEstoque.Models.NotaEntrada", "NotaEntrada")
                        .WithMany("ItensNotaEntrada")
                        .HasForeignKey("NotaEntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SysEstoque.Models.Produto", "Produto")
                        .WithMany("ItensNotaEntrada")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaEntrada");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("SysEstoque.Models.ItemNotaSaida", b =>
                {
                    b.HasOne("SysEstoque.Models.NotaSaida", "NotaSaida")
                        .WithMany("ItensNotaSaida")
                        .HasForeignKey("NotaSaidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SysEstoque.Models.Produto", "Produto")
                        .WithMany("ItensNotaSaida")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaSaida");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("SysEstoque.Models.NotaEntrada", b =>
                {
                    b.HasOne("SysEstoque.Models.Fornecedor", "Fornecedor")
                        .WithMany("NFs")
                        .HasForeignKey("FornecedorCNPJ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("SysEstoque.Models.NotaSaida", b =>
                {
                    b.HasOne("SysEstoque.Models.Almoxarife", "almoxarifeResposavel")
                        .WithMany()
                        .HasForeignKey("almoxarifeResposavelid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("almoxarifeResposavel");
                });

            modelBuilder.Entity("SysEstoque.Models.Produto", b =>
                {
                    b.HasOne("SysEstoque.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SysEstoque.Models.UnidadeMedida", "UnidadeMedida")
                        .WithMany()
                        .HasForeignKey("UnidadeMedidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("UnidadeMedida");
                });

            modelBuilder.Entity("SysEstoque.Models.Fornecedor", b =>
                {
                    b.Navigation("NFs");
                });

            modelBuilder.Entity("SysEstoque.Models.NotaEntrada", b =>
                {
                    b.Navigation("ItensNotaEntrada");
                });

            modelBuilder.Entity("SysEstoque.Models.NotaSaida", b =>
                {
                    b.Navigation("ItensNotaSaida");
                });

            modelBuilder.Entity("SysEstoque.Models.Produto", b =>
                {
                    b.Navigation("ItensNotaEntrada");

                    b.Navigation("ItensNotaSaida");
                });
#pragma warning restore 612, 618
        }
    }
}
