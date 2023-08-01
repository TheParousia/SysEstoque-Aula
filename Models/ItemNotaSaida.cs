using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SysEstoque.Models.Config;

namespace SysEstoque.Models {
	[EntityTypeConfiguration(typeof(ItemNotaSaidaConfig))]
	public class ItemNotaSaida {

		[ForeignKey(nameof(NotaSaida))]
		[Required]
		public int NotaSaidaId { get; set; }
		public NotaSaida NotaSaida;

		[ForeignKey(nameof(Produto))]
		[Required]
		public int ProdutoId { get; set; }
		public Produto Produto;
		
		public int Quantidade { get; set; }
	}
}
