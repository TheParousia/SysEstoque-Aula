using SysEstoque.Models.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace SysEstoque.Models {
	public class EstoqueContext : DbContext {
        // Cadastrando para EFCore a classe que vai
		// se transformar em tabela no banco de dados
		public DbSet<Usuario> Usuario { get; set; }
		public DbSet<NotaEntrada> NotsaEntrada { get; set; }

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<UnidadeMedida> UnidadesMedida {get;set;}
        public DbSet<Almoxarife> Almoxarife { get; set; }
        
        public DbSet<Fornecedor> Fornecedor { get; set; }

		public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<NotaEntrada> NotaEntrada{ get; set; }
        public DbSet<ItemNotaEntrada> ItemNotaEntrada { get; set; }

        public DbSet<NotaSaida> NotaSaida { get; set; }
        public DbSet<ItemNotaSaida> ItemNotaSaida { get; set; }

		//Método subrescrito para configurar a conexão ao inicia o sistema
		protected override void OnConfiguring(DbContextOptionsBuilder options) {
			options.UseMySQL("Server=127.0.0.1;port=3306;database=estoque;uid=root;password=#Root2022");

			/*
			options
				.EnableSensitiveDataLogging(true)
				.UseLoggerFactory(new LoggerFactory().AddConsole(
					(category, level) =>
						level == LogLevel.Information && category == DbLoggerCategory.Database.Name == true)
				);
			*/
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			//EXECUTA CONFIGURAÇÃO

			//CONFIGURAÇÃO M..M PARA NOTA_ENTRADA E PRODUTOS (ENTIDADE DE AGREGAÇÃO ItemNotaEntrada)
			new ItemNotaEntradaConfig().Configure(modelBuilder.Entity<ItemNotaEntrada>());
			
			//CONFIGURAÇÃO M..M PARA NOTA_SAIDA E PRODUTOS (ENTIDADE DE AGREGAÇÃO ItemNotaSaida)
			new ItemNotaSaidaConfig().Configure(modelBuilder.Entity<ItemNotaSaida>());

			//CONFIGURANDO SELEÇÃO DE ENTIDADE DE AGREGAÇÃO PARA NotaEntrada m:m Produtos
			new NotaEntradaConfig().Configure(modelBuilder.Entity<NotaEntrada>());
			
			//CONFIGURANDO SELEÇÃO DE ENTIDADE DE AGREGAÇÃO PARA NotaSaida m:m Produtos
			new NotaSaidaConfig().Configure(modelBuilder.Entity<NotaSaida>());
		}
	}
}
