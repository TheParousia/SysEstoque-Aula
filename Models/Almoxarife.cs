using System.ComponentModel.DataAnnotations;

namespace SysEstoque.Models {
    public class Almoxarife {
        [Key]
        public int id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
