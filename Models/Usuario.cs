using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysEstoque.Models{
    public class Usuario { 
        [Key]
        [Required] // Mesmo que o NOT NULL
        public string Login { get; set; }
        [Required]
        public string HashSenha { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required]
        public string Email { get; set; }
        public bool EhMaster { get; set; }
        [Required]
        public string Telefone { get; set; }
        [ForeignKey(nameof(Endereco))]
        public int? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }

        internal string getStringEndereco() {
            string endereco = "";

			if (this.Endereco != null) {
                endereco = $"{this.Endereco.Rua}, nº {this.Endereco.Numero}, rua {this.Endereco.Rua}. Bairro: {this.Endereco.Bairro}";
			}

            return endereco;
        }
    }
}