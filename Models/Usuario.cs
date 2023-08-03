using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Telefone { get; set; }
        //public Endereco? Endereco { get; set; }
    }
}