using System.ComponentModel.DataAnnotations;

namespace SysEstoque.Models {
	public class NotaEntrada {
		[Key]
		public int IdNotaEntrada { get; set; }
		public Fornecedor Fornecedor { get; set; } = new Fornecedor();
		public int Numeracao { get; set; }
		public int Serie { get; set; }
		public float ValorTotal { get; set; }
		public DateTime DataEmicao { get; set; }

		public ICollection<ItemNotaEntrada> ItensNotaEntrada { get; set; } = new List<ItemNotaEntrada>();

		public ICollection<Produto> ProdutosEntrada { get; set; } = new List<Produto>();
	}
}
