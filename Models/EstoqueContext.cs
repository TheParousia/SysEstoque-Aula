using SysEstoque.Models.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using SysEstoque.Utils;
using Microsoft.Extensions.Logging.Console;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.LinkLabel;

namespace SysEstoque.Models {
	public class EstoqueContext : DbContext {
		// Cadastrando para EFCore a classe que vai
		// se transformar em tabela no banco de dados

		//public static readonly ILoggerFactory loggerFactory = new LoggerFactory().AddConsole((_, ___) => true);


		/*
		public static readonly ILoggerFactory loggerFactory = new LoggerFactory(
		new[] {
				 new ConsoleLoggerProvider((cat, lrv) => {true, true})
			 }
		);
		*/

		public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
			builder.AddFilter("Microsoft", LogLevel.Warning)
				   .AddFilter("System", LogLevel.Warning)
				   .AddFilter("SampleApp.Program", LogLevel.Debug)
				   .AddConsole();
		});

		public EstoqueContext():base(){
		}

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
			options.UseMySQL(Globais.DBString);

			options
				.EnableSensitiveDataLogging(true)
				.UseLoggerFactory(loggerFactory);
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
