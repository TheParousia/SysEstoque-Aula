using System.ComponentModel.DataAnnotations;

namespace SysEstoque.Models {
    public class Fornecedor {
        [Key]
        public string CNPJ { get; set; }
        public string? NomeFantasia { get; set; }
        public string? RazaoSocial { get; set; }
        public string? CNAEPrincipal { get; set; }
        public string? ResponsavelRegistro { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public Endereco endereco { get; set; }
        public List<Produto>? produtos { get; set; } =
            new List<Produto>();
        public List<NotaEntrada>? NFs { get; set; } =
            new List<NotaEntrada>();
    }
}