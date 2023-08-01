using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysEstoque.Models {
	public class Endereco {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? CEP { get; set; }
		public string? Rua { get; set; }
		public string? Bairro { get; set; }
		public string? Numero { get; set; }
	}
}
