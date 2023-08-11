using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysEstoque.Models {
	public class NotaEntrada {
		[Key]
		public int IdNotaEntrada { get; set; }

		[ForeignKey(nameof(Fornecedor))]
		public string FornecedorCNPJ { get; set; }
		public Fornecedor? Fornecedor { get; set; }
		public int Numeracao { get; set; }
		public int Serie { get; set; }
		public float ValorTotal { get; set; }
		public DateTime DataEmicao { get; set; } = DateTime.Now;

		public ICollection<ItemNotaEntrada>? ItensNotaEntrada { get; set; } = new List<ItemNotaEntrada>();

		public ICollection<Produto>? ProdutosEntrada { get; set; } = new List<Produto>();
	}
}
