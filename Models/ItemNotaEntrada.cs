using SysEstoque.Models.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysEstoque.Models {
	[EntityTypeConfiguration(typeof(ItemNotaEntradaConfig))]
	public class ItemNotaEntrada {
		//Declaração de Chave Estrangeira
		[ForeignKey(nameof(NotaEntrada))]
		public int NotaEntradaId { get; set; }

		[ForeignKey(nameof(Produto))]
		public int ProdutoId { get; set; }


		public NotaEntrada? NotaEntrada = new();
		public Produto? Produto = new();

		public int Quantidade { get; set; }
	}
}
