using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysEstoque.Models {
    [Index(nameof(Id), nameof(Nome))]
    public class Produto {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(70)]
        public string Nome { get; set; }

        public double Preco { get; set; }

        public float Estoque { get; set; }



        [ForeignKey(nameof(Categoria))]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }


        [ForeignKey(nameof(UnidadeMedida))]
        public int UnidadeMedidaId { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; } = new UnidadeMedida();


        // Modo errado
        // public ItemNotaEntrada ItensNotaEntrada { get; set; } = new ItemNotaEntrada();


        //CONFIGURAÇÃO DE FK NOTA DE ENTRADA
        public ICollection<ItemNotaEntrada> ItensNotaEntrada { get; set; } =
            new List<ItemNotaEntrada>();
        
        public ICollection<NotaEntrada>? NotasEntrada { get; set; } = new List<NotaEntrada>();
		
        public ICollection<NotaSaida>? NotasSaida { get; set; } = new List<NotaSaida>();

		public ICollection<ItemNotaSaida>? ItensNotaSaida { get; set; } = new List<ItemNotaSaida>();

        public ICollection<Fornecedor> fornecedores { get; set; }
	}
}
