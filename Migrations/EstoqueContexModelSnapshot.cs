﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SysEstoque.Models;

#nullable disable

namespace SysEstoque.Migrations
{
    [DbContext(typeof(EstoqueContex))]
    partial class EstoqueContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SysEstoque.Models.Usuario", b =>
                {
                    b.Property<string>("login")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("login");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
