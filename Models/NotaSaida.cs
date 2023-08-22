using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysEstoque.Models {
    public class NotaSaida {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotaSaida { get; set; }
        public float ValorTotal { get; set; }
        public DateTime DataEmicao { get; set; } = DateTime.Now;
        public Almoxarife almoxarifeResposavel { get; set; } = new Almoxarife();
        public ICollection<ItemNotaSaida> ItensNotaSaida { get; set; } = new List<ItemNotaSaida>();
        public ICollection<Produto> ProdutosSaida { get; set; } = new List<Produto>();
    }
}